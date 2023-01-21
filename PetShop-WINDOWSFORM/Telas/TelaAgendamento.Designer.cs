namespace PetShop_WINDOWSFORM.Telas
{
    partial class TelaAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAgendamento));
            this._masked_hora = new System.Windows.Forms.MaskedTextBox();
            this._label_titleAgend = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._btn_Voltar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Verificar = new System.Windows.Forms.Button();
            this.cl_Servicos = new System.Windows.Forms.CheckedListBox();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _masked_hora
            // 
            this._masked_hora.Location = new System.Drawing.Point(557, 216);
            this._masked_hora.Mask = "00:00";
            this._masked_hora.Name = "_masked_hora";
            this._masked_hora.Size = new System.Drawing.Size(45, 23);
            this._masked_hora.TabIndex = 59;
            this._masked_hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._masked_hora.ValidatingType = typeof(System.DateTime);
            // 
            // _label_titleAgend
            // 
            this._label_titleAgend.AutoSize = true;
            this._label_titleAgend.BackColor = System.Drawing.Color.Transparent;
            this._label_titleAgend.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this._label_titleAgend.ForeColor = System.Drawing.Color.Black;
            this._label_titleAgend.Location = new System.Drawing.Point(319, 136);
            this._label_titleAgend.Name = "_label_titleAgend";
            this._label_titleAgend.Size = new System.Drawing.Size(281, 46);
            this._label_titleAgend.TabIndex = 60;
            this._label_titleAgend.Text = "Agendamento";
            this._label_titleAgend.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(417, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 57;
            this.label5.Text = "Serviços";
            // 
            // _btn_Voltar
            // 
            this._btn_Voltar.AllowDrop = true;
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
            this._btn_Voltar.TabIndex = 64;
            this._btn_Voltar.UseVisualStyleBackColor = false;
            this._btn_Voltar.Click += new System.EventHandler(this._btn_Voltar_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(317, 216);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 23);
            this.dateTimePicker1.TabIndex = 65;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_Verificar
            // 
            this.btn_Verificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Verificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Verificar.Location = new System.Drawing.Point(611, 216);
            this.btn_Verificar.Name = "btn_Verificar";
            this.btn_Verificar.Size = new System.Drawing.Size(70, 23);
            this.btn_Verificar.TabIndex = 71;
            this.btn_Verificar.Text = "Verificar";
            this.btn_Verificar.UseVisualStyleBackColor = true;
            this.btn_Verificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cl_Servicos
            // 
            this.cl_Servicos.FormattingEnabled = true;
            this.cl_Servicos.Location = new System.Drawing.Point(317, 293);
            this.cl_Servicos.Name = "cl_Servicos";
            this.cl_Servicos.Size = new System.Drawing.Size(285, 148);
            this.cl_Servicos.TabIndex = 72;
            this.cl_Servicos.SelectedIndexChanged += new System.EventHandler(this.cl_Servicos_SelectedIndexChanged);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Confirmar.Location = new System.Drawing.Point(398, 455);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(128, 37);
            this.btn_Confirmar.TabIndex = 73;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // TelaAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(903, 640);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.cl_Servicos);
            this.Controls.Add(this.btn_Verificar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this._btn_Voltar);
            this.Controls.Add(this._masked_hora);
            this.Controls.Add(this._label_titleAgend);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaAgendamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaskedTextBox _masked_hora;
        private Label _label_titleAgend;
        private Label label5;
        private Button _btn_Voltar;
        private DateTimePicker dateTimePicker1;
        private Button btn_Verificar;
        private CheckedListBox cl_Servicos;
        private Button btn_Confirmar;
    }
}