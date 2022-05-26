// See https://aka.ms/new-console-template for more information
using Question1.Models;
using Question1.Repos.DBManager;
using Question1.Repos.Helper;


FluentNHibernateHelper.OpenSession();


#region Initialization
var hospital1 = new Hospital();
var receptionist = new Receptionist();
var accountant = new Accountant();
var doctors = new List<Doctor>();
var nurses = new List<Nurse>();
var pharmacists = new List<Pharmacist>();
var unregisteredPatients = new List<UnregisteredPatient>();
var registeredPatients = new List<RegisteredPatient>();
#endregion

#region Add Hospital

hospital1 = new Hospital(0, "Ikoki Memorial Hospital", "Kpansia Bayelsa", receptionist, accountant);

DataBaseManager<Hospital>.AddItem(hospital1);
#endregion

#region Add Receptionist

receptionist = new Receptionist(0, "Blessing Abraham", hospital1);

DataBaseManager<Receptionist>.AddItem(receptionist);
#endregion

#region Add Accountant

accountant = new Accountant(0, "Chiamaka Asor", hospital1);

DataBaseManager<Accountant>.AddItem(accountant);
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
    DataBaseManager<Doctor>.AddItem(item);
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
    DataBaseManager<Nurse>.AddItem(item);
}
#endregion

#region Add Pharmacists
var Pharmacist1 = new Pharmacist(0, "Stephen Ede", hospital1);
var Pharmacist2 = new Pharmacist(1, "Obena Okpu", hospital1);
var Pharmacist3 = new Pharmacist(2, "Dalene Upe", hospital1);
var Pharmacist4 = new Pharmacist(3, "Sylva Ane", hospital1);
var Pharmacist5 = new Pharmacist(4, "Ebe Rita", hospital1);

pharmacists = new List<Pharmacist>() { Pharmacist1, Pharmacist2, Pharmacist3, Pharmacist4, Pharmacist5 };
foreach (var item in pharmacists)
{
    DataBaseManager<Pharmacist>.AddItem(item);
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
    DataBaseManager<RegisteredPatient>.AddItem(item);
}
#endregion


#region Add UnregisteredPatient
var unregisteredPatient1 = new UnregisteredPatient(0, 006, "Comfort Rita", Gender.Female, "Opolo Housing Estate", hospital1);
var unregisteredPatient2 = new UnregisteredPatient(1, 007, "Flora Edoghotu", Gender.Female, "Kpansia Town", hospital1);
var unregisteredPatient3 = new UnregisteredPatient(2, 008, "Nancy Favour", Gender.Female, "Otuoke Town", hospital1);
var unregisteredPatient4 = new UnregisteredPatient(3, 009, "Favour Angel", Gender.Male, "NNPC Junction", hospital1);
var unregisteredPatient5 = new UnregisteredPatient(4, 010, "Anita Richard", Gender.Female, "Tombia Street", hospital1);

unregisteredPatients = new List<UnregisteredPatient>() { unregisteredPatient1, unregisteredPatient2, unregisteredPatient3, unregisteredPatient4, unregisteredPatient5 };
foreach (var item in unregisteredPatients)
{
    DataBaseManager<UnregisteredPatient>.AddItem(item);
}
#endregion



Console.ReadLine();