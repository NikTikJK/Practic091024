namespace Practic091024
{
    partial class FormUpdate
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
            labelType = new Label();
            labelTitle = new Label();
            labelDirector = new Label();
            labelRating = new Label();
            labelAddress = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            comboBoxType = new ComboBox();
            textBoxPhone = new TextBox();
            textBoxAddress = new TextBox();
            textBoxDirector = new TextBox();
            textBoxTitle = new TextBox();
            numericUpDownRating = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRating).BeginInit();
            SuspendLayout();
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.BackColor = Color.White;
            labelType.Location = new Point(294, 58);
            labelType.Name = "labelType";
            labelType.Size = new Size(84, 15);
            labelType.TabIndex = 0;
            labelType.Text = "Тип партнёра:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.White;
            labelTitle.Location = new Point(294, 104);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(93, 15);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Наименование:";
            // 
            // labelDirector
            // 
            labelDirector.AutoSize = true;
            labelDirector.BackColor = Color.White;
            labelDirector.Location = new Point(294, 152);
            labelDirector.Name = "labelDirector";
            labelDirector.Size = new Size(97, 15);
            labelDirector.TabIndex = 2;
            labelDirector.Text = "ФИО директора:";
            // 
            // labelRating
            // 
            labelRating.AutoSize = true;
            labelRating.BackColor = Color.White;
            labelRating.Location = new Point(294, 197);
            labelRating.Name = "labelRating";
            labelRating.Size = new Size(54, 15);
            labelRating.TabIndex = 3;
            labelRating.Text = "Рейтинг:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.BackColor = Color.White;
            labelAddress.Location = new Point(294, 239);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(43, 15);
            labelAddress.TabIndex = 4;
            labelAddress.Text = "Адрес:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.BackColor = Color.White;
            labelPhone.Location = new Point(294, 285);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(58, 15);
            labelPhone.TabIndex = 5;
            labelPhone.Text = "Телефон:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.White;
            labelEmail.Location = new Point(294, 329);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.White;
            textBoxEmail.Location = new Point(406, 326);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(207, 23);
            textBoxEmail.TabIndex = 13;
            // 
            // comboBoxType
            // 
            comboBoxType.BackColor = Color.White;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "ЗАО", "ООО", "ПАО", "ОАО" });
            comboBoxType.Location = new Point(406, 58);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(207, 23);
            comboBoxType.TabIndex = 14;
            // 
            // textBoxPhone
            // 
            textBoxPhone.BackColor = Color.White;
            textBoxPhone.Location = new Point(406, 282);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(207, 23);
            textBoxPhone.TabIndex = 15;
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = Color.White;
            textBoxAddress.Location = new Point(406, 236);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(207, 23);
            textBoxAddress.TabIndex = 16;
            // 
            // textBoxDirector
            // 
            textBoxDirector.BackColor = Color.White;
            textBoxDirector.Location = new Point(406, 149);
            textBoxDirector.Name = "textBoxDirector";
            textBoxDirector.Size = new Size(207, 23);
            textBoxDirector.TabIndex = 18;
            // 
            // textBoxTitle
            // 
            textBoxTitle.BackColor = Color.White;
            textBoxTitle.Location = new Point(406, 101);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(207, 23);
            textBoxTitle.TabIndex = 19;
            // 
            // numericUpDownRating
            // 
            numericUpDownRating.BackColor = Color.White;
            numericUpDownRating.Location = new Point(406, 195);
            numericUpDownRating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownRating.Name = "numericUpDownRating";
            numericUpDownRating.Size = new Size(207, 23);
            numericUpDownRating.TabIndex = 20;
            // 
            // FormUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 455);
            Controls.Add(numericUpDownRating);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxDirector);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxPhone);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(labelPhone);
            Controls.Add(labelAddress);
            Controls.Add(labelRating);
            Controls.Add(labelDirector);
            Controls.Add(labelTitle);
            Controls.Add(labelType);
            Name = "FormUpdate";
            Text = "Изменение данных партнёра";
            FormClosing += FormUpdate_FormClosing;
            FormClosed += FormUpdate_FormClosed;
            Load += FormUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelType;
        private Label labelTitle;
        private Label labelDirector;
        private Label labelRating;
        private Label labelAddress;
        private Label labelPhone;
        private Label labelEmail;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBoxEmail;
        private ComboBox comboBoxType;
        private TextBox textBoxPhone;
        private TextBox textBoxAddress;
        private TextBox textBoxDirector;
        private TextBox textBoxTitle;
        private NumericUpDown numericUpDownRating;
    }
}