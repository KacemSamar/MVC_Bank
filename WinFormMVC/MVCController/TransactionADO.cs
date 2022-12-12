using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MVCModal;
namespace MVCController
{
    public class TransactionADO
    {
        public List<Transaction> TransactionADOList = new List<Transaction>();
        Connection cnx = new Connection();

        public bool insert(Transaction transaction)
        {


            SqlCommand cmd = new SqlCommand("insert into [transaction] (date,type,amount,id_account)values ('" + transaction.Date + "' , '" + transaction.Type + "' , '" + transaction.Amount + "' , '" + transaction.Id_account + "')");
            cnx.executeCommand(cmd);

            AccountADO ad = new AccountADO();
            Account ac = new Account();
            ac.Num = transaction.Id_account;
            if (transaction.Type == "withdraw")
                return (ad.withdraw(ac, transaction.Amount));

            else
                ad.deposit(ac, transaction.Amount);
            return true;

        }
        public void update(Transaction transaction)
        {


            SqlCommand cmd = new SqlCommand("update  [transaction] set date ='" + transaction.Date + "' ,  type =  '" + transaction.Type + "' ,  amount =  '" + transaction.Amount + "' ,  id_account =  '" + transaction.Id_account + "' where id = " + transaction.Id + "; ");
            cnx.executeCommand(cmd);
        }
        public void delete(Transaction transaction)
        {

            SqlCommand cmd = new SqlCommand("delete from  [transaction]  where id = " + transaction.Id + "; ");
            cnx.executeCommand(cmd);
        }
        public void load()
        {
            TransactionADOList = new List<Transaction>();
            SqlDataReader reader = cnx.SDD("SELECT * FROM [transaction]");

            while (reader.Read())
            {
                Transaction transaction = new Transaction();
                transaction.Id = (int)reader.GetValue(0);
                transaction.Date = (DateTime)reader.GetValue(1);
                transaction.Type = (String)reader.GetValue(2);
                transaction.Amount = (int)reader.GetValue(3);
                transaction.Id_account = (int)reader.GetValue(4);
                TransactionADOList.Add(transaction);


            }
            reader.Close();
        }
    }
}
