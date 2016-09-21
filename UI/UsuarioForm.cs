using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Util;
using BLL;

namespace UI
{
    public partial class UsuarioForm : Form
    {
        protected internal List<Validation> otherValidations;
        protected internal Validation validation;

        public void CreateBaseGrid()
        {
            DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
            gridViewCellStyle.BackColor = Color.AntiqueWhite;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AlternatingRowsDefaultCellStyle = gridViewCellStyle;
            this.dataGridView.BackgroundColor = Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = DockStyle.Fill;
            this.dataGridView.Location = new Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new Size(970, 396);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.TabStop = false;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;

            dataGridView.DataSource = bsDatagrid;
        }

        public void InitializeBaseGrid<T>(T NomeDaClasse, bool mostraAtivoGrid)
        {
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = DockStyle.Fill;
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var props = NomeDaClasse.GetType().GetProperties().Where(p => p.IsDefined(typeof(DisplayAttribute), true)).ToList()
                .OrderBy(p => p.GetCustomAttributes(typeof(DisplayAttribute), true).Cast<DisplayAttribute>().Select(a => a.Order)
                   .FirstOrDefault()).ToList(); // pega todas as variaveis da model por reflection e ordena pela ordem definida no display attribute

            foreach (var prop in props) // cria a grid.
            {

                var display = Util.PropertyValue.getDisplayName(prop);
                if (display != string.Empty)
                {
                    if (display.Equals("Ativo?"))
                        if (!mostraAtivoGrid)
                            break;

                    var tipo = Util.PropertyValue.getBaseAttribute(prop);
                    switch (tipo)
                    {
                        case ToneAttribute.None:
                            var textBoxColumn = new DataGridViewTextBoxColumn();
                            textBoxColumn.HeaderText = display;
                            textBoxColumn.Name = prop.Name;
                            textBoxColumn.DataPropertyName = prop.Name;
                            textBoxColumn.ReadOnly = true;
                            textBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            textBoxColumn.Width = 175;
                            this.dataGridView.Columns.Add((DataGridViewColumn)textBoxColumn);
                            break;
                        case ToneAttribute.Button:
                            var buttonColumn = new DataGridViewButtonColumn();
                            buttonColumn.UseColumnTextForButtonValue = true;
                            buttonColumn.HeaderText = display;
                            buttonColumn.Name = prop.Name;
                            buttonColumn.Text = prop.Name;
                            buttonColumn.DataPropertyName = prop.Name;
                            buttonColumn.ReadOnly = true;
                            buttonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            buttonColumn.Width = 175;
                            this.dataGridView.Columns.Add((DataGridViewColumn)buttonColumn);
                            break;
                        case ToneAttribute.Check:
                            var checkBoxColumn = new DataGridViewCheckBoxColumn();
                            checkBoxColumn.HeaderText = display;
                            checkBoxColumn.Name = prop.Name;
                            checkBoxColumn.DataPropertyName = prop.Name;
                            checkBoxColumn.ReadOnly = true;
                            checkBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            checkBoxColumn.Width = 175;
                            this.dataGridView.Columns.Add((DataGridViewColumn)checkBoxColumn);
                            break;
                    }
                }
            }
        }

        protected internal void clearValidation()
        {
            if (validation != null)
                validation.Free();
            if (otherValidations != null && otherValidations.Count > 0)
            {
                foreach (Validation item in otherValidations)
                {
                    item.Free();
                }
            }
        }

        public Validation Validacao()
        {
            this.Validate(); //chama a validação do formulario
            this.clearValidation();
            var v = new Validation();

            v.validateText(tbNome, " Um nome deve ser especificado! ");
            v.validateText(tbEmail, " Um email deve ser especificado! ");
            v.validateText(tbUsuario, " Um usuário deve ser especificado! ");
            v.validateText(tbSenha, " Uma senha deve ser especificada! ");

            v.setFocus();
            if (otherValidations == null)
                otherValidations = new List<Validation>();
            otherValidations.Add(v);
            return v;
        }
        public UsuarioForm()
        {
            InitializeComponent();
            bsDatagrid.DataSource = new List<Usuario>();

            CreateBaseGrid();
            InitializeBaseGrid(new Usuario(), true);


        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            var lst = string.IsNullOrEmpty(tbBusca.Text) ? new UsuarioBLL().ListAll() : new UsuarioBLL().ListByNome(tbBusca.Text);
            bsDatagrid.DataSource = lst;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var usr = new Usuario();
            usr.usuario = "teste";
            usr.email = "teste1";
            usr.senha = "teste2";
            usr.nome= "blau";
            var dal = new UsuarioBLL();
            dal.Store(usr);
            if (btnNovo.Text.Equals("Cancelar"))
            {
                btnSalvar.Enabled = false;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;

                gpbox.Enabled = false;

                btnNovo.Text = "Novo";

                bsUsuario.AddNew();
            }
            else if (btnNovo.Text.Equals("Novo"))
            {
                btnSalvar.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = true;

                gpbox.Enabled = true;

                btnNovo.Text = "Cancelar";

                bsUsuario.AddNew();
            }

            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var validation = Validacao();

            if (validation.IsValid)
            {
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
