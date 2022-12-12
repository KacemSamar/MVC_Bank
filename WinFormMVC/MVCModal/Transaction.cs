using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCModal
{
    public class Transaction
    {
        private int id;
        private DateTime date;
        private string type;
        private int amount;
        private int id_account;

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Type { get => type; set => type = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Id_account { get => id_account; set => id_account = value; }
    }
}
