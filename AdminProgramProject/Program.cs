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
            User amir = new User(0, "amir", "naast de buren", "hey@gmail.com", "+31 12 34 56 78", "password123", "30-04-2006", 19);
            Console.WriteLine(amir.Email);

            User user2 = new User(1, "name", "at home", "heyya@gmail.com", "+31 12 34 56 79", "wordpass", "01-01-1990", 36);
            Console.WriteLine(user2.Email);
        }
    }
}
