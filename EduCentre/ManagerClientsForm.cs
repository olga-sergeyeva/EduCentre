using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduCentre
{
    public partial class ManagerClientsForm : Form
    {
        public ManagerClientsForm()
        {
            InitializeComponent();
            ControlClients CtrlClients = new ControlClients();
            comboBoxClients.DataSource = CtrlClients.ClientsToList(CtrlClients.Clients);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ManagerMainForm ManagerMForm = new ManagerMainForm();
            this.Hide();
            ManagerMForm.Show();
        }

        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Temp = comboBoxClients.Text;
            string[] ParsedLine = new string[5];
            ParsedLine = Temp.Split(' ');
            textBoxLastName.Text = ParsedLine[0]; //Фамилия
            textBoxFirstName.Text = ParsedLine[1]; //Имя
            textBoxSecondName.Text = ParsedLine[2]; //Отчество
            textBoxPhoneNumber.Text = ParsedLine[3]; //Номер телефона
            textBoxEmail.Text = ParsedLine[4]; //Email
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {

        }
    }
}
