using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MVCModal;
namespace MVCController
{
    public class AccountADO
    {
        public List<Account> AccountADOList = new List<Account>();
        Connection cnx = new Connection();

        public void insert(Account account)
        {


            SqlCommand cmd = new SqlCommand("insert into account(balance,description,bank)values ('" + account.Balance + "' , '" + account.Description + "' , '" + account.Bank + "')");
            cnx.executeCommand(cmd);

        }
        public void update(Account account)
        {


            SqlCommand cmd = new SqlCommand("update  account set balance ='" + account.Balance + "' ,  description =  '" + account.Description + "' ,  bank =  '" + account.Bank + "' where num = " + account.Num + "; ");
            cnx.executeCommand(cmd);
        }
        public void delete(Account account)
        {

            SqlCommand cmd = new SqlCommand("delete from  account  where num = " + account.Num + "; ");
            cnx.executeCommand(cmd);
        }
        public void load()
        {
            AccountADOList = new List<Account>();
            SqlDataReader reader = cnx.SDD("SELECT * FROM account");

            while (reader.Read())
            {
                Account account = new Account();
                account.Num = (int)reader.GetValue(0);
                account.Balance = (int)reader.GetValue(1);
                account.Description = (String)reader.GetValue(2);
                account.Bank = (int)reader.GetValue(3);

                AccountADOList.Add(account);


            }
            reader.Close();
        }
        public List<Account> loadByBank(Bank bank)
        {
            List<Account>  accountList = new List<Account>();
            SqlDataReader reader = cnx.SDD("SELECT * FROM account where bank = " + bank.Code + "; ");

            while (reader.Read())
            {
                Account account = new Account();
                account.Num = (int)reader.GetValue(0);
                account.Balance = (int)reader.GetValue(1);
                account.Description = (String)reader.GetValue(2);
                account.Bank = (int)reader.GetValue(3);
                accountList.Add(account);


            }
            reader.Close();
            return accountList;
        }

        public void deposit(Account account, int montant)

        {
            SqlCommand cmd = new SqlCommand("update  account set balance +='" + montant +  "' where num = " + account.Num + "; ");
            cnx.executeCommand(cmd);
            

        }

        public bool withdraw(Account account, int montant)

        {

            SqlDataReader reader = cnx.SDD("SELECT * FROM account  where num = " + account.Num + "; ");
            reader.Read();
            if (montant < (int)reader.GetValue(1)) {

                SqlCommand cmd = new SqlCommand("update  account set balance -='" + montant + "' where num = " + account.Num + "; ");
                reader.Close();
                cnx.executeCommand(cmd);

                
                return true;
            }
            else {
                reader.Close(); 
                return false; }
        }

    }
    
}
