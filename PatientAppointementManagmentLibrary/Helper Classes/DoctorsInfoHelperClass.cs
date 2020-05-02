using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientAppointementManagmentLibrary.Model_Classes;

namespace PatientAppointementManagmentLibrary.Helper_Classes
{
    public class DoctorsInfoHelperClass
    {
        public DoctorsInfoModel AssignDoctor(DepartmentInfoModel.Departments department, List<DoctorsInfoModel> doctList, DateTime datenow)
        {
           
            if (department == DepartmentInfoModel.Departments.General_Physician)
            {
                var availableDoctor = doctList.Where(item => (item.Specialisation == DepartmentInfoModel.Departments.General_Physician)
                                      && ((datenow >= item.AvailableDateFrom)
                                      && (datenow <= item.AvailableDateTo)))
                                      .FirstOrDefault();
                return availableDoctor;
            }
            else if (department == DepartmentInfoModel.Departments.Cardiology)
            {
                var availableDoctor = doctList.Where(item => (item.Specialisation == DepartmentInfoModel.Departments.Cardiology)
                                      && ((datenow >= item.AvailableDateFrom)
                                      && (datenow <= item.AvailableDateTo)))
                                      .FirstOrDefault();
                return availableDoctor;
            }
            else if (department == DepartmentInfoModel.Departments.Dermatologist)
            {
                var availableDoctor = doctList.Where(item => (item.Specialisation == DepartmentInfoModel.Departments.Dermatologist)
                                      && ((datenow >= item.AvailableDateFrom)
                                      && (datenow <= item.AvailableDateTo)))
                                      .FirstOrDefault();
                return availableDoctor;
            }
            else if (department == DepartmentInfoModel.Departments.Pediatrician)
            {
                var availableDoctor = doctList.Where(item => (item.Specialisation == DepartmentInfoModel.Departments.Pediatrician)
                                      && ((datenow >= item.AvailableDateFrom)
                                      && (datenow <= item.AvailableDateTo)))
                                      .FirstOrDefault();
                return availableDoctor;
            }
            else if (department == DepartmentInfoModel.Departments.Oncology)
            {
                var availableDoctor = doctList.Where(item => (item.Specialisation == DepartmentInfoModel.Departments.Oncology)
                                      && ((datenow >= item.AvailableDateFrom)
                                      && (datenow <= item.AvailableDateTo)))
                                      .FirstOrDefault();
                return availableDoctor;
            }
            else
            {
                var availableDoctor = doctList.Where(item => (item.Specialisation == DepartmentInfoModel.Departments.Emergency)
                                      && ((DateTime.Now >= item.AvailableDateFrom)
                                      && (DateTime.Now <= item.AvailableDateTo)))
                                      .FirstOrDefault();
                return availableDoctor;
            }
        }
    }
}
