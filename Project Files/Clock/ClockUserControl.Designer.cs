namespace Clock
{
    partial class clockUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clockLabel = new Label();
            SuspendLayout();
            // 
            // clockLabel
            // 
            clockLabel.AutoSize = true;
            clockLabel.Location = new Point(621, 376);
            clockLabel.Margin = new Padding(6, 0, 6, 0);
            clockLabel.Name = "clockLabel";
            clockLabel.Size = new Size(77, 37);
            clockLabel.TabIndex = 0;
            clockLabel.Text = "clock";
            // 
            // clockUserControl
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(clockLabel);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(6);
            Name = "clockUserControl";
            Size = new Size(2364, 1698);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label clockLabel;
    }
}
