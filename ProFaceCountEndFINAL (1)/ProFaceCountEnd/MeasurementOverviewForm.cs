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
    public partial class MeasurementOverviewForm : Form
    {
        DAL dal;
        public MeasurementOverviewForm(DAL dal)
        {
            InitializeComponent();
            this.dal = dal;
            dal.FillMeasurementOverview();
            DGMeasurementOverview.DataSource = dal.MeasurementOverview;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MeasurementOverviewForm_Load(object sender, EventArgs e)
        {
            DGMeasurementOverview.Columns["EntryId"].Visible = false;
            DGMeasurementOverview.Columns["Sensor"].Visible = false;
            DGMeasurementOverview.AutoGenerateColumns = false;
            DGMeasurementOverview.DataSource = dal.MeasurementOverview;
        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            //dal.SearchSensors(TxtBxSearch2.Text);
        }
    }
}
