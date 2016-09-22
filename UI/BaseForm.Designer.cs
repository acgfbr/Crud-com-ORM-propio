namespace UI
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.tabControlUsuario = new System.Windows.Forms.TabControl();
            this.tabBusca = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupFiltros = new System.Windows.Forms.GroupBox();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gpbBase = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tabControlUsuario.SuspendLayout();
            this.tabBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUsuario
            // 
            this.tabControlUsuario.Controls.Add(this.tabBusca);
            this.tabControlUsuario.Controls.Add(this.tabCadastro);
            this.tabControlUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlUsuario.ItemSize = new System.Drawing.Size(60, 30);
            this.tabControlUsuario.Location = new System.Drawing.Point(0, 0);
            this.tabControlUsuario.Multiline = true;
            this.tabControlUsuario.Name = "tabControlUsuario";
            this.tabControlUsuario.Padding = new System.Drawing.Point(10, 3);
            this.tabControlUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControlUsuario.SelectedIndex = 0;
            this.tabControlUsuario.ShowToolTips = true;
            this.tabControlUsuario.Size = new System.Drawing.Size(1008, 730);
            this.tabControlUsuario.TabIndex = 4;
            // 
            // tabBusca
            // 
            this.tabBusca.AutoScroll = true;
            this.tabBusca.BackColor = System.Drawing.Color.Transparent;
            this.tabBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabBusca.Controls.Add(this.dataGridView);
            this.tabBusca.Controls.Add(this.groupFiltros);
            this.tabBusca.Location = new System.Drawing.Point(4, 34);
            this.tabBusca.Name = "tabBusca";
            this.tabBusca.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusca.Size = new System.Drawing.Size(1000, 692);
            this.tabBusca.TabIndex = 0;
            this.tabBusca.Tag = "busca";
            this.tabBusca.Text = "Consulta";
            this.tabBusca.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 97);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(994, 592);
            this.dataGridView.TabIndex = 5;
            // 
            // groupFiltros
            // 
            this.groupFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupFiltros.Location = new System.Drawing.Point(3, 3);
            this.groupFiltros.Name = "groupFiltros";
            this.groupFiltros.Size = new System.Drawing.Size(994, 94);
            this.groupFiltros.TabIndex = 4;
            this.groupFiltros.TabStop = false;
            this.groupFiltros.Text = "Filtros de busca";
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.btnExcluir);
            this.tabCadastro.Controls.Add(this.btnEditar);
            this.tabCadastro.Controls.Add(this.gpbBase);
            this.tabCadastro.Controls.Add(this.btnSalvar);
            this.tabCadastro.Controls.Add(this.btnAdicionar);
            this.tabCadastro.Location = new System.Drawing.Point(4, 34);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(1000, 692);
            this.tabCadastro.TabIndex = 4;
            this.tabCadastro.Text = "Cadastro";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(917, 379);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 58);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(836, 379);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 58);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gpbBase
            // 
            this.gpbBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbBase.Enabled = false;
            this.gpbBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBase.Location = new System.Drawing.Point(3, 3);
            this.gpbBase.Name = "gpbBase";
            this.gpbBase.Size = new System.Drawing.Size(994, 370);
            this.gpbBase.TabIndex = 55;
            this.gpbBase.TabStop = false;
            this.gpbBase.Text = "#Nome_Da_Tela";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(755, 379);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 58);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionar.Location = new System.Drawing.Point(674, 379);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 58);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.tabControlUsuario);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.tabControlUsuario.ResumeLayout(false);
            this.tabBusca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControlUsuario;
        private System.Windows.Forms.TabPage tabBusca;
        private System.Windows.Forms.TabPage tabCadastro;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnAdicionar;
        //public System.Windows.Forms.BindingSource bsDatagrid;
        public System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.GroupBox groupFiltros;
        public System.Windows.Forms.GroupBox gpbBase;
    }
}