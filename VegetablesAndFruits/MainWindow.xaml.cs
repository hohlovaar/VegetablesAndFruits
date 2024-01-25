using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VegetablesAndFruits
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static SqlConnection conn;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_connect(object sender, RoutedEventArgs e)
        {
            try
            {
                conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=VegetablesAndFruits; Integrated Security=SSPI;");
                conn.Open();
                text_block_DB.Text = "Сервер подключен";
                text_block_DB.Background = Brushes.LightGreen;

            }
            catch
            {
                text_block_DB.Text = "Сервер не подключен";
                text_block_DB.Background = Brushes.LightSalmon;
            }
        }

        private void button_disconnect(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Close();
                text_block_DB.Text = "Сервер отключен";
                text_block_DB.Background = Brushes.Beige;

            }
            catch
            {
                text_block_DB.Text = "Сервер не подключен";
                text_block_DB.Background = Brushes.LightSalmon;
            }

        }

        private void whole_table(object sender, RoutedEventArgs e)
        {
            try
            {
                string selectString = @"select * from VegetablesAndFruits;";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = selectString;

                SqlDataReader sdr = cmd.ExecuteReader();

                string text = "";

                while (sdr.Read())
                {
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        text += sdr[i] + "\t";
                    }
                    text += "\n";
                }

                information_db.Text = text;
            }
            catch
            {
                information_db.Text = "Не удалось вывести данные. Проверьте подключение к серверу!";
            }
        }

        private void names_products(object sender, RoutedEventArgs e)
        {
            try
            {
                string selectString = @"select Name from VegetablesAndFruits;";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = selectString;

                SqlDataReader sdr = cmd.ExecuteReader();

                string text = "";

                while (sdr.Read())
                {
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        text += sdr[i] + "\t";
                    }
                    text += "\n";
                }

                information_db.Text = text;
            }
            catch
            {
                information_db.Text = "Не удалось вывести данные. Проверьте подключение к серверу!";
            }
        }

        private void colours_products(object sender, RoutedEventArgs e)
        {
            try
            {
                string selectString = @"select distinct Colour from VegetablesAndFruits;";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = selectString;

                SqlDataReader sdr = cmd.ExecuteReader();

                string text = "";

                while (sdr.Read())
                {
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        text += sdr[i] + "\t";
                    }
                    text += "\n";
                }

                information_db.Text = text;
            }
            catch
            {
                information_db.Text = "Не удалось вывести данные. Проверьте подключение к серверу!";
            }
        }

        private void max_calorie(object sender, RoutedEventArgs e)
        {
            try
            {
                string selectString = @"select max(Calorie) from VegetablesAndFruits;";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = selectString;

                SqlDataReader sdr = cmd.ExecuteReader();

                string text = "";

                while (sdr.Read())
                {
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        text += sdr[i] + "\t";
                    }
                    text += "\n";
                }

                information_db.Text = text;
            }
            catch
            {
                information_db.Text = "Не удалось вывести данные. Проверьте подключение к серверу!";
            }
        }

        private void min_calorie(object sender, RoutedEventArgs e)
        {
            try
            {
                string selectString = @"select min(Calorie) from VegetablesAndFruits;";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = selectString;

                SqlDataReader sdr = cmd.ExecuteReader();

                string text = "";

                while (sdr.Read())
                {
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        text += sdr[i] + "\t";
                    }
                    text += "\n";
                }

                information_db.Text = text;
            }
            catch
            {
                information_db.Text = "Не удалось вывести данные. Проверьте подключение к серверу!";
            }
        }

        private void average_calorie(object sender, RoutedEventArgs e)
        {
            try
            {
                string selectString = @"select avg(Calorie) from VegetablesAndFruits;";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = selectString;

                SqlDataReader sdr = cmd.ExecuteReader();

                string text = "";

                while (sdr.Read())
                {
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        text += sdr[i] + "\t";
                    }
                    text += "\n";
                }

                information_db.Text = text;
            }
            catch
            {
                information_db.Text = "Не удалось вывести данные. Проверьте подключение к серверу!";
            }
        }

        private void number_of_vegetables(object sender, RoutedEventArgs e)
        {
            try
            {
                string selectString = @"select count(*) from VegetablesAndFruits where Type = 'Овощ';";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = selectString;

                SqlDataReader sdr = cmd.ExecuteReader();

                string text = "";

                while (sdr.Read())
                {
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        text += sdr[i] + "\t";
                    }
                    text += "\n";
                }

                information_db.Text = text;
            }
            catch
            {
                information_db.Text = "Не удалось вывести данные. Проверьте подключение к серверу!";
            }
        }

        private void number_of_fruits(object sender, RoutedEventArgs e)
        {
            try
            {
                string selectString = @"select count(*) from VegetablesAndFruits where Type = 'Фрукт';";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = selectString;

                SqlDataReader sdr = cmd.ExecuteReader();

                string text = "";

                while (sdr.Read())
                {
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        text += sdr[i] + "\t";
                    }
                    text += "\n";
                }

                information_db.Text = text;
            }
            catch
            {
                information_db.Text = "Не удалось вывести данные. Проверьте подключение к серверу!";
            }
        }
    }
}
