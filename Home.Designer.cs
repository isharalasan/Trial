namespace WindowsFormsApp11
{
    partial class Home
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
            this.tile_registration = new MetroFramework.Controls.MetroTile();
            this.tile_update_client = new MetroFramework.Controls.MetroTile();
            this.tile_delete_client = new MetroFramework.Controls.MetroTile();
            this.tile_display_client = new MetroFramework.Controls.MetroTile();
            this.tile_client_report = new MetroFramework.Controls.MetroTile();
            this.tile_client_report_by_dob = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tile_registration
            // 
            this.tile_registration.ActiveControl = null;
            this.tile_registration.Location = new System.Drawing.Point(72, 155);
            this.tile_registration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tile_registration.Name = "tile_registration";
            this.tile_registration.Size = new System.Drawing.Size(393, 220);
            this.tile_registration.TabIndex = 0;
            this.tile_registration.Text = "Registration";
            this.tile_registration.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_registration.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_registration.UseSelectable = true;
            this.tile_registration.Click += new System.EventHandler(this.tile_registration_Click);
            // 
            // tile_update_client
            // 
            this.tile_update_client.ActiveControl = null;
            this.tile_update_client.Location = new System.Drawing.Point(596, 155);
            this.tile_update_client.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tile_update_client.Name = "tile_update_client";
            this.tile_update_client.Size = new System.Drawing.Size(393, 220);
            this.tile_update_client.TabIndex = 1;
            this.tile_update_client.Text = "Update Client";
            this.tile_update_client.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_update_client.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_update_client.UseSelectable = true;
            this.tile_update_client.Click += new System.EventHandler(this.tile_update_client_Click);
            // 
            // tile_delete_client
            // 
            this.tile_delete_client.ActiveControl = null;
            this.tile_delete_client.Location = new System.Drawing.Point(72, 477);
            this.tile_delete_client.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tile_delete_client.Name = "tile_delete_client";
            this.tile_delete_client.Size = new System.Drawing.Size(393, 220);
            this.tile_delete_client.TabIndex = 2;
            this.tile_delete_client.Text = "Delete Client";
            this.tile_delete_client.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_delete_client.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_delete_client.UseSelectable = true;
            this.tile_delete_client.Click += new System.EventHandler(this.tile_delete_client_Click);
            // 
            // tile_display_client
            // 
            this.tile_display_client.ActiveControl = null;
            this.tile_display_client.Location = new System.Drawing.Point(596, 477);
            this.tile_display_client.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tile_display_client.Name = "tile_display_client";
            this.tile_display_client.Size = new System.Drawing.Size(393, 220);
            this.tile_display_client.TabIndex = 3;
            this.tile_display_client.Text = "Display Client";
            this.tile_display_client.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_display_client.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_display_client.UseSelectable = true;
            this.tile_display_client.Click += new System.EventHandler(this.tile_display_client_Click);
            // 
            // tile_client_report
            // 
            this.tile_client_report.ActiveControl = null;
            this.tile_client_report.Location = new System.Drawing.Point(72, 802);
            this.tile_client_report.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tile_client_report.Name = "tile_client_report";
            this.tile_client_report.Size = new System.Drawing.Size(393, 220);
            this.tile_client_report.TabIndex = 4;
            this.tile_client_report.Text = "Client Report";
            this.tile_client_report.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_client_report.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_client_report.UseSelectable = true;
            this.tile_client_report.Click += new System.EventHandler(this.tile_client_report_Click);
            // 
            // tile_client_report_by_dob
            // 
            this.tile_client_report_by_dob.ActiveControl = null;
            this.tile_client_report_by_dob.Location = new System.Drawing.Point(596, 802);
            this.tile_client_report_by_dob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tile_client_report_by_dob.Name = "tile_client_report_by_dob";
            this.tile_client_report_by_dob.Size = new System.Drawing.Size(393, 220);
            this.tile_client_report_by_dob.TabIndex = 5;
            this.tile_client_report_by_dob.Text = "Client Report by DOB";
            this.tile_client_report_by_dob.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_client_report_by_dob.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_client_report_by_dob.UseSelectable = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 1100);
            this.Controls.Add(this.tile_client_report_by_dob);
            this.Controls.Add(this.tile_client_report);
            this.Controls.Add(this.tile_display_client);
            this.Controls.Add(this.tile_delete_client);
            this.Controls.Add(this.tile_update_client);
            this.Controls.Add(this.tile_registration);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(30, 94, 30, 31);
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tile_registration;
        private MetroFramework.Controls.MetroTile tile_update_client;
        private MetroFramework.Controls.MetroTile tile_delete_client;
        private MetroFramework.Controls.MetroTile tile_display_client;
        private MetroFramework.Controls.MetroTile tile_client_report;
        private MetroFramework.Controls.MetroTile tile_client_report_by_dob;
    }
}

