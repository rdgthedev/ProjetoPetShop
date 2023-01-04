namespace PetShop_WINDOWSFORM
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._label_Titutlo = new System.Windows.Forms.Label();
            this._txt_Senha = new System.Windows.Forms.TextBox();
            this._txt_Login = new System.Windows.Forms.TextBox();
            this._btn_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(487, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 27);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(585, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(489, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(489, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Usuário";
            // 
            // _label_Titutlo
            // 
            this._label_Titutlo.AutoSize = true;
            this._label_Titutlo.BackColor = System.Drawing.Color.Transparent;
            this._label_Titutlo.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this._label_Titutlo.Location = new System.Drawing.Point(500, 210);
            this._label_Titutlo.Name = "_label_Titutlo";
            this._label_Titutlo.Size = new System.Drawing.Size(175, 46);
            this._label_Titutlo.TabIndex = 9;
            this._label_Titutlo.Text = "Pet Shop";
            this._label_Titutlo.Click += new System.EventHandler(this._label_Titutlo_Click);
            // 
            // _txt_Senha
            // 
            this._txt_Senha.Location = new System.Drawing.Point(487, 390);
            this._txt_Senha.Name = "_txt_Senha";
            this._txt_Senha.PasswordChar = '*';
            this._txt_Senha.Size = new System.Drawing.Size(177, 23);
            this._txt_Senha.TabIndex = 8;
            // 
            // _txt_Login
            // 
            this._txt_Login.Location = new System.Drawing.Point(487, 339);
            this._txt_Login.Name = "_txt_Login";
            this._txt_Login.Size = new System.Drawing.Size(177, 23);
            this._txt_Login.TabIndex = 7;
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
            this._btn_Fechar.Location = new System.Drawing.Point(1030, 12);
            this._btn_Fechar.Name = "_btn_Fechar";
            this._btn_Fechar.Size = new System.Drawing.Size(77, 43);
            this._btn_Fechar.TabIndex = 14;
            this._btn_Fechar.UseVisualStyleBackColor = false;
            this._btn_Fechar.Click += new System.EventHandler(this._btn_Fechar_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1104, 711);
            this.Controls.Add(this._btn_Fechar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._label_Titutlo);
            this.Controls.Add(this._txt_Senha);
            this.Controls.Add(this._txt_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label _label_Titutlo;
        private TextBox _txt_Senha;
        private TextBox _txt_Login;
        private Button _btn_Fechar;
    }
}