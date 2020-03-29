using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BaseProject.DataAccess.Repository.IRepository;
using ElmahCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Areas.Home.Controllers
{
    [Area("Home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _hostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {   //var objFromDb = await _unitOfWork.Category.GetAllAsync();

            //Get UserId

            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            //var UserId = _unitOfWork.ApplicationUser.GetFirstOrDefault(c => c.Id == claim.Value,includeProperties: "Company");

            //Call SP

            //var parameter = new DynamicParameters();
            //parameter.Add("@Id", id);
            //coverType = _unitOfWork.SP_Call.OneRecord<CoverType>(SD.Proc_CoverType_Get, parameter);

            //elmah
            try
            {
                int i = 1;
                int j = 0;
                int ans = i / j;
            }
            catch (Exception)
            {
                HttpContext.RiseError(new InvalidOperationException("Test"));
            }
            return View();
        }
    }
}