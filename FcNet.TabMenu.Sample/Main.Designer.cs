﻿namespace FcNet.TabMenu.Sample
{
    partial class Main
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
            this.tabMenuSample = new FcNet.TabMenu.TabMenu();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabMenuSample.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenuSample
            // 
            this.tabMenuSample.Controls.Add(this.button1);
            this.tabMenuSample.Controls.Add(this.button2);
            this.tabMenuSample.Location = new System.Drawing.Point(96, 93);
            this.tabMenuSample.Name = "tabMenuSample";
            this.tabMenuSample.Size = new System.Drawing.Size(373, 34);
            this.tabMenuSample.TabIndex = 0;
            this.tabMenuSample.TabItems.Add(this.button1);
            this.tabMenuSample.TabItems.Add(this.button2);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Main";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Foo";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 305);
            this.Controls.Add(this.tabMenuSample);
            this.Name = "Main";
            this.Text = "FcNet.TabMenu Sample";
            this.tabMenuSample.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabMenu tabMenuSample;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

