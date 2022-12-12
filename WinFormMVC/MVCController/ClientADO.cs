using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MVCModal;
namespace MVCController
{
    public class ClientADO
    {
        public List<Client> clientADOList = new List<Client>();
        Connection cnx = new Connection();

        public void insert(Client client)
        {


            SqlCommand cmd = new SqlCommand("insert into client(nom,email,tel,adress,card)values ('" + client.Nom + "' , '" + client.Email + "' , '" + client.Tel + "' , '" + client.Adress + "', '" + client.Card + "')");
            cnx.executeCommand(cmd);

        }
        public void update(Client client)
        {


            SqlCommand cmd = new SqlCommand("update  client set nom ='" + client.Nom + "' ,  email =  '" + client.Email + "' , tel =  '" + client.Tel + "' , adress =  '" + client.Adress + "' , card =  '" + client.Card + "' where id = " + client.Id + "; ");
            cnx.executeCommand(cmd);
        }
        public void delete(Client client)
        {

            SqlCommand cmd = new SqlCommand("delete from  client  where id = " + client.Id + "; ");
            cnx.executeCommand(cmd);
        }
        public void load()
        {
            clientADOList = new List<Client>();
            SqlDataReader reader = cnx.SDD("SELECT * FROM client");
            while (reader.Read())
            {
                Client client = new Client();
                client.Id = (int)reader.GetValue(0);
                client.Nom = (String)reader.GetValue(1);
                client.Email = (String)reader.GetValue(2);
                client.Tel = (int)reader.GetValue(3);
                client.Adress = (String)reader.GetValue(4);
                client.Card = (int)reader.GetValue(5);
                clientADOList.Add(client);


            }
            reader.Close();
        }

    }
}
