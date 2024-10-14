using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic091024
{
    public partial class FormAdd : Form
    {
        Form1 form1;
        string connectionString = "Data Source=D:\\myproject\\Sqllite\\new.db;Version=3;";

        public FormAdd(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
            button1.BackColor = ColorTranslator.FromHtml("#67BA80");
            button1.FlatStyle = FlatStyle.Flat;
        }

        private void FormAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите закрыть форму?", "Подтверждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Отменяет закрытие формы
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool allFieldsFilled = true;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        allFieldsFilled = false;
                        break;
                    }
                }
            }

            if (allFieldsFilled)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string querry = "INSERT INTO Партнёры ([Тип партнера], [Наименование партнера], [Директор], [Электронная почта партнера], [Телефон партнера], [Юридический адрес партнера], [ИНН], [Рейтинг]) VALUES (@Type, @Title, @Director, @Email, @Phone, @Address, @INN, @Rating);";

                    using (SQLiteCommand command = new SQLiteCommand(querry, connection))
                    {
                        command.Parameters.AddWithValue("@Type", comboBoxType.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Title", textBoxTitle.Text);
                        command.Parameters.AddWithValue("@Director", textBoxDirector.Text);
                        command.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        command.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
                        command.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                        command.Parameters.AddWithValue("@INN", Convert.ToInt32(textBoxINN.Text));
                        command.Parameters.AddWithValue("@Rating", numericUpDownRating.Value);

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
            }
        }

        private void FormAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Refresh_Form();
        }
    }
}
