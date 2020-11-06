namespace Accademy.Bank
{
    partial class FormManageCC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_numconto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_importo = new System.Windows.Forms.TextBox();
            this.btn_preleva = new System.Windows.Forms.Button();
            this.btn_versa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_importo_bonifico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_beneficiario = new System.Windows.Forms.TextBox();
            this.btn_bonifico = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_movimenti = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestisci il tuo conto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Conto:";
            // 
            // lbl_numconto
            // 
            this.lbl_numconto.AutoSize = true;
            this.lbl_numconto.Location = new System.Drawing.Point(208, 128);
            this.lbl_numconto.Name = "lbl_numconto";
            this.lbl_numconto.Size = new System.Drawing.Size(0, 20);
            this.lbl_numconto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saldo:";
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(140, 169);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(0, 20);
            this.lbl_saldo.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_versa);
            this.panel1.Controls.Add(this.btn_preleva);
            this.panel1.Controls.Add(this.txt_importo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(62, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 137);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Importo:";
            // 
            // txt_importo
            // 
            this.txt_importo.Location = new System.Drawing.Point(101, 15);
            this.txt_importo.Name = "txt_importo";
            this.txt_importo.Size = new System.Drawing.Size(100, 26);
            this.txt_importo.TabIndex = 1;
            // 
            // btn_preleva
            // 
            this.btn_preleva.Location = new System.Drawing.Point(321, 15);
            this.btn_preleva.Name = "btn_preleva";
            this.btn_preleva.Size = new System.Drawing.Size(75, 34);
            this.btn_preleva.TabIndex = 2;
            this.btn_preleva.Text = "Preleva";
            this.btn_preleva.UseVisualStyleBackColor = true;
            // 
            // btn_versa
            // 
            this.btn_versa.Location = new System.Drawing.Point(321, 73);
            this.btn_versa.Name = "btn_versa";
            this.btn_versa.Size = new System.Drawing.Size(75, 34);
            this.btn_versa.TabIndex = 3;
            this.btn_versa.Text = "Versa";
            this.btn_versa.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btn_bonifico);
            this.panel2.Controls.Add(this.txt_beneficiario);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_importo_bonifico);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(62, 413);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 113);
            this.panel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Importo:";
            // 
            // txt_importo_bonifico
            // 
            this.txt_importo_bonifico.Location = new System.Drawing.Point(150, 19);
            this.txt_importo_bonifico.Name = "txt_importo_bonifico";
            this.txt_importo_bonifico.Size = new System.Drawing.Size(100, 26);
            this.txt_importo_bonifico.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Beneficiario:";
            // 
            // txt_beneficiario
            // 
            this.txt_beneficiario.Location = new System.Drawing.Point(150, 60);
            this.txt_beneficiario.Name = "txt_beneficiario";
            this.txt_beneficiario.Size = new System.Drawing.Size(100, 26);
            this.txt_beneficiario.TabIndex = 3;
            // 
            // btn_bonifico
            // 
            this.btn_bonifico.Location = new System.Drawing.Point(365, 22);
            this.btn_bonifico.Name = "btn_bonifico";
            this.btn_bonifico.Size = new System.Drawing.Size(74, 56);
            this.btn_bonifico.TabIndex = 4;
            this.btn_bonifico.Text = "Esegui Bonifico";
            this.btn_bonifico.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.lbl_movimenti);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(620, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 421);
            this.panel3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Movimenti:";
            // 
            // lbl_movimenti
            // 
            this.lbl_movimenti.AutoSize = true;
            this.lbl_movimenti.Location = new System.Drawing.Point(33, 64);
            this.lbl_movimenti.Name = "lbl_movimenti";
            this.lbl_movimenti.Size = new System.Drawing.Size(0, 20);
            this.lbl_movimenti.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(792, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 34);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // FormManageCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 554);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_saldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_numconto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormManageCC";
            this.Text = "FormManageCC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_numconto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_versa;
        private System.Windows.Forms.Button btn_preleva;
        private System.Windows.Forms.TextBox txt_importo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_bonifico;
        private System.Windows.Forms.TextBox txt_beneficiario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_importo_bonifico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_movimenti;
        private System.Windows.Forms.Button btn_close;
    }
}