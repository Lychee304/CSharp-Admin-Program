using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgramProject
{

    internal class AdminProgram
    {
        Testing Database = new Testing();
        public static int _countingID = 0;
        private static User _userName;
        private int _AmountOfUser = _countingID + 1;
        private static User _newUserName;

        //  = "User" + _countingID
        public static User GetUser()
        {
            return _userName;
        }



        public void Start()
        {

            Database.GetList();


            Console.WriteLine("zet het programma aan? J = Ja, N = Nee: ");
            string _onOff = Console.ReadLine();

            bool _turningOn = false;



            if (_onOff == "J")
            {
                _turningOn = true;
            }
            else if (_onOff == "N")
            {
                Console.WriteLine("ok, fijne dag?");
            }
            else
            {
                Console.WriteLine("J = Ja, N = Nee, het programma moet opnieuw gestart worden");
            }

            while (_turningOn == true)
            {
                try
                {


                    Console.WriteLine("Er wordt een nieuwe klant aangemaakt omdat er geen klanten zijn toegevoegd");
                    Console.WriteLine(" ");

                    Console.WriteLine("naam: ");
                    string _input = Console.ReadLine();

                    Console.WriteLine("address: ");
                    string _input2 = Console.ReadLine();

                    Console.WriteLine("email: ");
                    string _input3 = Console.ReadLine();

                    Console.WriteLine("telefoon nummer: ");
                    string _input4 = Console.ReadLine();

                    Console.WriteLine("wachtwoord: ");
                    string _input5 = Console.ReadLine();

                    Console.WriteLine("geboortedatum dd/mm: ");
                    string _input6 = Console.ReadLine();

                    Console.WriteLine("geboortejaar: ");
                    int _input7 = int.Parse(Console.ReadLine());

                    if (_input7 >= 2027 || _input7 <= 1850) // adjust when the maximum year is the current year, enter the current year +1
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("foutmelding 0002! weet u zeker dat de geboortejaar correct is ingevoerd? de jaartal is automatisch gezet naar 1950");
                        _input7 = 1950;
                    }

                    _input7 = 2025 - _input7;

                    User _userName = new User(_countingID, _input, _input2, _input3, _input4, _input5, _input6, _input7); // with dynamic naming (example: user + _idCounter) it can probably make multiple users :D )

                    Database.AddUser(_userName); // just... please work i'll personally give you a tientje

                    // GetList();


                    Console.Clear();

                    Console.WriteLine("wilt u de nieuwe aangemaakte klant zien? J = ja, N = nee");
                    string _askView = Console.ReadLine();


                    if (_askView == "J")
                    {
                        Console.WriteLine(" ");
                        _userName.WriteAll();
                    }
                    else if (_askView == "N")
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(_input + " is toegevoegd met nummer " + _countingID + "!");
                    }


                }
                catch (Exception)
                {
                    Console.WriteLine("foutmelding 0001!, weet u zeker dat de geboortedatum in cijfers zijn ingevoerd? bijv: 1990 ipv negentien negentig");
                }



                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Wat wenst u te doen?");
                Console.WriteLine(" ");
                Console.WriteLine(" - N = Nieuw persoon");
                Console.WriteLine(" - A = Afsluiten");
                Console.WriteLine(" - C = Checken voor een aangemaakte gebruiker");
                Console.WriteLine(" - V = Klant verwijderen");
                Console.WriteLine(" - B = Klant bewerken");
                string _askProg = Console.ReadLine(); // prog = progress



                if (_askProg == "C")
                {
                    Console.Clear();
                    Console.WriteLine("wilt u ze allen bekijken of een klant opzoeken met een ID nummer? A = alle klanten zien, N = nummer voor klant");
                    string _userSearch = Console.ReadLine();

                    // Console.WriteLine("ok, toets de nummer in van de gebruiker: ");
                    // int _checkUser = int.Parse(Console.ReadLine()); // 'Convert.' is the answer.. how tho


                    if (_userSearch == "A")
                    {
                        Console.WriteLine(" ");
                        Database.LoopUserList();

                    } else if (_userSearch == "N")
                    {
                        try
                        {
                            Console.WriteLine("ok, toets de nummer in van de gebruiker: ");
                            int _checkUser = int.Parse(Console.ReadLine());

                            Console.WriteLine(" ");

                            Database.GetList()[_checkUser].WriteAll(); // <-- thx GPT :P

                        } catch (Exception)
                        {
                            Console.WriteLine("foutmelding 0003! weet u zeker dat de gebruiker bestaat? er zijn maar " + _AmountOfUser + " klanten opgeslagen");
                        }
                    }
                    //  User _userName = ShowUserWID(_countingID);  // _checkUser should be var type User, not string


                }
                



                else if (_askProg == "A")
                {
                    Console.Clear();
                    Console.WriteLine("ok, fijne dag!");
                    _turningOn = false;


                }
                else if (_askProg == "N")
                {
                    Console.Clear();
                    _countingID++;

                } 
                else if (_askProg == "V")
                {
                    Console.Clear();


                    try
                    {
                        Console.WriteLine("ok, toets de nummer in van de gebruiker: ");
                        int _checkUser = int.Parse(Console.ReadLine());

                        Console.WriteLine(" ");

                        Database.GetList()[_checkUser].WriteAll(); // <-- thx GPT :P

                        Console.WriteLine(" ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Weet u zeker dat u deze klant wilt verwijderen? J = ja, N = nee");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        string _deleteUser = Console.ReadLine();


                        if(_deleteUser == "J")
                        {
                            Console.Clear();
                            Database.GetList().RemoveAt(_checkUser);
                            Console.WriteLine("gebruiker met ID '" + _checkUser + "' is verwijderd, het deed gelukkig geen pijn");
                            _AmountOfUser--;
                        }
                        else if (_deleteUser == "N")
                        {
                            Console.Clear();
                            Console.WriteLine("ok, dan niet. Ze zullen vast blij zijn");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("foutmelding 0003! weet u zeker dat de gebruiker bestaat? of naja, bestond in dit geval? er zijn maar " + _AmountOfUser + " klanten opgeslagen");
                    }
                }
                else if(_askProg == "B")
                {
                    Console.WriteLine("ok, toets de nummer in van de gebruiker: ");
                    int _checkUser = int.Parse(Console.ReadLine());

                    Console.WriteLine(" ");

                    Database.GetList()[_checkUser].WriteAll(); // <-- thx GPT :P

                    Console.WriteLine(" ");
                    Console.WriteLine("wilt u verder gaan met bewerken? Ziet er al perfect uit! J = ja, N = nee");

                    string _userModify = Console.ReadLine();

                    

                    if(_userModify == "J")
                    {
                        Console.Clear();

                        Database.GetList()[_checkUser].WriteAll();
                        Console.WriteLine(" ");


                        // Database.GetList()[_checkUser];

                        Database.GetList().RemoveAt(_checkUser);


                            Console.WriteLine("naam: ");
                            string _input = Console.ReadLine();

                            Console.WriteLine("address: ");
                            string _input2 = Console.ReadLine();

                            Console.WriteLine("email: ");
                            string _input3 = Console.ReadLine();

                            Console.WriteLine("telefoon nummer: ");
                            string _input4 = Console.ReadLine(); 

                            Console.WriteLine("wachtwoord: ");
                            string _input5 = Console.ReadLine();

                            Console.WriteLine("geboortedatum dd/mm: ");
                            string _input6 = Console.ReadLine();

                            Console.WriteLine("geboortejaar: ");
                            int _input7 = int.Parse(Console.ReadLine());

                            if (_input7 >= 2027 || _input7 <= 1850) // adjust when the maximum year is the current year, enter the current year +1
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("foutmelding 0002! weet u zeker dat de geboortejaar correct is ingevoerd? de jaartal is automatisch gezet naar 1950");
                                _input7 = 1950;
                            }

                            _input7 = 2025 - _input7;

                            User _newUserName = new User(_checkUser, _input, _input2, _input3, _input4, _input5, _input6, _input7); 

                            
                            
                            Database.EditUser(_checkUser, _newUserName);




                            // delete da thing
                            // add da thing back but different
                        
                    }
                    else if (_userModify == "N")
                    {
                        Console.WriteLine("see, told ya!");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("appel");
                }
            }
        }
    }
}