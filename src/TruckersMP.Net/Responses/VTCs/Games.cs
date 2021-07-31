﻿using Newtonsoft.Json;

namespace TruckersMP.Net.Responses.VTCs
{
    public class Games
    {
        [JsonProperty("ats")]
        private bool _ats;

        [JsonProperty("ets")]
        private bool _ets;

        public bool Ats => _ats;

        public bool Ets => _ets;
    }
}