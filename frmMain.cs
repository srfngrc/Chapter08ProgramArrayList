using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter08ProgramArrayList
{
    public partial class frmMain : Form
    {
        ArrayList names = new ArrayList();
        public frmMain()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length != 0)
            {
                lstNames.Items.Clear();
                names.Add(txtName.Text); // Add new name
                txtName.Clear(); // Clear it out
                txtName.Focus(); // Get ready for another name
            }
            else
            {
                MessageBox.Show("Please enter a name.", "Input Error");
                return;
            }
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            foreach (string str in names)
            {
                lstNames.Items.Add(str);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
