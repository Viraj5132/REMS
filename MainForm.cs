using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Make the application name multline
            labelAppName.Text = "REAL\r\nESTATE\r\nMANAGER";

            //Setting the panel height
            panel1.Height= this.Height;



        }

        private void buttonGoToPropertyTypesForm_Click(object sender, EventArgs e)
        {
            PropertyTypeForm propTypeF = new PropertyTypeForm();
            propTypeF.Show();
        }

        private void buttonGoToOwnerForm_Click(object sender, EventArgs e)
        {

            PropertyOwner propOwnerF = new PropertyOwner();
            propOwnerF.Show();
        }
    }
}
