﻿using EddiDataDefinitions;
using System;
using Utilities;

namespace EddiEvents
{
    [PublicAPI]
    public class DockingGrantedEvent : Event
    {
        public const string NAME = "Docking granted";
        public const string DESCRIPTION = "Triggered when your ship is granted docking permission at a station or outpost";
        public const string SAMPLE = "{\"timestamp\":\"2016-06-10T14:32:03Z\",\"event\":\"DockingGranted\",\"MarketID\": 128666762,\"StationName\":\"Jameson Memorial\",\"StationType\":\"Orbis\",\"LandingPad\":2}";

        [PublicAPI("The station at which the commander has been granted docking")]
        public string station { get; private set; }

        [PublicAPI("The localized model / type of the station at which the commander has been granted docking")]
        public string stationtype => stationDefinition?.localizedName;

        [PublicAPI("The landing pad at which the commander has been granted docking")]
        public int landingpad { get; private set; }

        // Not intended to be user facing

        public long marketId { get; private set; }

        public StationModel stationDefinition { get; private set; }

        public DockingGrantedEvent(DateTime timestamp, string station, string stationType, long marketId, int landingpad) : base(timestamp, NAME)
        {
            this.station = station;
            this.stationDefinition = StationModel.FromEDName(stationType);
            this.marketId = marketId;
            this.landingpad = landingpad;
        }
    }
}
