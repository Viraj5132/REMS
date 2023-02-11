using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMS
{
    internal class PERSON
    {
        // we will use this class for owners as clients

        FUNC func = new FUNC();

        private int id;
        private string fname;
        private string lname;
        private string phone;
        private string email;
        private string address;

        public PERSON() { }

        public PERSON(int ID, string FNAME, string LNAME, string PHONE, string EMAIL, string ADDRESS)
        {
            this.id = ID;
            this.fname = FNAME;
            this.lname = LNAME;
            this.phone = PHONE;
            this.email = EMAIL;
            this.address = ADDRESS;
        }

        //get all  owners
        public DataTable getAllPersons(string ownerORclient)

        {
            string tableName = ownerORclient;

            MySqlCommand command = new MySqlCommand("SELECT * FROM `property_owner`");

            return func.getData(command);

        }


        //inserting a new person (owner/client)

        public Boolean insertPERSON( string fname, string lname, int phone, string email, string address)
            {

          

     
                MySqlCommand command = new MySqlCommand("INSERT INTO `property_owner`( `first_name`, `last_name`, `phone`, `email`, `address`) VALUES (@fname,@lname,@phn,@email,@adrs)");

            //@fname,@lname,@phn,@email,@adrs


            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value =phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = address;

            return func.ExecQuery(command);
            }

        //editing the  new person (owner/client)

        public Boolean updatePERSON(int id,string fname,string lname, int phone, string email,string address)
        {
           


            MySqlCommand command = new MySqlCommand("UPDATE`property_owner`SET,`first_name`=@fname,`last_name`=@lname,`phone`=@phn,`email`=@email ,`address`=@adrs WHERE 'id'=@id");

            //@id,@fname,@lname,@phn,@email,@adrs 


            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = address;

            return func.ExecQuery(command);

        }

        internal bool insertPERSON(string v, PERSON person)
        {
            throw new NotImplementedException();
        }

        internal bool updatePERSON(string v, PERSON person)
        {
            throw new NotImplementedException();
        }

        //deleting the owner/client



    }
    }

