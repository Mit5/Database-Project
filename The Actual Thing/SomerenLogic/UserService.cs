using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class UserService
    {
        UserDao userdb;
        string licenseKey = "XsZAb-tgz3PsD-qYh69un-WQCEx";
        public UserService()
        {
            userdb = new UserDao();
        }

        public List<User> GetAllUsers()
        {
            return userdb.GetAllUsers();
        }

        public void CreateUser(User user)
        {
            userdb.CreateUser(user);
        }

        public bool LicenseKeyChecker(string key)
        {
            return (key == licenseKey);
        }

        public bool PasswordIsCorrect(string password)
        {
            bool lenghtChecker = MinLenghtIs(password, 8);
            //Minimum of 1 lowercase letter
            bool lowercaseChcker = HasLowercaseLetter(password);
            //Minimum of 1 uppercase letter
            bool uppercaseChecker = HasLowercaseLetter(password);
            //Minimum of 1 number
            bool numberChecker = HasNumber(password);
            //Minimum of 1 special character(not a letter and not a number)
            bool specialCharacteChekcer = HasSpecialChar(password);
            return (lenghtChecker && lowercaseChcker && uppercaseChecker && numberChecker && specialCharacteChekcer);
        }

        bool MinLenghtIs(string word, int minLenght)
        {
            return (word.Length >= minLenght);
        }

        bool HasLowercaseLetter(string word)
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                if(word.Contains(i))
                {
                    return true;
                }
            }
            return false;
        }

        bool HasUppercaseLetter(string word)
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                if (word.Contains(i))
                {
                    return true;
                }
            }
            return false;
        }

        bool HasNumber(string word)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (word.Contains(i.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        bool HasSpecialChar(string word)
        {
            string checker = "";
            for (int i = 0; i <= 9; i++)
            {
                checker += i.ToString();
            }
            for (char i = 'A'; i <= 'Z'; i++)
            {
                checker += i;
            }
            for (char i = 'a'; i <= 'z'; i++)
            {
                checker += i;
            }
            for (int i = 0; i < word.Length; i++)
            {
                if(!checker.Contains(word[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
