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
            this.SuspendLayout();
            // 
            // cmbLocations
            // 
            this.cmbLocations.FormattingEnabled = true;
            this.cmbLocations.Location = new System.Drawing.Point(12, 203);
            this.cmbLocations.Name = "cmbLocations";
            this.cmbLocations.Size = new System.Drawing.Size(121, 21);
            this.cmbLocations.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 276);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(13, 305);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 300000;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // ckbRainfall
            // 
            this.ckbRainfall.AutoSize = true;
            this.ckbRainfall.Location = new System.Drawing.Point(12, 230);
            this.ckbRainfall.Name = "ckbRainfall";
            this.ckbRainfall.Size = new System.Drawing.Size(61, 17);
            this.ckbRainfall.TabIndex = 5;
            this.ckbRainfall.Text = "Rainfall";
            this.ckbRainfall.UseVisualStyleBackColor = true;
            // 
            // ckbTemp
            // 
            this.ckbTemp.AutoSize = true;
            this.ckbTemp.Location = new System.Drawing.Point(13, 253);
            this.ckbTemp.Name = "ckbTemp";
            this.ckbTemp.Size = new System.Drawing.Size(86, 17);
            this.ckbTemp.TabIndex = 6;
            this.ckbTemp.Text = "Temperature";
            this.ckbTemp.UseVisualStyleBackColor = true;
            // 
            // tlpLocations
            // 
            this.tlpLocations.AutoSize = true;
            this.tlpLocations.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpLocations.ColumnCount = 3;
            this.tlpLocations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLocations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLocations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLocations.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpLocations.Location = new System.Drawing.Point(0, 0);
            this.tlpLocations.Name = "tlpLocations";
            this.tlpLocations.RowCount = 1;
            this.tlpLocations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLocations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLocations.Size = new System.Drawing.Size(296, 2);
            this.tlpLocations.TabIndex = 7;
            // 
            // CfrmWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 337);
            this.Controls.Add(this.tlpLocations);
            this.Controls.Add(this.ckbTemp);
            this.Controls.Add(this.ckbRainfall);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbLocations);
            this.Name = "CfrmWeather";
            this.Text = "Weather";
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
    }
}

