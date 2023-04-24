using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App
{
    public class User
    {
        public static List<User> Users = new List<User>();
        public string Username { get; set; }
        public User(string username)
        {
            Username = username;
        }
        public static User GetUserByUsername(string username)
        {
            foreach (User user in Users)
            {
                if (user.Username == username)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
