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
        private readonly IMedicalHistoryService _medicalHistoryService;

        public HomeController(ILogger<HomeController> logger, IPatientService patientService, IMedicalHistoryService medicalHistoryService)
        {
            _logger = logger;
            _patientService = patientService;
            _medicalHistoryService = medicalHistoryService;
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

        [HttpPut]
        [Route("editpatient")]
        public async Task<IActionResult> EditPatient([FromBody] Patient patient)
        {
            await _patientService.UpdatePatient(patient);
            return Ok();
        }

        [HttpDelete]
        [Route("deletepatient/{id}")]
        public async Task<IActionResult> DeletePatient(int id)
        {
            await _patientService.DeletePatient(id);
            return Ok();
        }

        [HttpPost]
        [Route("addmedicalhistory")]
        public async Task<IActionResult> AddMedicalHistory([FromBody] MedicalHistory medicalHistory)
        {
            await _medicalHistoryService.AddMedicalHistory(medicalHistory);
            return Ok();
        }

        [HttpPut]
        [Route("editmedicalhistory")]
        public async Task<IActionResult> EditMedicalHistory([FromBody] MedicalHistory medicalHistory)
        {
            await _medicalHistoryService.UpdateMedicalHistory(medicalHistory);
            return Ok();
        }

        [HttpDelete]
        [Route("deletemedicalhistory/{id}")]
        public async Task<IActionResult> DeleteMedicalHistory(int id)
        {
            await _medicalHistoryService.DeleteMedicalHistory(id);
            return Ok();
        }
    }
}