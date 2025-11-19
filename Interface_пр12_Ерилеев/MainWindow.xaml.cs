using Interface_пр12_Ерилеев.Classes;
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

namespace Interface_пр12_Ерилеев
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal UsersContext usersContext = new Classes.UsersContext();
        internal MessagesContext messagesContext = new MessagesContext();
        public int IdSelectUser = -1;
        public static MainWindow mainwindow;

        public MainWindow()
        {
            InitializeComponent();

            mainwindow = this;

            LoadUser();
        }

        public void LoadUser()
        {
            foreach(Models.Users user in usersContext.AllUsers)
                ParentUser.Children.Add(new Elements.Users(user));
        }

        public void SelectUser(Models.Users User)
        {
            if (User != null)
                IdSelectUser = usersContext.AllUsers.FindIndex(x => x == User);

            ParentMessage.Children.Clear();

            foreach (MessagesContext messages in MessagesContext.AllMessages.FindAll(x => x.IdUser == IdSelectUser))
                ParentMessage.Children.Add(new Elements.Messages(messages));

            BlockMessage.IsEnabled = true;
        }

        private void SendMessages(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                if (IdSelectUser == -1)
                    return;

                MessagesContext newMessages = new MessagesContext(Message.Text, DateTime.Now, IdSelectUser);

                newMessages.Save();
                Message.Text = "";
                SelectUser(null);
            }

        }
    }
}
