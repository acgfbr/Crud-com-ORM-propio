namespace UI
{
    partial class ProdutoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutoForm));
            System.Windows.Forms.Label label13;
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lblBuscaBase = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.cbLote = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbLoteBusca = new System.Windows.Forms.ComboBox();
            this.cbMarcaBusca = new System.Windows.Forms.ComboBox();
            this.cbCategoriaBusca = new System.Windows.Forms.ComboBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.checkLote = new System.Windows.Forms.CheckBox();
            this.checkMarca = new System.Windows.Forms.CheckBox();
            this.checkCategoria = new System.Windows.Forms.CheckBox();
            this.checkVcto = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.bsProduto = new System.Windows.Forms.BindingSource(this.components);
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.tbQtde = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsDatagrid)).BeginInit();
            this.groupFiltros.SuspendLayout();
            this.gpbBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // bsDatagrid
            // 
            this.bsDatagrid.CurrentChanged += new System.EventHandler(this.bsDatagrid_CurrentChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(917, 164);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(836, 164);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(755, 164);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(674, 164);
            // 
            // groupFiltros
            // 
            this.groupFiltros.Controls.Add(this.label14);
            this.groupFiltros.Controls.Add(this.tbQtde);
            this.groupFiltros.Controls.Add(label13);
            this.groupFiltros.Controls.Add(this.dtpFim);
            this.groupFiltros.Controls.Add(this.label12);
            this.groupFiltros.Controls.Add(this.tbTotal);
            this.groupFiltros.Controls.Add(this.checkVcto);
            this.groupFiltros.Controls.Add(this.checkCategoria);
            this.groupFiltros.Controls.Add(this.checkMarca);
            this.groupFiltros.Controls.Add(this.checkLote);
            this.groupFiltros.Controls.Add(label11);
            this.groupFiltros.Controls.Add(this.dtpInicio);
            this.groupFiltros.Controls.Add(label8);
            this.groupFiltros.Controls.Add(this.cbLoteBusca);
            this.groupFiltros.Controls.Add(label9);
            this.groupFiltros.Controls.Add(this.cbMarcaBusca);
            this.groupFiltros.Controls.Add(label10);
            this.groupFiltros.Controls.Add(this.cbCategoriaBusca);
            this.groupFiltros.Controls.Add(this.lblBuscaBase);
            this.groupFiltros.Controls.Add(this.btnBusca);
            this.groupFiltros.Controls.Add(this.tbBusca);
            this.groupFiltros.Size = new System.Drawing.Size(994, 156);
            // 
            // gpbBase
            // 
            this.gpbBase.Controls.Add(this.textBox2);
            this.gpbBase.Controls.Add(label7);
            this.gpbBase.Controls.Add(this.textBox1);
            this.gpbBase.Controls.Add(label6);
            this.gpbBase.Controls.Add(label4);
            this.gpbBase.Controls.Add(this.cbLote);
            this.gpbBase.Controls.Add(label3);
            this.gpbBase.Controls.Add(this.cbMarca);
            this.gpbBase.Controls.Add(label1);
            this.gpbBase.Controls.Add(this.cbCategoria);
            this.gpbBase.Controls.Add(label5);
            this.gpbBase.Controls.Add(this.tbID);
            this.gpbBase.Controls.Add(this.tbDescricao);
            this.gpbBase.Controls.Add(label2);
            this.gpbBase.Size = new System.Drawing.Size(994, 155);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(16, 42);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 16);
            label5.TabIndex = 180;
            label5.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(122, 42);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(114, 16);
            label2.TabIndex = 182;
            label2.Text = "Nome do Produto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(122, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 16);
            label1.TabIndex = 184;
            label1.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(304, 91);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(46, 16);
            label3.TabIndex = 186;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(486, 91);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(34, 16);
            label4.TabIndex = 188;
            label4.Text = "Lote";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(668, 42);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(77, 16);
            label6.TabIndex = 190;
            label6.Text = "Valor Custo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(815, 42);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(83, 16);
            label7.TabIndex = 192;
            label7.Text = "Valor Venda";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(370, 78);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(34, 16);
            label8.TabIndex = 194;
            label8.Text = "Lote";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(188, 78);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(46, 16);
            label9.TabIndex = 192;
            label9.Text = "Marca";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(6, 78);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(67, 16);
            label10.TabIndex = 190;
            label10.Text = "Categoria";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(549, 78);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(161, 16);
            label11.TabIndex = 196;
            label11.Text = "Vencimento do Lote Início";
            // 
            // tbID
            // 
            this.tbID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "codigo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(19, 61);
            this.tbID.MaxLength = 200;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 22);
            this.tbID.TabIndex = 179;
            // 
            // tbDescricao
            // 
            this.tbDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "descricao", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Location = new System.Drawing.Point(125, 61);
            this.tbDescricao.MaxLength = 200;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(537, 22);
            this.tbDescricao.TabIndex = 181;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProduto, "codigo_categoria", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(125, 110);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(173, 23);
            this.cbCategoria.TabIndex = 183;
            // 
            // cbMarca
            // 
            this.cbMarca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProduto, "codigo_marca", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(307, 110);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(173, 23);
            this.cbMarca.TabIndex = 185;
            // 
            // lblBuscaBase
            // 
            this.lblBuscaBase.AutoSize = true;
            this.lblBuscaBase.Location = new System.Drawing.Point(6, 27);
            this.lblBuscaBase.Name = "lblBuscaBase";
            this.lblBuscaBase.Size = new System.Drawing.Size(117, 16);
            this.lblBuscaBase.TabIndex = 15;
            this.lblBuscaBase.Text = "Nome do Produto:";
            // 
            // btnBusca
            // 
            this.btnBusca.Image = ((System.Drawing.Image)(resources.GetObject("btnBusca.Image")));
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(370, 41);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(141, 32);
            this.btnBusca.TabIndex = 14;
            this.btnBusca.Text = "Busca";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // tbBusca
            // 
            this.tbBusca.Location = new System.Drawing.Point(9, 46);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(355, 22);
            this.tbBusca.TabIndex = 13;
            // 
            // cbLote
            // 
            this.cbLote.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProduto, "codigo_lote", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLote.FormattingEnabled = true;
            this.cbLote.Location = new System.Drawing.Point(489, 110);
            this.cbLote.Name = "cbLote";
            this.cbLote.Size = new System.Drawing.Size(173, 23);
            this.cbLote.TabIndex = 187;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "valor_custo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(671, 61);
            this.textBox1.MaxLength = 200;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 22);
            this.textBox1.TabIndex = 189;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "valor_venda", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(818, 61);
            this.textBox2.MaxLength = 200;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 22);
            this.textBox2.TabIndex = 191;
            // 
            // cbLoteBusca
            // 
            this.cbLoteBusca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProduto, "codigo_lote", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbLoteBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoteBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoteBusca.FormattingEnabled = true;
            this.cbLoteBusca.Location = new System.Drawing.Point(373, 97);
            this.cbLoteBusca.Name = "cbLoteBusca";
            this.cbLoteBusca.Size = new System.Drawing.Size(173, 23);
            this.cbLoteBusca.TabIndex = 193;
            // 
            // cbMarcaBusca
            // 
            this.cbMarcaBusca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProduto, "codigo_marca", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbMarcaBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarcaBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarcaBusca.FormattingEnabled = true;
            this.cbMarcaBusca.Location = new System.Drawing.Point(191, 97);
            this.cbMarcaBusca.Name = "cbMarcaBusca";
            this.cbMarcaBusca.Size = new System.Drawing.Size(173, 23);
            this.cbMarcaBusca.TabIndex = 191;
            // 
            // cbCategoriaBusca
            // 
            this.cbCategoriaBusca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProduto, "codigo_categoria", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbCategoriaBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaBusca.FormattingEnabled = true;
            this.cbCategoriaBusca.Location = new System.Drawing.Point(9, 97);
            this.cbCategoriaBusca.Name = "cbCategoriaBusca";
            this.cbCategoriaBusca.Size = new System.Drawing.Size(173, 23);
            this.cbCategoriaBusca.TabIndex = 189;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(552, 98);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(149, 22);
            this.dtpInicio.TabIndex = 195;
            // 
            // checkLote
            // 
            this.checkLote.AutoSize = true;
            this.checkLote.Location = new System.Drawing.Point(373, 126);
            this.checkLote.Name = "checkLote";
            this.checkLote.Size = new System.Drawing.Size(136, 20);
            this.checkLote.TabIndex = 197;
            this.checkLote.Text = "Usar Filtro de Lote";
            this.checkLote.UseVisualStyleBackColor = true;
            // 
            // checkMarca
            // 
            this.checkMarca.AutoSize = true;
            this.checkMarca.Location = new System.Drawing.Point(191, 126);
            this.checkMarca.Name = "checkMarca";
            this.checkMarca.Size = new System.Drawing.Size(148, 20);
            this.checkMarca.TabIndex = 198;
            this.checkMarca.Text = "Usar Filtro de Marca";
            this.checkMarca.UseVisualStyleBackColor = true;
            // 
            // checkCategoria
            // 
            this.checkCategoria.AutoSize = true;
            this.checkCategoria.Location = new System.Drawing.Point(9, 126);
            this.checkCategoria.Name = "checkCategoria";
            this.checkCategoria.Size = new System.Drawing.Size(169, 20);
            this.checkCategoria.TabIndex = 199;
            this.checkCategoria.Text = "Usar Filtro de Categoria";
            this.checkCategoria.UseVisualStyleBackColor = true;
            // 
            // checkVcto
            // 
            this.checkVcto.AutoSize = true;
            this.checkVcto.Location = new System.Drawing.Point(552, 126);
            this.checkVcto.Name = "checkVcto";
            this.checkVcto.Size = new System.Drawing.Size(137, 20);
            this.checkVcto.TabIndex = 200;
            this.checkVcto.Text = "Usar Filtro de Vcto";
            this.checkVcto.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(514, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 16);
            this.label12.TabIndex = 202;
            this.label12.Text = "Valor Total do Estoque da Busca";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(517, 46);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(232, 22);
            this.tbTotal.TabIndex = 201;
            // 
            // bsProduto
            // 
            this.bsProduto.DataSource = typeof(Model.ProdutoModel);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(706, 78);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(152, 16);
            label13.TabIndex = 204;
            label13.Text = "Vencimento do Lote Fim";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(709, 98);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(149, 22);
            this.dtpFim.TabIndex = 203;
            this.dtpFim.Value = new System.DateTime(2016, 10, 23, 13, 33, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(752, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 16);
            this.label14.TabIndex = 206;
            this.label14.Text = "Qtde itens do produto";
            // 
            // tbQtde
            // 
            this.tbQtde.Enabled = false;
            this.tbQtde.Location = new System.Drawing.Point(755, 46);
            this.tbQtde.Name = "tbQtde";
            this.tbQtde.Size = new System.Drawing.Size(232, 22);
            this.tbQtde.TabIndex = 205;
            // 
            // ProdutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Name = "ProdutoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.bsDatagrid)).EndInit();
            this.groupFiltros.ResumeLayout(false);
            this.groupFiltros.PerformLayout();
            this.gpbBase.ResumeLayout(false);
            this.gpbBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox tbID;
        public System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.BindingSource bsProduto;
        public System.Windows.Forms.Label lblBuscaBase;
        public System.Windows.Forms.Button btnBusca;
        public System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.ComboBox cbLote;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbLoteBusca;
        private System.Windows.Forms.ComboBox cbMarcaBusca;
        private System.Windows.Forms.ComboBox cbCategoriaBusca;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.CheckBox checkCategoria;
        private System.Windows.Forms.CheckBox checkMarca;
        private System.Windows.Forms.CheckBox checkLote;
        private System.Windows.Forms.CheckBox checkVcto;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.DateTimePicker dtpFim;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox tbQtde;
    }
}