
// he buggin                           haha get it? bug? as in bugs and errors? im sorry
// he must not know that im thuggin

using AdminProgramProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("AdminProgram.cs")]
// using System.Hopes.And.Dreams

namespace AdminProgramProject
{
    internal class Testing
    {


        // private User _userName = "User" + AdminProgram._countingID;      <-- bruh how you a error? yo a comment

        private List<User> UsersList = new List<User>();

        public List<User> GetList()
        {
            return UsersList;
        }

        public void LoopUserList()
        {

            for (int i = 0; i < UsersList.Count; i++)
            {
                UsersList[i].WriteAll();
            }
        }

        public void AddUser(User newUser)
        {
            UsersList.Add(newUser);
        }

        public void EditUser(int _checkUser, User newUser)
        {
            
            UsersList.Add(newUser);
            UsersList.Insert(_checkUser, newUser);
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


