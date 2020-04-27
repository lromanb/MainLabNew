using MainLab.SecurityLayer.Interface;
using MainLab.SecurityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainLab.DataAccess;
using MainLab.Logger;

namespace MainLab.Main
{
    public partial class LoginForm : Form
    {
        ISecurityLayer sl;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {

            sl.SetCurrentUser((User)cbUsers.SelectedItem);

            MainForm mf = new MainForm(sl.GetCurrentUserRoleCode());

            mf.Owner = this;
            this.Hide();

            //this.Close();
            mf.Show();

            //this.DialogResult = DialogResult.OK;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            IDataAccess da = new DataAccessImpl();
            ILogger logger = new GeneralLogger();

            sl = new SecurityLayerImpl(da, logger);

            IEnumerable<User> ul = sl.GetUsersList();

            cbUsers.Items.AddRange(ul.ToArray());
        }
    }
}
