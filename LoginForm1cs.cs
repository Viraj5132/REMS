using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace REMS
{
    public partial class LoginForm1cs : Form
    {
        //developed by Viraj and Atharva
        public LoginForm1cs()
        {
            InitializeComponent();
        }
       

        

        //Check if the username and password are empty
        public Boolean checkFields()
        {
            labelUsernameAstrikk.Visible=false;
            labelPasswordAstrikk.Visible=false;


            if ((textBoxUsernamee.Text.Trim().Equals("")) && textBoxPasswordd.Text.Trim().Equals(""))

            {
                labelUsernameAstrikk.Visible = true;
                labelPasswordAstrikk.Visible = true;
                return false;
            }

           else if (textBoxUsernamee.Text.Trim().Equals(""))
            {
                labelUsernameAstrikk.Visible = true;
                return false;
            }
            else if (textBoxPasswordd.Text.Trim().Equals(""))

            {
                labelPasswordAstrikk.Visible = true;
                return false;
            }

            else
            {
                return true;
            }
        }

        /////////////////////////////////////////////////////////////////////////////////
        private void textBoxPassworddd_Enter(object sender, EventArgs e)
        {
            labelErrorr.Visible = false;
        }
        private void textBoxUsernamee_Enter(object sender, EventArgs e)
        {
            labelErrorr.Visible = false;
        }
        ////////////////////////////////////////////////////////////////////////
        private void LoginForm1cs_Load(object sender, EventArgs e)
        {

        }

        private void buttonshut_Click(object sender, EventArgs e)
        {

            Close();
        }


        private void buttonLoginn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsernamee.Text;
            string password = textBoxPasswordd.Text;
            FUNC func = new FUNC();


            if (checkFields())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Username`=@un AND Password=@pass");
                command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

                DataTable table = func.getData(command);

                if (table.Rows.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    labelErrorr.Visible = true;
                }

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelUsernameAstrikk_Click(object sender, EventArgs e)
        {

        }

        private void labelErrorr_Click(object sender, EventArgs e)
        {

        }
    }
}
