namespace WinForms_SimpleCalculator
{
    partial class Simple_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simple_Calculator));
            this.Hlavka_Calculator = new System.Windows.Forms.Label();
            this.lbl_DrunksPerBus = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.lbl_NumberOfBuses = new System.Windows.Forms.Label();
            this.txtbox_ClownsPerCar = new System.Windows.Forms.TextBox();
            this.txtbox_NumberOfCars = new System.Windows.Forms.TextBox();
            this.txtbox_TotalClowns = new System.Windows.Forms.TextBox();
            this.btn_Help = new System.Windows.Forms.Button();
            this.radBtnNotDrunk = new System.Windows.Forms.RadioButton();
            this.radBtnDrunk = new System.Windows.Forms.RadioButton();
            this.picBoxFlagBus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFlagBus)).BeginInit();
            this.SuspendLayout();
            // 
            // Hlavka_Calculator
            // 
            this.Hlavka_Calculator.AutoSize = true;
            this.Hlavka_Calculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hlavka_Calculator.ForeColor = System.Drawing.Color.Red;
            this.Hlavka_Calculator.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Hlavka_Calculator.Location = new System.Drawing.Point(89, 20);
            this.Hlavka_Calculator.Name = "Hlavka_Calculator";
            this.Hlavka_Calculator.Size = new System.Drawing.Size(282, 32);
            this.Hlavka_Calculator.TabIndex = 0;
            this.Hlavka_Calculator.Text = "The Drunk Calculator";
            this.Hlavka_Calculator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_DrunksPerBus
            // 
            this.lbl_DrunksPerBus.AutoSize = true;
            this.lbl_DrunksPerBus.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_DrunksPerBus.Location = new System.Drawing.Point(30, 166);
            this.lbl_DrunksPerBus.Name = "lbl_DrunksPerBus";
            this.lbl_DrunksPerBus.Size = new System.Drawing.Size(120, 20);
            this.lbl_DrunksPerBus.TabIndex = 1;
            this.lbl_DrunksPerBus.Text = "Drunks Per Bus";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(33, 246);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(101, 35);
            this.btn_Calculate.TabIndex = 2;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // lbl_NumberOfBuses
            // 
            this.lbl_NumberOfBuses.AutoSize = true;
            this.lbl_NumberOfBuses.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_NumberOfBuses.Location = new System.Drawing.Point(29, 206);
            this.lbl_NumberOfBuses.Name = "lbl_NumberOfBuses";
            this.lbl_NumberOfBuses.Size = new System.Drawing.Size(135, 20);
            this.lbl_NumberOfBuses.TabIndex = 3;
            this.lbl_NumberOfBuses.Text = "Number Of Buses";
            // 
            // txtbox_ClownsPerCar
            // 
            this.txtbox_ClownsPerCar.Location = new System.Drawing.Point(164, 157);
            this.txtbox_ClownsPerCar.Name = "txtbox_ClownsPerCar";
            this.txtbox_ClownsPerCar.Size = new System.Drawing.Size(112, 26);
            this.txtbox_ClownsPerCar.TabIndex = 4;
            // 
            // txtbox_NumberOfCars
            // 
            this.txtbox_NumberOfCars.Location = new System.Drawing.Point(164, 198);
            this.txtbox_NumberOfCars.Name = "txtbox_NumberOfCars";
            this.txtbox_NumberOfCars.Size = new System.Drawing.Size(112, 26);
            this.txtbox_NumberOfCars.TabIndex = 5;
            // 
            // txtbox_TotalClowns
            // 
            this.txtbox_TotalClowns.Location = new System.Drawing.Point(164, 246);
            this.txtbox_TotalClowns.Name = "txtbox_TotalClowns";
            this.txtbox_TotalClowns.Size = new System.Drawing.Size(112, 26);
            this.txtbox_TotalClowns.TabIndex = 6;
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(348, 248);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(75, 32);
            this.btn_Help.TabIndex = 7;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // radBtnNotDrunk
            // 
            this.radBtnNotDrunk.AutoSize = true;
            this.radBtnNotDrunk.ForeColor = System.Drawing.Color.RoyalBlue;
            this.radBtnNotDrunk.Location = new System.Drawing.Point(34, 68);
            this.radBtnNotDrunk.Name = "radBtnNotDrunk";
            this.radBtnNotDrunk.Size = new System.Drawing.Size(139, 24);
            this.radBtnNotDrunk.TabIndex = 9;
            this.radBtnNotDrunk.TabStop = true;
            this.radBtnNotDrunk.Text = "I am not Drunk";
            this.radBtnNotDrunk.UseVisualStyleBackColor = true;
            this.radBtnNotDrunk.CheckedChanged += new System.EventHandler(this.radBtnNotDrunk_CheckedChanged);
            // 
            // radBtnDrunk
            // 
            this.radBtnDrunk.AutoSize = true;
            this.radBtnDrunk.ForeColor = System.Drawing.Color.RoyalBlue;
            this.radBtnDrunk.Location = new System.Drawing.Point(34, 115);
            this.radBtnDrunk.Name = "radBtnDrunk";
            this.radBtnDrunk.Size = new System.Drawing.Size(112, 24);
            this.radBtnDrunk.TabIndex = 10;
            this.radBtnDrunk.TabStop = true;
            this.radBtnDrunk.Text = "I am Drunk";
            this.radBtnDrunk.UseVisualStyleBackColor = true;
            this.radBtnDrunk.CheckedChanged += new System.EventHandler(this.radBtnDrunk_CheckedChanged);

            // 
            // picBoxFlagBus
            // 
            this.picBoxFlagBus.BackColor = System.Drawing.Color.Transparent;
            this.picBoxFlagBus.ErrorImage = global::WindowsFormsApplication1.Properties.Resources.bus5;
            this.picBoxFlagBus.Image = global::WindowsFormsApplication1.Properties.Resources.bus5;
            this.picBoxFlagBus.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxFlagBus.InitialImage")));
            this.picBoxFlagBus.Location = new System.Drawing.Point(141, 280);
            this.picBoxFlagBus.Name = "picBoxFlagBus";
            this.picBoxFlagBus.Size = new System.Drawing.Size(450, 255);
            this.picBoxFlagBus.TabIndex = 8;
            this.picBoxFlagBus.TabStop = false;
            // 
            // Simple_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 446);
            this.Controls.Add(this.radBtnDrunk);
            this.Controls.Add(this.radBtnNotDrunk);
            this.Controls.Add(this.picBoxFlagBus);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.txtbox_TotalClowns);
            this.Controls.Add(this.txtbox_NumberOfCars);
            this.Controls.Add(this.txtbox_ClownsPerCar);
            this.Controls.Add(this.lbl_NumberOfBuses);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.lbl_DrunksPerBus);
            this.Controls.Add(this.Hlavka_Calculator);
            this.Name = "Simple_Calculator";
            this.Text = "Hlavka Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFlagBus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hlavka_Calculator;
        private System.Windows.Forms.Label lbl_DrunksPerBus;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label lbl_NumberOfBuses;
        private System.Windows.Forms.TextBox txtbox_ClownsPerCar;
        private System.Windows.Forms.TextBox txtbox_NumberOfCars;
        private System.Windows.Forms.TextBox txtbox_TotalClowns;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.PictureBox picBoxFlagBus;
        private System.Windows.Forms.RadioButton radBtnNotDrunk;
        private System.Windows.Forms.RadioButton radBtnDrunk;
    }
}

