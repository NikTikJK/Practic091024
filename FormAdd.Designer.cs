namespace Practic091024
{
    partial class FormAdd
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
            numericUpDownRating = new NumericUpDown();
            textBoxTitle = new TextBox();
            textBoxDirector = new TextBox();
            textBoxAddress = new TextBox();
            textBoxPhone = new TextBox();
            comboBoxType = new ComboBox();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            labelPhone = new Label();
            labelAddress = new Label();
            labelRating = new Label();
            labelDirector = new Label();
            labelTitle = new Label();
            labelType = new Label();
            button1 = new Button();
            labelINN = new Label();
            textBoxINN = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRating).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownRating
            // 
            numericUpDownRating.Location = new Point(357, 184);
            numericUpDownRating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownRating.Name = "numericUpDownRating";
            numericUpDownRating.Size = new Size(207, 23);
            numericUpDownRating.TabIndex = 34;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(357, 90);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(207, 23);
            textBoxTitle.TabIndex = 33;
            // 
            // textBoxDirector
            // 
            textBoxDirector.Location = new Point(357, 138);
            textBoxDirector.Name = "textBoxDirector";
            textBoxDirector.Size = new Size(207, 23);
            textBoxDirector.TabIndex = 32;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(357, 225);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(207, 23);
            textBoxAddress.TabIndex = 31;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(357, 271);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(207, 23);
            textBoxPhone.TabIndex = 30;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "ЗАО", "ООО", "ПАО", "ОАО" });
            comboBoxType.Location = new Point(357, 47);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(207, 23);
            comboBoxType.TabIndex = 29;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(357, 315);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(207, 23);
            textBoxEmail.TabIndex = 28;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(245, 318);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 27;
            labelEmail.Text = "Email:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(245, 274);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(58, 15);
            labelPhone.TabIndex = 26;
            labelPhone.Text = "Телефон:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(245, 228);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(43, 15);
            labelAddress.TabIndex = 25;
            labelAddress.Text = "Адрес:";
            // 
            // labelRating
            // 
            labelRating.AutoSize = true;
            labelRating.Location = new Point(245, 186);
            labelRating.Name = "labelRating";
            labelRating.Size = new Size(54, 15);
            labelRating.TabIndex = 24;
            labelRating.Text = "Рейтинг:";
            // 
            // labelDirector
            // 
            labelDirector.AutoSize = true;
            labelDirector.Location = new Point(245, 141);
            labelDirector.Name = "labelDirector";
            labelDirector.Size = new Size(97, 15);
            labelDirector.TabIndex = 23;
            labelDirector.Text = "ФИО директора:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(245, 93);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(93, 15);
            labelTitle.TabIndex = 22;
            labelTitle.Text = "Наименование:";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(245, 47);
            labelType.Name = "labelType";
            labelType.Size = new Size(84, 15);
            labelType.TabIndex = 21;
            labelType.Text = "Тип партнёра:";
            // 
            // button1
            // 
            button1.Location = new Point(300, 415);
            button1.Name = "button1";
            button1.Size = new Size(211, 23);
            button1.TabIndex = 35;
            button1.Text = "добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelINN
            // 
            labelINN.AutoSize = true;
            labelINN.Location = new Point(245, 357);
            labelINN.Name = "labelINN";
            labelINN.Size = new Size(37, 15);
            labelINN.TabIndex = 36;
            labelINN.Text = "ИНН:";
            // 
            // textBoxINN
            // 
            textBoxINN.Location = new Point(357, 354);
            textBoxINN.Name = "textBoxINN";
            textBoxINN.Size = new Size(207, 23);
            textBoxINN.TabIndex = 37;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxINN);
            Controls.Add(labelINN);
            Controls.Add(button1);
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
            Name = "FormAdd";
            Text = "Добавление партнёра";
            FormClosing += FormAdd_FormClosing;
            FormClosed += FormAdd_FormClosed;
            Load += FormAdd_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownRating;
        private TextBox textBoxTitle;
        private TextBox textBoxDirector;
        private TextBox textBoxAddress;
        private TextBox textBoxPhone;
        private ComboBox comboBoxType;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Label labelPhone;
        private Label labelAddress;
        private Label labelRating;
        private Label labelDirector;
        private Label labelTitle;
        private Label labelType;
        private Button button1;
        private Label labelINN;
        private TextBox textBoxINN;
    }
}