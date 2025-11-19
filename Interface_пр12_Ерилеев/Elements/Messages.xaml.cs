using Interface_пр12_Ерилеев.Classes;
using System.Windows.Input;


namespace Interface_пр12_Ерилеев.Elements
{
    /// <summary>
    /// Логика взаимодействия для Messages.xaml
    /// </summary>
    public partial class Messages : System.Windows.Controls.UserControl
    {
        /// <summary>
        /// Данные о сообщении с которым мы взаимодействуем
        /// </summary>
        internal MessagesContext ThisMessage;
        internal Messages(Classes.MessagesContext messages)
        {
            InitializeComponent();
            /// Запоминаем сообщение с которым взаимодействуем
            ThisMessage = messages;

            // Отображаем текст сообщения
            Message.Text = messages.Message;

            // Отображаем дату сообщения
            Date.Text = messages.Create.ToString("dd.MM.yyyy");
        }

        private void DeleteMessage(object sender, MouseButtonEventArgs e)
        {
            // Вызываем метод удаления в реализующем классе
            ThisMessage.Delete();
            // Удаляем с UI
            ((MainWindow)System.Windows.Application.Current.MainWindow).ParentMessage.Children.Remove(this);

        }
    }
}