namespace CashDesk
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.amountSpinner = new System.Windows.Forms.NumericUpDown();
            this.priceSpinner = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.discountComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.amountSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "单价：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "数量：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = global::CashDesk.Properties.Resources.OKButtonCaptionString;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = global::CashDesk.Properties.Resources.ResetButtonCaptionString;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "总额：";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totalLabel.Location = new System.Drawing.Point(91, 242);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(70, 26);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "label4";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 114);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 121);
            this.listBox1.TabIndex = 9;
            // 
            // amountSpinner
            // 
            this.amountSpinner.Location = new System.Drawing.Point(55, 42);
            this.amountSpinner.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.amountSpinner.Name = "amountSpinner";
            this.amountSpinner.Size = new System.Drawing.Size(63, 20);
            this.amountSpinner.TabIndex = 11;
            // 
            // priceSpinner
            // 
            this.priceSpinner.DecimalPlaces = 2;
            this.priceSpinner.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.priceSpinner.Location = new System.Drawing.Point(55, 13);
            this.priceSpinner.Name = "priceSpinner";
            this.priceSpinner.Size = new System.Drawing.Size(63, 20);
            this.priceSpinner.TabIndex = 12;
            this.priceSpinner.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "优惠：";
            // 
            // discountComboBox
            // 
            this.discountComboBox.FormattingEnabled = true;
            this.discountComboBox.Items.AddRange(new object[] {
            "无优惠",
            "8折",
            "满300返100",
            "6折"});
            this.discountComboBox.Location = new System.Drawing.Point(55, 73);
            this.discountComboBox.Name = "discountComboBox";
            this.discountComboBox.Size = new System.Drawing.Size(121, 21);
            this.discountComboBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.discountComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceSpinner);
            this.Controls.Add(this.amountSpinner);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "收银系统";
            ((System.ComponentModel.ISupportInitialize)(this.amountSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown amountSpinner;
        private System.Windows.Forms.NumericUpDown priceSpinner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox discountComboBox;
    }
}

