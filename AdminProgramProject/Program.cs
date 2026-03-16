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
        private int _idCounter = 0;


        static void Main(string[] args)
        {

            

            Console.WriteLine("zet het programma aan? J = ja, N = nee: ");
            string _onOff = Console.ReadLine();

            private bool _turningOn = false;

            private bool _onOffLoop = true;

            while(_onOffLoop){

            if (_onOff == "J")
            {
                _turningOn = true;
                _onOffLoop = false;
            } else if (_onOff == "N") {
                Console.WriteLine("ok, fijne dag!");
                _onOffLoop = false;
            } else {
                Console.WriteLine("J = ja, N = nee, herstart de programma");
            }
            

                while (_turningOn == true)
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

                User user0 = new User(0, _input, _input2, _input3, _input4, _input5, _input6, _input7); // with dynamic naming (example: user + _idCounter) it can probably make multiple users :D 

                    Console.WriteLine("wilt u de nieuwe aangemaakte klant zien? J = ja, N = nee");
                    string _askView = Console.ReadLine();


                    if (_askView == "J")
                    {
                        user0.WriteAll();
                    }
                    else if (_askView == "N")
                    {
                        Console.WriteLine(_input + " is toegevoegd!");
                    }

                    Console.WriteLine("wil je de informatie veranderen of afsluiten? V = veranderen, A = afsluiten");
                    string _askProg = Console.ReadLine(); // prog = progress


                    if (_askProg == "A")
                {
                    Console.WriteLine("ok, fijne dag!");
                    _turningOn = false;
                }
                }
        }

        
    }
}
