using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientAppointementManagmentLibrary.Model_Classes;

namespace PatientAppointementManagmentLibrary.Helper_Classes
{
    public class PatientAppointmentHelperClass
    {
       public event EventHandler<DoctorsInfoModel> AppointmentNotification;
      
      
       public List<DoctorsInfoModel> DoctorsAvailable()
       {
            List<DoctorsInfoModel> doctorList = new List<DoctorsInfoModel>();
           doctorList.Add(new DoctorsInfoModel("Dr.Harry", "Potter", DepartmentInfoModel.Departments.General_Physician, new DateTime(2020, 5, 1), new DateTime(2020, 5, 8)));
           doctorList.Add(new DoctorsInfoModel("Dr.Hermione", "Granger", DepartmentInfoModel.Departments.General_Physician, new DateTime(2020, 5, 9), new DateTime(2020, 5, 20)));
           doctorList.Add(new DoctorsInfoModel("Dr.Ron", "Weasley", DepartmentInfoModel.Departments.General_Physician, new DateTime(2020, 5, 21), new DateTime(2020, 5, 31)));
           doctorList.Add(new DoctorsInfoModel("Dr.Ross", "Geller", DepartmentInfoModel.Departments.Cardiology, new DateTime(2020, 5, 1), new DateTime(2020, 5, 10)));
           doctorList.Add(new DoctorsInfoModel("Dr.Chandler", "Bing", DepartmentInfoModel.Departments.Cardiology, new DateTime(2020, 5, 11), new DateTime(2020, 5, 19)));
           doctorList.Add(new DoctorsInfoModel("Dr.Richard", "Burke", DepartmentInfoModel.Departments.Cardiology, new DateTime(2020, 5, 20), new DateTime(2020, 5, 31)));
           doctorList.Add(new DoctorsInfoModel("Dr.Michael", "Ross", DepartmentInfoModel.Departments.Dermatologist, new DateTime(2020, 5, 1), new DateTime(2020, 5, 13)));
           doctorList.Add(new DoctorsInfoModel("Dr.Samantha", "Wheeler", DepartmentInfoModel.Departments.Dermatologist, new DateTime(2020, 5, 14), new DateTime(2020, 5, 23)));
           doctorList.Add(new DoctorsInfoModel("Dr.Rachel", "Zane", DepartmentInfoModel.Departments.Dermatologist, new DateTime(2020, 5, 24), new DateTime(2020, 5, 31)));
           doctorList.Add(new DoctorsInfoModel("Dr.Hannah", "Baker", DepartmentInfoModel.Departments.Pediatrician, new DateTime(2020, 5, 1), new DateTime(2020, 5, 8)));
           doctorList.Add(new DoctorsInfoModel("Dr.Justin", "Foley", DepartmentInfoModel.Departments.Pediatrician, new DateTime(2020, 5, 9), new DateTime(2020, 5, 15)));
           doctorList.Add(new DoctorsInfoModel("Dr.Clay", "Jensen", DepartmentInfoModel.Departments.Pediatrician, new DateTime(2020, 5, 16), new DateTime(2020, 5, 31)));
           doctorList.Add(new DoctorsInfoModel("Dr.Alan", "Harper", DepartmentInfoModel.Departments.Oncology, new DateTime(2020, 5, 1), new DateTime(2020, 5, 10)));
           doctorList.Add(new DoctorsInfoModel("Dr.Herb", "Melnick", DepartmentInfoModel.Departments.Oncology, new DateTime(2020, 5, 11), new DateTime(2020, 5, 18)));
           doctorList.Add(new DoctorsInfoModel("Dr.Laura", "Lang", DepartmentInfoModel.Departments.Oncology, new DateTime(2020, 5, 19), new DateTime(2020, 5, 31)));
           doctorList.Add(new DoctorsInfoModel("Dr.Harvey", "Specter", DepartmentInfoModel.Departments.Emergency, new DateTime(2020, 5, 1), new DateTime(2020, 5, 13)));
           doctorList.Add(new DoctorsInfoModel("Dr.Louis", "Litt", DepartmentInfoModel.Departments.Emergency, new DateTime(2020, 5, 14), new DateTime(2020, 5, 22)));
           doctorList.Add(new DoctorsInfoModel("Dr.Michael", "Scott", DepartmentInfoModel.Departments.Emergency, new DateTime(2020, 5, 22), new DateTime(2020, 5, 31)));
      
           return doctorList;
      
       }

        public List<ReceptionInfoModel> ReceptionistsAvailable()
        {
            List<ReceptionInfoModel> receptionistList = new List<ReceptionInfoModel>();
            receptionistList.Add(new ReceptionInfoModel("Donna", "Paulsen", DepartmentInfoModel.Shifts.Morning));
            receptionistList.Add(new ReceptionInfoModel("Monica", "Greeen", DepartmentInfoModel.Shifts.Afternoon));
            receptionistList.Add(new ReceptionInfoModel("Jessica", "Pearson", DepartmentInfoModel.Shifts.Night));
        
            return receptionistList;
        }
         
          public List<PatientInfoModel> RegisteredPatients()
        {
            List<PatientInfoModel> patientList = new List<PatientInfoModel>();
            patientList.Add(new PatientInfoModel("54234", "John", "Doe", 36, "Male", "9723456702", "Venice", "Skincare",DepartmentInfoModel.Departments.Dermatologist, "Dr.Samantha", new DateTime(2020, 5, 18)));
            patientList.Add(new PatientInfoModel("54235", "Arjun", "Singania", 29, "Male", "888573462", "Banglore", "Cold",DepartmentInfoModel.Departments.General_Physician, "Dr.Harry", DateTime.Now ));
            patientList.Add(new PatientInfoModel("54236", "Ashika", "HM", 35, "Female", "834562788", "Davangere", "Cancer", DepartmentInfoModel.Departments.Oncology, "Dr.Alan", new DateTime(2020, 5, 7)));
            patientList.Add(new PatientInfoModel("54237", "Soumya", "Lokesh", 10, "Female", "98345278", "Hasan", "Childcare", DepartmentInfoModel.Departments.Pediatrician, "Dr.Michael", new DateTime(2020, 5, 23)));
            return patientList;
        }

        public void AddNewPatient(List<DoctorsInfoModel> availabledocList, List<PatientInfoModel> regPatients)
        {
           
            System.Console.WriteLine(" Add the new patient details here\n");
            Console.WriteLine(" PatientID");
            var patient_ID = Console.ReadLine();
            Console.WriteLine(" First Name");
            var patient_Firstname = Console.ReadLine();
            Console.WriteLine(" Last Name");
            var patient_Lastname = Console.ReadLine();
            Console.WriteLine(" Age");
            var age = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" Gender");
            var gender = Console.ReadLine();
            Console.WriteLine(" Phone Number");
            var phoneNumer = Console.ReadLine();
            Console.WriteLine(" Address");
            var address = Console.ReadLine();
            Console.WriteLine(" Health Problem");
            var health_Problem = Console.ReadLine();
            Console.WriteLine(" Enter the date of appointment You are expecting in yyyy mm dd ex(2020 05 20) format");
            DateTime expected_appointment = Convert.ToDateTime(Console.ReadLine());

            RegisterPatient(patient_ID, patient_Firstname, patient_Lastname, age, gender, phoneNumer, address, health_Problem, expected_appointment, availabledocList, regPatients);
            
        }
        public void RegisterPatient(string patientid, string pFname, string pLname, int age, string gender, string phoneNnmber, string address, string sickness,DateTime expectedDateOfAp, List<DoctorsInfoModel> availabledocList, List<PatientInfoModel> regPatients)
        {
            Console.WriteLine("-------------------------------Patient Registration------------------------------------\n\n");
           
            DepartmentInfoHelperClass depHelpclass = new DepartmentInfoHelperClass();
            DoctorsInfoHelperClass docHelpclass = new DoctorsInfoHelperClass();
          
            DepartmentInfoModel.Departments departmentSelected = depHelpclass.AssignDepartment(sickness, age);

            Console.WriteLine("******************Available Doctors in " + departmentSelected+"*****************");
            foreach (DoctorsInfoModel doc in availabledocList)
            {
                if (doc.Specialisation == departmentSelected)
                {
                    Console.WriteLine(doc.Doctor_FirstName + " " + doc.Doctor_LastName + " is available from "+ doc.AvailableDateFrom + " till "+ doc.AvailableDateTo);
                }
            }
            Console.WriteLine("*************************************************************************\n");
            DoctorsInfoModel availableDoctor = docHelpclass.AssignDoctor(departmentSelected, availabledocList, expectedDateOfAp);
            Console.WriteLine("The Patient " + pFname + " " + pLname + " has been registered Successfully with " + availableDoctor.Doctor_FirstName, availableDoctor.Doctor_LastName + " for department" + departmentSelected+"\n\n");
            regPatients.Add(new PatientInfoModel(patientid, pFname, pLname, age, gender, phoneNnmber, address, sickness, departmentSelected, availableDoctor.Doctor_FirstName, expectedDateOfAp));
            AppointmentNotification?.Invoke(this, availableDoctor);
        }

        public void Dashboard(List<PatientInfoModel> patientsRegistered)
        {
            Console.WriteLine("******************Dashboard of Daily Appointmets***********************");
            foreach(PatientInfoModel pdetails in patientsRegistered)
            {
                Console.WriteLine("Patient " + pdetails.Patient_Firstname +" "+ pdetails.Patient_Lastname + " has Appointment with " + pdetails.DoctorAppointed + " of " + pdetails.DepartmentRegistered + " on " + pdetails.Fixed_Appointment);
            }
            Console.WriteLine("*************************************************************************");
        }
    }
}
