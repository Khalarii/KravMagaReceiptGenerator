namespace ReciboKravMaga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.amountPaid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentType = new System.Windows.Forms.GroupBox();
            this.otherPaymentType = new System.Windows.Forms.TextBox();
            this.otherType = new System.Windows.Forms.RadioButton();
            this.threeMonths = new System.Windows.Forms.RadioButton();
            this.oneMonth = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.paymentDate = new System.Windows.Forms.DateTimePicker();
            this.paymentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aluno:";
            // 
            // studentName
            // 
            this.studentName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.studentName.Location = new System.Drawing.Point(135, 12);
            this.studentName.MaxLength = 200;
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(264, 21);
            this.studentName.TabIndex = 0;
            // 
            // amountPaid
            // 
            this.amountPaid.Location = new System.Drawing.Point(135, 39);
            this.amountPaid.Name = "amountPaid";
            this.amountPaid.Size = new System.Drawing.Size(100, 21);
            this.amountPaid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.label2.Location = new System.Drawing.Point(64, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor (R$):";
            // 
            // paymentType
            // 
            this.paymentType.Controls.Add(this.otherPaymentType);
            this.paymentType.Controls.Add(this.otherType);
            this.paymentType.Controls.Add(this.threeMonths);
            this.paymentType.Controls.Add(this.oneMonth);
            this.paymentType.Location = new System.Drawing.Point(75, 98);
            this.paymentType.Name = "paymentType";
            this.paymentType.Size = new System.Drawing.Size(246, 96);
            this.paymentType.TabIndex = 3;
            this.paymentType.TabStop = false;
            this.paymentType.Text = "Tipo do Pagamento";
            // 
            // otherPaymentType
            // 
            this.otherPaymentType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.otherPaymentType.Enabled = false;
            this.otherPaymentType.Location = new System.Drawing.Point(75, 59);
            this.otherPaymentType.Name = "otherPaymentType";
            this.otherPaymentType.Size = new System.Drawing.Size(165, 21);
            this.otherPaymentType.TabIndex = 5;
            // 
            // otherType
            // 
            this.otherType.AutoSize = true;
            this.otherType.Location = new System.Drawing.Point(11, 60);
            this.otherType.Name = "otherType";
            this.otherType.Size = new System.Drawing.Size(58, 19);
            this.otherType.TabIndex = 2;
            this.otherType.TabStop = true;
            this.otherType.Text = "Outro:";
            this.otherType.UseVisualStyleBackColor = true;
            this.otherType.CheckedChanged += new System.EventHandler(this.oneMonth_CheckedChanged);
            // 
            // threeMonths
            // 
            this.threeMonths.AutoSize = true;
            this.threeMonths.Location = new System.Drawing.Point(123, 34);
            this.threeMonths.Name = "threeMonths";
            this.threeMonths.Size = new System.Drawing.Size(111, 19);
            this.threeMonths.TabIndex = 1;
            this.threeMonths.TabStop = true;
            this.threeMonths.Text = "Trimestralidade";
            this.threeMonths.UseVisualStyleBackColor = true;
            this.threeMonths.CheckedChanged += new System.EventHandler(this.oneMonth_CheckedChanged);
            // 
            // oneMonth
            // 
            this.oneMonth.AutoSize = true;
            this.oneMonth.Location = new System.Drawing.Point(11, 34);
            this.oneMonth.Name = "oneMonth";
            this.oneMonth.Size = new System.Drawing.Size(97, 19);
            this.oneMonth.TabIndex = 0;
            this.oneMonth.TabStop = true;
            this.oneMonth.Text = "Mensalidade";
            this.oneMonth.UseVisualStyleBackColor = true;
            this.oneMonth.CheckedChanged += new System.EventHandler(this.oneMonth_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data do Pagamento:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 44);
            this.button1.TabIndex = 99;
            this.button1.Text = "Gerar Recibo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // paymentDate
            // 
            this.paymentDate.CustomFormat = "";
            this.paymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.paymentDate.Location = new System.Drawing.Point(135, 67);
            this.paymentDate.Name = "paymentDate";
            this.paymentDate.Size = new System.Drawing.Size(102, 21);
            this.paymentDate.TabIndex = 2;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 261);
            this.Controls.Add(this.paymentDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paymentType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountPaid);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Gerador Recibo de Pagamento - Centro de Krav Maga Moema";
            this.paymentType.ResumeLayout(false);
            this.paymentType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.TextBox amountPaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox paymentType;
        private System.Windows.Forms.TextBox otherPaymentType;
        private System.Windows.Forms.RadioButton otherType;
        private System.Windows.Forms.RadioButton threeMonths;
        private System.Windows.Forms.RadioButton oneMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker paymentDate;
    }
}

