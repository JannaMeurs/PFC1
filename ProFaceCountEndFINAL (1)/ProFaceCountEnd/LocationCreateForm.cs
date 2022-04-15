using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProFaceCountEnd.Classes;

namespace ProFaceCountEnd
{
    public partial class LocationCreateForm : Form
    {
        DAL dal;
        public Form activeForm = null; //Sets activeform to Null.
        // BindingList<Location> Locations;

        public LocationCreateForm(DAL dal)
        {
            InitializeComponent();
            
            this.dal = dal;
            dal.FillLocationListFromDatabase();
            DGLocation.DataSource = dal.Locations;
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

        private void BtnCreateLocation_Click(object sender, EventArgs e)
        {
            try
            {
                Location location = new Location(0, TbNameLocation.Text, Int32.Parse(TbMaxPersonsLocation.Text));
                dal.CreateLocation(location);
                dal.FillLocationListFromDatabase();
                TbNameLocation.Text = TbMaxPersonsLocation.Text = String.Empty;
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("Foutieve ingave!", "Message", MessageBoxButtons.OK) == DialogResult.Yes) ;
                TbMaxPersonsLocation.Text = String.Empty;
            }
        }

        private void LocationCreateForm_Load(object sender, EventArgs e)
        {
            DGLocation.Columns["Id"].Visible = false;    //Hides datagrid
            DGLocation.AutoGenerateColumns = false;
            
        }

        private void TbNameLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbHeaderLocation_Click(object sender, EventArgs e)
        {

        }

        private void LbNameLocation_Click(object sender, EventArgs e)
        {

        }

        private void DGLocation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            var column = e.ColumnIndex;
            if (column == 0)
            {
                openChildForm(new LocationEditForm(dal.Locations[row], dal));
                var location = DGLocation.CurrentRow.DataBoundItem as Location; //Search Filter
                //LocationEditForm openForm = new LocationEditForm(dal.Locations[row], dal);
                //openForm.Show();

                
            }
            else if (column == 1)
            {
                if (MessageBox.Show("Wilt u dit verwijderen?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dal.DeleteLocationCascade(dal.Locations[row]);
                    dal.FillLocationListFromDatabase();
                }
            }
        }

        private void DGLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void PnlFooterLocation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlHeaderLocation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtBxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            dal.SearchLocation(TxtBxSearch.Text);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
