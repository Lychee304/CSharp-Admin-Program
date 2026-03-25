
// user database
// base for the user data
// user of the data
// data of the user
// wow, such poetry
// alright cya later!

using AdminProgramLessons;
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
    }
}