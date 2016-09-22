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
    public partial class ProdutoForm : BaseForm
    {
        public Validation Validacao()
        {
            this.Validate(); //chama a validação do formulario
            this.clearValidation();
            var v = new Validation();

            v.validateText(cbCategoria, " Selecione uma categoria !  ");
            v.validateText(cbMarca, " Selecione uma marca !  ");
            v.validateText(tbDescricao, " Uma descrição para o produto deve ser informada !  ");

            v.setFocus();
            if (otherValidations == null)
                otherValidations = new List<Validation>();
            otherValidations.Add(v);
            return v;
        }

        private void carregaComboBoxs()
        {
            cbCategoria.DataSource = new CategoriaBLL().Get("");
            cbCategoria.ValueMember = "codigo";
            cbCategoria.DisplayMember = "descricao";

            cbMarca.DataSource = new MarcaBLL().Get("");
            cbMarca.ValueMember = "codigo";
            cbMarca.DisplayMember = "descricao";

            cbLote.DataSource = new LoteBLL().Get("");
            cbLote.ValueMember = "codigo";
            cbLote.DisplayMember = "nro_lote";
        }

        public ProdutoForm()
        {
            InitializeComponent();
            carregaComboBoxs();
            InitializeBaseGrid(new ProdutoModel(), true);
            gpbBase.Text = this.Text;

            dataGridView.Columns[0].Width = 65;

            dataGridView.CellDoubleClick += DataGridView_CellDoubleClick;
        }
        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var current = bsDatagrid.Current as ProdutoModel;
            if (current != null)
            {
                baseCellDoubleClick();
                bsProduto.DataSource = bsDatagrid.Current;
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
                bsProduto.Clear();
                bsProduto.AddNew();
                cbMarca.SelectedIndex = 0;
                cbCategoria.SelectedIndex = 0;
                cbLote.SelectedIndex = 0;
            }
        }


        protected internal override void btnSalvar_Click(object sender, EventArgs e)
        {
            var validation = Validacao();

            if (validation.IsValid)
            {
                var current = bsProduto.Current as ProdutoModel;
                if (current != null)
                {
                    if (new ProdutoBLL().SaveOrUpdate(current))
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
            var current = bsProduto.Current as ProdutoModel;
            if (current != null)
            {
                if (
                    MessageBox.Show("Deseja mesmo deletar este registro?", "AVISO", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (new ProdutoBLL().Delete(current.codigo))
                        MessageBox.Show("Deletado com sucesso!", "AVISO", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                }
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            var lst = new ProdutoBLL().Get(tbBusca.Text);
            bsDatagrid.DataSource = lst;
        }
    }
}
