namespace ProFaceCountEnd
{
    partial class MeasurementOverviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeasurementOverviewForm));
            this.PnlOpen = new System.Windows.Forms.Panel();
            this.PnlChildOpen = new System.Windows.Forms.Panel();
            this.PnlBody = new System.Windows.Forms.Panel();
            this.DGMeasurementOverview = new System.Windows.Forms.DataGridView();
            this.EntryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlHeaderMeasurementOverview = new System.Windows.Forms.Panel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LbHeaderMeasurementOverview = new System.Windows.Forms.Label();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.TxtBxSearch2 = new System.Windows.Forms.TextBox();
            this.PnlOpen.SuspendLayout();
            this.PnlChildOpen.SuspendLayout();
            this.PnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGMeasurementOverview)).BeginInit();
            this.PnlHeaderMeasurementOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlOpen
            // 
            this.PnlOpen.Controls.Add(this.PnlChildOpen);
            this.PnlOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlOpen.Location = new System.Drawing.Point(0, 0);
            this.PnlOpen.Name = "PnlOpen";
            this.PnlOpen.Size = new System.Drawing.Size(730, 530);
            this.PnlOpen.TabIndex = 0;
            // 
            // PnlChildOpen
            // 
            this.PnlChildOpen.Controls.Add(this.PnlBody);
            this.PnlChildOpen.Controls.Add(this.PnlHeaderMeasurementOverview);
            this.PnlChildOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlChildOpen.Location = new System.Drawing.Point(0, 0);
            this.PnlChildOpen.Name = "PnlChildOpen";
            this.PnlChildOpen.Size = new System.Drawing.Size(730, 530);
            this.PnlChildOpen.TabIndex = 0;
            // 
            // PnlBody
            // 
            this.PnlBody.Controls.Add(this.DGMeasurementOverview);
            this.PnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBody.Location = new System.Drawing.Point(0, 49);
            this.PnlBody.Name = "PnlBody";
            this.PnlBody.Size = new System.Drawing.Size(730, 481);
            this.PnlBody.TabIndex = 4;
            // 
            // DGMeasurementOverview
            // 
            this.DGMeasurementOverview.AllowUserToAddRows = false;
            this.DGMeasurementOverview.AllowUserToDeleteRows = false;
            this.DGMeasurementOverview.AllowUserToResizeColumns = false;
            this.DGMeasurementOverview.AllowUserToResizeRows = false;
            this.DGMeasurementOverview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGMeasurementOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMeasurementOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EntryId,
            this.PeopleIn,
            this.PeopleOut,
            this.TimeStamp});
            this.DGMeasurementOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGMeasurementOverview.Location = new System.Drawing.Point(0, 0);
            this.DGMeasurementOverview.Name = "DGMeasurementOverview";
            this.DGMeasurementOverview.ReadOnly = true;
            this.DGMeasurementOverview.RowHeadersVisible = false;
            this.DGMeasurementOverview.RowHeadersWidth = 62;
            this.DGMeasurementOverview.Size = new System.Drawing.Size(730, 481);
            this.DGMeasurementOverview.TabIndex = 12;
            // 
            // EntryId
            // 
            this.EntryId.DataPropertyName = "EntryId";
            this.EntryId.HeaderText = "Id";
            this.EntryId.Name = "EntryId";
            this.EntryId.ReadOnly = true;
            // 
            // PeopleIn
            // 
            this.PeopleIn.DataPropertyName = "PeopleIn";
            this.PeopleIn.HeaderText = "People in";
            this.PeopleIn.Name = "PeopleIn";
            this.PeopleIn.ReadOnly = true;
            // 
            // PeopleOut
            // 
            this.PeopleOut.DataPropertyName = "PeopleOut";
            this.PeopleOut.HeaderText = "People out";
            this.PeopleOut.Name = "PeopleOut";
            this.PeopleOut.ReadOnly = true;
            // 
            // TimeStamp
            // 
            this.TimeStamp.DataPropertyName = "TimeStamp";
            this.TimeStamp.HeaderText = "Timestamp";
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.ReadOnly = true;
            // 
            // PnlHeaderMeasurementOverview
            // 
            this.PnlHeaderMeasurementOverview.Controls.Add(this.TxtBxSearch2);
            this.PnlHeaderMeasurementOverview.Controls.Add(this.pictureBoxSearch);
            this.PnlHeaderMeasurementOverview.Controls.Add(this.BtnBack);
            this.PnlHeaderMeasurementOverview.Controls.Add(this.LbHeaderMeasurementOverview);
            this.PnlHeaderMeasurementOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeaderMeasurementOverview.Location = new System.Drawing.Point(0, 0);
            this.PnlHeaderMeasurementOverview.MinimumSize = new System.Drawing.Size(730, 49);
            this.PnlHeaderMeasurementOverview.Name = "PnlHeaderMeasurementOverview";
            this.PnlHeaderMeasurementOverview.Size = new System.Drawing.Size(730, 49);
            this.PnlHeaderMeasurementOverview.TabIndex = 3;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(12, 11);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(80, 34);
            this.BtnBack.TabIndex = 8;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LbHeaderMeasurementOverview
            // 
            this.LbHeaderMeasurementOverview.AutoSize = true;
            this.LbHeaderMeasurementOverview.Location = new System.Drawing.Point(103, 19);
            this.LbHeaderMeasurementOverview.Name = "LbHeaderMeasurementOverview";
            this.LbHeaderMeasurementOverview.Size = new System.Drawing.Size(200, 19);
            this.LbHeaderMeasurementOverview.TabIndex = 7;
            this.LbHeaderMeasurementOverview.Text = "Overview measurements";
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.BackColor = System.Drawing.Color.White;
            this.pictureBoxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.Image")));
            this.pictureBoxSearch.Location = new System.Drawing.Point(679, 17);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(39, 21);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearch.TabIndex = 21;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Click += new System.EventHandler(this.pictureBoxSearch_Click);
            // 
            // TxtBxSearch2
            // 
            this.TxtBxSearch2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxSearch2.Location = new System.Drawing.Point(508, 17);
            this.TxtBxSearch2.Name = "TxtBxSearch2";
            this.TxtBxSearch2.Size = new System.Drawing.Size(174, 21);
            this.TxtBxSearch2.TabIndex = 22;
            // 
            // MeasurementOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 530);
            this.Controls.Add(this.PnlOpen);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MeasurementOverviewForm";
            this.Text = "MeasurementOverviewForm";
            this.Load += new System.EventHandler(this.MeasurementOverviewForm_Load);
            this.PnlOpen.ResumeLayout(false);
            this.PnlChildOpen.ResumeLayout(false);
            this.PnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGMeasurementOverview)).EndInit();
            this.PnlHeaderMeasurementOverview.ResumeLayout(false);
            this.PnlHeaderMeasurementOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlOpen;
        private System.Windows.Forms.Panel PnlChildOpen;
        private System.Windows.Forms.Panel PnlHeaderMeasurementOverview;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LbHeaderMeasurementOverview;
        private System.Windows.Forms.Panel PnlBody;
        private System.Windows.Forms.DataGridView DGMeasurementOverview;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.TextBox TxtBxSearch2;
    }
}