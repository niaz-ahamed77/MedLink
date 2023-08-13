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
        private readonly IPatientTestService _testPatientService;
        private readonly IAppointmentService _appointmentService;
        private readonly ICurrentIllnessService _currentIllnessService;

        public HomeController(ILogger<HomeController> logger, IPatientService patientService, IMedicalHistoryService medicalHistoryService, IBillService billService, IInsuranceService insuranceService, IDoctorService doctorService, ITestService testService, IPatientTestService testPatientService, IAppointmentService appointmentService, ICurrentIllnessService currentIllnessService)
        {
            _logger = logger;
            _patientService = patientService;
            _medicalHistoryService = medicalHistoryService;
            _billService = billService;
            _insuranceService = insuranceService;
            _doctorService = doctorService;
            _testService = testService;
            _testPatientService = testPatientService;
            _appointmentService = appointmentService;
            _currentIllnessService = currentIllnessService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> PatientsAsync()
        {
            var patients = await _patientService.GetAllPatients();
            var doctors = await _doctorService.GetAllDoctors();
            var tests = await _testService.GetAllTests();
            ViewBag.Doctors = doctors.ToList();
            ViewBag.Tests = tests.ToList();
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
            var patients = (await _patientService.GetAllPatients()).ToList();
            return View(patients);
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

        [HttpPost]
        [Route("addpatienttest")]
        public async Task<IActionResult> AddPatientTest([FromBody] PatientTest patientTest)
        {
            await _testPatientService.AddPatientTest(patientTest);
            return Ok();
        }

        [HttpPut]
        [Route("editpatienttest")]
        public async Task<IActionResult> EditPatientTest([FromBody] PatientTest patientTest)
        {
            await _testPatientService.UpdatePatientTest(patientTest);
            return Ok();
        }

        [HttpDelete]
        [Route("deletepatienttest/{id}")]
        public async Task<IActionResult> DeletePatientTest(int id)
        {
            await _testPatientService.DeletePatientTest(id);
            return Ok();
        }

        [HttpPost]
        [Route("addcurrentillness")]
        public async Task<IActionResult> AddCurrentIllness([FromBody] CurrentIllness currentIllness)
        {
            await _currentIllnessService.AddCurrentIllness(currentIllness);
            return Ok();
        }

        [HttpPut]
        [Route("editcurrentillness")]
        public async Task<IActionResult> EditCurrentIllness([FromBody] CurrentIllness currentIllness)
        {
            await _currentIllnessService.UpdateCurrentIllness(currentIllness);
            return Ok();
        }

        [HttpDelete]
        [Route("deletecurrentillness/{id}")]
        public async Task<IActionResult> DeleteCurrentIllness(int id)
        {
            await _currentIllnessService.DeleteCurrentIllness(id);
            return Ok();
        }

        [HttpPost]
        [Route("addappointment")]
        public async Task<IActionResult> AddAppointment([FromBody] Appointment appointment)
        {
            await _appointmentService.AddAppointment(appointment);
            return Ok();
        }

        [HttpPut]
        [Route("editappointment")]
        public async Task<IActionResult> EditAppointment([FromBody] Appointment appointment)
        {
            await _appointmentService.UpdateAppointment(appointment);
            return Ok();
        }

        [HttpDelete]
        [Route("deleteappointment/{id}")]
        public async Task<IActionResult> DeleteAppointment(int id)
        {
            await _appointmentService.DeleteAppointment(id);
            return Ok();
        }
    }
}