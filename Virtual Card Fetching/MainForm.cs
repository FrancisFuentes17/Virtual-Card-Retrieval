using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Virtual_Card_Fetching.Program;

namespace Virtual_Card_Fetching
{
    public partial class MainForm : Form
    {
        // MySQL connection
        private readonly MySqlConnection mcon;
        private DataTable originalDataTable; // To store the original DataTable

        public MainForm()
        {
            InitializeComponent();
            mcon = new MySqlConnection($"server={Globals.con_host}; database={Globals.con_database}; username={Globals.con_username}; password={Globals.con_password}; Connect Timeout=120");

            dgvList.SelectionChanged += dgvList_SelectionChanged;

            txtSearch.KeyDown += txtSearch_KeyDown;

            // Wire up TextChanged events for filter textboxes
            txtFilter.TextChanged += FilterDataGridView;
            txtFilterOrganization.TextChanged += FilterDataGridView;

            dgvList.EnableHeadersVisualStyles = false;
            dgvList.RowPrePaint += dgvList_RowPrePaint;

            // Customize progress bar appearance
            pbloading.Style = ProgressBarStyle.Marquee;
            pbloading.MarqueeAnimationSpeed = 50;
            pbloading.Visible = false;

            btnSearch.Enabled = false;

            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void FilterDataGridView(object sender, EventArgs e)
        {
            if (originalDataTable == null)
                return;

            // Get filter texts
            string filterText = txtFilter.Text.Trim();
            string filterOrganization = txtFilterOrganization.Text.Trim();

            // Filter the original DataTable based on the filter texts
            DataView dv = originalDataTable.DefaultView;
            dv.RowFilter = $"MemberName LIKE '%{filterText}%' AND Organization LIKE '%{filterOrganization}%'";
            dgvList.DataSource = dv.ToTable();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = null;

            pbloading.Visible = true;

            try
            {
                await mcon.OpenAsync();

                // SQL query
                string query = @"
                    SELECT o.Classification AS Organization,
                           p.MemberName,
                           CONCAT('https://vcard.iwcsrvr.com/?cardNo=', p.IWCCardNo) AS vcard_link
                    FROM planholder p
                    LEFT JOIN office o ON p.officecode = o.officecode
                    WHERE p.MemberName LIKE @MemberName";

                // Command to execute the SQL query
                using (MySqlCommand mcd = new MySqlCommand(query, mcon))
                {
                    mcd.CommandTimeout = 300; // Increase the command timeout (in seconds)

                    // Adding parameter for MemberName
                    mcd.Parameters.AddWithValue("@MemberName", $"%{txtSearch.Text.Trim()}%");

                    // Data adapter to fill the DataTable
                    using (MySqlDataAdapter mda = new MySqlDataAdapter(mcd))
                    {
                        DataTable dt = new DataTable();
                        await Task.Run(() => mda.Fill(dt));

                        // Store the original DataTable
                        originalDataTable = dt;

                        dgvList.DataSource = dt;

                        dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                        dgvList.Columns["MemberName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dgvList.Columns["vcard_link"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dgvList.Columns["Organization"].Width = 220;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                mcon.Close();

                pbloading.Visible = false;
            }
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvList.SelectedRows[0];
                txtMember.Text = selectedRow.Cells["MemberName"].Value.ToString();
                txtCompany.Text = selectedRow.Cells["Organization"].Value.ToString();
                string vcardLink = selectedRow.Cells["vcard_link"].Value.ToString();
                // Extract cardNo from vcard link
                int startIndex = "https://vcard.iwcsrvr.com/?cardNo=".Length;
                if (vcardLink.Length > startIndex)
                {
                    string cardNo = vcardLink.Substring(startIndex);
                    txtVirtualId.Text = $"https://vcard.iwcsrvr.com/?cardNo={cardNo}";
                }
                else
                {
                    txtVirtualId.Text = vcardLink;
                }
            }
            else
            {
                txtMember.Text = "";
                txtCompany.Text = "";
                txtVirtualId.Text = "";
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                btnSearch.PerformClick();
            }
        }

        private void dgvList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Alternate row color
            if (e.RowIndex % 2 == 0)
                dgvList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            else
                dgvList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = !string.IsNullOrWhiteSpace(txtSearch.Text);
        }
    }
}