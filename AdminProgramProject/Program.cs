
// When I wrote this, only God and I understood what I was doing.
// Now, God only knows.

using AdminProgramProject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Testing.cs")]

namespace AdminProgramProject
{
    internal class Program
    {

        private static List<User> UsersList = new List<User>();

        public static List<User> GetList()
        {
            return UsersList;
        }


        //  bool _turningOn = false;


        private static int _countingID = 0;
        private string _userName = "User" + _countingID;



        static void Main(string[] args)
        {




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
                        Console.WriteLine("foutmelding 0002! weet u zeker dat de geboortejaar correct is ingevoerd? de jaartal is automatisch gezet naar 1950");
                        _input7 = 1950;
                    }


                    _input7 = 2025 - _input7;

                    User _userName = new User(_countingID, _input, _input2, _input3, _input4, _input5, _input6, _input7); // with dynamic naming (example: user + _idCounter) it can probably make multiple users :D )

                    _userName.Add(AddUser());

                    // GetList();

                    //


                    Console.WriteLine("wilt u de nieuwe aangemaakte klant zien? J = ja, N = nee");
                    string _askView = Console.ReadLine();


                    if (_askView == "J")
                    {
                        _userName.WriteAll();
                    }
                    else if (_askView == "N")
                    {
                        Console.WriteLine(_input + " is toegevoegd met nummer " + _countingID + "!");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("foutmelding 0001!, weet u zeker dat de geboortedatum in cijfers zijn ingevoerd? bijv: 1990 ipv negentien negentig");
                }

                Console.WriteLine("wil je de informatie veranderen of afsluiten? N = Nieuw persoon, A = Afsluiten, C = Checken voor een aangemaakte gebruiker");
                string _askProg = Console.ReadLine(); // prog = progress



                if (_askProg == "C")
                {
                    // Console.WriteLine("ok, toets de nummer in van de gebruiker: ");
                    // int _checkUser = int.Parse(Console.ReadLine()); // 'Convert.' is the answer.. how tho

                    UsersList.LoopUserList();

                    //  User _userName = ShowUserWID(_countingID);  // _checkUser should be var type User, not string


                }


                else if (_askProg == "A")
                {
                    Console.WriteLine("ok, fijne dag!");
                    _turningOn = false;


                }
                else if (_askProg == "N")
                {
                    _countingID++;

                }
                else
                {
                    Console.WriteLine("appel");
                }
            }
        }
    }
}

