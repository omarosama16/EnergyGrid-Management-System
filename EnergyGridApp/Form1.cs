using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EnergyGridApp
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=.;Database=EnergyGrid;Trusted_Connection=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsExists(string tableName, string columnName, int id)
        {
            string query = $"SELECT COUNT(1) FROM {tableName} WHERE {columnName} = @id";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private void btnSeedData_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // SAFETY CHECK
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Technician", con);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("The database already contains data! You are good to go.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Inserting foundational data
                    string seedQuery = @"
                        INSERT INTO EnergySite (coordinates, terrainType) VALUES ('30.0263 N, 31.2124 E', 'Urban');
                       
                        INSERT INTO Technician (name) VALUES ('Mahmoud'), ('Mohamed'), ('Ahmed');
                        
                        INSERT INTO PowerUnit (siteID, manufacturer, unitType, maxOutput) VALUES (1, 'Siemens', 'Solar Array', 5000);
                        
                        INSERT INTO Inspection (siteID, tID, inspectionDate) VALUES (1, 1, GETDATE());
                        
                        INSERT INTO InspectionDetails (unitID, inspectID, curEfficiency, status) VALUES (1, 1, 98.5, 1);
                    ";

                    SqlCommand cmd = new SqlCommand(seedQuery, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Database successfully seeded with foundational test data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seed Error: " + ex.Message);
            }
        }

        // Insert 1: The Master Inspection Log
        private void btnInsertInspection_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtSiteID.Text, out int siteID) || !int.TryParse(txtTechID.Text, out int tID))
                {
                    MessageBox.Show("IDs must be numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsExists("EnergySite", "siteID", siteID)) { MessageBox.Show("Site ID does not exist!"); return; }
                if (!IsExists("Technician", "tID", tID)) { MessageBox.Show("Technician ID does not exist!"); return; }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Inspection (siteID, tID, inspectionDate) VALUES (@siteID, @tID, @date)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@siteID", siteID);
                    cmd.Parameters.AddWithValue("@tID", tID);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inspection Log Created Successfully with Today's Date", "Success");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // Insert 2: Log Taken Part
        private void btnInsertPart_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Added unitID to the SQL query
                    string query = "INSERT INTO WarehouseLog (inspectID, serialNum, unitID) VALUES (@insp, @serial, @unit)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@insp", txtPartInspID.Text);
                    cmd.Parameters.AddWithValue("@serial", txtPartSerial.Text);

                    // Grab the new unit ID from the screen
                    cmd.Parameters.AddWithValue("@unit", txtPartUnitID.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Warehouse Part Logged to specific Unit Successfully", "Success");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // Update 1: The Team's Max Output Update
        private void btnUpdateOutput_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE PowerUnit SET maxOutput = @maxOutput WHERE unitID = @unitID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@maxOutput", txtUpdMaxOut.Text);
                    command.Parameters.AddWithValue("@unitID", txtUpdUnitID.Text);

                    connection.Open();
                    int rows = command.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Power Unit updated successfully.", "Success");
                    else MessageBox.Show("Unit ID not found.", "Warning");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // Update 2: Update Efficiency
        private void btnUpdateEff_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE InspectionDetails SET curEfficiency = @eff WHERE unitID = @unitID AND inspectID = @inspID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@eff", txtNewEff.Text);
                    command.Parameters.AddWithValue("@unitID", txtEffUnitID.Text);
                    command.Parameters.AddWithValue("@inspID", txtEffInspID.Text);

                    connection.Open();
                    int rows = command.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Efficiency corrected.", "Success");
                    else MessageBox.Show("Record not found.", "Warning");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // Delete 1: Inspection Record Delete
        private void btnDeleteInsp_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to permanently delete this?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes) return;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM InspectionDetails WHERE unitID = @unitID AND inspectID = @inspectID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@unitID", txtDelUnitID.Text);
                    command.Parameters.AddWithValue("@inspectID", txtDelInspID.Text);

                    connection.Open();
                    int rows = command.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Inspection record deleted.", "Success");
                    else MessageBox.Show("Record not found.", "Warning");
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547) MessageBox.Show("Cannot delete: Record is tied to a Warehouse Log.");
                else MessageBox.Show("Database error: " + sqlEx.Message);
            }
        }

        // Delete 2: Undo Part
        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM WarehouseLog WHERE serialNum = @serial";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@serial", txtDelSerial.Text);

                    connection.Open();
                    int rows = command.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Part removed from log.", "Success");
                    else MessageBox.Show("Serial Number not found.", "Warning");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // Select 1: Simple Select
        private void btnSimpleSelect_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Technician", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        // Select 2: Join Select
        private void btnJoinSelect_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT Inspection.inspectID, Technician.name, Inspection.inspectionDate
                FROM Inspection
                INNER JOIN Technician ON Inspection.tID = Technician.tID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
