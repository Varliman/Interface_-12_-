using System;
using System.Collections.Generic;
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

namespace Interface_пр12_Ерилеев.Elements
{
    public partial class Users : UserControl
    {
        public Models.Users ThisUser;
        /// <summary>
        /// Конструктор элемента
        /// </summary>
        /// <param name="User">Данные о пользователе</param>
        
        public Users(Models.Users User)
        {
            InitializeComponent();
            ThisUser = User;

            FIO.Text = User.FIO;
        }
        /// <summary>
        /// Метод выбора пользователя
        /// </summary>
        private void SelectUser(object sender, MouseButtonEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).SelectUser(ThisUser);

        }
    }
}
