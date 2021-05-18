using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShareCar.Data;
using MetroFramework.Forms;

namespace ShareCar.App
{
    public partial class ActiveRequest : MetroForm
    {
        private DataAccess Da { get; set; }
        public ActiveRequest()
        {
            this.Da = new DataAccess();
            InitializeComponent();
            this.PopulatedCarGridView();
        }

        private void PopulatedCarGridView(string query = "select * from CarRequestApprove where Status = 'Active' ")
        {
            DataSet dataSet = this.Da.ExecuteQuery(query);
            this.ActiveGrid.AutoGenerateColumns = false;
            this.ActiveGrid.DataSource = dataSet.Tables[0];
            this.ActiveGrid.ClearSelection();
            this.ActiveGrid.Refresh();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ExecutiveDashboard executiveDashboard = new ExecutiveDashboard();
            this.Visible = false;
            executiveDashboard.Show();
        }
    }
}
