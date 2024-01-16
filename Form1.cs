using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BONILLA_SchoolSupplyStore
{
    public partial class frmHome : Form
    {
        MySqlConnection con = new MySqlConnection(
            "datasource=localhost;" +
            "port=3306;" +
            "database=schoolsupplystore;" +
            "username=root;" +
            "password='';");
        MySqlCommand cmd;
        MySqlDataReader rdr;

        public frmHome()
        {
            InitializeComponent();
        }

        //Load Database
        private void frmHome_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadItems();
            LoadPurchase();
        }

        //Load Students Database
        private void LoadStudents()
        {
            dataStudents.Rows.Clear();
            dataStudents2.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("SELECT ID, studID, lastname, firstname, middlename, course, college FROM students;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataStudents.Rows.Add(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5), rdr.GetString(6));
                dataStudents2.Rows.Add(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5), rdr.GetString(6));
            }
            con.Close();
        }

        //Load Items Database
        private void LoadItems()
        {
            dataItems.Rows.Clear();
            dataItems2.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("SELECT ID, itemID, itemname, itemprice FROM items", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataItems.Rows.Add(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3));
                dataItems2.Rows.Add(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3));
            }

            con.Close();
        }

        //Load Purchase Database
        private void LoadPurchase()
        {
            dataPurchase.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("SELECT purchase.ID, CONCAT(lastname,', ',firstname,'  ', middlename) AS 'Student', itemname, itemquantity, purchaseDate " +
                "FROM students INNER JOIN purchase ON students.ID = purchase.studID " +
                "INNER JOIN items ON purchase.itemID = items.ID;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataPurchase.Rows.Add(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4));
            }
            con.Close();

        }

        //Clear Function
        private void ClearAll()
        {
            txtStudentID.Clear();
            txtLname.Clear();
            txtFname.Clear();
            txtMname.Clear();
            txtCourse.Clear();
            txtCollege.Clear();
            txtIID.Clear();
            txtItemID.Clear();
            txtItemname.Clear();
            txtItemprice.Clear();
            txtSelectedItemID.Clear();
            txtSelectedStudentID.Clear();
            txtSelectedPurchase.Clear();
            txtQuantity.Clear();

        }

        //Student Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand("INSERT INTO students(studID, lastname, firstname, middlename, course, college)" +
                "VALUES ('" + txtStudentID.Text + "', '" + txtLname.Text + "', '" + txtFname.Text + "', '" + txtMname.Text + "', '" + txtCourse.Text + "', '" + txtCollege.Text + "');", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The student has been added successfully.");
            LoadStudents();
            ClearAll();
        }

        //Student Edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataStudents.SelectedRows.Count > 0)
            {
                con.Open();
                cmd = new MySqlCommand("UPDATE students SET studID ='" + txtStudentID.Text + "', " +
                    "lastname = '" + txtLname.Text + "'," +
                    "firstname = '" + txtFname.Text + "'," +
                    "middlename = '" + txtMname.Text + "'," +
                    "course = '" + txtCourse.Text + "'," +
                    "college = '" + txtCollege.Text + "'" +
                    "WHERE ID = '" + txtSID.Text + "';", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student info has been edited successfully.");
                LoadStudents();
                ClearAll();
            }
        }

        //Student Selection
        private void dataStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dataStudents.SelectedRows.Count > 0)
            {
                txtSID.Text = dataStudents.SelectedRows[0].Cells[0].Value.ToString();
                txtStudentID.Text = dataStudents.SelectedRows[0].Cells[1].Value.ToString();
                txtLname.Text = dataStudents.SelectedRows[0].Cells[2].Value.ToString();
                txtFname.Text = dataStudents.SelectedRows[0].Cells[3].Value.ToString();
                txtMname.Text = dataStudents.SelectedRows[0].Cells[4].Value.ToString();
                txtCourse.Text = dataStudents.SelectedRows[0].Cells[5].Value.ToString();
                txtCollege.Text = dataStudents.SelectedRows[0].Cells[6].Value.ToString();
            }
        }


        //Item Add
        private void btnEnter_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand("INSERT INTO items(itemID, itemname, itemprice)" +
                "VALUES ('" + txtItemID.Text + "', '" + txtItemname.Text + "', '" + txtItemprice.Text + "');", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The school item has been added successfully.");
            LoadItems();
            ClearAll();
        }

        //Item Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand("UPDATE items SET itemID ='" + txtItemID.Text + "', " +
                "itemname = '" + txtItemname.Text + "'," +
                "itemprice = '" + txtItemprice.Text + "'" +
                "WHERE ID = '" + txtIID.Text + "';", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Item info has been edited successfully.");
            LoadItems();
            ClearAll();
        }

        private void dataItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Item Selection
        private void dataItems_SelectionChanged(object sender, EventArgs e)
        {
            if (dataItems.SelectedRows.Count > 0)
            {
                txtIID.Text = dataItems.SelectedRows[0].Cells[0].Value.ToString();
                txtItemID.Text = dataItems.SelectedRows[0].Cells[1].Value.ToString();
                txtItemname.Text = dataItems.SelectedRows[0].Cells[2].Value.ToString();
                txtItemprice.Text = dataItems.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void dataStudents2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataStudents2.SelectedRows.Count > 0)
            {
                txtSelectedStudentID.Text = dataStudents2.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void dataItems2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataItems2.SelectedRows.Count > 0)
            {
                txtSelectedItemID.Text = dataItems2.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        //Register Purchase Details
        private void btnRegister_Click(object sender, EventArgs e)
        {
            int quantity = 0;
            quantity = int.Parse(txtQuantity.Text);
            if (dataStudents2.SelectedRows.Count > 0 && dataItems2.SelectedRows.Count > 0 && txtQuantity.Text != "0")
            {
                con.Open();
                cmd = new MySqlCommand("INSERT INTO purchase(studID, itemID, itemQuantity, purchaseDate)" +
                    "VALUES ('" + txtSelectedStudentID.Text + "', '" + txtSelectedItemID.Text + "', '" + txtQuantity.Text + "', NOW());", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Purchase details registered.");
                LoadPurchase();
                ClearAll();

            }
            else
            {
                MessageBox.Show("Please select purchase details and enter the quantity you wish to purchase.");
            }
        }

        //Invalidate Purchase
        private void btnInvalidate_Click(object sender, EventArgs e)
        {
            if (dataPurchase.SelectedRows.Count > 0)
            {
                con.Open();
                cmd = new MySqlCommand("DELETE FROM purchase " +
                    "WHERE ID = '" + txtSelectedPurchase.Text + "';", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Purchase has been invalidated successfully!");
                LoadPurchase();
                ClearAll();
            }
        }

        private void dataPurchase_SelectionChanged(object sender, EventArgs e)
        {
            if (dataPurchase.SelectedRows.Count > 0)
            {
                txtSelectedPurchase.Text = dataPurchase.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}