using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_TechShop
{
    internal class User
    {
        private static int _count = 0;
        private string _id;
        private string _name;
        private string _email;
        private string _password;
        private static List<User> _users;

        public string ID { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Password { get => _password; set => _password = value; }
        public string Email { get => _email; set => _email = value; }

        static User()
        {
            _users = new List<User>();

            // testing
            _users.Add(new User("1","1","1"));
            _users.Add(new User("11","11","11"));
            _users.Add(new User("111","111","111"));
            _users.Add(new User("1111","1111","1111"));
        }

        public User()
        {
            _count++;
            this.ID = _count.ToString();
            _users.Add(this);
        }

        public User(string Name, string Password, string Email)
        {
            _count++;
            this.ID = _count.ToString();
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
            _users.Add(this);
        }

        public static string SignIn(string Password, string Email)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Password == Password && _users[i].Email == Email)
                {
                    return _users[i].ID;
                }
            }

            return string.Empty;
        }
    }
}
