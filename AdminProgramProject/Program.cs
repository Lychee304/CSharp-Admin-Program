using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgramLessons
{
    internal class Program
    {
<<<<<<< Updated upstream
=======

        //  bool _turningOn = false;


        private static int _countingID = 0;
        public string _userName = "User" + _countingID;

>>>>>>> Stashed changes
        static void Main(string[] args)
        {
            Console.WriteLine("naam: ");
            string _input = Console.ReadLine();

<<<<<<< Updated upstream


            User amir = new User(0, "amir", "naast de buren", "hey@gmail.com", "+31 12 34 56 78", "password123", "30-04-2006", 19);
            Console.WriteLine(amir.Email);

            User user2 = new User(1, "name", "at home", "heyya@gmail.com", "+31 03 69 12 15", "wordpass", "01-01-1990", 36);
            Console.WriteLine(user2.Email);
=======
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

            _input7 = 2025 - _input7;

            User amir = new User(0, _input, _input2, _input3, _input4, _input5, _input6, _input7);
            Console.WriteLine(amir.Email);

            amir.WriteAll();


<<<<<<< Updated upstream

>>>>>>> Stashed changes
=======

                    _input7 = 2025 - _input7;

                    User _userName = new User(0, _input, _input2, _input3, _input4, _input5, _input6, _input7); // with dynamic naming (example: user + _idCounter) it can probably make multiple users :D )

                    AddUserToDBase();

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
                    Console.WriteLine("ok, toets de nummer in van de gebruiker: ");
                    int _checkUser = int.Parse(Console.ReadLine()); // 'Convert.' is the answer.. how tho


                    User _checkUser = ShowUserWID(_countingID);  // _checkUser should be var type User, not string


                } else if (_askProg == "A")
                { 
                    Console.WriteLine("ok, fijne dag!");
                    _turningOn = false;


                } else if (_askProg == "N")
                {
                    _countingID++;

                } else
                {
                    Console.WriteLine("appel");
                }
            }
>>>>>>> Stashed changes
        }
    }
}


