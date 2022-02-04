﻿using AnalyticsMicroservice.API.Entities;
using MongoDB.Driver;
using Newtonsoft.Json;

//using ce faliti za rabbit
namespace AnalyticsMicroservice.API.Repository
{
    public class AnalyticsRepository: IAnalyticsRepository
    {

        private readonly IMongoClient _client;
        public AnalyticsRepository(IMongoClient client)
        {
            _client = client;
        }

        public async Task WriteToMongo(DataAnalytics data)
        {
            //await _dbContext.AllData.InsertOneAsync(data);

            var db = _client.GetDatabase("Analytics");
            var collection = db.GetCollection<DataAnalytics>("Data-Analytics");

            collection.InsertOne(data);
        }

        //public async Task RemoveAllData()
        //{
        //    await _dbContext.AllData.DeleteManyAsync(p => true);
        //}

        public async Task<IEnumerable<DataAnalytics>> GetDataById(int id)
        {
            /*return await _dbContext
                        .AllData
                        .Find(x => x.Id == id)
                        .ToListAsync();*/
            var db = _client.GetDatabase("Analytics");
            var collection = db.GetCollection<DataAnalytics>("Data-Analytics");

            return await collection.Find(x=> x.Id==id).ToListAsync();
        }
    }
}
