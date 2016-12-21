using System;
using System.IO;
using System.Windows.Forms;

namespace Jazz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.output = new System.Windows.Forms.RichTextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Jazz_img = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titlebar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.helpBut = new System.Windows.Forms.Button();
            this.addWordBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Jazz_img)).BeginInit();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(164)))), ((int)(((byte)(40)))));
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.output.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.Color.White;
            this.output.Location = new System.Drawing.Point(11, 351);
            this.output.Margin = new System.Windows.Forms.Padding(2);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(446, 321);
            this.output.TabIndex = 0;
            this.output.Text = "Welkom, mijn naam is Jazz! [Versie 0.01 Alpha]\n\nKlik op \'help\' om te zien wat je " +
    "kunt doen.";
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input.BackColor = System.Drawing.Color.White;
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.ForeColor = System.Drawing.Color.Black;
            this.input.Location = new System.Drawing.Point(124, 684);
            this.input.Margin = new System.Windows.Forms.Padding(2);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(260, 29);
            this.input.TabIndex = 1;
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 686);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Commando:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(164)))), ((int)(((byte)(40)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(0, 81);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(56, 42);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // Jazz_img
            // 
            this.Jazz_img.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Jazz_img.ImageLocation = "D:\\School spullen\\Eigen kleine projecten\\Jazz\\icons\\jazz_img.png";
            this.Jazz_img.InitialImage = ((System.Drawing.Image)(resources.GetObject("Jazz_img.InitialImage")));
            this.Jazz_img.Location = new System.Drawing.Point(99, 68);
            this.Jazz_img.Name = "Jazz_img";
            this.Jazz_img.Size = new System.Drawing.Size(256, 255);
            this.Jazz_img.TabIndex = 4;
            this.Jazz_img.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(-3, 674);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 51);
            this.label2.TabIndex = 5;
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.LimeGreen;
            this.titlebar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlebar.ForeColor = System.Drawing.Color.White;
            this.titlebar.Location = new System.Drawing.Point(-3, -3);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(465, 48);
            this.titlebar.TabIndex = 6;
            this.titlebar.Text = "   Taal:";
            this.titlebar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 12);
            this.comboBox1.MaxDropDownItems = 20;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Engels > Nederlands";
            // 
            // helpBut
            // 
            this.helpBut.BackColor = System.Drawing.Color.White;
            this.helpBut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.helpBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.helpBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.helpBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.helpBut.Location = new System.Drawing.Point(389, 684);
            this.helpBut.Name = "helpBut";
            this.helpBut.Size = new System.Drawing.Size(55, 29);
            this.helpBut.TabIndex = 8;
            this.helpBut.Text = "Help";
            this.helpBut.UseVisualStyleBackColor = false;
            this.helpBut.Click += new System.EventHandler(this.helpBut_Click);
            // 
            // addWordBut
            // 
            this.addWordBut.BackColor = System.Drawing.Color.White;
            this.addWordBut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addWordBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.addWordBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.addWordBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addWordBut.Location = new System.Drawing.Point(336, 12);
            this.addWordBut.Name = "addWordBut";
            this.addWordBut.Size = new System.Drawing.Size(108, 21);
            this.addWordBut.TabIndex = 9;
            this.addWordBut.Text = "Woord toevoegen";
            this.addWordBut.UseVisualStyleBackColor = false;
            this.addWordBut.Click += new System.EventHandler(this.addWordBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(164)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(456, 719);
            this.Controls.Add(this.addWordBut);
            this.Controls.Add(this.helpBut);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.titlebar);
            this.Controls.Add(this.Jazz_img);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.output);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jazz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Jazz_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox output;
        private TextBox input;
        private Label label1;
        private RichTextBox richTextBox1;
        private PictureBox Jazz_img;
        private Label label2;
        private Label titlebar;
        private ComboBox comboBox1;
        private Button helpBut;
        private Button addWordBut;
    }
}

