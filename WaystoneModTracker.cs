using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;
using ExileCore2;
using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;
using ExileCore2.Shared.Enums;
using ExileCore2.Shared.Helpers;
using Graphics = ExileCore2.Graphics;
using RectangleF = ExileCore2.Shared.RectangleF;
using Color = System.Drawing.Color;

namespace WaystoneModTracker
{
    public class WaystoneModTracker : BaseSettingsPlugin<Settings>
    {
        private Dictionary<string, int> _mapStats = new Dictionary<string, int>();

        public override void OnLoad()
        {
            base.OnLoad();
            Name = "Waystone Mod Tracker";
        }

        public override void Render()
        {
            if (!Settings.Enable.Value) return;

            var currentArea = GameController?.Area?.CurrentArea;
            if (currentArea == null) return;

            bool isInsideMap = !(currentArea.IsTown || currentArea.IsHideout);

            if (isInsideMap)
            {
                GetWaystoneMods();
            }
            else
            {
                _mapStats.Clear(); // 🔹 Clear data in town/hideout but keep title
            }

            // 🔹 Display Title (Even in Town/Hideout)
            var displayText = $"Waystone Mods ({currentArea.Name}):\n";

            if (isInsideMap && _mapStats.Count > 0)
            {
                // 🔹 Determine max width for column alignment
                int maxModLength = _mapStats.Keys
                    .Select(mod => Regex.Replace(mod.Replace("Map", ""), "([a-z])([A-Z])", "$1 $2").Trim().Length)
                    .Max();

                foreach (var mod in _mapStats)
                {
                    // 🔹 Format text properly
                    string modName = mod.Key.Replace("Map", ""); // Remove "Map"
                    modName = Regex.Replace(modName, "([a-z])([A-Z])", "$1 $2"); // Add spaces between words
                    modName = modName.Replace("Pct", "%").Trim();

                    string valueDisplay;
                    if (mod.Value == 1 && (modName.Contains("No") || modName.Contains("Has"))) 
                    {
                        valueDisplay = "Yes";
                    }
                    else if (mod.Value == 0 && (modName.Contains("No") || modName.Contains("Has"))) 
                    {
                        valueDisplay = "No";
                    }
                    else if (modName.Contains("Chance") || modName.Contains("Ratio") || modName.Contains("%"))
                    {
                        valueDisplay = $"{mod.Value}%";
                    }
                    else
                    {
                        valueDisplay = $"{mod.Value}";
                    }

                    // 🔹 Align values properly
                    displayText += $"{modName.PadRight(maxModLength + 5)} {valueDisplay,6}\n";
                }
            }

            // 🔹 Get screen position & size
            var fontSize = 22; // Slightly larger font for readability
            var size = Graphics.MeasureText(displayText, fontSize);
            var scrRect = GameController.Window.GetWindowRectangle();
            var topLeft = new Vector2(scrRect.X + Settings.X, scrRect.Y + Settings.Y);
            var drawRect = new RectangleF(topLeft.X - 8, topLeft.Y - 8, size.X + 16, size.Y + 16);

            // 🔹 Draw box background with padding
            Graphics.DrawBox(drawRect, Color.Black);

            // 🔹 Draw text in white
            Graphics.DrawText(displayText, topLeft, Color.White, FontAlign.Left);
        }


        private void GetWaystoneMods()
        {
            _mapStats.Clear();

            try
            {
                var mapStats = GameController?.IngameState?.Data?.MapStats;
                if (mapStats == null || mapStats.Count == 0) return;

            foreach (var stat in mapStats)
            {
                string statName = stat.Key.ToString();

                if (typeof(Settings).GetProperty(statName) is { } property &&
                    property.GetValue(Settings) is ToggleNode node && node.Value)
                {
                    _mapStats[statName] = stat.Value;
                }
            }
            }
            catch (Exception) { /* Handle silently */ }
        }
    }
}
