namespace DemoDBConnection
{
    partial class DemoDBConnectionForm
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
            this.TestDBConectionButton = new System.Windows.Forms.Button();
            this.ReadDataFromDBButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestDBConectionButton
            // 
            this.TestDBConectionButton.Location = new System.Drawing.Point(150, 53);
            this.TestDBConectionButton.Name = "TestDBConectionButton";
            this.TestDBConectionButton.Size = new System.Drawing.Size(180, 43);
            this.TestDBConectionButton.TabIndex = 0;
            this.TestDBConectionButton.Text = "Test DB connection";
            this.TestDBConectionButton.UseVisualStyleBackColor = true;
            this.TestDBConectionButton.Click += new System.EventHandler(this.TestDBConectionButton_Click);
            // 
            // ReadDataFromDBButton
            // 
            this.ReadDataFromDBButton.Location = new System.Drawing.Point(150, 138);
            this.ReadDataFromDBButton.Name = "ReadDataFromDBButton";
            this.ReadDataFromDBButton.Size = new System.Drawing.Size(180, 44);
            this.ReadDataFromDBButton.TabIndex = 1;
            this.ReadDataFromDBButton.Text = "Read Data From DB";
            this.ReadDataFromDBButton.UseVisualStyleBackColor = true;
            this.ReadDataFromDBButton.Click += new System.EventHandler(this.ReadDataFromDBButton_Click);
            // 
            // DemoDBConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.ReadDataFromDBButton);
            this.Controls.Add(this.TestDBConectionButton);
            this.MaximizeBox = false;
            this.Name = "DemoDBConnectionForm";
            this.Text = "DemoDBConnection application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TestDBConectionButton;
        private System.Windows.Forms.Button ReadDataFromDBButton;
    }
}

