using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;
using Util;

namespace UI
{
    public partial class CategoriaForm : BaseForm
    {
        public Validation Validacao()
        {
            this.Validate(); //chama a validação do formulario
            this.clearValidation();
            var v = new Validation();

            v.validateText(tbDescricao, " Uma descrição para a categoria deve ser informada !  ");
            
            v.setFocus();
            if (otherValidations == null)
                otherValidations = new List<Validation>();
            otherValidations.Add(v);
            return v;
        }

        public CategoriaForm()
        {
            InitializeComponent();
            InitializeBaseGrid(new CategoriaModel(), true);
            gpbBase.Text = this.Text;

            dataGridView.Columns[0].Width = 65;

            dataGridView.CellDoubleClick += DataGridView_CellDoubleClick;
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var current = bsDatagrid.Current as CategoriaModel;
            if (current != null)
            {
                baseCellDoubleClick();
                bsCategoria.DataSource = bsDatagrid.Current;
                tabControlUsuario.SelectedIndex = 1;
            }
        }

       

        protected internal override void btnAdicionar_Click(object sender, EventArgs e)
        {
            baseAdicionar(); // base controla os enables dos botoes padroes

            // coisas especificas desta classe

            if (btnAdicionar.Text == "Adicionar")
            {

            }
            else // click do adicionar
            {
                bsCategoria.Clear();
                bsCategoria.AddNew();
            }
        }


        protected internal override void btnSalvar_Click(object sender, EventArgs e)
        {
            var validation = Validacao();

            if (validation.IsValid)
            {
                var current = bsCategoria.Current as CategoriaModel;
                if (current != null)
                {
                    if (new CategoriaBLL().SaveOrUpdate(current))
                    {
                        MessageBox.Show("Salvo com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        endEditMode();
                    }
                    else
                        MessageBox.Show("Erro ao Salvar!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected internal override void btnExcluir_Click(object sender, EventArgs e)
        {
            var current = bsCategoria.Current as CategoriaModel;
            if (current != null)
            {
                if (
                    MessageBox.Show("Deseja mesmo deletar este registro?", "AVISO", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (new CategoriaBLL().Delete(current.codigo))
                        MessageBox.Show("Deletado com sucesso!", "AVISO", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                }
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            var lst = new CategoriaBLL().Get(tbBusca.Text);
            bsDatagrid.DataSource = lst;
        }
    }
}
