
using DataEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
    public interface IPatient
    {
        Patient RegisterPatient(Patient patient);
        Patient UpdatePatient(Patient patient);
        Patient DeletePatient(string email);
        List<Patient> GetAllPatient();
    }
}
