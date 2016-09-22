namespace UI
{
    partial class CategoriaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriaForm));
            this.bsCategoria = new System.Windows.Forms.BindingSource(this.components);
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lblBuscaBase = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.tbBusca = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupFiltros.SuspendLayout();
            this.gpbBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(919, 111);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(838, 111);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(757, 111);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(676, 111);
            // 
            // groupFiltros
            // 
            this.groupFiltros.Controls.Add(this.lblBuscaBase);
            this.groupFiltros.Controls.Add(this.btnBusca);
            this.groupFiltros.Controls.Add(this.tbBusca);
            this.groupFiltros.Size = new System.Drawing.Size(994, 75);
            // 
            // gpbBase
            // 
            this.gpbBase.Controls.Add(label5);
            this.gpbBase.Controls.Add(this.tbID);
            this.gpbBase.Controls.Add(this.tbDescricao);
            this.gpbBase.Controls.Add(label2);
            this.gpbBase.Enabled = false;
            this.gpbBase.Size = new System.Drawing.Size(994, 102);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(11, 45);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 16);
            label5.TabIndex = 168;
            label5.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(117, 45);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 16);
            label2.TabIndex = 170;
            label2.Text = "Descrição";
            // 
            // bsCategoria
            // 
            this.bsCategoria.DataSource = typeof(Model.CategoriaModel);
            // 
            // tbID
            // 
            this.tbID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCategoria, "codigo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(14, 64);
            this.tbID.MaxLength = 200;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 22);
            this.tbID.TabIndex = 167;
            // 
            // tbDescricao
            // 
            this.tbDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCategoria, "descricao", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Location = new System.Drawing.Point(120, 64);
            this.tbDescricao.MaxLength = 200;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(548, 22);
            this.tbDescricao.TabIndex = 169;
            // 
            // lblBuscaBase
            // 
            this.lblBuscaBase.AutoSize = true;
            this.lblBuscaBase.Location = new System.Drawing.Point(6, 24);
            this.lblBuscaBase.Name = "lblBuscaBase";
            this.lblBuscaBase.Size = new System.Drawing.Size(73, 16);
            this.lblBuscaBase.TabIndex = 9;
            this.lblBuscaBase.Text = "Descrição:";
            // 
            // btnBusca
            // 
            this.btnBusca.Image = ((System.Drawing.Image)(resources.GetObject("btnBusca.Image")));
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(432, 38);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(141, 32);
            this.btnBusca.TabIndex = 8;
            this.btnBusca.Text = "Busca";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // tbBusca
            // 
            this.tbBusca.Location = new System.Drawing.Point(9, 43);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(417, 22);
            this.tbBusca.TabIndex = 7;
            // 
            // CategoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Name = "CategoriaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Categorias";
            this.groupFiltros.ResumeLayout(false);
            this.groupFiltros.PerformLayout();
            this.gpbBase.ResumeLayout(false);
            this.gpbBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsCategoria;
        public System.Windows.Forms.TextBox tbID;
        public System.Windows.Forms.TextBox tbDescricao;
        public System.Windows.Forms.Label lblBuscaBase;
        public System.Windows.Forms.Button btnBusca;
        public System.Windows.Forms.TextBox tbBusca;
    }
}