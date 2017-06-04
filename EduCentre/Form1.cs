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
        private OleDbConnection connection = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Visual Studio 2015\Projects\EduCentre\EdCentre.accdb;
Persist Security Info=False;";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM authorizations WHERE login = '" + textBoxLogin.Text + "' and password = '" + textBoxPassword.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }

            reader.Close();
            if (count == 1)
            {
                MessageBox.Show("Логин и пароль введены правильно");
            }

            if (count == 0)
            {
                MessageBox.Show("Неверный логин или пароль, попробуйте заново");
            }

            connection.Close();
        }
    }
}
