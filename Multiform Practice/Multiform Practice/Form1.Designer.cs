namespace Multiform_Practice
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
            this.MainForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.MainForm.Location = new System.Drawing.Point(54, 107);
            this.MainForm.Name = "MainForm";
            this.MainForm.Size = new System.Drawing.Size(75, 23);
            this.MainForm.TabIndex = 0;
            this.MainForm.Text = "Display Form";
            this.MainForm.UseVisualStyleBackColor = true;
            this.MainForm.Click += new System.EventHandler(this.MainForm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MainForm);
            this.Name = "Form1";
            this.Text = "Multiform Practice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainForm;
        private System.Windows.Forms.Button button2;
    }
}

