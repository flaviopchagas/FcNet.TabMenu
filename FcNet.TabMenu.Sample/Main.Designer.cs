namespace FcNet.TabMenu.Sample
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
            this.tabItem1 = new FcNet.TabMenu.TabItem();
            this.tabItem2 = new FcNet.TabMenu.TabItem();
            this.tabItem3 = new FcNet.TabMenu.TabItem();
            this.tabMenu1 = new FcNet.TabMenu.TabMenu();
            this.SuspendLayout();
            // 
            // tabItem1
            // 
            this.tabItem1.Location = new System.Drawing.Point(0, 0);
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Size = new System.Drawing.Size(75, 23);
            this.tabItem1.TabIndex = 0;
            this.tabItem1.Text = "tabItem1";
            this.tabItem1.UseVisualStyleBackColor = true;
            // 
            // tabItem2
            // 
            this.tabItem2.Location = new System.Drawing.Point(0, 0);
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Size = new System.Drawing.Size(75, 23);
            this.tabItem2.TabIndex = 0;
            this.tabItem2.Text = "tabItem2";
            this.tabItem2.UseVisualStyleBackColor = true;
            // 
            // tabItem3
            // 
            this.tabItem3.Location = new System.Drawing.Point(0, 0);
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Size = new System.Drawing.Size(75, 23);
            this.tabItem3.TabIndex = 0;
            this.tabItem3.Text = "tabItem3";
            this.tabItem3.UseVisualStyleBackColor = true;
            // 
            // tabMenu1
            // 
            this.tabMenu1.Location = new System.Drawing.Point(116, 62);
            this.tabMenu1.Name = "tabMenu1";
            this.tabMenu1.Size = new System.Drawing.Size(200, 100);
            this.tabMenu1.TabIndex = 0;
            this.tabMenu1.TabMargin = new System.Windows.Forms.Padding(3);
            this.tabMenu1.TabSize = new System.Drawing.Size(75, 23);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 305);
            this.Controls.Add(this.tabMenu1);
            this.Name = "Main";
            this.Text = "FcNet.TabMenu Sample";
            this.ResumeLayout(false);

        }

        #endregion
        private TabItem tabItem1;
        private TabItem tabItem2;
        private TabItem tabItem3;
        private TabMenu tabMenu1;
    }
}

