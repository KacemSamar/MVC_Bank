using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MVCModal;
namespace MVCController
{
    public class AdminADO
    {
        public List<Admin> AdminADOList = new List<Admin>();
        Connection cnx = new Connection();

        public void insert(Admin admin)
        {


            SqlCommand cmd = new SqlCommand("insert into Admin(nom,email,tel,adress,card,username,password)values ('" + admin.Nom + "' , '" + admin.Email + "' , '" + admin.Tel + "' , '" + admin.Adress + "', '" + admin.Card + "' , '" + admin.Username + "' , '" + admin.Password + "')");
            cnx.executeCommand(cmd);

        }
        public void update(Admin admin)
        {


            SqlCommand cmd = new SqlCommand("update  Admin set nom ='" + admin.Nom + "' ,  email =  '" + admin.Email + "' , tel =  '" + admin.Tel + "' , adress =  '" + admin.Adress + "' , card =  '" + admin.Card + "' , username =  '" + admin.Username + "' , password =  '" + admin.Password + "' where id = " + admin.Id + "; ");
            cnx.executeCommand(cmd);
        }
        public void delete(Admin admin)
        {

            SqlCommand cmd = new SqlCommand("delete from  Admin  where id = " + admin.Id + "; ");
            cnx.executeCommand(cmd);
        }
        public void load()
        {
            AdminADOList = new List<Admin>();
            SqlDataReader reader = cnx.SDD("SELECT * FROM Admin");
            while (reader.Read())
            {
                Admin admin = new Admin();
                admin.Id = (int)reader.GetValue(0);
                admin.Nom = (String)reader.GetValue(1);
                admin.Email = (String)reader.GetValue(2);
                admin.Tel = (int)reader.GetValue(3);
                admin.Adress = (String)reader.GetValue(4);
                admin.Card = (int)reader.GetValue(5);
                admin.Username = (String)reader.GetValue(6);
                admin.Password = (String)reader.GetValue(7);
                AdminADOList.Add(admin);


            }
            reader.Close();
        }

    }
}
