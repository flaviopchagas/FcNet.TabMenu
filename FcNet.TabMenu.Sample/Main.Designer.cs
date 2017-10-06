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
            this.tabMenu1 = new FcNet.TabMenu.TabMenu();
            this.tabItem1 = new FcNet.TabMenu.TabItem();
            this.SuspendLayout();
            // 
            // tabMenu1
            // 
            this.tabMenu1.Location = new System.Drawing.Point(154, 79);
            this.tabMenu1.Name = "tabMenu1";
            this.tabMenu1.Size = new System.Drawing.Size(200, 100);
            this.tabMenu1.TabIndex = 0;
            this.tabMenu1.TabMargin = new System.Windows.Forms.Padding(3);
            this.tabMenu1.Tabs.Add(this.tabItem1);
            this.tabMenu1.TabSize = new System.Drawing.Size(75, 23);
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

        private TabMenu tabMenu1;
        private TabItem tabItem1;
    }
}

