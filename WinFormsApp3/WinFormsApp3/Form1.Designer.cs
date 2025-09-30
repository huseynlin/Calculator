namespace WinFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            num1 = new MaskedTextBox();
            num2 = new MaskedTextBox();
            operation = new ComboBox();
            history = new ListBox();
            label1 = new Label();
            label2 = new Label();
            result = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // num1
            // 
            num1.Location = new Point(72, 84);
            num1.Margin = new Padding(6, 7, 6, 7);
            num1.Mask = "00000000";
            num1.Name = "num1";
            num1.Size = new Size(512, 42);
            num1.TabIndex = 0;
            num1.ValidatingType = typeof(int);
            // 
            // num2
            // 
            num2.Location = new Point(72, 257);
            num2.Margin = new Padding(6, 7, 6, 7);
            num2.Mask = "00000000";
            num2.Name = "num2";
            num2.Size = new Size(512, 42);
            num2.TabIndex = 1;
            num2.ValidatingType = typeof(int);
            // 
            // operation
            // 
            operation.FormattingEnabled = true;
            operation.Items.AddRange(new object[] { "+", "-", "*", "/" });
            operation.Location = new Point(76, 373);
            operation.Margin = new Padding(6, 7, 6, 7);
            operation.Name = "operation";
            operation.Size = new Size(512, 44);
            operation.TabIndex = 3;
            operation.Text = "Operations";
            // 
            // history
            // 
            history.FormattingEnabled = true;
            history.ItemHeight = 36;
            history.Location = new Point(72, 679);
            history.Margin = new Padding(6, 7, 6, 7);
            history.Name = "history";
            history.Size = new Size(512, 328);
            history.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 22);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 37);
            label1.TabIndex = 5;
            label1.Text = "Number one:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 194);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 37);
            label2.TabIndex = 6;
            label2.Text = "Number two:";
            // 
            // result
            // 
            result.Location = new Point(72, 485);
            result.Margin = new Padding(6, 7, 6, 7);
            result.Name = "result";
            result.Size = new Size(516, 55);
            result.TabIndex = 2;
            result.Text = "Result";
            result.UseVisualStyleBackColor = true;
            result.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 614);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 37);
            label3.TabIndex = 7;
            label3.Text = "History";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(652, 1080);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(history);
            Controls.Add(operation);
            Controls.Add(result);
            Controls.Add(num2);
            Controls.Add(num1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Cakulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox num1;
        private MaskedTextBox num2;
        private ComboBox operation;
        private ListBox history;
        private Label label1;
        private Label label2;
        private Button result;
        private Label label3;
    }
}
