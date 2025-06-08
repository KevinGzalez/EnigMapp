namespace EnigMapp_1._1
{
    partial class Form1
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
            lblEntrada = new Label();
            txtEntrada = new RichTextBox();
            lblPosiciones = new Label();
            txtPosiciones = new TextBox();
            btnCifrar = new Button();
            lblSalida = new Label();
            txtSalida = new RichTextBox();
            Credits = new Label();
            KevinG = new LinkLabel();
            SuspendLayout();
            // 
            // lblEntrada
            // 
            lblEntrada.AutoSize = true;
            lblEntrada.Location = new Point(12, 31);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(158, 20);
            lblEntrada.TabIndex = 0;
            lblEntrada.Text = "Texto a cifrar/descifrar";
            lblEntrada.Click += label1_Click_1;
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(12, 63);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(769, 91);
            txtEntrada.TabIndex = 1;
            txtEntrada.Text = "";
            // 
            // lblPosiciones
            // 
            lblPosiciones.AutoSize = true;
            lblPosiciones.Location = new Point(12, 167);
            lblPosiciones.Name = "lblPosiciones";
            lblPosiciones.Size = new Size(219, 20);
            lblPosiciones.TabIndex = 2;
            lblPosiciones.Text = "Posición de los rotores (Ej: ABC)";
            lblPosiciones.Click += lblPosiciones_Click;
            // 
            // txtPosiciones
            // 
            txtPosiciones.CharacterCasing = CharacterCasing.Upper;
            txtPosiciones.Location = new Point(12, 200);
            txtPosiciones.MaxLength = 3;
            txtPosiciones.Name = "txtPosiciones";
            txtPosiciones.Size = new Size(236, 27);
            txtPosiciones.TabIndex = 3;
            // 
            // btnCifrar
            // 
            btnCifrar.Location = new Point(12, 243);
            btnCifrar.Name = "btnCifrar";
            btnCifrar.Size = new Size(113, 32);
            btnCifrar.TabIndex = 4;
            btnCifrar.Text = "Cifrar";
            btnCifrar.UseVisualStyleBackColor = true;
            btnCifrar.Click += btnCifrar_Click_1;
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Location = new Point(12, 290);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(75, 20);
            lblSalida.TabIndex = 6;
            lblSalida.Text = "Resultado";
            // 
            // txtSalida
            // 
            txtSalida.Location = new Point(12, 325);
            txtSalida.Name = "txtSalida";
            txtSalida.ReadOnly = true;
            txtSalida.Size = new Size(769, 93);
            txtSalida.TabIndex = 7;
            txtSalida.Text = "";
            // 
            // Credits
            // 
            Credits.AutoSize = true;
            Credits.Location = new Point(615, 421);
            Credits.Name = "Credits";
            Credits.Size = new Size(84, 20);
            Credits.TabIndex = 8;
            Credits.Text = "Created By:";
            // 
            // KevinG
            // 
            KevinG.AutoSize = true;
            KevinG.Location = new Point(705, 421);
            KevinG.Name = "KevinG";
            KevinG.Size = new Size(59, 20);
            KevinG.TabIndex = 9;
            KevinG.TabStop = true;
            KevinG.Text = "Kevin G";
            KevinG.LinkClicked += KevinG_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(KevinG);
            Controls.Add(Credits);
            Controls.Add(txtSalida);
            Controls.Add(lblSalida);
            Controls.Add(btnCifrar);
            Controls.Add(txtPosiciones);
            Controls.Add(lblPosiciones);
            Controls.Add(txtEntrada);
            Controls.Add(lblEntrada);
            Name = "Form1";
            Text = "EnigMapp 1.1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEntrada;
        private RichTextBox txtEntrada;
        private Label lblPosiciones;
        private TextBox txtPosiciones;
        private Button btnCifrar;
        private Label lblSalida;
        private RichTextBox txtSalida;
        private Label Credits;
        private LinkLabel KevinG;
    }
}
