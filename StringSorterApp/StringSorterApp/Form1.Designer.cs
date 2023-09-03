namespace LetterSortApp
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
            textBoxInput = new TextBox();
            labelResult = new Label();
            buttonSort = new Button();
            comboBoxStrategy = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.BackColor = SystemColors.Window;
            textBoxInput.Cursor = Cursors.IBeam;
            textBoxInput.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxInput.ForeColor = SystemColors.InactiveCaptionText;
            textBoxInput.Location = new Point(125, 70);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(193, 33);
            textBoxInput.TabIndex = 2;
            textBoxInput.Enter += textBoxInput_Enter;
            textBoxInput.Leave += textBoxInput_Leave;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.BackColor = Color.FromArgb(255, 255, 192);
            labelResult.Cursor = Cursors.IBeam;
            labelResult.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelResult.Location = new Point(179, 313);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(60, 25);
            labelResult.TabIndex = 1;
            labelResult.Text = "result";
            // 
            // buttonSort
            // 
            buttonSort.BackColor = Color.FromArgb(192, 255, 192);
            buttonSort.Cursor = Cursors.Hand;
            buttonSort.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSort.Location = new Point(179, 233);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(139, 33);
            buttonSort.TabIndex = 2;
            buttonSort.Text = "Click to sort";
            buttonSort.UseVisualStyleBackColor = false;
            // 
            // comboBoxStrategy
            // 
            comboBoxStrategy.BackColor = Color.FromArgb(192, 255, 255);
            comboBoxStrategy.Cursor = Cursors.Hand;
            comboBoxStrategy.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comboBoxStrategy.FormattingEnabled = true;
            comboBoxStrategy.Items.AddRange(new object[] { "Bubble Sort", "Merge Sort" });
            comboBoxStrategy.Location = new Point(179, 157);
            comboBoxStrategy.Name = "comboBoxStrategy";
            comboBoxStrategy.Size = new Size(139, 33);
            comboBoxStrategy.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 313);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 4;
            label1.Text = "Sorted string:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 9);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 5;
            label2.Text = "String Sorter";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 192, 255);
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 165);
            label3.Name = "label3";
            label3.Size = new Size(155, 25);
            label3.TabIndex = 6;
            label3.Text = "Choose strategy:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(349, 402);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxStrategy);
            Controls.Add(buttonSort);
            Controls.Add(labelResult);
            Controls.Add(textBoxInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private Label labelResult;
        private Button buttonSort;
        private ComboBox comboBoxStrategy;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}