namespace WinForms_SimpleCalculator
{
    partial class frm_Help
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
            this.lbl_Help = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Help
            // 
            this.lbl_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Help.Location = new System.Drawing.Point(28, 110);
            this.lbl_Help.Name = "lbl_Help";
            this.lbl_Help.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lbl_Help.Size = new System.Drawing.Size(710, 30);
            this.lbl_Help.TabIndex = 0;
            this.lbl_Help.Text = "You should try to Google it... \r\nthats what my insturctor tells me works!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "That\'s Not Helpful!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Help);
            this.Name = "frm_Help";
            this.Text = "frm_Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lbl_Help;
        private System.Windows.Forms.Button button1;
    }
}