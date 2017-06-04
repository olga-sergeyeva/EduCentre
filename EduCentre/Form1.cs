using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace EduCentre
{
    public partial class Form1 : Form
    {
        private OleDbConnection Connection = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
            Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Visual Studio 2015\Projects\EduCentre\EdCentre.accdb;
Persist Security Info=False;";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            var Id = 0;

            Connection.Open();
            OleDbCommand Command = new OleDbCommand();
            Command.Connection = Connection;
            Command.CommandText = "SELECT authorization_id FROM authorizations WHERE login = '" + textBoxLogin.Text + "' and password = '" + textBoxPassword.Text + "'";

            OleDbDataReader Reader = Command.ExecuteReader();
            int count = 0;
            while (Reader.Read())
            {
                count++;
            }

            Reader.Close();

            if (count == 1)
            {
                Id = Int32.Parse(Command.ExecuteScalar().ToString());
                MessageBox.Show(Id.ToString());

                bool SearchSuccessfull;
                OleDbCommand CommandSearchInClients = new OleDbCommand();
                OleDbCommand CommandSearchInTeachers = new OleDbCommand();
                OleDbCommand CommandSearchInManagers = new OleDbCommand();

                CommandSearchInClients.Connection = Connection;
                CommandSearchInTeachers.Connection = Connection;
                CommandSearchInManagers.Connection = Connection;
                CommandSearchInClients.CommandText = "SELECT * FROM clients WHERE authorization_id = " + Id + "";
                CommandSearchInTeachers.CommandText = "SELECT * FROM teachers WHERE authorization_id = " + Id + "";
                CommandSearchInManagers.CommandText = "SELECT * FROM managers WHERE authorization_id = " + Id + "";
                OleDbDataReader ReaderClients = CommandSearchInClients.ExecuteReader();
                SearchSuccessfull = false;
                while (ReaderClients.Read())
                {
                    SearchSuccessfull = true;
                }

                if (SearchSuccessfull == true)
                {
                    ClientMainForm ClientMForm = new ClientMainForm();
                    this.Hide();
                    ClientMForm.Show();
                }
                ReaderClients.Close();

                OleDbDataReader ReaderTeachers = CommandSearchInTeachers.ExecuteReader();
                SearchSuccessfull = false;
                while (ReaderTeachers.Read())
                {
                    SearchSuccessfull = true;
                }

                if (SearchSuccessfull == true)
                {
                    TeacherMainForm TeacherMForm = new TeacherMainForm();
                    this.Hide();
                    TeacherMForm.Show();
                }
                ReaderTeachers.Close();

                OleDbDataReader ReaderManagers = CommandSearchInManagers.ExecuteReader();
                SearchSuccessfull = false;
                while (ReaderManagers.Read())
                {
                    SearchSuccessfull = true;
                }

                if (SearchSuccessfull == true)
                {
                    ManagerMainForm ManagerMForm = new ManagerMainForm();
                    this.Hide();
                    ManagerMForm.Show();
                }
           
                ReaderManagers.Close();
            }

            if (count == 0)
            {
                MessageBox.Show("Неверный логин или пароль, попробуйте заново");
            }

            Connection.Close();
        }
    }
}
