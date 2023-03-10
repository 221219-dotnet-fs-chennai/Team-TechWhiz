using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Patient_Logic;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        IPatientLogic patientlogic;
        public PatientController(IPatientLogic _patientlogic)
        {
            patientlogic = _patientlogic;
        }

        [HttpPost("Register_Patient")]
        public IActionResult RegisterPat([FromBody]Patient patient)
        {
            var p = patientlogic.AddPatient(patient);
            if (p != null)
            {
                return Ok(p);
            }
            else
                return BadRequest("Sorry...Something Went Wrong");
        }

        [HttpGet("SignIn_Patient")]
        public IActionResult SignInPatient([FromHeader]string email, [FromHeader]string pass)
        {
            var p=patientlogic.LoginPatient(email, pass);
            if (p != null)
            {
                return Ok(p);
            }
            else
                return BadRequest("Sorry Not Found");
        }

        [HttpDelete("Delete_Patient")]

        public IActionResult Delete([FromHeader]string email)
        {
            var p=patientlogic.DeletePatient(email);
            if (p != null)
            {
                return Ok(p);
            }
            else
                return BadRequest("Not Found");
        }

        [HttpPut("Update_Patient")]

        public IActionResult Update([FromHeader]string email, [FromBody]Patient patient)
        {
            patientlogic.UpdatePatient(email, patient);
            return Ok(patient);
        }
    }
}
