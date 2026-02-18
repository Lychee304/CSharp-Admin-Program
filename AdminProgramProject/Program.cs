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
            User amir = new User(0, "amir", "naast de buren", "hey@gmail.com", "+420 69 69 69 69", "password123", "30-04-2006", 19);
            Console.WriteLine(amir.Email);
        }
    }
}
