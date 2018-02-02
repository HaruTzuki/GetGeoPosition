namespace GetGeoPosition
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_street = new System.Windows.Forms.TextBox();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_postal_code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_long = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_lat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_get_geo_position = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Διεύθυνση:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_street
            // 
            this.txt_street.Location = new System.Drawing.Point(96, 6);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(148, 22);
            this.txt_street.TabIndex = 2;
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(96, 34);
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(148, 22);
            this.txt_area.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Περιοχή:";
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(299, 6);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(148, 22);
            this.txt_city.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Πόλη:";
            // 
            // txt_postal_code
            // 
            this.txt_postal_code.Location = new System.Drawing.Point(299, 34);
            this.txt_postal_code.Name = "txt_postal_code";
            this.txt_postal_code.Size = new System.Drawing.Size(148, 22);
            this.txt_postal_code.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Τ.Κ.";
            // 
            // txt_long
            // 
            this.txt_long.Location = new System.Drawing.Point(299, 119);
            this.txt_long.Name = "txt_long";
            this.txt_long.ReadOnly = true;
            this.txt_long.Size = new System.Drawing.Size(148, 22);
            this.txt_long.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Long:";
            // 
            // txt_lat
            // 
            this.txt_lat.Location = new System.Drawing.Point(96, 119);
            this.txt_lat.Name = "txt_lat";
            this.txt_lat.ReadOnly = true;
            this.txt_lat.Size = new System.Drawing.Size(148, 22);
            this.txt_lat.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lat:";
            // 
            // btn_get_geo_position
            // 
            this.btn_get_geo_position.Location = new System.Drawing.Point(192, 62);
            this.btn_get_geo_position.Name = "btn_get_geo_position";
            this.btn_get_geo_position.Size = new System.Drawing.Size(129, 40);
            this.btn_get_geo_position.TabIndex = 13;
            this.btn_get_geo_position.Text = "Get Geo Position";
            this.btn_get_geo_position.UseVisualStyleBackColor = true;
            this.btn_get_geo_position.Click += new System.EventHandler(this.btn_get_geo_position_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(400, 219);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(84, 34);
            this.btn_settings.TabIndex = 14;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 265);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_get_geo_position);
            this.Controls.Add(this.txt_long);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_lat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_postal_code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_street);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_postal_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_long;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_lat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_get_geo_position;
        private System.Windows.Forms.Button btn_settings;
    }
}

