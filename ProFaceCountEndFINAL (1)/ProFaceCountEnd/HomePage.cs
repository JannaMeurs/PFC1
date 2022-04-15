using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProFaceCountEnd.Classes;

namespace ProFaceCountEnd
{
    public partial class HomePage : Form
    {
        DAL dal;
        public Form activeForm = null; //Sets activeform to Null.

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );
        public HomePage()
        {
            InitializeComponent();
            dal = new DAL();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void BtnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Stops Application.
        }
        public void openChildForm(Form childForm)
        {
            //Opens forms inside 'PnlPage'.
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PnlPage.Controls.Add(childForm);
            PnlPage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void BtnLibrary_Click(object sender, EventArgs e)
        {
            //niks
        }
        private void SideNavSlider_Tick(object sender, EventArgs e)
        {
            //Slides the pnl in or out when called(visible or hidden). 
            if (SideNav.Width == 150)
            {
                TLPnlSideNav.Visible = false;
                for (int i = 0; i < 10; i++)
                {
                    SideNav.Width = SideNav.Width - 15;
                }
                SideNavSlider.Stop();
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    SideNav.Width = SideNav.Width + 15;
                }
                TLPnlSideNav.Visible = true;
                SideNavSlider.Stop();
            }
        }
        private void BtnNavExpand_Click(object sender, EventArgs e)
        {
            SideNavSlider.Start(); //Opens/closes 'SideNav'.
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            SideNav.Width = 0; //Sets SideNav to 0.
            LabelHour.Text = DateTime.Now.Hour.ToString("00");
            labelMinute.Text = DateTime.Now.Minute.ToString("00");
            labelSeconds.Text = DateTime.Now.Second.ToString("00");
            TimerSeconds.Start();
        }
        private void BtnFullscreen_Click(object sender, EventArgs e)
        {
            //Maximizes window or set to normal.
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }
        private void BtnMinimalise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //Minimalises window.
        }

        private void BtnLocationCreate_Click(object sender, EventArgs e)
        {
            openChildForm(new LocationCreateForm(dal)); //Opens 'LocationCreateForm' form.
        }

        private void PnlPage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TimerSeconds_Tick(object sender, EventArgs e)
        {
            LabelHour.Text = DateTime.Now.Hour.ToString("00");
            labelMinute.Text = DateTime.Now.Minute.ToString("00");
            labelSeconds.Text = DateTime.Now.Second.ToString("00");
        }

        private void BtnSensors_Click(object sender, EventArgs e)
        {
            openChildForm(new SensorOverviewForm(dal));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new MeasurementOverviewForm(dal));
        }
    }
}
