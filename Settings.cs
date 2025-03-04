using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;
using ExileCore2.Shared.Attributes;

namespace WaystoneModTracker
{
    public class Settings : ISettings
    {
        public Settings()
        {
            Enable = new ToggleNode(true);
            X = new RangeNode<int>(150, -3000, 3000);
            Y = new RangeNode<int>(200, -3000, 3000);

            // Initialize all map stats settings
            MapMonstersDamagePct = new ToggleNode(false);
            MapPlayerHasLevelXTemporalChains = new ToggleNode(false);
            MapPackSizePct = new ToggleNode(false);
            MapNumberOfRarePacksPct = new ToggleNode(false);
            MapItemDropQuantityPct = new ToggleNode(false);
            MapItemDropRarityPct = new ToggleNode(false);
            MapRarity = new ToggleNode(false);
            MapAreaPortalVariation = new ToggleNode(false);
            MapNoStrongboxes = new ToggleNode(false);
            MapNoShrines = new ToggleNode(false);
            MapNoEssences = new ToggleNode(false);
            MapNoCoreLeagues = new ToggleNode(false);
            MapNumberOfExplicitMods = new ToggleNode(false);
            MapBossDroppedItemQuantityPct = new ToggleNode(false);
            MapMagicPackSizePct = new ToggleNode(false);
            MapBreachMonsterQuantityPct = new ToggleNode(false);
            MapPlayerDamageTakenPctVsBreachMonsters = new ToggleNode(false);
            TotalNumberOfMapMods = new ToggleNode(false);
            MapItemDropChancePct = new ToggleNode(false);
            MapTier = new ToggleNode(false);
            MapModEffectPct = new ToggleNode(false);
            MapEndgameFogDepth = new ToggleNode(false);
            MapAfflictionEncounterBossChancePct = new ToggleNode(false);
            MapBreachTimePassedPct = new ToggleNode(false);
            MapRitualAdditionalRewardRerolls = new ToggleNode(false);
            MapRitualRewardsRerollCostPctFinal = new ToggleNode(false);
            MapRitualEncounterCountIsFour = new ToggleNode(false);
            ExpeditionMonstersLogbookChancePct = new ToggleNode(false);
            MapExpeditionEliteMarkerCountPct = new ToggleNode(false);
            MapExpeditionArtifactQuantityPct = new ToggleNode(false);
            MapExpeditionVendorRerollCurrencyQuantityPct = new ToggleNode(false);
            MapBreachMonsterSplinterQuantityPct = new ToggleNode(false);
            MapRareMonsterNumAdditionalModifiers = new ToggleNode(false);
            MapDeviceType = new ToggleNode(false);
            MapBreachPctChanceFor1AdditionalBreach = new ToggleNode(false);
            MapBreachPctChanceFor3AdditionalBreach = new ToggleNode(false);
            MapBreachPctChanceFor10AdditionalBreach = new ToggleNode(false);
            MapRitualMonsterSpawningSpeedPct = new ToggleNode(false);
            MapExpeditionFuseBurnTimePct = new ToggleNode(false);
            MapHiddenPlayersResistAllPct = new ToggleNode(false);
            MapAtlasX = new ToggleNode(false);
            MapAtlasY = new ToggleNode(false);
            MapMonsterAdditionalEzomytePacks = new ToggleNode(false);
            AtlasKeystonePrefixOrSuffixModEffectPctFinal = new ToggleNode(false);
            AtlasKeystoneRareOrUniqueMonstersHave10r2AdditionalMods = new ToggleNode(false);
            MapUniqueMonsterNumAdditionalModifiers = new ToggleNode(false);
            MapModSeed = new ToggleNode(false);
            MapMonstersAdditionalStrengthRatioPctForArmour = new ToggleNode(false);
            MapModEffectPctPerMod = new ToggleNode(false);
            MapModEffectPctPerTowerAffectingArea = new ToggleNode(false);
            TableEffectPctWhenOpeningAMap = new ToggleNode(false);
            DoubleTableEffectChancePctWhenOpeningAMap = new ToggleNode(false);
            MapFinalBossMaxKeyOfAtlasSameTierAsCurrentMapDropChancePct = new ToggleNode(false);
            MapBiomeIndex = new ToggleNode(false);
            MapSimulacrumDifficulty = new ToggleNode(false);
            MapVoodooKingDifficulty = new ToggleNode(false);
            MapBreachDomainDifficulty = new ToggleNode(false);
            MapLogbookDifficulty = new ToggleNode(false);
            MapBossingDifficulty = new ToggleNode(false);
            MapDeliriumDifficultyScalingFromMirrorIsDouble = new ToggleNode(false);
            MapsWithBossesAdditionalEssence = new ToggleNode(false);
            MapsWithBossesAreIrradiated = new ToggleNode(false);
            MapTowerAugmentQuantityPct = new ToggleNode(false);
            MapExpeditionRareMonstersPct = new ToggleNode(false);
            MapBossAreaChanceToBeCorruptedPct = new ToggleNode(false);
            MapPinnacleBossItemDroppedRarityPctFinal = new ToggleNode(false);
            MapPinnacleBossAdditionalUniqueDropChancePct = new ToggleNode(false);
        }

        [Menu("Enable Plugin")]
        public ToggleNode Enable { get; set; }

        [Menu("UI Position X")]
        public RangeNode<int> X { get; set; }

        [Menu("UI Position Y")]
        public RangeNode<int> Y { get; set; }

        // 🔹 Map Mod Checkboxes
        [Menu("Map Monsters Damage %")] public ToggleNode MapMonstersDamagePct { get; set; }
        [Menu("Map Player Temporal Chains")] public ToggleNode MapPlayerHasLevelXTemporalChains { get; set; }
        [Menu("Map Pack Size %")] public ToggleNode MapPackSizePct { get; set; }
        [Menu("Number of Rare Packs %")] public ToggleNode MapNumberOfRarePacksPct { get; set; }
        [Menu("Map Item Drop Quantity %")] public ToggleNode MapItemDropQuantityPct { get; set; }
        [Menu("Map Item Drop Rarity %")] public ToggleNode MapItemDropRarityPct { get; set; }
        [Menu("Map Rarity")] public ToggleNode MapRarity { get; set; }
        [Menu("Map Area Portal Variation")] public ToggleNode MapAreaPortalVariation { get; set; }
        [Menu("No Strongboxes")] public ToggleNode MapNoStrongboxes { get; set; }
        [Menu("No Shrines")] public ToggleNode MapNoShrines { get; set; }
        [Menu("No Essences")] public ToggleNode MapNoEssences { get; set; }
        [Menu("No Core Leagues")] public ToggleNode MapNoCoreLeagues { get; set; }
        [Menu("Number of Explicit Mods")] public ToggleNode MapNumberOfExplicitMods { get; set; }
        [Menu("Map Boss Dropped Item Quantity %")] public ToggleNode MapBossDroppedItemQuantityPct { get; set; }
        [Menu("Map Magic Pack Size %")] public ToggleNode MapMagicPackSizePct { get; set; }
        [Menu("Map Breach Monster Quantity %")] public ToggleNode MapBreachMonsterQuantityPct { get; set; }
        [Menu("Map Player Damage Taken vs Breach Monsters %")] public ToggleNode MapPlayerDamageTakenPctVsBreachMonsters { get; set; }
        [Menu("Total Number of Map Mods")] public ToggleNode TotalNumberOfMapMods { get; set; }
        [Menu("Map Item Drop Chance %")] public ToggleNode MapItemDropChancePct { get; set; }
        [Menu("Map Tier")] public ToggleNode MapTier { get; set; }
        [Menu("Map Mod Effect %")] public ToggleNode MapModEffectPct { get; set; }
        [Menu("Map Endgame Fog Depth")] public ToggleNode MapEndgameFogDepth { get; set; }
        [Menu("Map Affliction Encounter Boss Chance %")] public ToggleNode MapAfflictionEncounterBossChancePct { get; set; }
        [Menu("Map Breach Time Passed %")] public ToggleNode MapBreachTimePassedPct { get; set; }
        [Menu("Map Ritual Additional Reward Rerolls")] public ToggleNode MapRitualAdditionalRewardRerolls { get; set; }
        [Menu("Map Ritual Rewards Reroll Cost %")] public ToggleNode MapRitualRewardsRerollCostPctFinal { get; set; }
        [Menu("Map Ritual Encounter Count is Four")] public ToggleNode MapRitualEncounterCountIsFour { get; set; }
        [Menu("Expedition Monsters Logbook Chance %")] public ToggleNode ExpeditionMonstersLogbookChancePct { get; set; }
        [Menu("Map Expedition Elite Marker Count %")] public ToggleNode MapExpeditionEliteMarkerCountPct { get; set; }
        [Menu("Map Expedition Artifact Quantity %")] public ToggleNode MapExpeditionArtifactQuantityPct { get; set; }
        [Menu("Map Expedition Vendor Reroll Currency Quantity %")] public ToggleNode MapExpeditionVendorRerollCurrencyQuantityPct { get; set; }
        [Menu("Map Breach Monster Splinter Quantity %")] public ToggleNode MapBreachMonsterSplinterQuantityPct { get; set; }
        [Menu("Map Rare Monster Additional Modifiers")] public ToggleNode MapRareMonsterNumAdditionalModifiers { get; set; }
        [Menu("Map Device Type")] public ToggleNode MapDeviceType { get; set; }
        [Menu("Map Breach Chance for 1 Additional Breach %")] public ToggleNode MapBreachPctChanceFor1AdditionalBreach { get; set; }
        [Menu("Map Breach Chance for 3 Additional Breach %")] public ToggleNode MapBreachPctChanceFor3AdditionalBreach { get; set; }
        [Menu("Map Breach Chance for 10 Additional Breach %")] public ToggleNode MapBreachPctChanceFor10AdditionalBreach { get; set; }
        [Menu("Map Ritual Monster Spawning Speed %")] public ToggleNode MapRitualMonsterSpawningSpeedPct { get; set; }
        [Menu("Map Expedition Fuse Burn Time %")] public ToggleNode MapExpeditionFuseBurnTimePct { get; set; }
        [Menu("Map Hidden Players Resist All %")] public ToggleNode MapHiddenPlayersResistAllPct { get; set; }
        [Menu("Map Atlas X")] public ToggleNode MapAtlasX { get; set; }
        [Menu("Map Atlas Y")] public ToggleNode MapAtlasY { get; set; }
        [Menu("Map Monster Additional Ezomyte Packs")] public ToggleNode MapMonsterAdditionalEzomytePacks { get; set; }
        [Menu("Atlas Keystone Prefix/Suffix Mod Effect %")] public ToggleNode AtlasKeystonePrefixOrSuffixModEffectPctFinal { get; set; }
        [Menu("Atlas Keystone Rare/Unique Monsters Extra Mods")] public ToggleNode AtlasKeystoneRareOrUniqueMonstersHave10r2AdditionalMods { get; set; }
        [Menu("Map Unique Monster Additional Modifiers")] public ToggleNode MapUniqueMonsterNumAdditionalModifiers { get; set; }
        [Menu("Map Mod Seed")] public ToggleNode MapModSeed { get; set; }
        [Menu("Map Monsters Additional Strength for Armour %")] public ToggleNode MapMonstersAdditionalStrengthRatioPctForArmour { get; set; }
        [Menu("Map Mod Effect % per Mod")] public ToggleNode MapModEffectPctPerMod { get; set; }
        [Menu("Map Mod Effect % per Tower Affecting Area")] public ToggleNode MapModEffectPctPerTowerAffectingArea { get; set; }
        [Menu("Table Effect % When Opening a Map")] public ToggleNode TableEffectPctWhenOpeningAMap { get; set; }
        [Menu("Double Table Effect Chance % When Opening a Map")] public ToggleNode DoubleTableEffectChancePctWhenOpeningAMap { get; set; }
        [Menu("Map Final Boss Key Drop Chance %")] public ToggleNode MapFinalBossMaxKeyOfAtlasSameTierAsCurrentMapDropChancePct { get; set; }
        [Menu("Map Biome Index")] public ToggleNode MapBiomeIndex { get; set; }
        [Menu("Map Simulacrum Difficulty")] public ToggleNode MapSimulacrumDifficulty { get; set; }
        [Menu("Map Voodoo King Difficulty")] public ToggleNode MapVoodooKingDifficulty { get; set; }
        [Menu("Map Breach Domain Difficulty")] public ToggleNode MapBreachDomainDifficulty { get; set; }
        [Menu("Map Logbook Difficulty")] public ToggleNode MapLogbookDifficulty { get; set; }
        [Menu("Map Bossing Difficulty")] public ToggleNode MapBossingDifficulty { get; set; }
        [Menu("Map Delirium Difficulty Scaling (Mirror is Double)")] public ToggleNode MapDeliriumDifficultyScalingFromMirrorIsDouble { get; set; }
        [Menu("Maps with Bosses Additional Essence")] public ToggleNode MapsWithBossesAdditionalEssence { get; set; }
        [Menu("Maps with Bosses are Irradiated")] public ToggleNode MapsWithBossesAreIrradiated { get; set; }
        [Menu("Map Tower Augment Quantity %")] public ToggleNode MapTowerAugmentQuantityPct { get; set; }
        [Menu("Map Expedition Rare Monsters %")] public ToggleNode MapExpeditionRareMonstersPct { get; set; }
        [Menu("Map Boss Area Chance to Be Corrupted %")] public ToggleNode MapBossAreaChanceToBeCorruptedPct { get; set; }
        [Menu("Map Pinnacle Boss Item Dropped Rarity %")] public ToggleNode MapPinnacleBossItemDroppedRarityPctFinal { get; set; }
        [Menu("Map Pinnacle Boss Additional Unique Drop Chance %")] public ToggleNode MapPinnacleBossAdditionalUniqueDropChancePct { get; set; }

    }
}
