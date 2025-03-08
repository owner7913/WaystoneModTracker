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
            TransparentBackground = new ToggleNode(false);
            HideInTown = new ToggleNode(false);
            HideInHideout = new ToggleNode(false);
            X = new RangeNode<int>(150, -3000, 3000);
            Y = new RangeNode<int>(200, -3000, 3000);

            // Initialize all 85 map stats settings
            MapPackSizePct = new ToggleNode(false);
            MapNumberOfMagicPacksPct = new ToggleNode(false);
            MapNumberOfRarePacksPct = new ToggleNode(false);
            MapItemDropQuantityPct = new ToggleNode(false);
            MapItemDropRarityPct = new ToggleNode(false);
            MapRarity = new ToggleNode(false);
            MapBeyondRules = new ToggleNode(false);
            MapAreaPortalVariation = new ToggleNode(false);
            MapIsCorrupted = new ToggleNode(false);
            MapNumberOfExplicitMods = new ToggleNode(false);
            MapBossDroppedItemQuantityPct = new ToggleNode(false);
            MapContainsAdditionalBreaches = new ToggleNode(false);
            MapBreachMonsterQuantityPct = new ToggleNode(false);
            MapPlayerDamageTakenPctVsBreachMonsters = new ToggleNode(false);
            TotalNumberOfMapMods = new ToggleNode(false);
            MapItemDropChancePct = new ToggleNode(false);
            MapMonsterTreePct = new ToggleNode(false);
            MapTier = new ToggleNode(false);
            MapLevel = new ToggleNode(false);
            MapModEffectPct = new ToggleNode(false);
            MapEndgameFogDepth = new ToggleNode(false);
            MapAfflictionEncounterBossChancePct = new ToggleNode(false);
            MapBreachTimePassedPct = new ToggleNode(false);
            MapRitualTributePct = new ToggleNode(false);
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
            MapMonstersAdditionalStrengthRatioPct = new ToggleNode(false);
            MapMonsterAdditionalFarricPacks = new ToggleNode(false);
            AtlasKeystonePrefixOrSuffixModEffectPctFinal = new ToggleNode(false);
            AtlasKeystoneRareOrUniqueMonstersHave10r2AdditionalMods = new ToggleNode(false);
            MapUniqueMonsterNumAdditionalModifiers = new ToggleNode(false);
            MapModSeed = new ToggleNode(false);
            MapModEffectPctPerMod = new ToggleNode(false);
            MapModEffectPctPerTowerAffectingArea = new ToggleNode(false);
            TableEffectPctWhenOpeningAMap = new ToggleNode(false);
            DoubleTableEffectChancePctWhenOpeningAMap = new ToggleNode(false);
            MapFinalBossMaxKeyOfAtlasSameTierAsCurrentMapDropChancePct = new ToggleNode(false);
            MapNumberOfTowersAffectingArea = new ToggleNode(false);
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
            MapPinnacleBossDifficulty = new ToggleNode(false);
            MapPinnacleBossItemDroppedRarityPctFinal = new ToggleNode(false);
            MapPinnacleBossDropsXCorruptedRareTablets = new ToggleNode(false);
            MapPinnacleBossSpecialGemDropChancePct = new ToggleNode(false);
            MapRitualAdditionalDaemon = new ToggleNode(false);
            MapRitualVoodooKingKeyChancePct = new ToggleNode(false);
            MapRitualMagicMonstersPct = new ToggleNode(false);
            MapRitualRareMonstersPct = new ToggleNode(false);
            MapRitualOmenChancePct = new ToggleNode(false);
            MapExpeditionLogbooksDropWith3Implicits = new ToggleNode(false);
            MapWasDropWithDistilledEmotionsAppliedChancePct = new ToggleNode(false);
            MapNonUniqueDeliriumMonsterSplinterAmountPct = new ToggleNode(false);
            MapKillingRareMonstersPausesDeliriumMirrorTimerForXSeconds = new ToggleNode(false);
            MapDeliriumDoodadsPctFinal = new ToggleNode(false);
            MapUnique = new ToggleNode(false);
            MapMonstersPctAllDamageToGainAsLightning = new ToggleNode(false);
            MapMonstersPctAllDamageToGainAsChaos = new ToggleNode(false);
            MapMonstersPctAllDamageToGainAsCold = new ToggleNode(false);
            MapMonstersPctAllDamageToGainAsFire= new ToggleNode(false);
            MapMonstersAdditionalElementalResistance= new ToggleNode(false);


        }

        [Menu("Enable Plugin")]
        public ToggleNode Enable { get; set; }

        [Menu("Transparent Background")]
        public ToggleNode TransparentBackground { get; set; } = new ToggleNode(false);

        [Menu("UI Position X")]
        public RangeNode<int> X { get; set; }
        
        [Menu("Hide in Town")]
        public ToggleNode HideInTown { get; set; } = new ToggleNode(false);

        [Menu("Hide in Hideout")]
        public ToggleNode HideInHideout { get; set; } = new ToggleNode(false);

        [Menu("UI Position Y")]
        public RangeNode<int> Y { get; set; }
        // 🔹 Map Mod Checkboxes
        [Menu("Map Monsters Elemental Resistance")] public ToggleNode MapMonstersAdditionalElementalResistance { get; set; }
        [Menu("Map Monsters Damage As Extra Fire %")] public ToggleNode MapMonstersPctAllDamageToGainAsFire { get; set; }
        [Menu("Map Monsters Damage As Extra Cold %")] public ToggleNode MapMonstersPctAllDamageToGainAsCold { get; set; }
        [Menu("Map Monsters Damage As Extra Chaos %")] public ToggleNode MapMonstersPctAllDamageToGainAsChaos { get; set; }
        [Menu("Map Monsters Damage As Extra Lightning %")] public ToggleNode MapMonstersPctAllDamageToGainAsLightning { get; set; }
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
        [Menu("Map Map Unique")] public ToggleNode MapUnique { get; set; }
        [Menu("Map Delerium Doodads % Final")] public ToggleNode MapDeliriumDoodadsPctFinal { get; set; }
        [Menu("Map Killing Rare Monsters Pauses Delerium Mirrior Time For X Seconds")] public ToggleNode MapKillingRareMonstersPausesDeliriumMirrorTimerForXSeconds { get; set; }
        [Menu("Map Non Unique Delerium Monster Splinter Amount %")] public ToggleNode MapNonUniqueDeliriumMonsterSplinterAmountPct { get; set; }
        [Menu("Map Chance To Drop Maps With Destilled Amotion Applied Chance %")] public ToggleNode MapWasDropWithDistilledEmotionsAppliedChancePct { get; set; }
        [Menu("Map Expidition Log Books Drop With 3 Implicits")] public ToggleNode MapExpeditionLogbooksDropWith3Implicits { get; set; }
        [Menu("Map Ritual Omen Chance %")] public ToggleNode MapRitualOmenChancePct { get; set; }
        [Menu("Map Ritual magic Monsters %")] public ToggleNode MapRitualMagicMonstersPct { get; set; }
        [Menu("Map Vodoo King key Chance %")] public ToggleNode MapRitualVoodooKingKeyChancePct { get; set; }
        [Menu("Map Ritual Additional Deamon")] public ToggleNode MapRitualAdditionalDaemon { get; set; }
        [Menu("Map Pinnacle Boss Drops Special Gem Drop Chance %")] public ToggleNode MapPinnacleBossSpecialGemDropChancePct { get; set; }
        [Menu("Map Pinnacle Boss Drops X Corrupted Rare Tablets")] public ToggleNode MapPinnacleBossDropsXCorruptedRareTablets { get; set; }
        [Menu("Map Pinnacle Boss Difficulty")] public ToggleNode MapPinnacleBossDifficulty { get; set; }
        [Menu("Map Number Of Towers Affecting Area")] public ToggleNode MapNumberOfTowersAffectingArea { get; set; }
        [Menu("Map Monster Additional Farric Packs")] public ToggleNode MapMonsterAdditionalFarricPacks { get; set; }
        [Menu("Map Monster Additional Strength ratio %")] public ToggleNode MapMonstersAdditionalStrengthRatioPct { get; set; }
        [Menu("Map Ritual Tribute %")] public ToggleNode MapRitualTributePct { get; set; }
        [Menu("Map Level")] public ToggleNode MapLevel { get; set; }
        [Menu("Map Monster Tree %")] public ToggleNode MapMonsterTreePct { get; set; }
        [Menu("Map Has Breach")] public ToggleNode MapContainsAdditionalBreaches { get; set; }
        [Menu("Map Is Corrupted")] public ToggleNode MapIsCorrupted { get; set; }
        [Menu("Map Beyond Rules")] public ToggleNode MapBeyondRules { get; set; }
        [Menu("Map Number of Magic packs")] public ToggleNode MapNumberOfMagicPacksPct { get; set; }        
        [Menu("Map Ritual Rare Monsters %")] public ToggleNode MapRitualRareMonstersPct { get; set; }        

    }
}
