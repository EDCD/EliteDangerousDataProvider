﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace EddiDataDefinitions
{
    /// <summary>
    /// Details of a blueprint
    /// </summary>
    public class Blueprint
    {
        public string modulename { get; private set; }

        public string LocalModuleName
        {
            get
            {
                return I18N.GetString(modulename) ?? modulename;
            }
        }

        public string name { get; private set; }

        public string LocalName
        {
            get
            {
                return I18N.GetString(name) ?? name;
            }
        }

        public int grade { get; private set; }

        public Blueprint(string modulename, string name, int grade)
        {
            this.modulename = modulename;
            this.name = name;
            this.grade = grade;
        }
    }
}
