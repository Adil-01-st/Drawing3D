using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Adilbek.Khiiasov58981
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnRegularFigures_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "Lab")
                {
                    form.Show();
                    Hide();
                    return;
                }
            }

            Lab formrep = new Lab();
            formrep.Show();
            this.Hide();
        }

        private void btnComplexFigures_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "Project3")
                {
                    form.Show();
                    Hide();
                    return;
                }
            }

            Project3 formrep = new Project3();
            formrep.Show();
            this.Hide();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
