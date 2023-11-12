namespace Semaphore_WinForm
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
            workingTxtBox = new ListBox();
            waitingTxtBox = new ListBox();
            createdTxtBox = new ListBox();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            createButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 58);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "Working Threads";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 58);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 1;
            label2.Text = "Waiting Threads";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(547, 58);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 2;
            label3.Text = "Created Threads";
            // 
            // workingTxtBox
            // 
            workingTxtBox.FormattingEnabled = true;
            workingTxtBox.ItemHeight = 25;
            workingTxtBox.Location = new Point(34, 117);
            workingTxtBox.Name = "workingTxtBox";
            workingTxtBox.Size = new Size(231, 179);
            workingTxtBox.TabIndex = 3;
            // 
            // waitingTxtBox
            // 
            waitingTxtBox.FormattingEnabled = true;
            waitingTxtBox.ItemHeight = 25;
            waitingTxtBox.Location = new Point(291, 117);
            waitingTxtBox.Name = "waitingTxtBox";
            waitingTxtBox.Size = new Size(220, 179);
            waitingTxtBox.TabIndex = 4;
            // 
            // createdTxtBox
            // 
            createdTxtBox.FormattingEnabled = true;
            createdTxtBox.ItemHeight = 25;
            createdTxtBox.Location = new Point(547, 117);
            createdTxtBox.Name = "createdTxtBox";
            createdTxtBox.Size = new Size(214, 179);
            createdTxtBox.TabIndex = 5;
            createdTxtBox.SelectedIndexChanged += createdTxtBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 318);
            label4.Name = "label4";
            label4.Size = new Size(175, 25);
            label4.TabIndex = 6;
            label4.Text = "Places in Semaphore";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(41, 368);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 7;
            // 
            // createButton
            // 
            createButton.Location = new Point(608, 368);
            createButton.Name = "createButton";
            createButton.Size = new Size(153, 34);
            createButton.TabIndex = 8;
            createButton.Text = "Create New";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(createButton);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(createdTxtBox);
            Controls.Add(waitingTxtBox);
            Controls.Add(workingTxtBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox workingTxtBox;
        private ListBox waitingTxtBox;
        private ListBox createdTxtBox;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Button createButton;
    }
}