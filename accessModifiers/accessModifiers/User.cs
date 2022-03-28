using System;
using System.Collections.Generic;
using System.Text;

namespace accessModifiers
{
    class User
    {
        public User(string username)
        {
            this.Username = username;
        }
        private string _username;
        private string _password;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 25 && value.Length > 5)
                    _username = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 25 && value.Length > 7)
                {
                    if (HasDigit(value) && HasLower(value) && HasUpper(value) && !HasSpace(value))
                        _password = value;
                }
            }
        }

        public bool HasDigit(string str)
        {
            foreach (var item in str)
            {
                if (char.IsDigit(item))
                    return true;
            }
            return false;
        }
        public bool HasUpper(string str)
        {
            foreach (var item in str)
            {
                if (char.IsUpper(item))
                    return true;
            }
            return false;
        }
        public bool HasLower(string str)
        {
            foreach (var item in str)
            {
                if (char.IsLower(item))
                    return true;
            }
            return false;
        }
        public bool HasSpace(string str)
        {
            foreach (var item in str)
            {
                if (item == ' ')
                    return true;
            }
            return false;
        }
    }
}
