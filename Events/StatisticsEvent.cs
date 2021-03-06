﻿using EddiDataDefinitions;
using System;
using Utilities;

namespace EddiEvents
{
    [PublicAPI]
    public class StatisticsEvent : Event
    {
        public const string NAME = "Statistics";
        public const string DESCRIPTION = "Statistics provided at the beginning of a game session";
        public const string SAMPLE = "{ \"timestamp\":\"2019-04-12T04:32:39Z\", \"event\":\"Statistics\", \"Bank_Account\":{ \"Current_Wealth\":5159157167, \"Spent_On_Ships\":1120070427, \"Spent_On_Outfitting\":4789623432, \"Spent_On_Repairs\":35846267, \"Spent_On_Fuel\":607469, \"Spent_On_Ammo_Consumables\":2333849, \"Insurance_Claims\":65, \"Spent_On_Insurance\":113693872, \"Owned_Ship_Count\":30 }, \"Combat\":{ \"Bounties_Claimed\":4115, \"Bounty_Hunting_Profit\":174831710.5, \"Combat_Bonds\":1630, \"Combat_Bond_Profits\":49624687, \"Assassinations\":148, \"Assassination_Profits\":160772353, \"Highest_Single_Reward\":763828, \"Skimmers_Killed\":299 }, \"Crime\":{ \"Notoriety\":0, \"Fines\":402, \"Total_Fines\":2133850, \"Bounties_Received\":716, \"Total_Bounties\":1363285, \"Highest_Bounty\":10615 }, \"Smuggling\":{ \"Black_Markets_Traded_With\":42, \"Black_Markets_Profits\":16115721, \"Resources_Smuggled\":4362, \"Average_Profit\":124928.06976744, \"Highest_Single_Transaction\":1449990 }, \"Trading\":{ \"Markets_Traded_With\":209, \"Market_Profits\":72979036, \"Resources_Traded\":32394, \"Average_Profit\":57965.874503574, \"Highest_Single_Transaction\":7373696 }, \"Mining\":{ \"Mining_Profits\":14267147, \"Quantity_Mined\":1456, \"Materials_Collected\":45683 }, \"Exploration\":{ \"Systems_Visited\":13401, \"Exploration_Profits\":436075034, \"Planets_Scanned_To_Level_2\":4762, \"Planets_Scanned_To_Level_3\":6585, \"Efficient_Scans\":0, \"Highest_Payout\":5639116, \"Total_Hyperspace_Distance\":480443, \"Total_Hyperspace_Jumps\":18670, \"Greatest_Distance_From_Start\":22470.803927811, \"Time_Played\":8271840 }, \"Passengers\":{ \"Passengers_Missions_Accepted\":501, \"Passengers_Missions_Disgruntled\":35, \"Passengers_Missions_Bulk\":3418, \"Passengers_Missions_VIP\":914, \"Passengers_Missions_Delivered\":4332, \"Passengers_Missions_Ejected\":68 }, \"Search_And_Rescue\":{ \"SearchRescue_Traded\":75, \"SearchRescue_Profit\":1138348, \"SearchRescue_Count\":27 }, \"TG_ENCOUNTERS\":{ \"TG_ENCOUNTER_WAKES\":1, \"TG_ENCOUNTER_IMPRINT\":6, \"TG_ENCOUNTER_TOTAL\":9, \"TG_ENCOUNTER_TOTAL_LAST_SYSTEM\":\"Aries Dark Region TE-P b6-4\", \"TG_ENCOUNTER_TOTAL_LAST_TIMESTAMP\":\"3304-12-02 03:21\", \"TG_ENCOUNTER_TOTAL_LAST_SHIP\":\"Python\", \"TG_SCOUT_COUNT\":12 }, \"Crafting\":{ \"Count_Of_Used_Engineers\":20, \"Recipes_Generated\":4502, \"Recipes_Generated_Rank_1\":749, \"Recipes_Generated_Rank_2\":209, \"Recipes_Generated_Rank_3\":595, \"Recipes_Generated_Rank_4\":600, \"Recipes_Generated_Rank_5\":2349 }, \"Crew\":{ \"NpcCrew_TotalWages\":238928453, \"NpcCrew_Hired\":2, \"NpcCrew_Fired\":1 }, \"Multicrew\":{ \"Multicrew_Time_Total\":2601, \"Multicrew_Gunner_Time_Total\":0, \"Multicrew_Fighter_Time_Total\":0, \"Multicrew_Credits_Total\":0, \"Multicrew_Fines_Total\":0 }, \"Material_Trader_Stats\":{ \"Trades_Completed\":157, \"Materials_Traded\":7527, \"Encoded_Materials_Traded\":1473, \"Raw_Materials_Traded\":2054, \"Grade_1_Materials_Traded\":2412, \"Grade_2_Materials_Traded\":1781, \"Grade_3_Materials_Traded\":1793, \"Grade_4_Materials_Traded\":1278, \"Grade_5_Materials_Traded\":263 }, \"CQC\":{ \"CQC_Credits_Earned\":58630, \"CQC_Time_Played\":27450, \"CQC_KD\":1.1729323308271, \"CQC_Kills\":156, \"CQC_WL\":0.24444444444444 } }";

        [PublicAPI]
        public BankAccountStats bankaccount => statistics.bankaccount;

        [PublicAPI]
        public CombatStats combat => statistics.combat;

        [PublicAPI]
        public CrimeStats crime => statistics.crime;

        [PublicAPI]
        public SmugglingStats smuggling => statistics.smuggling;

        [PublicAPI]
        public ThargoidEncounterStats thargoidencounters => statistics.thargoidencounters;

        [PublicAPI]
        public TradingStats trading => statistics.trading;

        [PublicAPI]
        public MiningStats mining => statistics.mining;

        [PublicAPI]
        public ExplorationStats exploration => statistics.exploration;

        [PublicAPI]
        public PassengerStats passengers => statistics.passengers;

        [PublicAPI]
        public SearchAndRescueStats searchandrescue => statistics.searchandrescue;

        [PublicAPI]
        public CraftingStats crafting => statistics.crafting;

        [PublicAPI]
        public NpcCrewStats npccrew => statistics.npccrew;

        [PublicAPI]
        public MulticrewStats multicrew => statistics.multicrew;

        [PublicAPI]
        public MaterialTraderStats materialTrader => statistics.materialtrader;

        [PublicAPI]
        public CQCstats cqc => statistics.cqc;

        // Not intended to be user facing

        private Statistics statistics { get; set; }

        public StatisticsEvent(DateTime timestamp, Statistics statistics) : base(timestamp, NAME)
        {
            this.statistics = statistics;
        }
    }
}
