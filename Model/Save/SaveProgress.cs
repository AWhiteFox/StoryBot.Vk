﻿using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;

namespace StoryBot.Model
{
    [Serializable]
    public class SaveProgress
    {
        [JsonProperty("story")]
        [BsonElement("story")]
        public int? Story { get; set; }

        [JsonProperty("chapter")]
        [BsonElement("chapter")]
        public int? Chapter { get; set; }

        [JsonProperty("storyline")]
        [BsonElement("storyline")]
        public string Storyline { get; set; }

        [JsonProperty("position")]
        [BsonElement("position")]
        public int Position { get; set; }

        [JsonProperty("achievement")]
        [BsonElement("achievement")]
        public int? Achievement { get; set; }
    }
}
