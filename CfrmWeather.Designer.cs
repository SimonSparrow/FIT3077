namespace Hopeful
{
    partial class CfrmWeather
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
            this.cmbLocations = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.ckbRainfall = new System.Windows.Forms.CheckBox();
            this.ckbTemp = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tlpLocations = new System.Windows.Forms.TableLayoutPanel();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbLocations
            // 
            this.cmbLocations.FormattingEnabled = true;
            this.cmbLocations.Location = new System.Drawing.Point(41, 1);
            this.cmbLocations.Name = "cmbLocations";
            this.cmbLocations.Size = new System.Drawing.Size(172, 21);
            this.cmbLocations.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(263, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(344, 26);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ckbRainfall
            // 
            this.ckbRainfall.AutoSize = true;
            this.ckbRainfall.Location = new System.Drawing.Point(263, 3);
            this.ckbRainfall.Name = "ckbRainfall";
            this.ckbRainfall.Size = new System.Drawing.Size(61, 17);
            this.ckbRainfall.TabIndex = 5;
            this.ckbRainfall.Text = "Rainfall";
            this.ckbRainfall.UseVisualStyleBackColor = true;
            // 
            // ckbTemp
            // 
            this.ckbTemp.AutoSize = true;
            this.ckbTemp.Location = new System.Drawing.Point(344, 3);
            this.ckbTemp.Name = "ckbTemp";
            this.ckbTemp.Size = new System.Drawing.Size(86, 17);
            this.ckbTemp.TabIndex = 6;
            this.ckbTemp.Text = "Temperature";
            this.ckbTemp.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tlpLocations
            // 
            this.tlpLocations.AutoScroll = true;
            this.tlpLocations.ColumnCount = 3;
            this.tlpLocations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.92738F));
            this.tlpLocations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.07262F));
            this.tlpLocations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tlpLocations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpLocations.Location = new System.Drawing.Point(0, 164);
            this.tlpLocations.Name = "tlpLocations";
            this.tlpLocations.RowCount = 1;
            this.tlpLocations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.37276F));
            this.tlpLocations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.62724F));
            this.tlpLocations.Size = new System.Drawing.Size(529, 229);
            this.tlpLocations.TabIndex = 9;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(38, 31);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 10;
            // 
            // CfrmWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(529, 393);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.tlpLocations);
            this.Controls.Add(this.ckbTemp);
            this.Controls.Add(this.ckbRainfall);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbLocations);
            this.Name = "CfrmWeather";
            this.Text = "Melbourne Weather App";
            this.Load += new System.EventHandler(this.CfrmWeather_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLocations;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckBox ckbRainfall;
        private System.Windows.Forms.CheckBox ckbTemp;
		private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tlpLocations;
        private System.Windows.Forms.Label lblTime;
    }
}

