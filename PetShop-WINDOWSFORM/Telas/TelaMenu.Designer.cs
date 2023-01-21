namespace PetShop_WINDOWSFORM
{
    partial class TelaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMenu));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pn_opcoes = new System.Windows.Forms.Panel();
            this._btn_animal = new System.Windows.Forms.Button();
            this._btn_loja = new System.Windows.Forms.Button();
            this._btn_servicos = new System.Windows.Forms.Button();
            this._btn_sair = new System.Windows.Forms.Button();
            this._btn_agendamento = new System.Windows.Forms.Button();
            this.pn_central = new System.Windows.Forms.Panel();
            this._btn_fecharMenu = new System.Windows.Forms.Button();
            this._btn_Fechar = new System.Windows.Forms.Button();
            this.pn_opcoes.SuspendLayout();
            this.pn_central.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_opcoes
            // 
            this.pn_opcoes.BackColor = System.Drawing.Color.OldLace;
            this.pn_opcoes.Controls.Add(this._btn_animal);
            this.pn_opcoes.Controls.Add(this._btn_loja);
            this.pn_opcoes.Controls.Add(this._btn_servicos);
            this.pn_opcoes.Controls.Add(this._btn_sair);
            this.pn_opcoes.Controls.Add(this._btn_agendamento);
            this.pn_opcoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_opcoes.Location = new System.Drawing.Point(0, 0);
            this.pn_opcoes.Name = "pn_opcoes";
            this.pn_opcoes.Size = new System.Drawing.Size(200, 701);
            this.pn_opcoes.TabIndex = 0;
            // 
            // _btn_animal
            // 
            this._btn_animal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_animal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btn_animal.Location = new System.Drawing.Point(12, 200);
            this._btn_animal.Name = "_btn_animal";
            this._btn_animal.Size = new System.Drawing.Size(174, 43);
            this._btn_animal.TabIndex = 5;
            this._btn_animal.Text = "Animal";
            this._btn_animal.UseVisualStyleBackColor = true;
            // 
            // _btn_loja
            // 
            this._btn_loja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_loja.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btn_loja.Location = new System.Drawing.Point(12, 84);
            this._btn_loja.Name = "_btn_loja";
            this._btn_loja.Size = new System.Drawing.Size(174, 43);
            this._btn_loja.TabIndex = 3;
            this._btn_loja.Text = "Loja";
            this._btn_loja.UseVisualStyleBackColor = true;
            // 
            // _btn_servicos
            // 
            this._btn_servicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_servicos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btn_servicos.Location = new System.Drawing.Point(12, 142);
            this._btn_servicos.Name = "_btn_servicos";
            this._btn_servicos.Size = new System.Drawing.Size(174, 43);
            this._btn_servicos.TabIndex = 2;
            this._btn_servicos.Text = "Serviços";
            this._btn_servicos.UseVisualStyleBackColor = true;
            this._btn_servicos.Click += new System.EventHandler(this._btn_servicos_Click);
            // 
            // _btn_sair
            // 
            this._btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_sair.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btn_sair.Location = new System.Drawing.Point(12, 642);
            this._btn_sair.Name = "_btn_sair";
            this._btn_sair.Size = new System.Drawing.Size(174, 38);
            this._btn_sair.TabIndex = 1;
            this._btn_sair.Text = "Sair";
            this._btn_sair.UseVisualStyleBackColor = true;
            this._btn_sair.Click += new System.EventHandler(this._btn_sair_Click);
            // 
            // _btn_agendamento
            // 
            this._btn_agendamento.BackColor = System.Drawing.Color.Transparent;
            this._btn_agendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_agendamento.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btn_agendamento.Location = new System.Drawing.Point(12, 26);
            this._btn_agendamento.Name = "_btn_agendamento";
            this._btn_agendamento.Size = new System.Drawing.Size(174, 43);
            this._btn_agendamento.TabIndex = 0;
            this._btn_agendamento.Text = "Agendamento";
            this._btn_agendamento.UseVisualStyleBackColor = false;
            this._btn_agendamento.Click += new System.EventHandler(this.button1_Click);
            // 
            // pn_central
            // 
            this.pn_central.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_central.BackgroundImage")));
            this.pn_central.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_central.Controls.Add(this._btn_fecharMenu);
            this.pn_central.Controls.Add(this._btn_Fechar);
            this.pn_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_central.Location = new System.Drawing.Point(200, 0);
            this.pn_central.Name = "pn_central";
            this.pn_central.Size = new System.Drawing.Size(904, 701);
            this.pn_central.TabIndex = 1;
            // 
            // _btn_fecharMenu
            // 
            this._btn_fecharMenu.BackColor = System.Drawing.Color.Transparent;
            this._btn_fecharMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btn_fecharMenu.BackgroundImage")));
            this._btn_fecharMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btn_fecharMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btn_fecharMenu.FlatAppearance.BorderSize = 0;
            this._btn_fecharMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._btn_fecharMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._btn_fecharMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_fecharMenu.Location = new System.Drawing.Point(832, 6);
            this._btn_fecharMenu.Name = "_btn_fecharMenu";
            this._btn_fecharMenu.Size = new System.Drawing.Size(77, 43);
            this._btn_fecharMenu.TabIndex = 52;
            this._btn_fecharMenu.UseVisualStyleBackColor = false;
            this._btn_fecharMenu.Click += new System.EventHandler(this._btn_fecharMenu_Click);
            // 
            // _btn_Fechar
            // 
            this._btn_Fechar.BackColor = System.Drawing.Color.Transparent;
            this._btn_Fechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btn_Fechar.BackgroundImage")));
            this._btn_Fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btn_Fechar.FlatAppearance.BorderSize = 0;
            this._btn_Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._btn_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_Fechar.Location = new System.Drawing.Point(1033, 10);
            this._btn_Fechar.Name = "_btn_Fechar";
            this._btn_Fechar.Size = new System.Drawing.Size(77, 43);
            this._btn_Fechar.TabIndex = 51;
            this._btn_Fechar.UseVisualStyleBackColor = false;
            // 
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 701);
            this.Controls.Add(this.pn_central);
            this.Controls.Add(this.pn_opcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaMenu";
            this.pn_opcoes.ResumeLayout(false);
            this.pn_central.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel pn_opcoes;
        private Panel pn_central;
        private Button _btn_loja;
        private Button _btn_servicos;
        private Button _btn_sair;
        private Button _btn_agendamento;
        private Button _btn_animal;
        private Button _btn_Fechar;
        private Button _btn_fecharMenu;
    }
}