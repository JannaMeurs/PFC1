namespace ProFaceCountEnd
{
    partial class LocationEditForm
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
            this.PnlHeaderLocation = new System.Windows.Forms.Panel();
            this.LbHeaderLocationEdit = new System.Windows.Forms.Label();
            this.LbEditLocationName = new System.Windows.Forms.Label();
            this.LbEditLocationMaxPersons = new System.Windows.Forms.Label();
            this.TbNameEditLocation = new System.Windows.Forms.TextBox();
            this.TbEditLocationMaxPersons = new System.Windows.Forms.TextBox();
            this.btnLocationEdit = new System.Windows.Forms.Button();
            this.BtnSensor = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PnlChildOpen = new System.Windows.Forms.Panel();
            this.PnlOpen = new System.Windows.Forms.Panel();
            this.PnlHeaderLocation.SuspendLayout();
            this.PnlChildOpen.SuspendLayout();
            this.PnlOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHeaderLocation
            // 
            this.PnlHeaderLocation.Controls.Add(this.BtnBack);
            this.PnlHeaderLocation.Controls.Add(this.LbHeaderLocationEdit);
            this.PnlHeaderLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeaderLocation.Location = new System.Drawing.Point(0, 0);
            this.PnlHeaderLocation.Name = "PnlHeaderLocation";
            this.PnlHeaderLocation.Size = new System.Drawing.Size(730, 49);
            this.PnlHeaderLocation.TabIndex = 9;
            // 
            // LbHeaderLocationEdit
            // 
            this.LbHeaderLocationEdit.AutoSize = true;
            this.LbHeaderLocationEdit.Location = new System.Drawing.Point(104, 17);
            this.LbHeaderLocationEdit.Name = "LbHeaderLocationEdit";
            this.LbHeaderLocationEdit.Size = new System.Drawing.Size(107, 19);
            this.LbHeaderLocationEdit.TabIndex = 6;
            this.LbHeaderLocationEdit.Text = "Edit location ";
            // 
            // LbEditLocationName
            // 
            this.LbEditLocationName.AutoSize = true;
            this.LbEditLocationName.Location = new System.Drawing.Point(130, 184);
            this.LbEditLocationName.Name = "LbEditLocationName";
            this.LbEditLocationName.Size = new System.Drawing.Size(58, 19);
            this.LbEditLocationName.TabIndex = 10;
            this.LbEditLocationName.Text = "Name";
            this.LbEditLocationName.Click += new System.EventHandler(this.LbEditLocationName_Click);
            // 
            // LbEditLocationMaxPersons
            // 
            this.LbEditLocationMaxPersons.AutoSize = true;
            this.LbEditLocationMaxPersons.Location = new System.Drawing.Point(130, 247);
            this.LbEditLocationMaxPersons.Name = "LbEditLocationMaxPersons";
            this.LbEditLocationMaxPersons.Size = new System.Drawing.Size(99, 19);
            this.LbEditLocationMaxPersons.TabIndex = 11;
            this.LbEditLocationMaxPersons.Text = "MaxPersons";
            this.LbEditLocationMaxPersons.Click += new System.EventHandler(this.LbEditLocationMaxPersons_Click);
            // 
            // TbNameEditLocation
            // 
            this.TbNameEditLocation.Location = new System.Drawing.Point(134, 206);
            this.TbNameEditLocation.Name = "TbNameEditLocation";
            this.TbNameEditLocation.Size = new System.Drawing.Size(139, 27);
            this.TbNameEditLocation.TabIndex = 12;
            this.TbNameEditLocation.TextChanged += new System.EventHandler(this.TbNameEditLocation_TextChanged);
            // 
            // TbEditLocationMaxPersons
            // 
            this.TbEditLocationMaxPersons.Location = new System.Drawing.Point(134, 269);
            this.TbEditLocationMaxPersons.Name = "TbEditLocationMaxPersons";
            this.TbEditLocationMaxPersons.Size = new System.Drawing.Size(139, 27);
            this.TbEditLocationMaxPersons.TabIndex = 13;
            this.TbEditLocationMaxPersons.TextChanged += new System.EventHandler(this.TbEditLocationMaxPersons_TextChanged);
            // 
            // btnLocationEdit
            // 
            this.btnLocationEdit.Location = new System.Drawing.Point(134, 312);
            this.btnLocationEdit.Name = "btnLocationEdit";
            this.btnLocationEdit.Size = new System.Drawing.Size(139, 41);
            this.btnLocationEdit.TabIndex = 14;
            this.btnLocationEdit.Text = "Edit";
            this.btnLocationEdit.UseVisualStyleBackColor = true;
            this.btnLocationEdit.Click += new System.EventHandler(this.btnLocationEdit_Click);
            // 
            // BtnSensor
            // 
            this.BtnSensor.Location = new System.Drawing.Point(403, 206);
            this.BtnSensor.Name = "BtnSensor";
            this.BtnSensor.Size = new System.Drawing.Size(139, 45);
            this.BtnSensor.TabIndex = 15;
            this.BtnSensor.Text = "Sensors";
            this.BtnSensor.UseVisualStyleBackColor = true;
            this.BtnSensor.Click += new System.EventHandler(this.BtnSensor_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(12, 9);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(80, 34);
            this.BtnBack.TabIndex = 8;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // PnlChildOpen
            // 
            this.PnlChildOpen.Controls.Add(this.BtnSensor);
            this.PnlChildOpen.Controls.Add(this.PnlHeaderLocation);
            this.PnlChildOpen.Controls.Add(this.LbEditLocationMaxPersons);
            this.PnlChildOpen.Controls.Add(this.TbEditLocationMaxPersons);
            this.PnlChildOpen.Controls.Add(this.btnLocationEdit);
            this.PnlChildOpen.Controls.Add(this.TbNameEditLocation);
            this.PnlChildOpen.Controls.Add(this.LbEditLocationName);
            this.PnlChildOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlChildOpen.Location = new System.Drawing.Point(0, 0);
            this.PnlChildOpen.Name = "PnlChildOpen";
            this.PnlChildOpen.Size = new System.Drawing.Size(730, 530);
            this.PnlChildOpen.TabIndex = 16;
            // 
            // PnlOpen
            // 
            this.PnlOpen.Controls.Add(this.PnlChildOpen);
            this.PnlOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlOpen.Location = new System.Drawing.Point(0, 0);
            this.PnlOpen.Name = "PnlOpen";
            this.PnlOpen.Size = new System.Drawing.Size(730, 530);
            this.PnlOpen.TabIndex = 17;
            // 
            // LocationEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 530);
            this.Controls.Add(this.PnlOpen);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LocationEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocationEditForm";
            this.Load += new System.EventHandler(this.LocationEditForm_Load);
            this.PnlHeaderLocation.ResumeLayout(false);
            this.PnlHeaderLocation.PerformLayout();
            this.PnlChildOpen.ResumeLayout(false);
            this.PnlChildOpen.PerformLayout();
            this.PnlOpen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeaderLocation;
        private System.Windows.Forms.Label LbHeaderLocationEdit;
        private System.Windows.Forms.Label LbEditLocationName;
        private System.Windows.Forms.Label LbEditLocationMaxPersons;
        private System.Windows.Forms.TextBox TbNameEditLocation;
        private System.Windows.Forms.TextBox TbEditLocationMaxPersons;
        private System.Windows.Forms.Button btnLocationEdit;
        private System.Windows.Forms.Button BtnSensor;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Panel PnlChildOpen;
        private System.Windows.Forms.Panel PnlOpen;
    }
}