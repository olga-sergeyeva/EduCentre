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
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ManagerMainForm ManagerMForm = new ManagerMainForm();
            this.Hide();
            ManagerMForm.Show();
        }
    }
}
