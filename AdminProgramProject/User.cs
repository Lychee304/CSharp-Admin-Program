
// it works without errors or warnings
// DO NOT TOUCH

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AdminProgramProject
{
    internal class User
    {
        private int _id;
        private string _name;
        private string _address;
        private string _email;
        private string _telNum;
        private string _passWord;
        private string _dOB; // date of birth
        private int _age;


        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }


        

        public User(int id, string name, string address, string email, string telNum, string password, string dOB, int age)
        {
            _id = id;
            _name = name;
            _address = address;
            _email = email;
            _telNum = telNum;
            _passWord = password;
            _dOB = dOB;
            _age = age;
        }

        public void SetEmail(string email)
        {
            if (email.Contains("@"))
            {
                if (email.Contains("."))          
                {
                    _email = email;
                }
            }
            else
            {
                Console.WriteLine("that isnt a email, THIS is a email: example@mail.com");
            }
        }


        public string GetEmail()
        {
            return _email;
        }


        public void WriteAll()
        {
            Console.WriteLine("naam:" + _name + ", address:  " + _address + ", email: " + _email + ", telefoon nummer: " + _telNum + ", wachtwoord: " + _passWord + ", geboortedatum: " + _dOB + ", leeftijd: " + _age);
        }

       
        /*
        public static void AddUser()
        {
            Testing.UsersList;
        }

        */

    }
}
