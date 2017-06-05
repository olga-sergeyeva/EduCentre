using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduCentre
{
    class ControlClients
    {
        public ControlClients()
        {
            this.Clients = ReadAllClientsFromDB();
        }

        public List<Client> Clients;

        private List<Client> ReadAllClientsFromDB()
        {
            OleDbConnection Connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Visual Studio 2015\Projects\EduCentre\EdCentre.accdb;
Persist Security Info=False;");

            List<Client> Clients = new List<Client>();
            OleDbCommand CommandReadAllRows = new OleDbCommand();
            CommandReadAllRows.CommandText = "Select * from Clients";
            CommandReadAllRows.Connection = Connection;
            try
            {
                Connection.Open();
                OleDbDataReader Reader = CommandReadAllRows.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Client client = new Client(Reader.GetInt32(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetString(4), Reader.GetString(5));
                        Clients.Add(client);
                    }

                    Connection.Close();
                }

                return Clients;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка получения данных: " + Environment.NewLine + ex.ToString());
                return null;
            }

            finally
            {
                Connection.Close();
            }
        }

        public List<string> ClientsToList(List<Client> Clients)
        {
            List<string> ListOfClients = new List<string>();
            for (int i = 0; i < Clients.Count(); i++)
            {
                string Temp;
                string LastName;
                string FirstName;
                string SecondName;
                string PhoneNumber;
                string Email;

                LastName = Clients.ElementAt(i).LastName.ToString();
                FirstName = Clients.ElementAt(i).FirstName.ToString();
                SecondName = Clients.ElementAt(i).SecondName.ToString();
                PhoneNumber = Clients.ElementAt(i).PhoneNumber.ToString();
                Email = Clients.ElementAt(i).Email.ToString();

                Temp = LastName + " " + FirstName + " " + SecondName + " " + PhoneNumber + " " + Email;
                ListOfClients.Add(Temp);
            }

            return ListOfClients;
        }
    }
}


