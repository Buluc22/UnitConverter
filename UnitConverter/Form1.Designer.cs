namespace UnitConverter
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
            txtAmount = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            cmbType = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            lstFrom = new ListBox();
            lstTo = new ListBox();
            btnConvert = new Button();
            panel2 = new Panel();
            txtConvertedAmount = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 30);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(110, 31);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(194, 23);
            txtAmount.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(92, 290);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 85);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(112, 32);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 3;
            label2.Text = "Type";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(202, 33);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(194, 23);
            cmbType.TabIndex = 4;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(112, 125);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 5;
            label3.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(276, 125);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 6;
            label4.Text = "To";
            // 
            // lstFrom
            // 
            lstFrom.FormattingEnabled = true;
            lstFrom.ItemHeight = 15;
            lstFrom.Location = new Point(112, 163);
            lstFrom.Name = "lstFrom";
            lstFrom.Size = new Size(120, 109);
            lstFrom.TabIndex = 7;
            // 
            // lstTo
            // 
            lstTo.FormattingEnabled = true;
            lstTo.ItemHeight = 15;
            lstTo.Location = new Point(276, 163);
            lstTo.Name = "lstTo";
            lstTo.Size = new Size(120, 109);
            lstTo.TabIndex = 8;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvert.Location = new Point(202, 390);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(134, 65);
            btnConvert.TabIndex = 9;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtConvertedAmount);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(61, 477);
            panel2.Name = "panel2";
            panel2.Size = new Size(406, 77);
            panel2.TabIndex = 3;
            // 
            // txtConvertedAmount
            // 
            txtConvertedAmount.Location = new Point(191, 24);
            txtConvertedAmount.Name = "txtConvertedAmount";
            txtConvertedAmount.Size = new Size(168, 23);
            txtConvertedAmount.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(31, 27);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 0;
            label5.Text = "Converted Amount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(521, 637);
            Controls.Add(panel2);
            Controls.Add(btnConvert);
            Controls.Add(lstTo);
            Controls.Add(lstFrom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbType);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Unit Converter";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAmount;
        private Panel panel1;
        private Label label2;
        private ComboBox cmbType;
        private Label label3;
        private Label label4;
        private ListBox lstFrom;
        private ListBox lstTo;
        private Button btnConvert;
        private Panel panel2;
        private TextBox txtConvertedAmount;
        private Label label5;
    }
}