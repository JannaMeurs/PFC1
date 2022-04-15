using ProFaceCountEnd.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFaceCountEnd
{
    public partial class LocationEditForm : Form
    {
        DAL dal;
        Location location;
        public Form activeForm = null;


        public LocationEditForm(Location location, DAL dal)
        {
            InitializeComponent();
            
            this.location = location;
            this.dal = dal;
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
            PnlOpen.Controls.Add(childForm);
            PnlOpen.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void LocationEditForm_Load(object sender, EventArgs e)
        {
            TbNameEditLocation.Text = location.Name;
            TbEditLocationMaxPersons.Text = location.MaxPersons.ToString();
            
        }

        private void btnLocationEdit_Click(object sender, EventArgs e)
        {
            try
            {
                dal.UpdateLocation(location.Id, TbNameEditLocation.Text, Int32.Parse(TbEditLocationMaxPersons.Text));
                dal.FillLocationListFromDatabase();
                this.Hide();
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("Foutieve ingave!", "Message", MessageBoxButtons.OK) == DialogResult.Yes) ;
                TbEditLocationMaxPersons.Text = String.Empty;
            }
        }

        private void BtnSensor_Click(object sender, EventArgs e)
        {

            openChildForm(new SensorCreateForm(dal, location));
            //SensorCreateForm openForm = new SensorCreateForm(dal, location);
            //openForm.Show();
            
        }

        private void BtnCloseApp_Click(object sender, EventArgs e)
        {
            //dal.FillLocationListFromDatabase(); //search
            //this.Close();
        }

        private void TbEditLocationMaxPersons_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbNameEditLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbEditLocationMaxPersons_Click(object sender, EventArgs e)
        {

        }

        private void LbEditLocationName_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
