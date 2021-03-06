﻿using EddiDataDefinitions;
using System;
using System.Collections.Generic;
using Utilities;

namespace EddiEvents
{
    [PublicAPI]
    public class MaterialInventoryEvent : Event
    {
        public const string NAME = "Material inventory";
        public const string DESCRIPTION = "Triggered when you obtain an inventory of your current materials";
        public const string SAMPLE = @"{ ""timestamp"":""2017-02-10T14:25:51Z"", ""event"":""Materials"", ""Raw"":[ { ""Name"":""chromium"", ""Count"":28 }, { ""Name"":""zinc"", ""Count"":18 }, { ""Name"":""iron"", ""Count"":23 }, { ""Name"":""sulphur"", ""Count"":19 } ], ""Manufactured"":[ { ""Name"":""refinedfocuscrystals"", ""Count"":10 }, { ""Name"":""highdensitycomposites"", ""Count"":3 }, { ""Name"":""mechanicalcomponents"", ""Count"":3 } ], ""Encoded"":[ { ""Name"":""emissiondata"", ""Count"":32 }, { ""Name"":""shielddensityreports"", ""Count"":23 } ] }";

        [PublicAPI("The materials in your inventory (as objects)")]
        public List<MaterialAmount> inventory { get; private set; }

        public MaterialInventoryEvent(DateTime timestamp, List<MaterialAmount> inventory) : base(timestamp, NAME)
        {
            this.inventory = inventory;
        }
    }
}
