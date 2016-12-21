namespace Jazz
{
    partial class helpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helpForm));
            this.helpTitle = new System.Windows.Forms.Label();
            this.helpText = new System.Windows.Forms.Label();
            this.OK_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helpTitle
            // 
            this.helpTitle.AutoSize = true;
            this.helpTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpTitle.Location = new System.Drawing.Point(223, 9);
            this.helpTitle.Name = "helpTitle";
            this.helpTitle.Size = new System.Drawing.Size(303, 37);
            this.helpTitle.TabIndex = 0;
            this.helpTitle.Text = "Jazz [Version 0.01]";
            // 
            // helpText
            // 
            this.helpText.AutoSize = true;
            this.helpText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpText.Location = new System.Drawing.Point(61, 85);
            this.helpText.Name = "helpText";
            this.helpText.Size = new System.Drawing.Size(621, 216);
            this.helpText.TabIndex = 1;
            this.helpText.Text = resources.GetString("helpText.Text");
            // 
            // OK_but
            // 
            this.OK_but.Location = new System.Drawing.Point(333, 332);
            this.OK_but.Name = "OK_but";
            this.OK_but.Size = new System.Drawing.Size(75, 23);
            this.OK_but.TabIndex = 2;
            this.OK_but.Text = "OK";
            this.OK_but.UseVisualStyleBackColor = true;
            this.OK_but.Click += new System.EventHandler(this.OK_but_Click);
            // 
            // helpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(742, 367);
            this.Controls.Add(this.OK_but);
            this.Controls.Add(this.helpText);
            this.Controls.Add(this.helpTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "helpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helpTitle;
        private System.Windows.Forms.Label helpText;
        private System.Windows.Forms.Button OK_but;
    }
}