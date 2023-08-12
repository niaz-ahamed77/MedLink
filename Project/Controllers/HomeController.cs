using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Models.Entities;
using Project.Services;
using Project.Services.Interfaces;
using System.Diagnostics;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPatientService _patientService;
        private readonly IDoctorService _doctorService;
        private readonly ITestService _testService;
        private readonly IMedicalHistoryService _medicalHistoryService;
        private readonly IBillService _billService;
        private readonly IInsuranceService _insuranceService;

        public HomeController(ILogger<HomeController> logger, IPatientService patientService, IMedicalHistoryService medicalHistoryService, IBillService billService, IInsuranceService insuranceService, IDoctorService doctorService, ITestService testService)
        {
            _logger = logger;
            _patientService = patientService;
            _medicalHistoryService = medicalHistoryService;
            _billService = billService;
            _insuranceService = insuranceService;
            _doctorService = doctorService;
            _testService = testService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> PatientsAsync()
        {
            var patients = await _patientService.GetAllPatients();
            return View(patients);
        }

        public async Task<IActionResult> DoctorsAsync()
        {
            var doctors = await _doctorService.GetAllDoctors();
            return View(doctors);
        }

        public async Task<IActionResult> TestsAsync()
        {
            var tests = await _testService.GetAllTests();
            return View(tests);
        }

        public async Task<IActionResult> QueriesAsync()
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

        [HttpPost]
        [Route("addbill")]
        public async Task<IActionResult> AddBill([FromBody] Bill bill)
        {
            await _billService.AddBill(bill);
            return Ok();
        }

        [HttpPut]
        [Route("editbill")]
        public async Task<IActionResult> EditBill([FromBody] Bill bill)
        {
            await _billService.UpdateBill(bill);
            return Ok();
        }

        [HttpDelete]
        [Route("deletebill/{id}")]
        public async Task<IActionResult> DeletelBill(int id)
        {
            await _billService.DeleteBill(id);
            return Ok();
        }

        [HttpPost]
        [Route("addinsurance")]
        public async Task<IActionResult> AddInsurance([FromBody] Insurance insurance)
        {
            await _insuranceService.AddInsurance(insurance);
            return Ok();
        }

        [HttpPut]
        [Route("editinsurance")]
        public async Task<IActionResult> EditInsurance([FromBody] Insurance insurance)
        {
            await _insuranceService.UpdateInsurance(insurance);
            return Ok();
        }

        [HttpDelete]
        [Route("deleteinsurance/{id}")]
        public async Task<IActionResult> DeletelInsurance(int id)
        {
            await _insuranceService.DeleteInsurance(id);
            return Ok();
        }

        [HttpPost]
        [Route("adddoctor")]
        public async Task<IActionResult> AddDoctor([FromBody] Doctor doctor)
        {
            await _doctorService.AddDoctor(doctor);
            return Ok();
        }

        [HttpPut]
        [Route("editdoctor")]
        public async Task<IActionResult> EditDoctor([FromBody] Doctor doctor)
        {
            await _doctorService.UpdateDoctor(doctor);
            return Ok();
        }

        [HttpDelete]
        [Route("deletedoctor/{id}")]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            await _doctorService.DeleteDoctor(id);
            return Ok();
        }

        [HttpPost]
        [Route("addtest")]
        public async Task<IActionResult> AddTest([FromBody] Test test)
        {
            await _testService.AddTest(test);
            return Ok();
        }

        [HttpPut]
        [Route("edittest")]
        public async Task<IActionResult> EditTest([FromBody] Test test)
        {
            await _testService.UpdateTest(test);
            return Ok();
        }

        [HttpDelete]
        [Route("deletetest/{id}")]
        public async Task<IActionResult> DeleteTest(int id)
        {
            await _testService.DeleteTest(id);
            return Ok();
        }
    }
}