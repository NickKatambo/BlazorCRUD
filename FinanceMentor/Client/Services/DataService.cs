using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FinanceMentor.Client.Services
{
    public class DataService : IDataService
    {
        private readonly HttpClient _httpClient;

        public DataService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public Task<ICollection<YearlyItem>> LoadCurrentYearEarnings()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<YearlyItem>> LoadCurrentYearExpenses()
        {
            throw new NotImplementedException();
        }

        public Task<ThreeMonthsData> LoadLast3MonthsEarnings()
        {
            throw new NotImplementedException();
        }

        public Task<ThreeMonthsData> LoadLastMonthsExpenses()
        {
            throw new NotImplementedException();
        }
    }
}
