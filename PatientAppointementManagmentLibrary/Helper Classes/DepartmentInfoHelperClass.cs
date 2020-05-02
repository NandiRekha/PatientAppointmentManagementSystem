using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientAppointementManagmentLibrary.Model_Classes;

namespace PatientAppointementManagmentLibrary.Helper_Classes
{
    public class DepartmentInfoHelperClass
    {
        public DepartmentInfoModel.Departments AssignDepartment(string sickness, int age)
        {

            if (age <= 12)
            {
                return DepartmentInfoModel.Departments.Pediatrician;
            }
            else
            {
                if (sickness.Equals("Fever") || sickness.Equals("cold") || sickness.Equals("fever"))
                {
                    return DepartmentInfoModel.Departments.General_Physician;
                }
                else if (sickness.Equals("cancer"))
                {
                    return DepartmentInfoModel.Departments.Oncology;
                }
                else if (sickness.Equals("skincare") || sickness.Equals("hairloss"))
                {
                    return DepartmentInfoModel.Departments.Dermatologist;
                }
                else if (sickness.Equals("heart desease") || (sickness.Equals("heart related")))
                {
                    return DepartmentInfoModel.Departments.Cardiology;
                }
                else
                {
                    return DepartmentInfoModel.Departments.Emergency;
                }
            }
        }
    }

}
