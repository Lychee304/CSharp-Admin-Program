
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
        static void Main(string[] args)
        {
            AdminProgram admin = new AdminProgram();
            admin.Start();
        }

    }
}

