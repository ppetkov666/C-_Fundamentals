using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public ICollection<int> PostsIds { get; set; }

        public User(int id, string username, string password, ICollection<int> postsIds)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.PostsIds = new List<int>(postsIds);

        }
    }
}
