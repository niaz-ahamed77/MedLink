using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Models.Entities;
using Project.Services.Interfaces;
using System.Diagnostics;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPatientService _patientService;

        public HomeController(ILogger<HomeController> logger, IPatientService patientService)
        {
            _logger = logger;
            _patientService = patientService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var patients = await _patientService.GetAllPatients();
            return View(patients);
        }

        public IActionResult Doctors()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        [Route("addpatient")]
        public async Task<IActionResult> AddPatient([FromBody] Patient patient)
        {
            await _patientService.AddPatient(patient);
            return Ok();
        }
    }
}