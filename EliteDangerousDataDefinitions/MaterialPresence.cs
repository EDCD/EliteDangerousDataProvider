﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace EliteDangerousDataDefinitions
{
    /// <summary>
    /// Presence of a material
    /// </summary>
    public class MaterialPresence
    {
        public MaterialDefinition definition { get; private set; }

        public string name { get; private set; }

        public Rarity rarity { get; private set; }

        public decimal percentage { get; private set; }

        public MaterialPresence(MaterialDefinition definition, decimal presence)
        {
            this.definition = definition;
            this.name = definition.name;
            this.rarity= definition.rarity;
            this.percentage = presence;

        }
    }
}
