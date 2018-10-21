namespace WindowsFormsApplication1
{
    partial class frm_DrunkMessage
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
            this.btn_Drunk = new System.Windows.Forms.Button();
            this.lbl_Drunk = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Drunk
            // 
            this.btn_Drunk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Drunk.ForeColor = System.Drawing.Color.Red;
            this.btn_Drunk.Location = new System.Drawing.Point(455, 322);
            this.btn_Drunk.Name = "btn_Drunk";
            this.btn_Drunk.Size = new System.Drawing.Size(302, 82);
            this.btn_Drunk.TabIndex = 0;
            this.btn_Drunk.Text = "Ok I will come back later";
            this.btn_Drunk.UseVisualStyleBackColor = true;
            this.btn_Drunk.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Drunk
            // 
            this.lbl_Drunk.AutoSize = true;
            this.lbl_Drunk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Drunk.ForeColor = System.Drawing.Color.Red;
            this.lbl_Drunk.Location = new System.Drawing.Point(69, 161);
            this.lbl_Drunk.Name = "lbl_Drunk";
            this.lbl_Drunk.Size = new System.Drawing.Size(675, 37);
            this.lbl_Drunk.TabIndex = 1;
            this.lbl_Drunk.Text = "You should not be calcualting and drinking!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.bus5;
            this.pictureBox1.InitialImage = global::WindowsFormsApplication1.Properties.Resources.bus5;
            this.pictureBox1.Location = new System.Drawing.Point(12, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 199);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frm_DrunkMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Drunk);
            this.Controls.Add(this.btn_Drunk);
            this.Name = "frm_DrunkMessage";
            this.Text = "Go Sober Up!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Drunk;
        private System.Windows.Forms.Label lbl_Drunk;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}