namespace ProFaceCountEnd
{
    partial class LocationCreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationCreateForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LbNameLocation = new System.Windows.Forms.Label();
            this.TbNameLocation = new System.Windows.Forms.TextBox();
            this.LbMaxPersonsLocation = new System.Windows.Forms.Label();
            this.TbMaxPersonsLocation = new System.Windows.Forms.TextBox();
            this.BtnCreateLocation = new System.Windows.Forms.Button();
            this.LbHeaderLocation = new System.Windows.Forms.Label();
            this.PnlHeaderLocation = new System.Windows.Forms.Panel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.TxtBxSearch = new System.Windows.Forms.TextBox();
            this.PnlFooterLocation = new System.Windows.Forms.Panel();
            this.DGLocation = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPersons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PnlChildOpen = new System.Windows.Forms.Panel();
            this.PnlBody = new System.Windows.Forms.Panel();
            this.PnlOpen = new System.Windows.Forms.Panel();
            this.PnlHeaderLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.PnlFooterLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGLocation)).BeginInit();
            this.PnlChildOpen.SuspendLayout();
            this.PnlBody.SuspendLayout();
            this.PnlOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbNameLocation
            // 
            this.LbNameLocation.AutoSize = true;
            this.LbNameLocation.Location = new System.Drawing.Point(45, 22);
            this.LbNameLocation.Name = "LbNameLocation";
            this.LbNameLocation.Size = new System.Drawing.Size(58, 19);
            this.LbNameLocation.TabIndex = 0;
            this.LbNameLocation.Text = "Name";
            this.LbNameLocation.Click += new System.EventHandler(this.LbNameLocation_Click);
            // 
            // TbNameLocation
            // 
            this.TbNameLocation.Location = new System.Drawing.Point(111, 19);
            this.TbNameLocation.Name = "TbNameLocation";
            this.TbNameLocation.Size = new System.Drawing.Size(100, 27);
            this.TbNameLocation.TabIndex = 1;
            this.TbNameLocation.TextChanged += new System.EventHandler(this.TbNameLocation_TextChanged);
            // 
            // LbMaxPersonsLocation
            // 
            this.LbMaxPersonsLocation.AutoSize = true;
            this.LbMaxPersonsLocation.Location = new System.Drawing.Point(236, 22);
            this.LbMaxPersonsLocation.Name = "LbMaxPersonsLocation";
            this.LbMaxPersonsLocation.Size = new System.Drawing.Size(105, 19);
            this.LbMaxPersonsLocation.TabIndex = 2;
            this.LbMaxPersonsLocation.Text = "Max persons";
            // 
            // TbMaxPersonsLocation
            // 
            this.TbMaxPersonsLocation.Location = new System.Drawing.Point(347, 19);
            this.TbMaxPersonsLocation.Name = "TbMaxPersonsLocation";
            this.TbMaxPersonsLocation.Size = new System.Drawing.Size(100, 27);
            this.TbMaxPersonsLocation.TabIndex = 3;
            // 
            // BtnCreateLocation
            // 
            this.BtnCreateLocation.Location = new System.Drawing.Point(501, 11);
            this.BtnCreateLocation.Name = "BtnCreateLocation";
            this.BtnCreateLocation.Size = new System.Drawing.Size(100, 40);
            this.BtnCreateLocation.TabIndex = 4;
            this.BtnCreateLocation.Text = "Add";
            this.BtnCreateLocation.UseVisualStyleBackColor = true;
            this.BtnCreateLocation.Click += new System.EventHandler(this.BtnCreateLocation_Click);
            // 
            // LbHeaderLocation
            // 
            this.LbHeaderLocation.AutoSize = true;
            this.LbHeaderLocation.Location = new System.Drawing.Point(93, 18);
            this.LbHeaderLocation.Name = "LbHeaderLocation";
            this.LbHeaderLocation.Size = new System.Drawing.Size(79, 19);
            this.LbHeaderLocation.TabIndex = 6;
            this.LbHeaderLocation.Text = "Location ";
            this.LbHeaderLocation.Click += new System.EventHandler(this.LbHeaderLocation_Click);
            // 
            // PnlHeaderLocation
            // 
            this.PnlHeaderLocation.Controls.Add(this.BtnBack);
            this.PnlHeaderLocation.Controls.Add(this.pictureBoxSearch);
            this.PnlHeaderLocation.Controls.Add(this.TxtBxSearch);
            this.PnlHeaderLocation.Controls.Add(this.LbHeaderLocation);
            this.PnlHeaderLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeaderLocation.Location = new System.Drawing.Point(0, 0);
            this.PnlHeaderLocation.Name = "PnlHeaderLocation";
            this.PnlHeaderLocation.Size = new System.Drawing.Size(730, 49);
            this.PnlHeaderLocation.TabIndex = 8;
            this.PnlHeaderLocation.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHeaderLocation_Paint);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(12, 9);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 31);
            this.BtnBack.TabIndex = 20;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.BackColor = System.Drawing.Color.White;
            this.pictureBoxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.Image")));
            this.pictureBoxSearch.Location = new System.Drawing.Point(674, 18);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(39, 21);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearch.TabIndex = 19;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Click += new System.EventHandler(this.pictureBoxSearch_Click);
            // 
            // TxtBxSearch
            // 
            this.TxtBxSearch.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxSearch.Location = new System.Drawing.Point(501, 18);
            this.TxtBxSearch.Name = "TxtBxSearch";
            this.TxtBxSearch.Size = new System.Drawing.Size(174, 21);
            this.TxtBxSearch.TabIndex = 18;
            this.TxtBxSearch.TextChanged += new System.EventHandler(this.TxtBxSearch_TextChanged);
            // 
            // PnlFooterLocation
            // 
            this.PnlFooterLocation.Controls.Add(this.BtnCreateLocation);
            this.PnlFooterLocation.Controls.Add(this.TbMaxPersonsLocation);
            this.PnlFooterLocation.Controls.Add(this.LbMaxPersonsLocation);
            this.PnlFooterLocation.Controls.Add(this.LbNameLocation);
            this.PnlFooterLocation.Controls.Add(this.TbNameLocation);
            this.PnlFooterLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooterLocation.Location = new System.Drawing.Point(0, 461);
            this.PnlFooterLocation.Name = "PnlFooterLocation";
            this.PnlFooterLocation.Size = new System.Drawing.Size(730, 69);
            this.PnlFooterLocation.TabIndex = 9;
            this.PnlFooterLocation.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFooterLocation_Paint);
            // 
            // DGLocation
            // 
            this.DGLocation.AllowUserToAddRows = false;
            this.DGLocation.AllowUserToDeleteRows = false;
            this.DGLocation.AllowUserToResizeColumns = false;
            this.DGLocation.AllowUserToResizeRows = false;
            this.DGLocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGLocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.MaxPersons,
            this.Edit,
            this.Delete});
            this.DGLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGLocation.Location = new System.Drawing.Point(0, 0);
            this.DGLocation.Name = "DGLocation";
            this.DGLocation.ReadOnly = true;
            this.DGLocation.RowHeadersVisible = false;
            this.DGLocation.RowHeadersWidth = 62;
            this.DGLocation.Size = new System.Drawing.Size(730, 412);
            this.DGLocation.TabIndex = 5;
            this.DGLocation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGLocation_CellClick);
            this.DGLocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGLocation_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // MaxPersons
            // 
            this.MaxPersons.DataPropertyName = "MaxPersons";
            this.MaxPersons.HeaderText = "Max persons";
            this.MaxPersons.MinimumWidth = 8;
            this.MaxPersons.Name = "MaxPersons";
            this.MaxPersons.ReadOnly = true;
            // 
            // Edit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // PnlChildOpen
            // 
            this.PnlChildOpen.Controls.Add(this.PnlBody);
            this.PnlChildOpen.Controls.Add(this.PnlFooterLocation);
            this.PnlChildOpen.Controls.Add(this.PnlHeaderLocation);
            this.PnlChildOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlChildOpen.Location = new System.Drawing.Point(0, 0);
            this.PnlChildOpen.Name = "PnlChildOpen";
            this.PnlChildOpen.Size = new System.Drawing.Size(730, 530);
            this.PnlChildOpen.TabIndex = 11;
            // 
            // PnlBody
            // 
            this.PnlBody.Controls.Add(this.DGLocation);
            this.PnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBody.Location = new System.Drawing.Point(0, 49);
            this.PnlBody.Name = "PnlBody";
            this.PnlBody.Size = new System.Drawing.Size(730, 412);
            this.PnlBody.TabIndex = 11;
            // 
            // PnlOpen
            // 
            this.PnlOpen.Controls.Add(this.PnlChildOpen);
            this.PnlOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlOpen.Location = new System.Drawing.Point(0, 0);
            this.PnlOpen.Name = "PnlOpen";
            this.PnlOpen.Size = new System.Drawing.Size(730, 530);
            this.PnlOpen.TabIndex = 12;
            // 
            // LocationCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 530);
            this.Controls.Add(this.PnlOpen);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(730, 530);
            this.Name = "LocationCreateForm";
            this.Text = "LocationCreateForm";
            this.Load += new System.EventHandler(this.LocationCreateForm_Load);
            this.PnlHeaderLocation.ResumeLayout(false);
            this.PnlHeaderLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.PnlFooterLocation.ResumeLayout(false);
            this.PnlFooterLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGLocation)).EndInit();
            this.PnlChildOpen.ResumeLayout(false);
            this.PnlBody.ResumeLayout(false);
            this.PnlOpen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbNameLocation;
        private System.Windows.Forms.TextBox TbNameLocation;
        private System.Windows.Forms.Label LbMaxPersonsLocation;
        private System.Windows.Forms.TextBox TbMaxPersonsLocation;
        private System.Windows.Forms.Button BtnCreateLocation;
        private System.Windows.Forms.Label LbHeaderLocation;
        private System.Windows.Forms.Panel PnlHeaderLocation;
        private System.Windows.Forms.Panel PnlFooterLocation;
        private System.Windows.Forms.DataGridView DGLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPersons;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.TextBox TxtBxSearch;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Panel PnlChildOpen;
        private System.Windows.Forms.Panel PnlBody;
        private System.Windows.Forms.Panel PnlOpen;
    }
}