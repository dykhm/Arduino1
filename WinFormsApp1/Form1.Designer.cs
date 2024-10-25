namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            statusLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 14F);
            button1.Location = new Point(268, 77);
            button1.Name = "button1";
            button1.Size = new Size(187, 65);
            button1.TabIndex = 0;
            button1.Text = "ON";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 14F);
            button2.Location = new Point(268, 181);
            button2.Name = "button2";
            button2.Size = new Size(187, 63);
            button2.TabIndex = 1;
            button2.Text = "OFF";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI Black", 12F);
            statusLabel.Location = new Point(277, 282);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(189, 21);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "Button State: Released";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusLabel);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label statusLabel;
    }
}
