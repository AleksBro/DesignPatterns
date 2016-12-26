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
            this.TestBehavioralPatternsChainOfResponsibility_button = new System.Windows.Forms.Button();
            this.TestCreationalPatternsBuilderWikipediaExample_button = new System.Windows.Forms.Button();
            this.TestCreationalPatternsBuilderMetanitExample_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestCreationalPatternsFactoryMethod_button
            // 
            this.TestCreationalPatternsFactoryMethod_button.Location = new System.Drawing.Point(41, 51);
            this.TestCreationalPatternsFactoryMethod_button.Name = "TestCreationalPatternsFactoryMethod_button";
            this.TestCreationalPatternsFactoryMethod_button.Size = new System.Drawing.Size(191, 24);
            this.TestCreationalPatternsFactoryMethod_button.TabIndex = 0;
            this.TestCreationalPatternsFactoryMethod_button.Text = "CreationalPatterns.FactoryMethod";
            this.TestCreationalPatternsFactoryMethod_button.UseVisualStyleBackColor = true;
            this.TestCreationalPatternsFactoryMethod_button.Click += new System.EventHandler(this.TestCreationalPatternsFactoryMethod_button_Click);
            // 
            // TestBehavioralPatternsChainOfResponsibility_button
            // 
            this.TestBehavioralPatternsChainOfResponsibility_button.Location = new System.Drawing.Point(41, 283);
            this.TestBehavioralPatternsChainOfResponsibility_button.Name = "TestBehavioralPatternsChainOfResponsibility_button";
            this.TestBehavioralPatternsChainOfResponsibility_button.Size = new System.Drawing.Size(217, 23);
            this.TestBehavioralPatternsChainOfResponsibility_button.TabIndex = 1;
            this.TestBehavioralPatternsChainOfResponsibility_button.Text = "BehavioralPatterns.ChainOfResponsibility";
            this.TestBehavioralPatternsChainOfResponsibility_button.UseVisualStyleBackColor = true;
            this.TestBehavioralPatternsChainOfResponsibility_button.Click += new System.EventHandler(this.TestBehavioralPatternsChainOfResponsibility_button_Click);
            // 
            // TestCreationalPatternsBuilderWikipediaExample_button
            // 
            this.TestCreationalPatternsBuilderWikipediaExample_button.Location = new System.Drawing.Point(41, 81);
            this.TestCreationalPatternsBuilderWikipediaExample_button.Name = "TestCreationalPatternsBuilderWikipediaExample_button";
            this.TestCreationalPatternsBuilderWikipediaExample_button.Size = new System.Drawing.Size(244, 24);
            this.TestCreationalPatternsBuilderWikipediaExample_button.TabIndex = 2;
            this.TestCreationalPatternsBuilderWikipediaExample_button.Text = "CreationalPatterns.Builder - Wikipedia Example";
            this.TestCreationalPatternsBuilderWikipediaExample_button.UseVisualStyleBackColor = true;
            this.TestCreationalPatternsBuilderWikipediaExample_button.Click += new System.EventHandler(this.TestCreationalPatternsBuilderWikipediaExample_button_Click);
            // 
            // TestCreationalPatternsBuilderMetanitExample_button
            // 
            this.TestCreationalPatternsBuilderMetanitExample_button.Location = new System.Drawing.Point(291, 81);
            this.TestCreationalPatternsBuilderMetanitExample_button.Name = "TestCreationalPatternsBuilderMetanitExample_button";
            this.TestCreationalPatternsBuilderMetanitExample_button.Size = new System.Drawing.Size(244, 24);
            this.TestCreationalPatternsBuilderMetanitExample_button.TabIndex = 3;
            this.TestCreationalPatternsBuilderMetanitExample_button.Text = "CreationalPatterns.Builder - Metanit Example";
            this.TestCreationalPatternsBuilderMetanitExample_button.UseVisualStyleBackColor = true;
            this.TestCreationalPatternsBuilderMetanitExample_button.Click += new System.EventHandler(this.TestCreationalPatternsBuilderMetanitExample_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 492);
            this.Controls.Add(this.TestCreationalPatternsBuilderMetanitExample_button);
            this.Controls.Add(this.TestCreationalPatternsBuilderWikipediaExample_button);
            this.Controls.Add(this.TestBehavioralPatternsChainOfResponsibility_button);
            this.Controls.Add(this.TestCreationalPatternsFactoryMethod_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TestCreationalPatternsFactoryMethod_button;
        private System.Windows.Forms.Button TestBehavioralPatternsChainOfResponsibility_button;
        private System.Windows.Forms.Button TestCreationalPatternsBuilderWikipediaExample_button;
        private System.Windows.Forms.Button TestCreationalPatternsBuilderMetanitExample_button;
    }
}

