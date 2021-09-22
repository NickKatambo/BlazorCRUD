using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceMentor.Client.Services
{
    public interface IDataService
    {
        Task<ICollection<YearlyItem>> LoadCurrentYearExpenses();
        Task<ICollection<YearlyItem>> LoadCurrentYearEarnings();
        Task<ThreeMonthsData> LoadLastMonthsExpenses();
        Task<ThreeMonthsData> LoadLast3MonthsEarnings();
    }
}
