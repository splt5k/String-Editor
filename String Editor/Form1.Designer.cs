namespace String_Editor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbGeral = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbBuscar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gbEditar = new System.Windows.Forms.GroupBox();
            this.lbSucesso = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbDescr2 = new System.Windows.Forms.Label();
            this.lbDescr = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.cb_idioma = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.gbGeral.SuspendLayout();
            this.gbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_arquivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_arquivo
            // 
            this.menu_arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_abrir,
            this.menu_salvar,
            this.menu_sair});
            this.menu_arquivo.Name = "menu_arquivo";
            this.menu_arquivo.Size = new System.Drawing.Size(61, 20);
            this.menu_arquivo.Text = "Arquivo";
            // 
            // menu_abrir
            // 
            this.menu_abrir.Name = "menu_abrir";
            this.menu_abrir.Size = new System.Drawing.Size(105, 22);
            this.menu_abrir.Text = "Abrir";
            this.menu_abrir.Click += new System.EventHandler(this.menu_abrir_Click);
            // 
            // menu_salvar
            // 
            this.menu_salvar.Enabled = false;
            this.menu_salvar.Name = "menu_salvar";
            this.menu_salvar.Size = new System.Drawing.Size(105, 22);
            this.menu_salvar.Text = "Salvar";
            this.menu_salvar.Click += new System.EventHandler(this.menu_salvar_Click);
            // 
            // menu_sair
            // 
            this.menu_sair.Name = "menu_sair";
            this.menu_sair.Size = new System.Drawing.Size(105, 22);
            this.menu_sair.Text = "Sair";
            this.menu_sair.Click += new System.EventHandler(this.menu_sair_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 381);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // gbGeral
            // 
            this.gbGeral.Controls.Add(this.button1);
            this.gbGeral.Controls.Add(this.lbBuscar);
            this.gbGeral.Controls.Add(this.linkLabel1);
            this.gbGeral.Controls.Add(this.gbEditar);
            this.gbGeral.Controls.Add(this.listBox1);
            this.gbGeral.Controls.Add(this.textBox1);
            this.gbGeral.Enabled = false;
            this.gbGeral.Location = new System.Drawing.Point(12, 27);
            this.gbGeral.Name = "gbGeral";
            this.gbGeral.Size = new System.Drawing.Size(833, 452);
            this.gbGeral.TabIndex = 7;
            this.gbGeral.TabStop = false;
            this.gbGeral.Text = "Geral";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Update DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbBuscar
            // 
            this.lbBuscar.Location = new System.Drawing.Point(243, 30);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(74, 23);
            this.lbBuscar.TabIndex = 6;
            this.lbBuscar.Text = "Buscar";
            this.lbBuscar.UseVisualStyleBackColor = true;
            this.lbBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(421, 331);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(302, 39);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Fenix Last Chaos";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // gbEditar
            // 
            this.gbEditar.Controls.Add(this.lbSucesso);
            this.gbEditar.Controls.Add(this.btnGravar);
            this.gbEditar.Controls.Add(this.textBox5);
            this.gbEditar.Controls.Add(this.textBox4);
            this.gbEditar.Controls.Add(this.textBox3);
            this.gbEditar.Controls.Add(this.textBox2);
            this.gbEditar.Controls.Add(this.lbDescr2);
            this.gbEditar.Controls.Add(this.lbDescr);
            this.gbEditar.Controls.Add(this.lbNome);
            this.gbEditar.Controls.Add(this.lbID);
            this.gbEditar.Location = new System.Drawing.Point(335, 35);
            this.gbEditar.Name = "gbEditar";
            this.gbEditar.Size = new System.Drawing.Size(483, 260);
            this.gbEditar.TabIndex = 7;
            this.gbEditar.TabStop = false;
            this.gbEditar.Text = "Editar";
            // 
            // lbSucesso
            // 
            this.lbSucesso.AutoSize = true;
            this.lbSucesso.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbSucesso.Location = new System.Drawing.Point(159, 172);
            this.lbSucesso.Name = "lbSucesso";
            this.lbSucesso.Size = new System.Drawing.Size(155, 13);
            this.lbSucesso.TabIndex = 13;
            this.lbSucesso.Text = "Alterações salvas com sucesso";
            this.lbSucesso.Visible = false;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(345, 167);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(118, 23);
            this.btnGravar.TabIndex = 12;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(93, 124);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(370, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(93, 98);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(370, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(262, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 20);
            this.textBox2.TabIndex = 8;
            // 
            // lbDescr2
            // 
            this.lbDescr2.AutoSize = true;
            this.lbDescr2.Location = new System.Drawing.Point(39, 127);
            this.lbDescr2.Name = "lbDescr2";
            this.lbDescr2.Size = new System.Drawing.Size(41, 13);
            this.lbDescr2.TabIndex = 3;
            this.lbDescr2.Text = "Descr2";
            // 
            // lbDescr
            // 
            this.lbDescr.AutoSize = true;
            this.lbDescr.Location = new System.Drawing.Point(46, 101);
            this.lbDescr.Name = "lbDescr";
            this.lbDescr.Size = new System.Drawing.Size(35, 13);
            this.lbDescr.TabIndex = 2;
            this.lbDescr.Text = "Descr";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(46, 75);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(34, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "String";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(63, 49);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 13);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID";
            // 
            // cb_idioma
            // 
            this.cb_idioma.FormattingEnabled = true;
            this.cb_idioma.Location = new System.Drawing.Point(724, 3);
            this.cb_idioma.Name = "cb_idioma";
            this.cb_idioma.Size = new System.Drawing.Size(121, 21);
            this.cb_idioma.TabIndex = 8;
            this.cb_idioma.SelectedIndexChanged += new System.EventHandler(this.cb_idioma_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 485);
            this.Controls.Add(this.cb_idioma);
            this.Controls.Add(this.gbGeral);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fenix LastChaos - String Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbGeral.ResumeLayout(false);
            this.gbGeral.PerformLayout();
            this.gbEditar.ResumeLayout(false);
            this.gbEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_arquivo;
        private System.Windows.Forms.ToolStripMenuItem menu_abrir;
        private System.Windows.Forms.ToolStripMenuItem menu_salvar;
        private System.Windows.Forms.ToolStripMenuItem menu_sair;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox gbGeral;
        private System.Windows.Forms.GroupBox gbEditar;
        private System.Windows.Forms.Label lbSucesso;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbDescr2;
        private System.Windows.Forms.Label lbDescr;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cb_idioma;
        private System.Windows.Forms.Button lbBuscar;
        private System.Windows.Forms.Button button1;
    }
}

