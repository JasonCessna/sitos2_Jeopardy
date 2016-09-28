using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sitos_jeapordy
{
    public partial class teamNameTxt : Form
    {
        public teamNameTxt()
        {
            InitializeComponent();
            SetDefault(btnSubmit);
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void SetDefault(Button myDefaultBtn)
        {
            this.AcceptButton = myDefaultBtn;
        }
        public string TxtValue
        {
            get { if (txtTeamName.Text != null) { return txtTeamName.Text; } else return "0"; }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTxtTeamName_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTeamName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
