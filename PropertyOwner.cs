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
using MySql.Data.Common;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace REMS
{
    public partial class PropertyOwner : Form
    {
        public PropertyOwner()
        {
            InitializeComponent();
        }

       PERSON person = new PERSON();
      
        private void PropertyOwner_Load(object sender, EventArgs e)
        {
            //populate the datagridview with owners data
            LoadDatagridviewOwners();

            // diplaying the powners count
            displayOwnersCount();
        }
        //insert a new owner
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = 0;
            string fname = textBoxFName.Text;
            string lname = textBoxLName.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string address = textBoxAddress.Text;


            person = new PERSON(id, fname, lname, phone, email, address);
            if (verifTextBoxes())
            {


                if (person.insertPERSON("property_owner", person))
                {
                    MessageBox.Show("Owner Added", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDatagridviewOwners();
                    displayOwnersCount();
                }
                else
                {
                    MessageBox.Show("Owner Not Added", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter the Owner First & Last Name + the phone number", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        //updating the data

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                string fname = textBoxFName.Text;
                string lname = textBoxLName.Text;
                string phone = textBoxPhone.Text;
                string email = textBoxEmail.Text;
                string address = textBoxAddress.Text;


                PERSON person = new PERSON(id, fname, lname, phone, email, address);

                if (!verifTextBoxes())
                {
                    return;
                }
                if (person.updatePERSON("property_owner", person))
                {
                    MessageBox.Show("Owner Updated", "Edit Owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDatagridviewOwners();
                    displayOwnersCount();
                }
                else
                {
                    MessageBox.Show("Owner Data Not Up+56dated", "Edit Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Owner Id error", "Edit Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            
        }









            // removing the data
            private void buttonRemove_Click(object sender, EventArgs e)
        {

        }


        //display the selectedd owner data from datagridview to textbox
        private void dataGridViewOwners_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewOwners.CurrentRow.Cells[0].Value.ToString();
            textBoxFName.Text = dataGridViewOwners.CurrentRow.Cells[1].Value.ToString();
            textBoxLName.Text = dataGridViewOwners.CurrentRow.Cells[2].Value.ToString();
            textBoxPhone.Text = dataGridViewOwners.CurrentRow.Cells[3].Value.ToString();
            textBoxEmail.Text = dataGridViewOwners.CurrentRow.Cells[4].Value.ToString();
            textBoxAddress.Text = dataGridViewOwners.CurrentRow.Cells[5].Value.ToString();
        }



        //create a function to check if the user entered the owner first and last namme as well as thier phone number

        public bool verifTextBoxes()
        {
            string fname = textBoxFName.Text.Trim();
            string lname = textBoxLName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string address = textBoxAddress.Text.Trim();

            if (fname.Equals("") || lname.Equals("") || phone.Equals("") || address.Equals("") || email.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // populate the datagridview

        public void LoadDatagridviewOwners()
        {
            person = new PERSON();
            dataGridViewOwners.DataSource = person.getAllPersons("property_owner");



        }

        //display the owners total count 
        public void displayOwnersCount()
        {

            string ownersCount = person.getAllPersons("property_owner").Rows.Count.ToString();
            labelCount.Text = ownersCount +  " Owner(s) ";
        }

       
    }

}

             
        
 
