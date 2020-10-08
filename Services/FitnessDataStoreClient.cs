using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FitnessApp.Models;

namespace FitnessApp.Services
{
    public class FitnessDataStoreClient:IDataStoreClient
    {
        private readonly IHttpClientFactory _httpFactory;
        public FitnessDataStoreClient(IHttpClientFactory factoryInstance)
        {
            _httpFactory = factoryInstance;
        }
        public async Task<bool> WriteRecord(FitnessRecord newRecord)
        {
            return false;
        }
        public async Task<List<FitnessRecord>> GetAllRecords()
        {
            return new List<FitnessRecord>();
        }
        public async Task<List<FitnessRecord>> GetRecordsByWorkoutType(string
       workoutType)
        {
            return new List<FitnessRecord>();

        }
        public async Task<FitnessRecord> GetRecordByTitle(string title)
        {
            return new FitnessRecord();
        }
        public async Task<bool> UpdateRecord(string title, string newComment)
        {
            return true;
        }
        public async Task<bool> DeleteRecord(string title)
        {
            return true;
        }
    }

    public interface IDataStoreClient
    {
        Task<bool> WriteRecord(FitnessRecord newRecord);
        Task<List<FitnessRecord>> GetAllRecords();
        Task<List<FitnessRecord>> GetRecordsByWorkoutType(string workoutType);
        Task<FitnessRecord> GetRecordByTitle(string title);
        Task<bool> UpdateRecord(string title, string newComment);
        Task<bool> DeleteRecord(string title);
    }

}
