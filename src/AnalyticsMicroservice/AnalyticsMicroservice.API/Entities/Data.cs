﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AnalyticsMicroservice.API.Entities
{
    public class Data
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string City { get; set; }
        public string SiteName { get; set; }
        public string Site { get; set; }
        public string QueryName { get; set; }
        public string ToDate { get; set; }
        public string FromDate { get; set; }
        public string SensorType { get; set; } //so2(sumpor dioksid), co(kobalt), ozone(azot dioksid)
        public decimal Value { get; set; }
    }
}
