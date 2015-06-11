using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientInfo
{
    public class Patient : IComparable<Patient>, IEquatable<Patient>
    {
        public string patientName { get; set; }
        public int patientAge { get; set; }
        public string healthCardNumber { get; set; }
        public string bloodType { get; set; }
        public string familyDoctorName { get; set; }

        //public void addPatient(string patientName, int patientAge, int healthCardNumber, string bloodType, string familyDoctorName)
        //{
        //    this.patientName = patientName;
        //    this.patientAge = patientAge;
        //    this.healthCardNumber = healthCardNumber;
        //    this.bloodType = bloodType;
        //    this.familyDoctorName = familyDoctorName;
        //}

        public int CompareTo(Patient other)
    {
            if (this.patientName == other.patientName)
          {
              return this.patientName.CompareTo(other.patientName);
          }
            return other.patientName.CompareTo(this.patientName);
    }

        public bool Equals(Patient other)
        {
            if (other == null) return false;
            return (this.healthCardNumber.Equals(other.healthCardNumber));
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
