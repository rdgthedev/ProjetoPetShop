namespace PetShop_WINDOWSFORM.Telas
{
    partial class TelaServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaServicos));
            this._lv_servicos = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.servico = new System.Windows.Forms.ColumnHeader();
            this.preco = new System.Windows.Forms.ColumnHeader();
            this._label_Servicos = new System.Windows.Forms.Label();
            this._btn_Voltar = new System.Windows.Forms.Button();
            this._btn_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lv_servicos
            // 
            this._lv_servicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.servico,
            this.preco});
            this._lv_servicos.Location = new System.Drawing.Point(322, 217);
            this._lv_servicos.Name = "_lv_servicos";
            this._lv_servicos.Size = new System.Drawing.Size(327, 257);
            this._lv_servicos.TabIndex = 0;
            this._lv_servicos.UseCompatibleStateImageBehavior = false;
            this._lv_servicos.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 30;
            // 
            // servico
            // 
            this.servico.Text = "Serviço";
            this.servico.Width = 150;
            // 
            // preco
            // 
            this.preco.Tag = "";
            this.preco.Text = "Preço";
            this.preco.Width = 150;
            // 
            // _label_Servicos
            // 
            this._label_Servicos.AutoSize = true;
            this._label_Servicos.BackColor = System.Drawing.Color.Transparent;
            this._label_Servicos.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this._label_Servicos.ForeColor = System.Drawing.Color.Black;
            this._label_Servicos.Location = new System.Drawing.Point(402, 139);
            this._label_Servicos.Name = "_label_Servicos";
            this._label_Servicos.Size = new System.Drawing.Size(169, 46);
            this._label_Servicos.TabIndex = 61;
            this._label_Servicos.Text = "Serviços";
            this._label_Servicos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._label_Servicos.Click += new System.EventHandler(this._label_Servicos_Click);
            // 
            // _btn_Voltar
            // 
            this._btn_Voltar.BackColor = System.Drawing.Color.Transparent;
            this._btn_Voltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btn_Voltar.BackgroundImage")));
            this._btn_Voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btn_Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btn_Voltar.FlatAppearance.BorderSize = 0;
            this._btn_Voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._btn_Voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_Voltar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btn_Voltar.Location = new System.Drawing.Point(-9, 9);
            this._btn_Voltar.Margin = new System.Windows.Forms.Padding(0);
            this._btn_Voltar.Name = "_btn_Voltar";
            this._btn_Voltar.Size = new System.Drawing.Size(99, 44);
            this._btn_Voltar.TabIndex = 62;
            this._btn_Voltar.UseVisualStyleBackColor = false;
            this._btn_Voltar.Click += new System.EventHandler(this._btn_Voltar_Click);
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
            this._btn_Fechar.Location = new System.Drawing.Point(1018, 8);
            this._btn_Fechar.Name = "_btn_Fechar";
            this._btn_Fechar.Size = new System.Drawing.Size(77, 43);
            this._btn_Fechar.TabIndex = 63;
            this._btn_Fechar.UseVisualStyleBackColor = false;
            // 
            // TelaServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1088, 662);
            this.Controls.Add(this._btn_Fechar);
            this.Controls.Add(this._btn_Voltar);
            this.Controls.Add(this._label_Servicos);
            this.Controls.Add(this._lv_servicos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(317, 293);
            this.Name = "TelaServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaServicos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView _lv_servicos;
        private Label _label_Servicos;
        private ColumnHeader servico;
        private ColumnHeader preco;
        private ColumnHeader id;
        private Button _btn_Voltar;
        private Button _btn_Fechar;
    }
}