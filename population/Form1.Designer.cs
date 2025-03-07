namespace population
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            exitButton = new Button();
            decreaseLabel = new Label();
            increaseLabel = new Label();
            averageLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 43);
            label1.Name = "label1";
            label1.Size = new Size(287, 31);
            label1.TabIndex = 0;
            label1.Text = "US Population 1950-1990";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 146);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 1;
            label2.Text = "Average Anual Change";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 189);
            label3.Name = "label3";
            label3.Size = new Size(185, 20);
            label3.TabIndex = 2;
            label3.Text = "Year with greatest increase";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 233);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 3;
            label4.Text = "Year with Least Increase";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(177, 328);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // decreaseLabel
            // 
            decreaseLabel.BorderStyle = BorderStyle.FixedSingle;
            decreaseLabel.Location = new Point(265, 233);
            decreaseLabel.Name = "decreaseLabel";
            decreaseLabel.Size = new Size(93, 29);
            decreaseLabel.TabIndex = 7;
            // 
            // increaseLabel
            // 
            increaseLabel.BorderStyle = BorderStyle.FixedSingle;
            increaseLabel.Location = new Point(265, 189);
            increaseLabel.Name = "increaseLabel";
            increaseLabel.Size = new Size(93, 30);
            increaseLabel.TabIndex = 6;
            // 
            // averageLabel
            // 
            averageLabel.BorderStyle = BorderStyle.FixedSingle;
            averageLabel.Location = new Point(265, 146);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(93, 27);
            averageLabel.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 373);
            Controls.Add(decreaseLabel);
            Controls.Add(increaseLabel);
            Controls.Add(averageLabel);
            Controls.Add(exitButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button exitButton;
        private Label decreaseLabel;
        private Label increaseLabel;
        private Label averageLabel;
    }
}
