using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatGridDemoInCSharp
{
    public partial class DemoGVForm : Form
    {
        private List<PlayerInDB> PlayersDataSourceList;
        public void refreshDS() {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = PlayersDataSourceList;
        }
        public DemoGVForm()
        {
            InitializeComponent();

        }

        private void DemoGVForm_Load(object sender, EventArgs e)
        {
            DataAccessClass dbAccess = new DataAccessClass();

            PlayersDataSourceList = dbAccess.GetAllPlayers();
            refreshDS();
        }

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PlayerInDB aDataTransferObject = (PlayerInDB)dataGridView1.SelectedRows[0].DataBoundItem;
            aDataTransferObject.Edit(this);
        }


        //    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        //    Debug.Print("Got a double click on " & e.ColumnIndex & ", " & e.RowIndex)
        //    Dim aDataTransferObject As PlayerInDB = DataGridView1.SelectedRows(0).DataBoundItem
        //    aDataTransferObject.Edit()
        //End Sub
    }
}
