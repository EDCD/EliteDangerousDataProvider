﻿using System;
using Utilities;

namespace EddiEvents
{
    [PublicAPI]
    public class ScreenshotEvent : Event
    {
        public const string NAME = "Screenshot";
        public const string DESCRIPTION = "Triggered when you take a screenshot";
        public const string SAMPLE = @"{ ""timestamp"":""2018-02-03T23:46:07Z"", ""event"":""Screenshot"", ""Filename"":""\\ED_Pictures\\Screenshot_0003.bmp"", ""Width"":3440, ""Height"":1440, ""System"":""Wyrd"", ""Body"":""Wyrd A 2"", ""Latitude"":-63.855904, ""Longitude"":-81.981064, ""Heading"":50 }";

        [PublicAPI("The name of the file where the screenshot has been saved")]
        public string filename { get; private set; }

        [PublicAPI("The width in pixels of the screenshot")]
        public int width { get; private set; }

        [PublicAPI("The height in pixels of the screenshot")]
        public int height { get; private set; }

        [PublicAPI("The name of the system where the screenshot was taken")]
        public string system { get; private set; }

        [PublicAPI("The name of the nearest body to where the screenshot was taken")]
        public string body { get; private set; }

        [PublicAPI("The longitude where the screenshot was taken (if applicable)")]
        public decimal? longitude { get; private set; }

        [PublicAPI("The latitude where the screenshot was taken (if applicable)")]
        public decimal? latitude { get; private set; }

        public ScreenshotEvent(DateTime timestamp, string filename, int width, int height, string system, string body, decimal? longitude, decimal? latitude) : base(timestamp, NAME)
        {
            this.filename = filename;
            this.width = width;
            this.height = height;
            this.system = system;
            this.body = body;
            this.longitude = longitude;
            this.latitude = latitude;
        }
    }
}
