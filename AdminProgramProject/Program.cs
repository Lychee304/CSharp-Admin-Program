using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgramLessons
{
    internal class Program
    {

        //  bool _turningOn = false;


        private static int _countingID = 0;
        private string _userName = "User" + _countingID;

        static void Main(string[] args)
        {


        Console.WriteLine("zet het programma aan? J = ja, N = nee: ");
            string _onOff = Console.ReadLine();

            bool _turningOn = false;

            

            if (_onOff == "J")
            {
                _turningOn = true;
            }
            else if (_onOff == "N")
            {
                Console.WriteLine("ok, fijne dag!");
            }
            else
            {
                Console.WriteLine("J = ja, N = nee, het programma moet opnieuw gestart worden");
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



                    _input7 = 2025 - _input7;

                    User _userName = new User(0, _input, _input2, _input3, _input4, _input5, _input6, _input7); // with dynamic naming (example: user + _idCounter) it can probably make multiple users :D )

                    Console.WriteLine("wilt u de nieuwe aangemaakte klant zien? J = ja, N = nee");
                    string _askView = Console.ReadLine();


                    if (_askView == "J")
                    {
                        _userName.WriteAll();
                    }
                    else if (_askView == "N")
                    {
                        Console.WriteLine(_input + " is toegevoegd!");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("foutmelding 0001!, weet u zeker dat de geboortedatum in cijfers zijn ingevoerd? bijv: 1990 ipv negentien negentig");
                }

                Console.WriteLine("wil je de informatie veranderen of afsluiten? N = nieuw persoon, A = afsluiten, C = checken voor een aangemaakte gebruiker");
                string _askProg = Console.ReadLine(); // prog = progress


                if (_askProg == "A")
                {
                    Console.WriteLine("ok, fijne dag!");
                    _turningOn = false;
                } else if (_askProg == "N")
                {
                    _countingID++;
                } else if (_askProg == "C")
                {
                    Console.WriteLine("ok, toets 'User' en volg deze met de nummer: ");
                    string _checkUser = Console.ReadLine();

                    _checkUser.WriteAll();
                } else
                {
                    Console.WriteLine("appel");
                }
            }
        }
    }
}


