using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket
{
    public partial class Form1 : Form
    {
        #region First version of the implementation (now is commented)
        //SqlCommand cmd;
        //SqlConnection con;
        //SqlDataAdapter da;
        #endregion

        #region Second version, now using ADO.Net

        /// <summary>
        /// Object model of the class Store
        /// </summary>
        Store model = new Store();

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// It runs general actions on the form without any action button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Open the connection to the database and inserts the store's information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            #region First version of Insert button (now is commented)
            //// Connect to the database
            //con = new SqlConnection(@"Data Source=LAPTOP-ODCVK5TP\SQLEXPRESS;Initial Catalog=TICKETDB;Integrated Security=True");
            ////Open the database
            //con.Open();
            //// Add information into the database
            //cmd = new SqlCommand("INSERT INTO Stores (Store, Country, Province, City) VALUES (@Store, @Country, @Province, @City)", con);
            //cmd.Parameters.Add("@Store", UserInputStore.Text);
            //cmd.Parameters.Add("@Country", comboBoxCountry.SelectedItem.ToString());
            //cmd.Parameters.Add("@Province", UserInputProvince.Text);
            //cmd.Parameters.Add("@City", UserInputCity.Text);

            //cmd.ExecuteNonQuery();

            #endregion

            // Storage all info in StoreNum removing the blank spaces before and after the text
            model.StoreID = int.Parse(UserInputStore.Text.Trim());
            model.Country = comboBoxCountry.Text.Trim();
            model.Province = UserInputProvince.Text.Trim();
            model.City = UserInputCity.Text.Trim();
            
            // Create a db object of the class DBEntities to add the information into the database
            using (DBEntities db = new DBEntities())
            {
                if (model.Id == 0) //Insert the model data into the database
                {
                    db.Stores.Add(model);
                    db.SaveChanges();
                }
                else // Update
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }

            // After insert, clear the txt boxes
            Clear();

            // Show the Data Grid View with current info
            PopulateDataGridView();

            // Pop up a box to show it was Submitted
            MessageBox.Show("Submitted Successfully");
        }

        /// <summary>
        /// Populate the data grid with Store information retrieved from database
        /// </summary>
        void PopulateDataGridView()
        {
            dgvStores.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dgvStores.DataSource = db.Stores.ToList<Store>();
            }
        }

        /// <summary>
        /// Action button to execute the Clear method to erase all txt boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        /// <summary>
        /// Void method to clear all text boxes
        /// </summary>
        void Clear ()
        {
            // Clear the textBoxes and the combobox
            UserInputStore.Text = UserInputProvince.Text = UserInputCity.Text = "";
            comboBoxCountry.SelectedIndex = -1;
            // Change the text in the Insert button
            btnInsert.Text = "Insert";
            // Disable the Cancel button
            btnCancel.Enabled = true;
            model.Id = 0;
        }

        /// <summary>
        /// Delete the information of the store from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete this record?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBEntities db = new DBEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Stores.Attach(model);
                    }
                    db.Stores.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Succesfuly");
                }
            }
        }


        private void UserInputStore_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserInputCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserInputProvince_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserInputCity_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Double click will populate the txt boxes to edit them or delete them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStores_DoubleClick(object sender, EventArgs e)
        {
            // To make sure the double click is in the row, not the head (-1 index)
            if(dgvStores.CurrentRow.Index != 1)
            {
                // Hold the Id of the row to search in the database
                model.Id = Convert.ToInt32(dgvStores.CurrentRow.Cells["Id"].Value);
                using (DBEntities db = new DBEntities())
                {
                    // Retrieve the store information related to the Id holded previously
                    model = db.Stores.Where(x => x.Id == model.Id).FirstOrDefault();

                    // Populate the txt boxes with the store info from the database
                    UserInputStore.Text = model.StoreID.ToString();
                    comboBoxCountry.Text = model.Country;
                    UserInputProvince.Text = model.Province;
                    UserInputCity.Text = model.City;
                }
                // Set Insert button as Update
                btnInsert.Text = "Update";
                // Enable again Delete button
                btnDelete.Enabled = true;
            }
        }

        private void btnNewTk_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnCallHist_Click(object sender, EventArgs e)
        {

        }
    }
}
