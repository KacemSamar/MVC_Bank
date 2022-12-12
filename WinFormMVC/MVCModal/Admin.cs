using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCModal
{
    public class Admin
    {

        private int id;
        private string nom;
        private string email;
        private int tel;
        private string adress;
        private int card;
        private string username;
        private string password;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Email { get => email; set => email = value; }
        public int Tel { get => tel; set => tel = value; }
        public string Adress { get => adress; set => adress = value; }
        public int Card { get => card; set => card = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

    }
}
