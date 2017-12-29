namespace WindowsFormsApp1
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
            this.ip_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fetchip_btn = new System.Windows.Forms.Button();
            this.lookup_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.location_txt = new System.Windows.Forms.TextBox();
            this.city_txt = new System.Windows.Forms.TextBox();
            this.isp_txt = new System.Windows.Forms.TextBox();
            this.status_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ip_txt
            // 
            this.ip_txt.Location = new System.Drawing.Point(16, 39);
            this.ip_txt.Name = "ip_txt";
            this.ip_txt.Size = new System.Drawing.Size(120, 20);
            this.ip_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP address";
            // 
            // fetchip_btn
            // 
            this.fetchip_btn.Location = new System.Drawing.Point(16, 65);
            this.fetchip_btn.Name = "fetchip_btn";
            this.fetchip_btn.Size = new System.Drawing.Size(120, 25);
            this.fetchip_btn.TabIndex = 2;
            this.fetchip_btn.Text = "Fetch your IP";
            this.fetchip_btn.UseVisualStyleBackColor = true;
            this.fetchip_btn.Click += new System.EventHandler(this.fetchip_btn_Click);
            // 
            // lookup_btn
            // 
            this.lookup_btn.Location = new System.Drawing.Point(142, 39);
            this.lookup_btn.Name = "lookup_btn";
            this.lookup_btn.Size = new System.Drawing.Size(64, 51);
            this.lookup_btn.TabIndex = 3;
            this.lookup_btn.Text = "Lookup";
            this.lookup_btn.UseVisualStyleBackColor = true;
            this.lookup_btn.Click += new System.EventHandler(this.lookup_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ISP";
            // 
            // location_txt
            // 
            this.location_txt.Location = new System.Drawing.Point(58, 169);
            this.location_txt.Name = "location_txt";
            this.location_txt.ReadOnly = true;
            this.location_txt.Size = new System.Drawing.Size(100, 20);
            this.location_txt.TabIndex = 9;
            this.location_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // city_txt
            // 
            this.city_txt.Location = new System.Drawing.Point(58, 209);
            this.city_txt.Name = "city_txt";
            this.city_txt.ReadOnly = true;
            this.city_txt.Size = new System.Drawing.Size(100, 20);
            this.city_txt.TabIndex = 10;
            this.city_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // isp_txt
            // 
            this.isp_txt.Location = new System.Drawing.Point(59, 249);
            this.isp_txt.Name = "isp_txt";
            this.isp_txt.ReadOnly = true;
            this.isp_txt.Size = new System.Drawing.Size(100, 20);
            this.isp_txt.TabIndex = 12;
            this.isp_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // status_txt
            // 
            this.status_txt.Location = new System.Drawing.Point(59, 130);
            this.status_txt.Name = "status_txt";
            this.status_txt.ReadOnly = true;
            this.status_txt.Size = new System.Drawing.Size(100, 20);
            this.status_txt.TabIndex = 14;
            this.status_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 290);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.status_txt);
            this.Controls.Add(this.isp_txt);
            this.Controls.Add(this.city_txt);
            this.Controls.Add(this.location_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lookup_btn);
            this.Controls.Add(this.fetchip_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ip_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "IP Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fetchip_btn;
        private System.Windows.Forms.Button lookup_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox location_txt;
        private System.Windows.Forms.TextBox city_txt;
        private System.Windows.Forms.TextBox isp_txt;
        private System.Windows.Forms.TextBox status_txt;
        private System.Windows.Forms.Label label4;
    }
}

