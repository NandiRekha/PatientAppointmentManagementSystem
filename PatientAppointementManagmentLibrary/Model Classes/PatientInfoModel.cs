using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAppointementManagmentLibrary.Model_Classes
{
    /// <summary>
    /// Property class for PatientInfoModel 
    /// </summary>
    public class PatientInfoModel
    {
        private string pid;
        private string pFname;
        private string pLame;
        private int age;
        private string gender;
        private string pNumber;
        private string address;
        private string hProb;
        private DateTime expectedAppointment;
        private DateTime fixedAppointement;
        private DepartmentInfoModel.Departments department;
        private string doctorName;

        public PatientInfoModel(string pid, string pFname, string pLame, int age, string gender, string pNumber, string address, string hProb, DateTime expectedAppointment)
        {
            this.pid = pid;
            this.pFname = pFname;
            this.pLame = pLame;
            this.age = age;
            this.gender = gender;
            this.pNumber = pNumber;
            this.address = address;
            this.hProb = hProb;
            this.expectedAppointment = expectedAppointment;

        }
        public PatientInfoModel(string pid, string pFname, string pLame, int age, string gender, string pNumber, string address, string hProb, DepartmentInfoModel.Departments department, string doctorName, DateTime fixedAppointement)
        {
            this.pid = pid;
            this.pFname = pFname;
            this.pLame = pLame;
            this.age = age;
            this.gender = gender;
            this.pNumber = pNumber;
            this.address = address;
            this.hProb = hProb;
            this.fixedAppointement = fixedAppointement;
            this.department = department;
            this.doctorName = doctorName;

        }



        public string Patient_ID { get { return pid; } set { pid = value; } }

        public string Patient_Firstname { get{ return pFname; } set { pFname = value; } }

        public string Patient_Lastname { get { return pLame; } set { pLame = value; } }

        public int Age { get { return age; } set { age = value; } }

        public string Gender { get { return gender; } set { gender = value; } }

        public string PhoneNumer { get { return pNumber; } set {pNumber = value; } }

        public string Address { get {return address; } set {address = value; } }

        public string Health_Problem { get {return hProb; } set {hProb = value; } }

        public DateTime Expected_Appointment { get { return expectedAppointment; } set{ expectedAppointment = value; } }

        public DateTime Fixed_Appointment { get { return fixedAppointement; } set { fixedAppointement = value; } }

        public DepartmentInfoModel.Departments DepartmentRegistered { get { return department; } set { department = value; } }

        public string DoctorAppointed { get { return doctorName; } set { doctorName = value; } }
    }
}
