namespace ProFaceCountEnd
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.TopNav = new System.Windows.Forms.TableLayoutPanel();
            this.BtnNavExpand = new System.Windows.Forms.Button();
            this.BtnFullscreen = new System.Windows.Forms.Button();
            this.BtnMinimalise = new System.Windows.Forms.Button();
            this.BtnCloseApp = new System.Windows.Forms.Button();
            this.SideNav = new System.Windows.Forms.Panel();
            this.TLPnlSideNav = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelHour = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.BtnLocationCreate = new System.Windows.Forms.Button();
            this.BtnSensors = new System.Windows.Forms.Button();
            this.PnlPage = new System.Windows.Forms.Panel();
            this.SideNavSlider = new System.Windows.Forms.Timer(this.components);
            this.TimerSeconds = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.TopNav.SuspendLayout();
            this.SideNav.SuspendLayout();
            this.TLPnlSideNav.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopNav
            // 
            this.TopNav.ColumnCount = 5;
            this.TopNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TopNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.TopNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.TopNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.TopNav.Controls.Add(this.BtnNavExpand, 0, 0);
            this.TopNav.Controls.Add(this.BtnFullscreen, 3, 0);
            this.TopNav.Controls.Add(this.BtnMinimalise, 2, 0);
            this.TopNav.Controls.Add(this.BtnCloseApp, 4, 0);
            this.TopNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopNav.Location = new System.Drawing.Point(0, 0);
            this.TopNav.Margin = new System.Windows.Forms.Padding(0);
            this.TopNav.Name = "TopNav";
            this.TopNav.RowCount = 1;
            this.TopNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TopNav.Size = new System.Drawing.Size(880, 60);
            this.TopNav.TabIndex = 0;
            // 
            // BtnNavExpand
            // 
            this.BtnNavExpand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNavExpand.FlatAppearance.BorderSize = 0;
            this.BtnNavExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNavExpand.Image = ((System.Drawing.Image)(resources.GetObject("BtnNavExpand.Image")));
            this.BtnNavExpand.Location = new System.Drawing.Point(4, 4);
            this.BtnNavExpand.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNavExpand.Name = "BtnNavExpand";
            this.BtnNavExpand.Size = new System.Drawing.Size(112, 52);
            this.BtnNavExpand.TabIndex = 3;
            this.BtnNavExpand.UseVisualStyleBackColor = true;
            this.BtnNavExpand.Click += new System.EventHandler(this.BtnNavExpand_Click);
            // 
            // BtnFullscreen
            // 
            this.BtnFullscreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnFullscreen.FlatAppearance.BorderSize = 0;
            this.BtnFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFullscreen.Image = ((System.Drawing.Image)(resources.GetObject("BtnFullscreen.Image")));
            this.BtnFullscreen.Location = new System.Drawing.Point(674, 4);
            this.BtnFullscreen.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFullscreen.Name = "BtnFullscreen";
            this.BtnFullscreen.Size = new System.Drawing.Size(97, 52);
            this.BtnFullscreen.TabIndex = 2;
            this.BtnFullscreen.UseVisualStyleBackColor = true;
            this.BtnFullscreen.Click += new System.EventHandler(this.BtnFullscreen_Click);
            // 
            // BtnMinimalise
            // 
            this.BtnMinimalise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMinimalise.FlatAppearance.BorderSize = 0;
            this.BtnMinimalise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimalise.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimalise.Image")));
            this.BtnMinimalise.Location = new System.Drawing.Point(569, 4);
            this.BtnMinimalise.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMinimalise.Name = "BtnMinimalise";
            this.BtnMinimalise.Size = new System.Drawing.Size(97, 52);
            this.BtnMinimalise.TabIndex = 1;
            this.BtnMinimalise.UseVisualStyleBackColor = true;
            this.BtnMinimalise.Click += new System.EventHandler(this.BtnMinimalise_Click);
            // 
            // BtnCloseApp
            // 
            this.BtnCloseApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCloseApp.FlatAppearance.BorderSize = 0;
            this.BtnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseApp.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseApp.Image")));
            this.BtnCloseApp.Location = new System.Drawing.Point(779, 4);
            this.BtnCloseApp.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCloseApp.Name = "BtnCloseApp";
            this.BtnCloseApp.Size = new System.Drawing.Size(97, 52);
            this.BtnCloseApp.TabIndex = 0;
            this.BtnCloseApp.UseVisualStyleBackColor = true;
            this.BtnCloseApp.Click += new System.EventHandler(this.BtnCloseApp_Click);
            // 
            // SideNav
            // 
            this.SideNav.BackColor = System.Drawing.Color.LightGray;
            this.SideNav.Controls.Add(this.TLPnlSideNav);
            this.SideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideNav.Location = new System.Drawing.Point(0, 60);
            this.SideNav.Margin = new System.Windows.Forms.Padding(4);
            this.SideNav.Name = "SideNav";
            this.SideNav.Size = new System.Drawing.Size(150, 540);
            this.SideNav.TabIndex = 1;
            // 
            // TLPnlSideNav
            // 
            this.TLPnlSideNav.ColumnCount = 1;
            this.TLPnlSideNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPnlSideNav.Controls.Add(this.button1, 0, 2);
            this.TLPnlSideNav.Controls.Add(this.panel1, 0, 4);
            this.TLPnlSideNav.Controls.Add(this.BtnLocationCreate, 0, 0);
            this.TLPnlSideNav.Controls.Add(this.BtnSensors, 0, 1);
            this.TLPnlSideNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPnlSideNav.Location = new System.Drawing.Point(0, 0);
            this.TLPnlSideNav.Name = "TLPnlSideNav";
            this.TLPnlSideNav.RowCount = 5;
            this.TLPnlSideNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TLPnlSideNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TLPnlSideNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TLPnlSideNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TLPnlSideNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TLPnlSideNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPnlSideNav.Size = new System.Drawing.Size(150, 540);
            this.TLPnlSideNav.TabIndex = 0;
            this.TLPnlSideNav.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelHour);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelMinute);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelSeconds);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 50);
            this.panel1.TabIndex = 5;
            // 
            // LabelHour
            // 
            this.LabelHour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHour.AutoSize = true;
            this.LabelHour.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.LabelHour.Location = new System.Drawing.Point(3, 9);
            this.LabelHour.Name = "LabelHour";
            this.LabelHour.Size = new System.Drawing.Size(36, 26);
            this.LabelHour.TabIndex = 0;
            this.LabelHour.Text = "00";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(87, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // labelMinute
            // 
            this.labelMinute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinute.AutoSize = true;
            this.labelMinute.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.labelMinute.Location = new System.Drawing.Point(52, 9);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(36, 26);
            this.labelMinute.TabIndex = 1;
            this.labelMinute.Text = "00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // labelSeconds
            // 
            this.labelSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.labelSeconds.Location = new System.Drawing.Point(100, 9);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(36, 26);
            this.labelSeconds.TabIndex = 2;
            this.labelSeconds.Text = "00";
            // 
            // BtnLocationCreate
            // 
            this.BtnLocationCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLocationCreate.FlatAppearance.BorderSize = 0;
            this.BtnLocationCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLocationCreate.Location = new System.Drawing.Point(3, 3);
            this.BtnLocationCreate.Name = "BtnLocationCreate";
            this.BtnLocationCreate.Size = new System.Drawing.Size(144, 64);
            this.BtnLocationCreate.TabIndex = 1;
            this.BtnLocationCreate.Text = "Locations";
            this.BtnLocationCreate.UseVisualStyleBackColor = true;
            this.BtnLocationCreate.Click += new System.EventHandler(this.BtnLocationCreate_Click);
            // 
            // BtnSensors
            // 
            this.BtnSensors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSensors.FlatAppearance.BorderSize = 0;
            this.BtnSensors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSensors.Location = new System.Drawing.Point(3, 73);
            this.BtnSensors.Name = "BtnSensors";
            this.BtnSensors.Size = new System.Drawing.Size(144, 64);
            this.BtnSensors.TabIndex = 6;
            this.BtnSensors.Text = "Sensors overview";
            this.BtnSensors.UseVisualStyleBackColor = true;
            this.BtnSensors.Click += new System.EventHandler(this.BtnSensors_Click);
            // 
            // PnlPage
            // 
            this.PnlPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPage.Location = new System.Drawing.Point(150, 60);
            this.PnlPage.Name = "PnlPage";
            this.PnlPage.Size = new System.Drawing.Size(730, 540);
            this.PnlPage.TabIndex = 2;
            this.PnlPage.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlPage_Paint);
            // 
            // SideNavSlider
            // 
            this.SideNavSlider.Interval = 300;
            this.SideNavSlider.Tick += new System.EventHandler(this.SideNavSlider_Tick);
            // 
            // TimerSeconds
            // 
            this.TimerSeconds.Tick += new System.EventHandler(this.TimerSeconds_Tick);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 64);
            this.button1.TabIndex = 7;
            this.button1.Text = "Measurements overview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.PnlPage);
            this.Controls.Add(this.SideNav);
            this.Controls.Add(this.TopNav);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(880, 600);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.TopNav.ResumeLayout(false);
            this.SideNav.ResumeLayout(false);
            this.TLPnlSideNav.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TopNav;
        private System.Windows.Forms.Panel SideNav;
        private System.Windows.Forms.Button BtnNavExpand;
        private System.Windows.Forms.Button BtnFullscreen;
        private System.Windows.Forms.Button BtnMinimalise;
        private System.Windows.Forms.Button BtnCloseApp;
        private System.Windows.Forms.Panel PnlPage;
        private System.Windows.Forms.TableLayoutPanel TLPnlSideNav;
        private System.Windows.Forms.Timer SideNavSlider;
        private System.Windows.Forms.Button BtnLocationCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label LabelHour;
        private System.Windows.Forms.Timer TimerSeconds;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSensors;
        private System.Windows.Forms.Button button1;
    }
}