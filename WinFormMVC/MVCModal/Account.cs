using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCModal
{
    public class Account
    {
        private int num;
        private int balance;
        private string description;
        private int bank;

        public int Num { get => num; set => num = value; }
        public int Balance { get => balance; set => balance = value; }
        public string Description { get => description; set => description = value; }
        public int Bank { get => bank; set => bank = value; }
    }
}
