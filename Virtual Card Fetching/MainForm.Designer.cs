namespace Virtual_Card_Fetching
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dgvList = new DataGridView();
            txtMember = new TextBox();
            txtCompany = new TextBox();
            txtVirtualId = new TextBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnSearch = new Button();
            label2 = new Label();
            pbloading = new ProgressBar();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox2 = new PictureBox();
            txtFilter = new TextBox();
            txtFilterOrganization = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvList
            // 
            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dgvList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgvList.BackgroundColor = SystemColors.ButtonHighlight;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.GridColor = SystemColors.ScrollBar;
            dgvList.Location = new Point(335, 48);
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.RowHeadersWidth = 51;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(1118, 395);
            dgvList.TabIndex = 0;
            // 
            // txtMember
            // 
            txtMember.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMember.Font = new Font("Verdana", 9F, FontStyle.Bold);
            txtMember.Location = new Point(15, 213);
            txtMember.Name = "txtMember";
            txtMember.PlaceholderText = "Full Name";
            txtMember.ReadOnly = true;
            txtMember.Size = new Size(302, 26);
            txtMember.TabIndex = 1;
            // 
            // txtCompany
            // 
            txtCompany.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCompany.Font = new Font("Verdana", 9F, FontStyle.Bold);
            txtCompany.Location = new Point(15, 277);
            txtCompany.Name = "txtCompany";
            txtCompany.PlaceholderText = "Company";
            txtCompany.ReadOnly = true;
            txtCompany.Size = new Size(302, 26);
            txtCompany.TabIndex = 2;
            // 
            // txtVirtualId
            // 
            txtVirtualId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtVirtualId.Font = new Font("Verdana", 9F, FontStyle.Bold);
            txtVirtualId.Location = new Point(15, 346);
            txtVirtualId.Name = "txtVirtualId";
            txtVirtualId.PlaceholderText = "VIrtual Card ID";
            txtVirtualId.ReadOnly = true;
            txtVirtualId.Size = new Size(302, 26);
            txtVirtualId.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(15, 149);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(245, 28);
            txtSearch.TabIndex = 4;
            // 
            // lblSearch
            // 
            lblSearch.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(12, 112);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(248, 34);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search by Member Name";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(266, 141);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(51, 42);
            btnSearch.TabIndex = 6;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.Font = new Font("Verdana", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 431);
            label2.Name = "label2";
            label2.Size = new Size(167, 15);
            label2.TabIndex = 10;
            label2.Text = "Version: 1.0.1";
            // 
            // pbloading
            // 
            pbloading.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbloading.ForeColor = Color.FromArgb(255, 192, 128);
            pbloading.Location = new Point(15, 183);
            pbloading.Name = "pbloading";
            pbloading.Size = new Size(302, 24);
            pbloading.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(317, 104);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // txtFilter
            // 
            txtFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFilter.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilter.Location = new Point(1172, 14);
            txtFilter.Name = "txtFilter";
            txtFilter.PlaceholderText = "Find Member Name";
            txtFilter.Size = new Size(281, 28);
            txtFilter.TabIndex = 13;
            // 
            // txtFilterOrganization
            // 
            txtFilterOrganization.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFilterOrganization.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterOrganization.Location = new Point(836, 14);
            txtFilterOrganization.Name = "txtFilterOrganization";
            txtFilterOrganization.PlaceholderText = "Find Organization";
            txtFilterOrganization.Size = new Size(330, 28);
            txtFilterOrganization.TabIndex = 14;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1465, 455);
            Controls.Add(txtFilterOrganization);
            Controls.Add(txtFilter);
            Controls.Add(pictureBox2);
            Controls.Add(pbloading);
            Controls.Add(label2);
            Controls.Add(btnSearch);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(txtVirtualId);
            Controls.Add(txtCompany);
            Controls.Add(txtMember);
            Controls.Add(dgvList);
            Font = new Font("Verdana", 9F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Virtual Card Retrieval Application";
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvList;
        private TextBox txtMember;
        private TextBox txtCompany;
        private TextBox txtVirtualId;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnSearch;
        private Label label2;
        private ProgressBar pbloading;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox2;
        private TextBox txtFilter;
        private TextBox txtFilterOrganization;
    }
}
