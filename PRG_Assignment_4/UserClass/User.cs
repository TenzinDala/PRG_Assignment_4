using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Seneca
{
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string passWord { get; set; }

        public static bool loggedInStatus = false;

        public static Dictionary<string, User> Credentials = new Dictionary<string, User>();

        public static User loggedInUser;


        public User()
        {
            
        }

        //public User CreateUser(string FirstName, string LastName, string Email, string PassWord) 
        //{
        //    try
        //    {
        //        User userNew = new User();  // Create an instance of the User class
        //        bool firstNameCheck = nameValidation(FirstName);
        //        if (firstNameCheck)
        //        {
        //            userNew.firstName = this.firstName;  // Set the properties of the user object

        //        }
        //        else
        //        {
        //            throw new Exception();
        //        }
        //        bool lastNameCheck = nameValidation(LastName);
        //        if (lastNameCheck)
        //        {
        //            userNew.lastName = this.lastName;

        //        }
        //        else
        //        {
        //            throw new Exception();

        //        }
        //        bool emailCheck = emailValidation(Email);
        //        if (emailCheck)
        //        {
        //            userNew.email = this.email;

        //        }
        //        else
        //        {
        //            throw new Exception();

        //        }
        //        bool passWordCheck = passwordValidation(PassWord);
        //        if (passWordCheck)
        //        {
        //            userNew.passWord = this.passWord;

        //        }
        //        else
        //        {
        //            throw new Exception();

        //        }

        //        return userNew;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        return null;
        //    }
        //}

        public bool CreateUser(string FirstName, string LastName, string Email, string PassWord)
        {
            try
            {
                bool firstNameCheck = nameValidation(FirstName);
                if (!firstNameCheck)
                {
                    throw new Exception("Invalid first name.");
                }

                bool lastNameCheck = nameValidation(LastName);
                if (!lastNameCheck)
                {
                    throw new Exception("Invalid last name.");
                }

                bool emailCheck = emailValidation(Email);
                if (!emailCheck)
                {
                    throw new Exception("Invalid email.");
                }

                bool passWordCheck = passwordValidation(PassWord);
                if (!passWordCheck)
                {
                    throw new Exception("Invalid password.");
                }

                User user = new User()
                {
                    firstName = FirstName,
                    lastName = LastName,
                    email = Email,
                    passWord = PassWord
                };
                int id = Credentials.Count();
                Credentials.Add($"Email {id}", user);

                return true; 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }


        public bool nameValidation(string name)
        {
            if(Regex.IsMatch(name, @"^[a-zA-Z]+$")) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool emailValidation(string email)
        {
            //if (Regex.IsMatch(email, @"^[\s]+$"))
            if (Regex.IsMatch(email, " "))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool passwordValidation(string PassWord)
        {
            if(PassWord.Length > 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
