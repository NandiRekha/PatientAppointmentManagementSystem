using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointementManagmentLibrary.Model_Classes
{
    /// <summary>
    /// Property class for ReceptionInfoModel
    /// </summary>
    public class ReceptionInfoModel
    {
        private string _receptionistname;
        private string _gender;
        private DepartmentInfoModel.Shifts _workingShifts;

        public ReceptionInfoModel(string _receptionistname, string _gender, DepartmentInfoModel.Shifts _workingShifts)
        {
            this._receptionistname = _receptionistname;
            this._gender = _gender;
            this._workingShifts = _workingShifts;
        }

        public string ReceptionistName { get {return _receptionistname; } set {_receptionistname = value; } }

        public string Gender { get {return _gender; } set {_gender = value; } }

        public DepartmentInfoModel.Shifts WorkingShift { get {return _workingShifts; } set {_workingShifts = value; } }
    }
}
