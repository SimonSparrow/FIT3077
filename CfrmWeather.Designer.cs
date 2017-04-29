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
			this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
			this.ckbRainfall = new System.Windows.Forms.CheckBox();
			this.ckbTemp = new System.Windows.Forms.CheckBox();
			this.tlpLocations = new System.Windows.Forms.TableLayoutPanel();
			this.btnClear = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
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
			// tmrUpdate
			// 
			this.tmrUpdate.Enabled = true;
			this.tmrUpdate.Interval = 500000;
			this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
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
			this.ckbRainfall.CheckedChanged += new System.EventHandler(this.ckbRainfall_CheckedChanged);
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
			this.ckbTemp.CheckedChanged += new System.EventHandler(this.ckbTemp_CheckedChanged);
			// 
			// tlpLocations
			// 
			this.tlpLocations.AutoSize = true;
			this.tlpLocations.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
			this.tlpLocations.ColumnCount = 1;
			this.tlpLocations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpLocations.Location = new System.Drawing.Point(41, 77);
			this.tlpLocations.Name = "tlpLocations";
			this.tlpLocations.RowCount = 1;
			this.tlpLocations.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpLocations.Size = new System.Drawing.Size(450, 74);
			this.tlpLocations.TabIndex = 7;
			this.tlpLocations.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpLocations_Paint);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(425, 26);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 8;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// CfrmWeather
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(529, 393);
			this.Controls.Add(this.btnClear);
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
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.CheckBox ckbRainfall;
        private System.Windows.Forms.CheckBox ckbTemp;
        private System.Windows.Forms.TableLayoutPanel tlpLocations;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Timer timer1;
	}
}

