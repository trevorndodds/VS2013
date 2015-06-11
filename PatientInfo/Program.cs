using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientInfo
{
    class Program
    {
        static void Main(string[] args)
        {

           // Patient newP = new Patient();
            List<Patient> newPatient = new List<Patient>();
            
            int selection = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("----Patient Information System----");
                Console.WriteLine();
                Console.WriteLine("1.  Add Patient");
                Console.WriteLine("2.  Show Patients");
                Console.WriteLine("3.  Edit Patients");
                Console.WriteLine("4.  Search Patients");
                Console.WriteLine("5.  Sort Patients");
                Console.WriteLine("6.  Quit");
                Console.Write("\n"+"Please make a selection: ");
                selection =int.Parse(Console.ReadLine());

                if (selection == 1)
                {
                    Console.Clear();
                    Console.WriteLine("--------------------New Patient--------------------\n");
                    Console.Write("Enter Patient Name       : ");
                    string strPatientName = Console.ReadLine();
                    Console.Write("Enter Patient Age        : ");
                    int intPatientAge = int.Parse(Console.ReadLine());
                    Console.Write("Enter Patient OHIP Number: ");
                    string strPatientOHIPNumber = (Console.ReadLine());
                    Console.Write("Enter Patient BloodType  : ");
                    string strBloodType = Console.ReadLine();
                    Console.Write("Enter Family Doctor      : ");
                    string strPatientDoctor = Console.ReadLine();

                    newPatient.Add(new Patient() { patientName = strPatientName, patientAge = intPatientAge, healthCardNumber = strPatientOHIPNumber, bloodType = strBloodType, familyDoctorName = strPatientDoctor });
                 //   newP.addPatient(strPatientName, intPatientAge, intPatientOHIPNumber, strBloodType, strPatientDoctor);
                 //   newPatient.Add(newP);
                 //   newPatient.Add(new Patient() { patientName = strPatientName, patientAge = intPatientAge, healthCardNumber = intPatientOHIPNumber, bloodType = strBloodType, familyDoctorName = strPatientDoctor });
                }
                else if (selection == 2)
                {

                   // newPatient.ForEach(i => Console.WriteLine("{0}\t", i.patientName));
                   // Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("--------Show Patient List--------\n");
                    foreach (Patient line in newPatient)
                    {
                        Console.WriteLine("Name: {0} Age: {1} OHIP: {2} BloodType: {3} Doctor: {4}", line.patientName, line.patientAge, line.healthCardNumber, line.bloodType, line.familyDoctorName);
                    }
                    Console.WriteLine("\nPress a key to return to menu.");
                    Console.ReadKey();
                }
                else if (selection == 3)
                {
                    //Edit Patients
                    Console.Clear();
                    Console.WriteLine("--------Update Patient Information--------\n");
                    int patientNumber = 0;
                    Console.WriteLine("Listing all Patients Records: \n");
                    foreach (Patient line in newPatient)
                    {

                        Console.WriteLine(patientNumber +" " + line.patientName + " | " + line.healthCardNumber);
                        patientNumber++;
                    }
                    Console.Write("\nSelect patient to update: ");
                    int selectPatient = int.Parse(Console.ReadLine());
                    if (selectPatient + 1 > newPatient.Count) { Console.WriteLine("Key does not exist"); }
                    else
                    {
                        Console.WriteLine("You are now going to Update: {0} ", newPatient[selectPatient].patientName);
                        Console.Write("Enter Patient Name [" + newPatient[selectPatient].patientName + "] : ");
                        newPatient[selectPatient].patientName = Console.ReadLine();
                        Console.Write("Enter Patient Age: [" + newPatient[selectPatient].patientAge + "] : ");
                        newPatient[selectPatient].patientAge = int.Parse(Console.ReadLine());
                        Console.Write("Enter Patient OHIP Number: [" + newPatient[selectPatient].healthCardNumber + "] : ");
                        newPatient[selectPatient].healthCardNumber = Console.ReadLine();
                        Console.Write("Enter Patient BloodType: [" + newPatient[selectPatient].bloodType + "] : ");
                        newPatient[selectPatient].bloodType = Console.ReadLine();
                        Console.Write("Enter Patient Family Doctor: [" + newPatient[selectPatient].familyDoctorName + "] : ");
                        newPatient[selectPatient].familyDoctorName = Console.ReadLine();
                    }
                    Console.WriteLine("\nPress a key to return to menu.");
                    Console.ReadKey();
                }
                else if (selection == 4)
                {
                    //Search OHIP
                        Console.Clear();
                        Console.WriteLine("--------Search Patient--------\n");
                        Console.Write("Search Patient by OHIP Number: ");
                        string strPatientOHIPNumber = Console.ReadLine();

                        bool checkExists = newPatient.Contains(new Patient { healthCardNumber = strPatientOHIPNumber});
                        if (checkExists == true)
                        {
                            Patient result = newPatient.Find(i => i.healthCardNumber == strPatientOHIPNumber);
                            Console.WriteLine("Name: {0} \n\tAge      : {1} \n\tOHIP     : {2} \n\tBloodType: {3} \n\tDoctor   : {4}", result.patientName, result.patientAge, result.healthCardNumber, result.bloodType, result.familyDoctorName);
                            Console.WriteLine("\nPress to return to main menu.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("No Records Found, press to continue");
                            Console.ReadKey();
                        }
                }

                else if (selection == 5)
                {
                    //Sort Patients
                    Console.Clear();
                    Console.WriteLine("--------Patients Sorted by Name--------\n");
                    newPatient.Sort(delegate(Patient x, Patient y)
                    {
                        if (x.patientName == null && y.patientName == null) return 0;
                        else if (x.patientName == null) return -1;
                        else if (y.patientName == null) return 1;
                        else return x.patientName.CompareTo(y.patientName);
                    });

                    foreach (Patient line in newPatient)
                    {
                        Console.WriteLine("Name: {0} \n\tAge      : {1} \n\tOHIP     : {2} \n\tBloodType: {3} \n\tDoctor   : {4}", line.patientName, line.patientAge, line.healthCardNumber, line.bloodType, line.familyDoctorName);
                    }
                    Console.WriteLine("\nPress a key to return to menu.");
                    Console.ReadKey();
                }
              //  Console.Clear();
            }
            while (selection != 6);
        }
       
    }
}
