namespace UI
{
    partial class LoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoteForm));
            this.bsLote = new System.Windows.Forms.BindingSource(this.components);
            this.lblBuscaBase = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNroLote = new System.Windows.Forms.TextBox();
            this.tbQtde = new System.Windows.Forms.TextBox();
            this.dtpVcto = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsDatagrid)).BeginInit();
            this.groupFiltros.SuspendLayout();
            this.gpbBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLote)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(917, 102);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(836, 102);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(755, 102);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(674, 102);
            // 
            // groupFiltros
            // 
            this.groupFiltros.Controls.Add(this.lblBuscaBase);
            this.groupFiltros.Controls.Add(this.btnBusca);
            this.groupFiltros.Controls.Add(this.tbBusca);
            this.groupFiltros.Size = new System.Drawing.Size(994, 88);
            // 
            // gpbBase
            // 
            this.gpbBase.Controls.Add(label3);
            this.gpbBase.Controls.Add(this.dtpVcto);
            this.gpbBase.Controls.Add(this.tbQtde);
            this.gpbBase.Controls.Add(label1);
            this.gpbBase.Controls.Add(label5);
            this.gpbBase.Controls.Add(this.tbID);
            this.gpbBase.Controls.Add(this.tbNroLote);
            this.gpbBase.Controls.Add(label2);
            this.gpbBase.Size = new System.Drawing.Size(994, 93);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(16, 41);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 16);
            label5.TabIndex = 176;
            label5.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(122, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 16);
            label2.TabIndex = 178;
            label2.Text = "Número Lote";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(357, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 16);
            label1.TabIndex = 180;
            label1.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(591, 41);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(111, 16);
            label3.TabIndex = 182;
            label3.Text = "Data Vencimento";
            // 
            // bsLote
            // 
            this.bsLote.DataSource = typeof(Model.LoteModel);
            // 
            // lblBuscaBase
            // 
            this.lblBuscaBase.AutoSize = true;
            this.lblBuscaBase.Location = new System.Drawing.Point(6, 27);
            this.lblBuscaBase.Name = "lblBuscaBase";
            this.lblBuscaBase.Size = new System.Drawing.Size(88, 16);
            this.lblBuscaBase.TabIndex = 15;
            this.lblBuscaBase.Text = "Número Lote:";
            // 
            // btnBusca
            // 
            this.btnBusca.Image = ((System.Drawing.Image)(resources.GetObject("btnBusca.Image")));
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(432, 41);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(141, 32);
            this.btnBusca.TabIndex = 14;
            this.btnBusca.Text = "Busca";
            this.btnBusca.UseVisualStyleBackColor = true;
            // 
            // tbBusca
            // 
            this.tbBusca.Location = new System.Drawing.Point(9, 46);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(417, 22);
            this.tbBusca.TabIndex = 13;
            // 
            // tbID
            // 
            this.tbID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLote, "codigo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(19, 60);
            this.tbID.MaxLength = 200;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 22);
            this.tbID.TabIndex = 175;
            // 
            // tbNroLote
            // 
            this.tbNroLote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLote, "nro_lote", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbNroLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNroLote.Location = new System.Drawing.Point(125, 60);
            this.tbNroLote.MaxLength = 200;
            this.tbNroLote.Name = "tbNroLote";
            this.tbNroLote.Size = new System.Drawing.Size(207, 22);
            this.tbNroLote.TabIndex = 177;
            // 
            // tbQtde
            // 
            this.tbQtde.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLote, "qtde", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQtde.Location = new System.Drawing.Point(360, 60);
            this.tbQtde.MaxLength = 200;
            this.tbQtde.Name = "tbQtde";
            this.tbQtde.Size = new System.Drawing.Size(207, 22);
            this.tbQtde.TabIndex = 179;
            // 
            // dtpVcto
            // 
            this.dtpVcto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLote, "data_vencimento", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtpVcto.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsLote, "data_vencimento", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtpVcto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVcto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVcto.Location = new System.Drawing.Point(594, 60);
            this.dtpVcto.Name = "dtpVcto";
            this.dtpVcto.Size = new System.Drawing.Size(128, 22);
            this.dtpVcto.TabIndex = 181;
            // 
            // LoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Name = "LoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Lote";
            ((System.ComponentModel.ISupportInitialize)(this.bsDatagrid)).EndInit();
            this.groupFiltros.ResumeLayout(false);
            this.groupFiltros.PerformLayout();
            this.gpbBase.ResumeLayout(false);
            this.gpbBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsLote;
        public System.Windows.Forms.Label lblBuscaBase;
        public System.Windows.Forms.Button btnBusca;
        public System.Windows.Forms.TextBox tbBusca;
        public System.Windows.Forms.TextBox tbID;
        public System.Windows.Forms.TextBox tbNroLote;
        private System.Windows.Forms.DateTimePicker dtpVcto;
        public System.Windows.Forms.TextBox tbQtde;
    }
}