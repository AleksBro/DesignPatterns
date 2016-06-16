namespace SoftwareDesignPatterns.WinFormsApp
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
            this.TestCreationalPatternsFactoryMethod_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestCreationalPatternsFactoryMethod_button
            // 
            this.TestCreationalPatternsFactoryMethod_button.Location = new System.Drawing.Point(58, 65);
            this.TestCreationalPatternsFactoryMethod_button.Name = "TestCreationalPatternsFactoryMethod_button";
            this.TestCreationalPatternsFactoryMethod_button.Size = new System.Drawing.Size(191, 24);
            this.TestCreationalPatternsFactoryMethod_button.TabIndex = 0;
            this.TestCreationalPatternsFactoryMethod_button.Text = "CreationalPatterns.FactoryMethod";
            this.TestCreationalPatternsFactoryMethod_button.UseVisualStyleBackColor = true;
            this.TestCreationalPatternsFactoryMethod_button.Click += new System.EventHandler(this.TestCreationalPatternsFactoryMethod_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 492);
            this.Controls.Add(this.TestCreationalPatternsFactoryMethod_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TestCreationalPatternsFactoryMethod_button;
    }
}

