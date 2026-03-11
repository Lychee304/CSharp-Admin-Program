using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgramLessons
{
    internal class Program
    {
        static void Main(string[] args)
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

            User user1 = new User(0, _input, _input2, _input3, _input4, _input5, _input6, _input7);

            Console.WriteLine("wilt u de nieuwe aangemaakte klant zien? J = ja, N = nee");
            string _askView = Console.ReadLine();


            if (_askView == "J")
            {
                user1.WriteAll();
            } else if (_askView == "N")
            {
                Console.WriteLine(_input + " is toegevoegd!");
            }



        }
    }
}
