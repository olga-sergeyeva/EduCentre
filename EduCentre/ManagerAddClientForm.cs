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
    public partial class ManagerAddClientForm : Form
    {
        ControlClients CtrlClients = new ControlClients();
        
        public ManagerAddClientForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ManagerClientsForm ManagerPreviousForm = new ManagerClientsForm();
            this.Hide();
            ManagerPreviousForm.Show();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            int ClientId = CtrlClients.Clients.Count();
            string LastName = textBoxLastName.Text;
            string FirstName = textBoxFirstName.Text;
            string SecondName = textBoxSecondName.Text;
            string PhoneNumber = textBoxPhoneNumber.Text;
            string Email = textBoxEmail.Text;
            CtrlClients.AddClientToDB(CtrlClients, ClientId, LastName, FirstName, SecondName, PhoneNumber, Email);
        }
    }
}
