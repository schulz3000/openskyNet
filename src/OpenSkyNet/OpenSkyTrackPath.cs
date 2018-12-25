﻿using System;

namespace OpenSkyNet
{
    class OpenSkyTrackPath : IOpenSkyTrackPath
    {
        public DateTime Time { get; set; }

        public float? Latitude { get; set; }

        public float? Longitude { get; set; }

        public float? BaroAltitude { get; set; }

        public float? TrueTrack { get; set; }

        public bool OnGround { get; set; }
    }
}
