using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using UI;

namespace SISLand.UI
{
    public partial class MenuForm : Form
    {
        private readonly MainForm mainForm;
        public MenuForm(MainForm _mainForm)
        {
            this.mainForm = _mainForm;
            InitializeComponent();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        }

        private void btnLote_Click(object sender, EventArgs e)
        {
            if (!mainForm.formAberto("LoteForm"))
            {
                mainForm.OpenMdiForm(new LoteForm(), "LoteForm");
            }
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            if (!mainForm.formAberto("MarcaForm"))
            {
                mainForm.OpenMdiForm(new MarcaForm(), "MarcaForm");
            }
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            if (!mainForm.formAberto("CategoriaForm"))
            {
                mainForm.OpenMdiForm(new CategoriaForm(), "CategoriaForm");
            }
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            if (!mainForm.formAberto("ProdutoForm"))
            {
                mainForm.OpenMdiForm(new ProdutoForm(), "ProdutoForm");
            }
        }
    }
}
