namespace WindowsFormsApp11
{
    partial class DeleteClient
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
            this.btn_del_exit = new MetroFramework.Controls.MetroButton();
            this.btn_del_clear = new MetroFramework.Controls.MetroButton();
            this.btn_del_delete = new MetroFramework.Controls.MetroButton();
            this.txt_del_client_id = new MetroFramework.Controls.MetroTextBox();
            this.lbl_del_client_id = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btn_del_exit
            // 
            this.btn_del_exit.Location = new System.Drawing.Point(373, 160);
            this.btn_del_exit.Name = "btn_del_exit";
            this.btn_del_exit.Size = new System.Drawing.Size(130, 23);
            this.btn_del_exit.TabIndex = 29;
            this.btn_del_exit.Text = "Exit";
            this.btn_del_exit.UseSelectable = true;
            this.btn_del_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_del_clear
            // 
            this.btn_del_clear.Location = new System.Drawing.Point(199, 160);
            this.btn_del_clear.Name = "btn_del_clear";
            this.btn_del_clear.Size = new System.Drawing.Size(130, 23);
            this.btn_del_clear.TabIndex = 28;
            this.btn_del_clear.Text = "Clear";
            this.btn_del_clear.UseSelectable = true;
            // 
            // btn_del_delete
            // 
            this.btn_del_delete.Location = new System.Drawing.Point(24, 160);
            this.btn_del_delete.Name = "btn_del_delete";
            this.btn_del_delete.Size = new System.Drawing.Size(127, 23);
            this.btn_del_delete.TabIndex = 27;
            this.btn_del_delete.Text = "Delete";
            this.btn_del_delete.UseSelectable = true;
            // 
            // txt_del_client_id
            // 
            // 
            // 
            // 
            this.txt_del_client_id.CustomButton.Image = null;
            this.txt_del_client_id.CustomButton.Location = new System.Drawing.Point(282, 1);
            this.txt_del_client_id.CustomButton.Name = "";
            this.txt_del_client_id.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_del_client_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_del_client_id.CustomButton.TabIndex = 1;
            this.txt_del_client_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_del_client_id.CustomButton.UseSelectable = true;
            this.txt_del_client_id.CustomButton.Visible = false;
            this.txt_del_client_id.Lines = new string[0];
            this.txt_del_client_id.Location = new System.Drawing.Point(199, 91);
            this.txt_del_client_id.MaxLength = 32767;
            this.txt_del_client_id.Name = "txt_del_client_id";
            this.txt_del_client_id.PasswordChar = '\0';
            this.txt_del_client_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_del_client_id.SelectedText = "";
            this.txt_del_client_id.SelectionLength = 0;
            this.txt_del_client_id.SelectionStart = 0;
            this.txt_del_client_id.ShortcutsEnabled = true;
            this.txt_del_client_id.Size = new System.Drawing.Size(304, 23);
            this.txt_del_client_id.TabIndex = 21;
            this.txt_del_client_id.UseSelectable = true;
            this.txt_del_client_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_del_client_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_del_client_id
            // 
            this.lbl_del_client_id.AutoSize = true;
            this.lbl_del_client_id.Location = new System.Drawing.Point(23, 95);
            this.lbl_del_client_id.Name = "lbl_del_client_id";
            this.lbl_del_client_id.Size = new System.Drawing.Size(61, 20);
            this.lbl_del_client_id.TabIndex = 15;
            this.lbl_del_client_id.Text = "Client ID";
            // 
            // DeleteClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 219);
            this.Controls.Add(this.btn_del_exit);
            this.Controls.Add(this.btn_del_clear);
            this.Controls.Add(this.btn_del_delete);
            this.Controls.Add(this.txt_del_client_id);
            this.Controls.Add(this.lbl_del_client_id);
            this.Name = "DeleteClient";
            this.Text = "Delete Client";
            this.Load += new System.EventHandler(this.DeleteClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_del_exit;
        private MetroFramework.Controls.MetroButton btn_del_clear;
        private MetroFramework.Controls.MetroButton btn_del_delete;
        private MetroFramework.Controls.MetroTextBox txt_del_client_id;
        private MetroFramework.Controls.MetroLabel lbl_del_client_id;
    }
}