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
    public partial class EditAccountForm : Form
    {
        public PlayerInDB lcPlayerINDB ;
        private DemoGVForm parentForm;
        public EditAccountForm(DemoGVForm pParentForm)
        {
            InitializeComponent();
            parentForm = pParentForm;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            lcPlayerINDB.UserName = UserNameTxt.Text;
            lcPlayerINDB.Strength = Convert.ToInt32( this.Strengthtxt.Text);
            parentForm.refreshDS();
           
            var aDbAccess = new DataAccessClass();
            List<Message> aMessages = aDbAccess.UpDatePlayer(lcPlayerINDB.UserName, lcPlayerINDB.Strength);
            MessageBox.Show(aMessages[0].TheMessage);
            Close();
        }
    }
}
