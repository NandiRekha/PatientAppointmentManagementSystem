using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointementManagmentLibrary.Model_Classes
{
    /// <summary>
    /// Property class for DoctorsInfoModel
    /// </summary>
    public class DoctorsInfoModel
    {
        private string _doctorFirstname;
        private string _doctorLastname;
        private DepartmentInfoModel.Departments _specialisation;
       // private DepartmentInfoModel.Shifts _workingshift;
        private DateTime _availableDateFrom;
        private DateTime _availableDateTo;

        public DoctorsInfoModel(string _doctorFirstname, string _doctorLastname, DepartmentInfoModel.Departments _specialisation, DateTime _availableDateFrom, DateTime _availableDateTo)
        {
            this._doctorFirstname = _doctorFirstname;
            this._doctorLastname = _doctorLastname;
            this._specialisation = _specialisation;
            //this._workingshift = _workingshift;
            this._availableDateFrom = _availableDateFrom;
            this._availableDateTo = _availableDateTo;

        }

        public string Doctor_FirstName { get {return _doctorFirstname; } set {_doctorFirstname = value; } }

        public string Doctor_LastName { get {return _doctorLastname; } set {_doctorLastname = value; } }

        public DepartmentInfoModel.Departments Specialisation { get {return _specialisation; } set {_specialisation =  value; } }

       // public DepartmentInfoModel.Shifts WorkingShift { get { return _workingshift; } set {_workingshift = value; } }

        public DateTime AvailableDateFrom { get { return _availableDateFrom; } set { _availableDateFrom = value; } }

        public DateTime AvailableDateTo { get { return _availableDateTo; } set { _availableDateTo = value; } }

    }
}
