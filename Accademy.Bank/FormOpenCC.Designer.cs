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
            this.btn_manage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_manage
            // 
            this.btn_manage.Location = new System.Drawing.Point(129, 301);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(220, 56);
            this.btn_manage.TabIndex = 0;
            this.btn_manage.Text = "Manage CC";
            this.btn_manage.UseVisualStyleBackColor = true;
            this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
            // 
            // FormOpenCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_manage);
            this.Name = "FormOpenCC";
            this.Text = "FormOpenCC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_manage;
    }
}