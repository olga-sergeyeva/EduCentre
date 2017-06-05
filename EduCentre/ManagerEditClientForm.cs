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
    public partial class ManagerEditClientForm : Form
    {
        public ManagerEditClientForm(string selectedItem)
        {
            InitializeComponent();
        }

        private void ManagerEditClientForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ManagerClientsForm ManagerPreviousForm = new ManagerClientsForm();
            this.Hide();
            ManagerPreviousForm.Show();
        }

        private void buttonSaveEdited_Click(object sender, EventArgs e)
        {

        }
    }
}
