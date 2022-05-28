// See https://aka.ms/new-console-template for more information
using Question1.Models;
using Question1.Models.Products;
using Question1.Repos.DBManager;
using Question1.Repos.Helper;
using System.Data.SqlClient;

FluentNHibernateHelper.OpenSession();


#region Initialization
var hospital1 = new Hospital();
var receptionist = new Receptionist();
var accountant = new Accountant();
var doctors = new List<Doctor>();
var nurses = new List<Nurse>();
var pharmacists = new List<Pharmacist>();
var patients = new List<Patient>();
var registeredPatients = new List<RegisteredPatient>();
var drugs = new List<Drug>();
var transactions = new List<Drug>();
#endregion

#region Add Hospital

hospital1 = new Hospital(0, "Ikoki Memorial Hospital", "Kpansia Bayelsa", receptionist, accountant);

//DataBaseManager<Hospital>.AddItem(hospital1);
#endregion


#region Add Receptionist

receptionist = new Receptionist(0, "Blessing Abraham", hospital1);

//DataBaseManager<Receptionist>.AddItem(receptionist);
#endregion

#region Add Accountant

accountant = new Accountant(0, "Chiamaka Asor", hospital1);

//DataBaseManager<Accountant>.AddItem(accountant);
#endregion

#region Add Doctors
var doctor1 = new Doctor(0, "Dr.Timothy", hospital1);
var doctor2 = new Doctor(1, "Dr.Gideon", hospital1);
var doctor3 = new Doctor(2, "Dr.Gift", hospital1);
var doctor4 = new Doctor(3, "Dr.Dozie", hospital1);
var doctor5 = new Doctor(4, "Dr.Mary", hospital1);

doctors = new List<Doctor>() { doctor1, doctor2, doctor3, doctor4, doctor5 };
foreach (var item in doctors)
{
   // DataBaseManager<Doctor>.AddItem(item);
}
#endregion

#region Add Nurses
var nurse1 = new Nurse(0, "Miss Angela", hospital1);
var nurse2 = new Nurse(1, "Effiong Etim", hospital1);
var nurse3 = new Nurse(2, "Archibong Rachael", hospital1);
var nurse4 = new Nurse(3, "Gloria Andrew", hospital1);
var nurse5 = new Nurse(4, "Esther Edem", hospital1);

nurses = new List<Nurse>() { nurse1, nurse2, nurse3, nurse4, nurse5 };
foreach (var item in nurses)
{
    // DataBaseManager<Nurse>.AddItem(item);
}
//DataBaseManager<Nurse>.DeleteItem(nurse2);
//DataBaseManager<Nurse>.AddItem(nurse2);
//DataBaseManager<Nurse>.UpdateItem(nurse2);
//var readNurse2 = DataBaseManager<Nurse>.ReadItemById(1);

//Console.WriteLine(readNurse2.Name);


#endregion



#region Add Pharmacists
var pharmacist1 = new Pharmacist(0, "Stephen Ede", hospital1);
var pharmacist2 = new Pharmacist(1, "Obena Okpu", hospital1);
var pharmacist3 = new Pharmacist(2, "Dalene Upe", hospital1);
var pharmacist4 = new Pharmacist(3, "Sylva Ane", hospital1);
var pharmacist5 = new Pharmacist(4, "Ebe Rita", hospital1);

pharmacists = new List<Pharmacist>() { pharmacist1, pharmacist2, pharmacist3, pharmacist4, pharmacist5 };
foreach (var item in pharmacists)
{
   // DataBaseManager<Pharmacist>.AddItem(item);
}
#endregion

#region Add RegisteredPatients
var registeredPatient1 = new RegisteredPatient(0, 001, "Bassey Udoh", Gender.Female, "Ekeki Housing Estate", hospital1);
var registeredPatient2 = new RegisteredPatient(1, 002, "Etulan Edoghotu", Gender.Male, "Azikoro Town", hospital1);
var registeredPatient3 = new RegisteredPatient(2, 003, "Iyaronin Favour", Gender.Female, "Igbogene Town", hospital1);
var registeredPatient4 = new RegisteredPatient(3, 004, "Favour Lively", Gender.Male, "Opolo Elebele", hospital1);
var registeredPatient5 = new RegisteredPatient(4, 005, "Blessing Richard", Gender.Female, "Baybridge Street", hospital1);

registeredPatients = new List<RegisteredPatient>() { registeredPatient1, registeredPatient2, registeredPatient3, registeredPatient4, registeredPatient5 };
foreach (var item in registeredPatients)
{
   // DataBaseManager<RegisteredPatient>.AddItem(item);
}

//DataBaseManager<RegisteredPatient>.DeleteItem(registeredPatient2);
////DataBaseManager<RegisteredPatient>.AddItem(nurse2);
//DataBaseManager<RegisteredPatient>.UpdateItem(registeredPatient2);
//var readNurse2 = DataBaseManager<RegisteredPatient>.ReadItemById(3);

//Console.WriteLine(readNurse2.Name);
#endregion


#region Add Patients
var patient1 = new Patient(0, 006, "Comfort Rita", Gender.Female, "Opolo Housing Estate", hospital1);
var patient2 = new Patient(1, 007, "Flora Edoghotu", Gender.Female, "Kpansia Town", hospital1);
var patient3 = new Patient(2, 008, "Nancy Favour", Gender.Female, "Otuoke Town", hospital1);
var patient4 = new Patient(3, 009, "Favour Angel", Gender.Male, "NNPC Junction", hospital1);
var patient5 = new Patient(4, 010, "Anita Richard", Gender.Female, "Tombia Street", hospital1);

patients = new List<Patient>() { patient1, patient2, patient3, patient4, patient5 };
foreach (var item in patients)
{
   // DataBaseManager<Patient>.AddItem(item);
}
#endregion

#region Add Drugs
var drug1  = new Drug(0,  "AMLODIPINE",      200, pharmacist3);
var drug2  = new Drug(1,  "ALPRAZOLAM",      400, pharmacist3);
var drug3  = new Drug(2,  "ATIVAN",          100, pharmacist2);
var drug4 =  new Drug(3,  "ABILIFY",         300, pharmacist3);
var drug5 =  new Drug(4,  "ACYCLOVIR",       500, pharmacist3);
var drug6 =  new Drug(5,  "ATENOLOL",        600, pharmacist3);
var drug7 =  new Drug(6,  "PARACETAMOL",     400, pharmacist4);
var drug8 =  new Drug(7,  "AMOXICILLIN",     200, pharmacist3);
var drug9 =  new Drug(8,  "BUPRENORPHINE",   700, pharmacist3);
var drug10 = new Drug(9,  "DIAZEPAM",        800, pharmacist3);
var drug11 = new Drug(10, "ACETAMINOPHENE",  900, pharmacist2);
var drug12 = new Drug(11, "CODEINE",         300, pharmacist1);
var drug13 = new Drug(12, "PANADOL",         100, pharmacist1);
var drug14 = new Drug(13, "METOPROLOL",      200, pharmacist3);
var drug15 = new Drug(14, "ALLOPURNOL",      200, pharmacist5);

drugs = new List<Drug>() { drug1, drug2, drug3, drug4, drug5, drug6, drug7, drug8, drug9, drug10, drug11, drug12, drug13, drug14, drug15 };
foreach (var item in drugs)
{
   // DataBaseManager<Drug>.AddItem(item);
}
#endregion




Console.ReadLine();