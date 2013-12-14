﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Dto.Summoner
{
    public class SummonerDto
    {
        /// <summary>
        /// Summoner ID.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Summoner name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// ID of the summoner icon associated with the summoner.
        /// </summary>
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }

        /// <summary>
        /// Date summoner was last modified specified as epoch milliseconds.
        /// </summary>
        [JsonProperty("revisionDate")]
        public long RevisionDate { get; set; }

        /// <summary>
        /// Human readable string representing date summoner was last modified.
        /// </summary>
        [JsonProperty("revisionDateStr")]
        public string RevisionDateStr { get; set; }

        /// <summary>
        /// Summoner level associated with the summoner.
        /// </summary>
        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; set; }

    }
}