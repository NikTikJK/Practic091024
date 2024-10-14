using System.Data.SqlClient;
using System.Data.SQLite;

namespace Practic091024
{
    public partial class Form1 : Form
    {
        List<Panel> panelList = new List<Panel>();
        string connectionString = "Data Source=D:\\myproject\\Sqllite\\new.db;Version=3;";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createPage();
        }

        public void Refresh_Form()
        {
            foreach (Control control in this.Controls.OfType<Control>().ToList())
            {
                this.Controls.Remove(control);
            }
            panelList.Clear();
            createPage();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createPage()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Партнёры";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string type = reader.GetString(0);
                            string title = reader.GetString(1);
                            string director = reader.GetString(2);
                            string email = reader.GetString(3);
                            string phone = reader.GetString(4);
                            string address = reader.GetString(5);
                            string rating = reader.GetInt32(7).ToString();
                            Dictionary<string, string> prop = new Dictionary<string, string>
                            {
                                {"type", type },
                                {"title", title },
                                {"director", director },
                                {"phone", phone },
                                {"rating", rating },
                                {"address",  address},
                                {"email", email},
                            };
                            createElemnt(prop);
                        }
                    }
                }
            }

            createElemntAdd();
        }

        private void createElemntAdd() 
        { 
            Panel panel = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Height = 100,
                Width = 940,
            };
            panel.Click += (sender, e) =>
            {
                FormAdd newForm = new FormAdd(this);
                newForm.ShowDialog();
            };
            Panel lastPanel = panelList.Last();
            panel.Location = new Point(lastPanel.Location.X, lastPanel.Location.Y + 120);
            Label label = new Label
            {
                Font = new Font("Segoe UI", 26, FontStyle.Bold),
                AutoSize = true,
                Text = "Add",
            };
            label.Location = new Point((panel.Width - label.Width) / 2, (panel.Height / 2) - label.Height);
            panel.Controls.Add(label);
            this.Controls.Add(panel);
        }
        private void createElemnt(Dictionary<string, string> dict)
        {
            Panel newPanel = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Height = 100,
                Width = 940
            };
            if (panelList.Count > 0)
            {
                Panel lastPanel = panelList.LastOrDefault();
                newPanel.Location = new Point(lastPanel.Location.X, lastPanel.Location.Y + 120);
            }
            else
            {
                newPanel.Location = new Point(20, 20);
            }
            newPanel.Click += (sender, e) =>
            {
                FormUpdate newForm = new FormUpdate(dict, this);
                newForm.ShowDialog();
            };
            Label labelTitle = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Text = $"{dict["type"]} | {dict["title"]}",
                Location = new Point(10, 10)
            };
            Label director = new Label
            {
                AutoSize = true,
                Location = new Point(labelTitle.Location.X, labelTitle.Location.Y + labelTitle.Height),
                Text = $"{dict["director"]}",
            };
            Label phone = new Label
            {
                AutoSize = true,
                Location = new Point(director.Location.X, director.Location.Y + director.Height),
                Text = $"+7 {dict["phone"]}",
            };
            Label rating = new Label
            {
                AutoSize = true,
                Location = new Point(phone.Location.X, phone.Location.Y + phone.Height - 5),
                Text = $"рейтинг: {dict["rating"]}",
            };
            int count = 0;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM [Партнёры и продукты] WHERE [Наименование партнера] = @Title";


                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", dict["title"]);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            count += reader.GetInt32(2);
                        }
                    }
                }
            }
            string disc;
            if (count < 10000)
            {
                disc = "0%";
            }else if (count >= 10000 && count < 50000)
            {
                disc = "5%";
            }
            else if (count >= 50000 && count < 300000)
            {
                disc = "10%";
            }else
            {
                disc = "15%";
            }

            Label price = new Label
            {
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(newPanel.Width - 100, labelTitle.Location.Y),
                Text = disc,
            };
            newPanel.Controls.Add(director);
            newPanel.Controls.Add(phone);
            newPanel.Controls.Add(rating);
            newPanel.Controls.Add(price);
            newPanel.Controls.Add(labelTitle);
            newPanel.Controls.Add(director);

            panelList.Add(newPanel);
            this.Controls.Add(newPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
