using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public interface IPatientCheckUP
    {
        public IEnumerable<Models.PatientIntialCheckUp> GetCheckUpDetails(Guid appointment_id);

        public Models.PatientIntialCheckUp AddCheckUpDetails(Models.PatientIntialCheckUp initialCheckUp);

        //public ArrayList GetAppointmentandCheckUp(Guid appointment_id);

       // public Models.PatientIntialCheckUp UpdateCheckUpStatus(Guid appointment_id);
    }
}
