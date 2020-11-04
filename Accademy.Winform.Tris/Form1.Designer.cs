using System.Windows.Forms;

namespace Accademy.Winform.Tris
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
            this.txt_00 = new System.Windows.Forms.TextBox();
            this.txt_01 = new System.Windows.Forms.TextBox();
            this.txt_02 = new System.Windows.Forms.TextBox();
            this.txt_10 = new System.Windows.Forms.TextBox();
            this.txt_11 = new System.Windows.Forms.TextBox();
            this.txt_12 = new System.Windows.Forms.TextBox();
            this.txt_20 = new System.Windows.Forms.TextBox();
            this.txt_21 = new System.Windows.Forms.TextBox();
            this.txt_22 = new System.Windows.Forms.TextBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_00
            // 
            this.txt_00.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_00.Location = new System.Drawing.Point(128, 108);
            this.txt_00.Name = "txt_00";
            this.txt_00.Size = new System.Drawing.Size(61, 61);
            this.txt_00.TabIndex = 0;
            this.txt_00.TextChanged += new System.EventHandler(this.txt_00_TextChanged);
            this.txt_00.KeyPress += new KeyPressEventHandler(this.txt_00_KeyPress);
            this.txt_00.KeyDown += new KeyEventHandler(this.txt_00_KeyDown);
            // 
            // txt_01
            // 
            this.txt_01.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_01.Location = new System.Drawing.Point(195, 108);
            this.txt_01.Name = "txt_01";
            this.txt_01.Size = new System.Drawing.Size(61, 61);
            this.txt_01.TabIndex = 0;
            this.txt_01.TextChanged += new System.EventHandler(this.txt_01_TextChanged);
            // 
            // txt_02
            // 
            this.txt_02.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_02.Location = new System.Drawing.Point(262, 108);
            this.txt_02.Name = "txt_02";
            this.txt_02.Size = new System.Drawing.Size(61, 61);
            this.txt_02.TabIndex = 0;
            this.txt_02.TextChanged += new System.EventHandler(this.txt_02_TextChanged);
            // 
            // txt_10
            // 
            this.txt_10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_10.Location = new System.Drawing.Point(128, 175);
            this.txt_10.Name = "txt_10";
            this.txt_10.Size = new System.Drawing.Size(61, 61);
            this.txt_10.TabIndex = 0;
            this.txt_10.TextChanged += new System.EventHandler(this.txt_10_TextChanged);
            // 
            // txt_11
            // 
            this.txt_11.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_11.Location = new System.Drawing.Point(195, 175);
            this.txt_11.Name = "txt_11";
            this.txt_11.Size = new System.Drawing.Size(61, 61);
            this.txt_11.TabIndex = 0;
            this.txt_11.TextChanged += new System.EventHandler(this.txt_11_TextChanged);
            // 
            // txt_12
            // 
            this.txt_12.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_12.Location = new System.Drawing.Point(262, 175);
            this.txt_12.Name = "txt_12";
            this.txt_12.Size = new System.Drawing.Size(61, 61);
            this.txt_12.TabIndex = 0;
            this.txt_12.TextChanged += new System.EventHandler(this.txt_12_TextChanged);
            // 
            // txt_20
            // 
            this.txt_20.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_20.Location = new System.Drawing.Point(128, 242);
            this.txt_20.Name = "txt_20";
            this.txt_20.Size = new System.Drawing.Size(61, 61);
            this.txt_20.TabIndex = 0;
            this.txt_20.TextChanged += new System.EventHandler(this.txt_20_TextChanged);
            // 
            // txt_21
            // 
            this.txt_21.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_21.Location = new System.Drawing.Point(195, 242);
            this.txt_21.Name = "txt_21";
            this.txt_21.Size = new System.Drawing.Size(61, 61);
            this.txt_21.TabIndex = 0;
            this.txt_21.TextChanged += new System.EventHandler(this.txt_21_TextChanged);
            // 
            // txt_22
            // 
            this.txt_22.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_22.Location = new System.Drawing.Point(262, 242);
            this.txt_22.Name = "txt_22";
            this.txt_22.Size = new System.Drawing.Size(61, 61);
            this.txt_22.TabIndex = 0;
            this.txt_22.TextChanged += new System.EventHandler(this.txt_22_TextChanged);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(128, 394);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 54);
            this.lbl_error.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.txt_22);
            this.Controls.Add(this.txt_21);
            this.Controls.Add(this.txt_20);
            this.Controls.Add(this.txt_12);
            this.Controls.Add(this.txt_11);
            this.Controls.Add(this.txt_10);
            this.Controls.Add(this.txt_02);
            this.Controls.Add(this.txt_01);
            this.Controls.Add(this.txt_00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_00;
        private System.Windows.Forms.TextBox txt_01;
        private System.Windows.Forms.TextBox txt_02;
        private System.Windows.Forms.TextBox txt_10;
        private System.Windows.Forms.TextBox txt_11;
        private System.Windows.Forms.TextBox txt_12;
        private System.Windows.Forms.TextBox txt_20;
        private System.Windows.Forms.TextBox txt_21;
        private System.Windows.Forms.TextBox txt_22;
        private System.Windows.Forms.Label lbl_error;
    }
}

