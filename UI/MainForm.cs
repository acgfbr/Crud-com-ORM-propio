using System;
using System.Linq;
using System.Windows.Forms;
using BLL;
using SISLand.UI;
using UI;
using Util;


namespace UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
                    
        }
        
        //abre o menu interno
        public void setupProgramMenu()
        {

            if (!formAberto("MenuForm"))
            {
                var menu = new MenuForm(this);
                menu.MdiParent = this;
                menu.WindowState = FormWindowState.Maximized;
                menu.Show();
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            setupProgramMenu();
        }

        //verifica se o form está aberto
        public bool formAberto(string form)
        {
            try
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Name == form)
                    {
                        item.Activate();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return false;
        }

        public void OpenMdiForm(Form form, string name)
        {
            
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
