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
    public partial class FormUpdate : Form
    {
        Dictionary<string, string> data;
        string connectionString = "Data Source=D:\\myproject\\Sqllite\\new.db;Version=3;";
        Form1 form1;

        public FormUpdate(Dictionary<string, string> dict, Form1 form1)
        {
            InitializeComponent();
            data = dict;
            this.form1 = form1;

        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            switch (data["type"])
            {
                case "ЗАО":
                    comboBoxType.SelectedIndex = 0;
                    break;
                case "ООО":
                    comboBoxType.SelectedIndex = 1;
                    break;
                case "ПАО":
                    comboBoxType.SelectedIndex = 2;
                    break;
                case "ОАО":
                    comboBoxType.SelectedIndex = 3;
                    break;
            }

            textBoxTitle.Text = data["title"];
            textBoxDirector.Text = data["director"];
            numericUpDownRating.Value = Convert.ToDecimal(data["rating"]);
            textBoxAddress.Text = data["address"];
            textBoxPhone.Text = data["phone"];
            textBoxEmail.Text = data["email"];
        }

        private void FormUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Хотите сохранить изменения перед закрытием?", "Подтверждение", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Партнёры SET [Тип партнера] = @Type, [Наименование партнера] = @Title, [Директор] = @Director, [Электронная почта партнера] = @Email, [Телефон партнера] = @Phone, [Юридический адрес партнера] = @Address, [Рейтинг] = @Rating WHERE [Наименование партнера] = @TitleS";

                    using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Type", comboBoxType.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Title", textBoxTitle.Text);
                        command.Parameters.AddWithValue("@Director", textBoxDirector.Text);
                        command.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        command.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
                        command.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                        command.Parameters.AddWithValue("@Rating", numericUpDownRating.Value);
                        command.Parameters.AddWithValue("@TitleS", data["title"]);

                        int rowsUpdated = command.ExecuteNonQuery();
                        Console.WriteLine("Rows Updated: " + rowsUpdated);
                    }

                    connection.Close();
                }

                MessageBox.Show("Данные сохранены.");
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true; // Отменить закрытие формы
            }
        }

        private void FormUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Refresh_Form();
        }
    }
}
