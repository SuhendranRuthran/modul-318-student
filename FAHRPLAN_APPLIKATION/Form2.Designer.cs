namespace FAHRPLAN_APPLIKATION
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_cancel_exit = new System.Windows.Forms.Button();
            this.btn_confitm_exit = new System.Windows.Forms.Button();
            this.lbl_confirm_exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancel_exit
            // 
            this.btn_cancel_exit.BackColor = System.Drawing.Color.Firebrick;
            this.btn_cancel_exit.ForeColor = System.Drawing.Color.White;
            this.btn_cancel_exit.Location = new System.Drawing.Point(152, 66);
            this.btn_cancel_exit.Name = "btn_cancel_exit";
            this.btn_cancel_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel_exit.TabIndex = 5;
            this.btn_cancel_exit.Text = "Nein";
            this.btn_cancel_exit.UseVisualStyleBackColor = false;
            this.btn_cancel_exit.Click += new System.EventHandler(this.btn_cancel_exit_Click);
            // 
            // btn_confitm_exit
            // 
            this.btn_confitm_exit.BackColor = System.Drawing.Color.Firebrick;
            this.btn_confitm_exit.ForeColor = System.Drawing.Color.White;
            this.btn_confitm_exit.Location = new System.Drawing.Point(71, 66);
            this.btn_confitm_exit.Name = "btn_confitm_exit";
            this.btn_confitm_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_confitm_exit.TabIndex = 4;
            this.btn_confitm_exit.Text = "Ja";
            this.btn_confitm_exit.UseVisualStyleBackColor = false;
            this.btn_confitm_exit.Click += new System.EventHandler(this.btn_confitm_exit_Click);
            // 
            // lbl_confirm_exit
            // 
            this.lbl_confirm_exit.AutoSize = true;
            this.lbl_confirm_exit.Location = new System.Drawing.Point(32, 40);
            this.lbl_confirm_exit.Name = "lbl_confirm_exit";
            this.lbl_confirm_exit.Size = new System.Drawing.Size(240, 13);
            this.lbl_confirm_exit.TabIndex = 3;
            this.lbl_confirm_exit.Text = "Möchten Sie die Anwendung wirklich schliessen?";
            this.lbl_confirm_exit.Click += new System.EventHandler(this.lbl_confirm_exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 137);
            this.Controls.Add(this.btn_cancel_exit);
            this.Controls.Add(this.btn_confitm_exit);
            this.Controls.Add(this.lbl_confirm_exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form2";
            this.Text = "Anwendung schliessen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel_exit;
        private System.Windows.Forms.Button btn_confitm_exit;
        private System.Windows.Forms.Label lbl_confirm_exit;
    }
}