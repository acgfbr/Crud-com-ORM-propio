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
    }
}
