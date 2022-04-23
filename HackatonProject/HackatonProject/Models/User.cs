using SQLite;
using System;

namespace HackatonProject.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BornDate { get; set; }
    }
}