using FinanceMentor.Server.Storage;
using FinanceMentor.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceMentor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EarningsController : ControllerBase
    {
        private readonly IRepository<Earning> _earningRepository;

        public EarningsController(IRepository<Earning> earningRepository)
        {
            _earningRepository = earningRepository;
        }

        public IEnumerable<Earning> Get()
        {
            return _earningRepository.GetAll()
                .OrderBy(earning => earning.Date);
        }

        [HttpPost]
        public void Post(Earning earning)
        {
            _earningRepository.Add(earning);
        }
    }
}
