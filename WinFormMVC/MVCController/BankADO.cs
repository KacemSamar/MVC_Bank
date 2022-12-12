using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MVCModal;
namespace MVCController
{
    public class BankADO
    {

        public List<Bank> BankADOList = new List<Bank>();


        Connection cnx = new Connection();

        public void insert(Bank bank)
        {


            SqlCommand cmd = new SqlCommand("insert into bank(adress,name)values ('" + bank.Adress + "' , '" + bank.Name +  "')");
            cnx.executeCommand(cmd);

        }
        public void update(Bank bank)
        {


            SqlCommand cmd = new SqlCommand("update  bank set adress =  '" + bank.Adress + "' , name =  '" + bank.Name + "' where code = " + bank.Code + "; ");
            cnx.executeCommand(cmd);
        }
        public void delete(Bank bank)
        {

            SqlCommand cmd = new SqlCommand("delete from  bank  where code = " + bank.Code + "; ");
            cnx.executeCommand(cmd);
        }
        public void load()
        {
            BankADOList = new List<Bank>();
            SqlDataReader reader = cnx.SDD("SELECT * FROM bank");
            AccountADO ac = new AccountADO();

            while (reader.Read())
            {
                Bank bank = new Bank();

                bank.Code = (int)reader.GetValue(0);
                bank.Adress = (String)reader.GetValue(1);
                bank.Name = (String)reader.GetValue(2);
                bank.AccountADOList = ac.loadByBank(bank);
                BankADOList.Add(bank);


            }
            reader.Close();
        }
    }
}
