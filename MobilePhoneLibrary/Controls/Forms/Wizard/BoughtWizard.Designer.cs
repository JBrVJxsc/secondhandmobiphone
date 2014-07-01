namespace MobilePhoneLibrary.Controls.Forms.Wizard
{
    partial class BoughtWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoughtWizard));
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).BeginInit();
            this.SuspendLayout();
            // 
            // BoughtWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 562);
            this.CompletionText = "输入卖家信息";
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BoughtWizard";
            this.Text = "收购";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}