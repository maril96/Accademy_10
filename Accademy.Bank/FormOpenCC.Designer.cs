namespace Accademy.Bank
{
    partial class FormOpenCC
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
            this.btn_conferma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_numeroconto = new System.Windows.Forms.Label();
            this.btn_annulla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cognome = new System.Windows.Forms.TextBox();
            this.txt_cf = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_conferma
            // 
            this.btn_conferma.Location = new System.Drawing.Point(127, 372);
            this.btn_conferma.Name = "btn_conferma";
            this.btn_conferma.Size = new System.Drawing.Size(173, 56);
            this.btn_conferma.TabIndex = 0;
            this.btn_conferma.Text = "Conferma";
            this.btn_conferma.UseVisualStyleBackColor = true;
            this.btn_conferma.Click += new System.EventHandler(this.btn_conferma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apertura Conto Corrente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Location = new System.Drawing.Point(160, 114);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(0, 20);
            this.lbl_cliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero Conto:";
            // 
            // lbl_numeroconto
            // 
            this.lbl_numeroconto.AutoSize = true;
            this.lbl_numeroconto.Location = new System.Drawing.Point(160, 162);
            this.lbl_numeroconto.Name = "lbl_numeroconto";
            this.lbl_numeroconto.Size = new System.Drawing.Size(0, 20);
            this.lbl_numeroconto.TabIndex = 5;
            // 
            // btn_annulla
            // 
            this.btn_annulla.Location = new System.Drawing.Point(340, 370);
            this.btn_annulla.Name = "btn_annulla";
            this.btn_annulla.Size = new System.Drawing.Size(187, 58);
            this.btn_annulla.TabIndex = 6;
            this.btn_annulla.Text = "Annulla";
            this.btn_annulla.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cognome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Codice Fiscale:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(222, 236);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(154, 26);
            this.txt_nome.TabIndex = 10;
            // 
            // txt_cognome
            // 
            this.txt_cognome.Location = new System.Drawing.Point(222, 279);
            this.txt_cognome.Name = "txt_cognome";
            this.txt_cognome.Size = new System.Drawing.Size(154, 26);
            this.txt_cognome.TabIndex = 11;
            // 
            // txt_cf
            // 
            this.txt_cf.Location = new System.Drawing.Point(222, 319);
            this.txt_cf.Name = "txt_cf";
            this.txt_cf.Size = new System.Drawing.Size(154, 26);
            this.txt_cf.TabIndex = 12;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(700, 26);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(88, 46);
            this.btn_close.TabIndex = 13;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_error.Location = new System.Drawing.Point(575, 278);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 37);
            this.lbl_error.TabIndex = 14;
            // 
            // FormOpenCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_cf);
            this.Controls.Add(this.txt_cognome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_annulla);
            this.Controls.Add(this.lbl_numeroconto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_conferma);
            this.Name = "FormOpenCC";
            this.Text = "FormOpenCC";
            this.Load += new System.EventHandler(this.FormOpenCC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_conferma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_numeroconto;
        private System.Windows.Forms.Button btn_annulla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cognome;
        private System.Windows.Forms.TextBox txt_cf;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_error;
    }
}