using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Util;

namespace UI
{
    public partial class LoteForm : BaseForm
    {
        public Validation Validacao()
        {
            this.Validate(); //chama a validação do formulario
            this.clearValidation();
            var v = new Validation();

            v.validateText(tbNroLote, " Um numero do lote deve ser informado !  ");
            v.validateText(tbQtde, " Uma quantidade do lote deve ser informada !  ");
            v.validateText(dtpVcto, " Uma data de vencimento do lote deve ser informada !  ");
            asd
            v.setFocus();
            if (otherValidations == null)
                otherValidations = new List<Validation>();
            otherValidations.Add(v);
            return v;
        }
        public LoteForm()
        {
            InitializeComponent();

            InitializeBaseGrid(new LoteModel(), true);
            gpbBase.Text = this.Text;

            dataGridView.Columns[0].Width = 65;

            dataGridView.CellDoubleClick += DataGridView_CellDoubleClick;
        }
        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var current = bsDatagrid.Current as LoteModel;
            if (current != null)
            {
                baseCellDoubleClick();
                bsLote.DataSource = bsDatagrid.Current;
                tabControlUsuario.SelectedIndex = 1;
            }
        }
    }
}
