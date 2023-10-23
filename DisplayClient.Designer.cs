namespace WindowsFormsApp11
{
    partial class DisplayClient
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
            this.btn_dis_search = new MetroFramework.Controls.MetroButton();
            this.txt_dis_client_id = new MetroFramework.Controls.MetroTextBox();
            this.lbl_dis_client_id = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dis_search
            // 
            this.btn_dis_search.Location = new System.Drawing.Point(1162, 139);
            this.btn_dis_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_dis_search.Name = "btn_dis_search";
            this.btn_dis_search.Size = new System.Drawing.Size(190, 36);
            this.btn_dis_search.TabIndex = 27;
            this.btn_dis_search.Text = "Search";
            this.btn_dis_search.UseSelectable = true;
            this.btn_dis_search.Click += new System.EventHandler(this.btn_dis_search_Click);
            // 
            // txt_dis_client_id
            // 
            // 
            // 
            // 
            this.txt_dis_client_id.CustomButton.Image = null;
            this.txt_dis_client_id.CustomButton.Location = new System.Drawing.Point(633, 3);
            this.txt_dis_client_id.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_dis_client_id.CustomButton.Name = "";
            this.txt_dis_client_id.CustomButton.Size = new System.Drawing.Size(46, 48);
            this.txt_dis_client_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_dis_client_id.CustomButton.TabIndex = 1;
            this.txt_dis_client_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_dis_client_id.CustomButton.UseSelectable = true;
            this.txt_dis_client_id.CustomButton.Visible = false;
            this.txt_dis_client_id.Lines = new string[0];
            this.txt_dis_client_id.Location = new System.Drawing.Point(407, 139);
            this.txt_dis_client_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_dis_client_id.MaxLength = 32767;
            this.txt_dis_client_id.Name = "txt_dis_client_id";
            this.txt_dis_client_id.PasswordChar = '\0';
            this.txt_dis_client_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_dis_client_id.SelectedText = "";
            this.txt_dis_client_id.SelectionLength = 0;
            this.txt_dis_client_id.SelectionStart = 0;
            this.txt_dis_client_id.ShortcutsEnabled = true;
            this.txt_dis_client_id.Size = new System.Drawing.Size(456, 36);
            this.txt_dis_client_id.TabIndex = 21;
            this.txt_dis_client_id.UseSelectable = true;
            this.txt_dis_client_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_dis_client_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_dis_client_id
            // 
            this.lbl_dis_client_id.AutoSize = true;
            this.lbl_dis_client_id.Location = new System.Drawing.Point(34, 156);
            this.lbl_dis_client_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dis_client_id.Name = "lbl_dis_client_id";
            this.lbl_dis_client_id.Size = new System.Drawing.Size(58, 19);
            this.lbl_dis_client_id.TabIndex = 15;
            this.lbl_dis_client_id.Text = "Client ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 343);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1318, 749);
            this.dataGridView1.TabIndex = 30;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1162, 205);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(190, 36);
            this.metroButton1.TabIndex = 31;
            this.metroButton1.Text = "Exit";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // DisplayClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 1128);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_dis_search);
            this.Controls.Add(this.txt_dis_client_id);
            this.Controls.Add(this.lbl_dis_client_id);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisplayClient";
            this.Padding = new System.Windows.Forms.Padding(30, 94, 30, 31);
            this.Text = "Display Client";
            this.Load += new System.EventHandler(this.DisplayClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_dis_search;
        private MetroFramework.Controls.MetroTextBox txt_dis_client_id;
        private MetroFramework.Controls.MetroLabel lbl_dis_client_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}