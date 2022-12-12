using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCModal
{
    public class Bank
    {
        public List<Account> AccountADOList = new List<Account>();
        private int code;
        private string adress;
        private string name;

        public int Code { get => code; set => code = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Name { get => name; set => name = value; }
    }
}
