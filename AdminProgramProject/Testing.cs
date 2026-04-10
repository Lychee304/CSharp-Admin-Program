
// he buggin                           haha get it? bug? as in bugs and errors? im sorry
// he must not know that im thuggin

using AdminProgramProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Program.cs")]
// using System.hopes.and.dreams

namespace AdminProgramProject
{
    internal class Testing
    {

        private static User _userName;

        private static List<User> UsersList = new List<User>();

        public static List<User> GetList()
        {
            return UsersList;
        }

        public void LoopUserList()
        {

            for (int i = 0; i < UsersList.Count; i++)
            {
                Console.WriteLine(UsersList[i]);
            }
        }

        public static void AddUser()
        {
            UsersList.Add(_userName);
        }
    }
}









    /*



// user database
// base for the user data
// user of the data
// data of the user
// wow, such poetry
// alright cya later!

// y'know when I said cya later, I didnt mean 'hide from the solution explorer... forever..'

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgramProject
{
internal class UserDatabase
{

    private static List<User> UsersList = new List<User>();

    public static List<User> GetList()
    {
        return UsersList;
    }

    public int LoopUserList()
    {

        for (int i = 0; i < UsersList; i++)
        {
            Console.WriteLine(UsersList[i]);
        }
    }
}
}



     */


