using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointementManagmentLibrary.Model_Classes
{
    /// <summary>
    /// property class for DepartmentInfoModel
    /// </summary>
    public class DepartmentInfoModel
    {
        public enum Departments
        {
            General_Physician,
            Emergency,
            Pediatrician,
            Cardiology,
            Oncology,
            Dermatologist
        }

        public enum Shifts
        {
            Morning,
            Afternoon,
            Night

        }
    }
}
