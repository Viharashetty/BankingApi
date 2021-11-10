using BankingApi.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller


    {

        private BankContext _dbContext;
        public HomeController(BankContext dbContext)
        {
            _dbContext = dbContext;
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public float Get(int AdminID)
        {

            var user = _dbContext.Banks.Find(AdminID);
            var amount = user.Amount;

            return amount;

        }
    }
}







