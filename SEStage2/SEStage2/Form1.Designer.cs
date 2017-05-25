namespace SEStage2
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbLocations = new System.Windows.Forms.ComboBox();
            this.ckbRainfall = new System.Windows.Forms.CheckBox();
            this.ckbTemperature = new System.Windows.Forms.CheckBox();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(140, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbLocations
            // 
            this.cmbLocations.FormattingEnabled = true;
            this.cmbLocations.Location = new System.Drawing.Point(13, 12);
            this.cmbLocations.Name = "cmbLocations";
            this.cmbLocations.Size = new System.Drawing.Size(121, 21);
            this.cmbLocations.TabIndex = 1;
            // 
            // ckbRainfall
            // 
            this.ckbRainfall.AutoSize = true;
            this.ckbRainfall.Location = new System.Drawing.Point(13, 40);
            this.ckbRainfall.Name = "ckbRainfall";
            this.ckbRainfall.Size = new System.Drawing.Size(61, 17);
            this.ckbRainfall.TabIndex = 2;
            this.ckbRainfall.Text = "Rainfall";
            this.ckbRainfall.UseVisualStyleBackColor = true;
            // 
            // ckbTemperature
            // 
            this.ckbTemperature.AutoSize = true;
            this.ckbTemperature.Location = new System.Drawing.Point(81, 40);
            this.ckbTemperature.Name = "ckbTemperature";
            this.ckbTemperature.Size = new System.Drawing.Size(86, 17);
            this.ckbTemperature.TabIndex = 3;
            this.ckbTemperature.Text = "Temperature";
            this.ckbTemperature.UseVisualStyleBackColor = true;
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(13, 64);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(28, 13);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "0:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 85);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.ckbTemperature);
            this.Controls.Add(this.ckbRainfall);
            this.Controls.Add(this.cmbLocations);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "WeatherData";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbLocations;
        private System.Windows.Forms.CheckBox ckbRainfall;
        private System.Windows.Forms.CheckBox ckbTemperature;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Label lblTime;
    }
}

