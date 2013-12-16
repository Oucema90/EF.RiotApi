﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.Dto.League
{
    public class LeagueDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// (legal values: RANKED_SOLO_5x5, RANKED_TEAM_3x3, RANKED_TEAM_5x5)
        /// </summary>
        [JsonProperty("queue")]
        public string Queue { get; set; }

        /// <summary>
        /// (legal values: CHALLENGER, DIAMOND, PLATINUM, GOLD, SILVER, BRONZE)
        /// </summary>
        [JsonProperty("tier")]
        public string Tier { get; set; }  

        [JsonProperty("timeStamp")]
        public string Timestamp { get; set; }

        [JsonProperty("entries")]
        public List<LeagueDtoEntry> Entries { get; set; }
    }
}
