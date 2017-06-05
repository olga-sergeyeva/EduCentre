using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduCentre
{
    public partial class ManagerAddClient : Form
    {
        private OleDbConnection Connection = new OleDbConnection();
        public ManagerAddClient()
        {
            InitializeComponent();
            Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Visual Studio 2015\Projects\EduCentre\EdCentre.accdb;
Persist Security Info=False;";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ManagerClientsForm ManagerPreviousForm = new ManagerClientsForm();
            this.Hide();
            ManagerPreviousForm.Show();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                OleDbCommand CommandInsert = new OleDbCommand();
                CommandInsert.Connection = Connection;
                CommandInsert.CommandText = "INSERT INTO clients(last_name, first_name, second_name, phone_number, email) values('"+ textBoxLastName.Text + "', '" + textBoxFirstName.Text + "', '" + textBoxSecondName.Text + "', '" + textBoxPhoneNumber.Text + "', '" + textBoxEmail.Text + "')";
                CommandInsert.ExecuteNonQuery();
                MessageBox.Show("Клиент добавлен");
            }
            
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

            Connection.Close();
        }
    }
}
