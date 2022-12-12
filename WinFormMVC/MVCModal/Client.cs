using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCModal
{
    public class Client
    {
        private int id;
        private string nom;
        private string email;
        private int tel;
        private string adress;
        private int card;

        List<Account> accounts = new List<Account>();
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Email { get => email; set => email = value; }
        public int Tel { get => tel; set => tel = value; }
        public string Adress { get => adress; set => adress = value; }
        public int Card { get => card; set => card = value; }
    }
}
