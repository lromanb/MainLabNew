using MainLab.BusinessService;
using MainLab.Configure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainLab.Main
{
    public partial class MainForm : Form
    {
        internal class MenuPositions
        {
            public Button But { get; private set; }
            public TabPage Tp{ get; private set; }
            public int RoleCode { get; private set; }

            public MenuPositions(Button but, TabPage tp, int roleCode)
            {
                But = but;
                Tp = tp;
                RoleCode = roleCode;
            }
        }

        private int roleCode;
        private CompositionRoot cr;
        private List<MenuPositions> lmp;

        public MainForm(int _roleCode)
        {
            InitializeComponent();

            roleCode = _roleCode;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //заполняем список меню
            lmp = new List<MenuPositions>();
            lmp.Add(new MenuPositions(btmAccBalanceReport, tpAccBalanceReport, 2));
            lmp.Add(new MenuPositions(btmTrafficReport, tpTrafficReport, 2));
            lmp.Add(new MenuPositions(btmPayAccount, tpPayAccount, 2));
            lmp.Add(new MenuPositions(btmChooseTarif, tpChooseTarif, 2));
            lmp.Add(new MenuPositions(btmCreateAbonent, tpCreateAbonent, 1));
            lmp.Add(new MenuPositions(btmEditAbonent, tpEditAbonent, 1));
            lmp.Add(new MenuPositions(btmCreateTarif, tpCreateTarif, 1));
            lmp.Add(new MenuPositions(btmEditTarif, tpEditTarif, 1));

            //List<MenuPositions> menuByRole = lmp.Where(m => m.RoleCode == roleCode).ToList();

            //здесь можно попробовать свой енумератор
            foreach (MenuPositions m in lmp)
            {
                if (m.RoleCode != roleCode)
                { m.But.Visible = false; }
            }

            HideTabs();
            cr = new CompositionRoot();
            cr.BuildApplication();
           
        }

        //процедура нажатия кнопки меню
        private void CustomMenuButClick(object sender, EventArgs e)
        {
            HideTabs();
            lmp.Where(m => m.But == sender).Select(m => m.Tp).First().Parent = tcMain;
        }

        //убираем заголовки закладок, чтобы переключать их программно
        private void HideTabs()
        {
            foreach (TabPage tab in tcMain.TabPages)
            {
                tab.Parent = null;
            }
        }

        private void btAccBalanceReport_Click(object sender, EventArgs e)
        {
            tbBalanceReport.Text = "";

            PassedParams pp = new PassedParams();
            IEnumerable res = cr.root.CreateAccBalanceReport(pp);

            foreach (var r in res)
            {
                tbBalanceReport.Text += r.ToString() + " ";
            }
        }

        private void btTrafficReport_Click(object sender, EventArgs e)
        {
            tbTrafficReport.Text = "";

            PassedParams pp = new PassedParams();
            IEnumerable res = cr.root.CreateAccBalanceReport(pp).OfType<string>();

            foreach (var r in res)
            {
                tbTrafficReport.Text += r.ToString() + " ";
            }
        }

        private void btPayAccount_Click(object sender, EventArgs e)
        {
            PassedParams pp = new PassedParams();
            IEnumerable<string> res = cr.root.PayAccount(pp).OfType<string>();

            tsslMain.Text = res.First();
        }

        private void btChooseTarif_Click(object sender, EventArgs e)
        {
            PassedParams pp = new PassedParams();
            IEnumerable<string> res = cr.root.ChooseTariff(pp).OfType<string>();

            tsslMain.Text = res.First();
        }

        private void btCreateAbonent_Click(object sender, EventArgs e)
        {
            PassedParams pp = new PassedParams();
            IEnumerable<string> res = cr.root.CreateAbonent(pp).OfType<string>();

            tsslMain.Text = res.First();
        }

        private void btEditAbonent_Click(object sender, EventArgs e)
        {
            PassedParams pp = new PassedParams();
            IEnumerable<string> res = cr.root.EditAbonent(pp).OfType<string>();

            tsslMain.Text = res.First();
        }

        private void btCreateTarif_Click(object sender, EventArgs e)
        {
            PassedParams pp = new PassedParams();
            IEnumerable<string> res = cr.root.CreateTarif(pp).OfType<string>();

            tsslMain.Text = res.First();
        }

        private void btEditTarif_Click(object sender, EventArgs e)
        {
            PassedParams pp = new PassedParams();
            IEnumerable<string> res = cr.root.EditTarif(pp).OfType<string>();

            tsslMain.Text = res.First();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FormClosing -= MainForm_FormClosing;
            this.Owner.Close();
        }
    }
}
