﻿using System;
using System.Collections.Generic;
using Utilities;

namespace EddiEvents
{
    [PublicAPI]
    public class TradeVoucherRedeemedEvent : Event
    {
        public const string NAME = "Trade voucher redeemed";
        public const string DESCRIPTION = "Triggered when you redeem a trade voucher";
        public const string SAMPLE = @"{ ""timestamp"":""2016-12-29T10:10:11Z"", ""event"":""RedeemVoucher"", ""Type"":""trade"",""Amount"":1000,""Factions"":[{""Faction"":""The Pilots Federation"",""Amount"":1000}]}";

        [PublicAPI("The rewards obtained broken down by faction (as a list of Rewards objects)")]
        public List<Reward> rewards { get; private set; }

        [PublicAPI("The amount rewarded (after any broker fees)")]
        public long amount { get; private set; }

        [PublicAPI("Broker precentage fee (if paid via a Broker)")]
        public decimal? brokerpercentage { get; private set; }

        public TradeVoucherRedeemedEvent(DateTime timestamp, List<Reward> rewards, long amount, decimal? brokerpercentage) : base(timestamp, NAME)
        {
            this.rewards = rewards;
            this.amount = amount;
            this.brokerpercentage = brokerpercentage;
        }
    }
}
