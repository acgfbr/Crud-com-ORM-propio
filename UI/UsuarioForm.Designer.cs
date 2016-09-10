namespace UI
{
    partial class UsuarioForm
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
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioForm));
            this.tabControlUsuario = new System.Windows.Forms.TabControl();
            this.tabBusca = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.ckativo = new System.Windows.Forms.CheckBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.bsUsuario = new System.Windows.Forms.BindingSource(this.components);
            this.bsDatagrid = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            label5 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.tabControlUsuario.SuspendLayout();
            this.tabBusca.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDatagrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(6, 19);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 16);
            label5.TabIndex = 162;
            label5.Text = "Código";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(312, 19);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(42, 16);
            label8.TabIndex = 75;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(6, 63);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(58, 16);
            label7.TabIndex = 73;
            label7.Text = "Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(261, 63);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 16);
            label3.TabIndex = 69;
            label3.Text = "Senha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(99, 19);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(45, 16);
            label6.TabIndex = 53;
            label6.Text = "Nome";
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
            this.tabControlUsuario.TabIndex = 3;
            // 
            // tabBusca
            // 
            this.tabBusca.AutoScroll = true;
            this.tabBusca.BackColor = System.Drawing.Color.Transparent;
            this.tabBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabBusca.Controls.Add(this.dataGridView);
            this.tabBusca.Controls.Add(this.groupBox1);
            this.tabBusca.Location = new System.Drawing.Point(4, 34);
            this.tabBusca.Name = "tabBusca";
            this.tabBusca.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusca.Size = new System.Drawing.Size(1000, 692);
            this.tabBusca.TabIndex = 0;
            this.tabBusca.Tag = "busca";
            this.tabBusca.Text = "Consulta";
            this.tabBusca.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBusca);
            this.groupBox1.Controls.Add(this.tbBusca);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome/Usuário:";
            // 
            // btnBusca
            // 
            this.btnBusca.Image = ((System.Drawing.Image)(resources.GetObject("btnBusca.Image")));
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(555, 23);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(141, 32);
            this.btnBusca.TabIndex = 1;
            this.btnBusca.Text = "Busca";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // tbBusca
            // 
            this.tbBusca.Location = new System.Drawing.Point(111, 28);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(417, 22);
            this.tbBusca.TabIndex = 0;
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.groupBox3);
            this.tabCadastro.Location = new System.Drawing.Point(4, 34);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(1000, 692);
            this.tabCadastro.TabIndex = 4;
            this.tabCadastro.Text = "Cadastro";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.btnExcluir);
            this.groupBox3.Controls.Add(this.btnEditar);
            this.groupBox3.Controls.Add(this.btnSalvar);
            this.groupBox3.Controls.Add(this.btnNovo);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(994, 686);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do Usuário";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(6, 38);
            this.tbID.MaxLength = 200;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(93, 22);
            this.tbID.TabIndex = 0;
            // 
            // ckativo
            // 
            this.ckativo.AutoSize = true;
            this.ckativo.Checked = true;
            this.ckativo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckativo.Enabled = false;
            this.ckativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckativo.Location = new System.Drawing.Point(521, 82);
            this.ckativo.Name = "ckativo";
            this.ckativo.Size = new System.Drawing.Size(110, 20);
            this.ckativo.TabIndex = 8;
            this.ckativo.Text = "Registro ativo";
            this.ckativo.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(571, 148);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 58);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(490, 148);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 58);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(409, 148);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 58);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(328, 148);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 58);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(315, 38);
            this.tbEmail.MaxLength = 200;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(197, 22);
            this.tbEmail.TabIndex = 3;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Enabled = false;
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(6, 82);
            this.tbUsuario.MaxLength = 200;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(251, 22);
            this.tbUsuario.TabIndex = 4;
            // 
            // tbSenha
            // 
            this.tbSenha.Enabled = false;
            this.tbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenha.Location = new System.Drawing.Point(264, 82);
            this.tbSenha.MaxLength = 200;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(251, 22);
            this.tbSenha.TabIndex = 6;
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(102, 38);
            this.tbNome.MaxLength = 200;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(209, 22);
            this.tbNome.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(label5);
            this.groupBox2.Controls.Add(this.tbID);
            this.groupBox2.Controls.Add(this.tbNome);
            this.groupBox2.Controls.Add(label6);
            this.groupBox2.Controls.Add(this.ckativo);
            this.groupBox2.Controls.Add(this.tbSenha);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.tbUsuario);
            this.groupBox2.Controls.Add(label7);
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Controls.Add(label8);
            this.groupBox2.Location = new System.Drawing.Point(6, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 108);
            this.groupBox2.TabIndex = 163;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 76);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(994, 613);
            this.dataGridView.TabIndex = 5;
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.tabControlUsuario);
            this.Name = "UsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.tabControlUsuario.ResumeLayout(false);
            this.tabBusca.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabCadastro.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDatagrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControlUsuario;
        private System.Windows.Forms.TabPage tabBusca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBusca;
        public System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox tbID;
        public System.Windows.Forms.CheckBox ckativo;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnNovo;
        public System.Windows.Forms.TextBox tbEmail;
        public System.Windows.Forms.TextBox tbUsuario;
        public System.Windows.Forms.TextBox tbSenha;
        public System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.BindingSource bsUsuario;
        private System.Windows.Forms.BindingSource bsDatagrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}