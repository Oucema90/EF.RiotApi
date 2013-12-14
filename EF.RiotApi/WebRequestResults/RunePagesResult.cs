﻿using EF.RiotApi.Dto.Summoner;
using EF.RiotApi.Dto.Summoner.Runes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.WebRequestResults
{
    public class RunePagesResult
    {
        /// <summary>
        /// Set of rune pages associated with the summoner.
        /// </summary>
        [JsonProperty("pages")]
        public List<RunePageDto> Pages { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}