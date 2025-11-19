using Interface_пр12_Ерилеев.Interfaces;
using Interface_пр12_Ерилеев.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace Interface_пр12_Ерилеев.Classes
{
    internal class MessagesContext: Messages, IMessages
    {
        public static List<Messages> AllMessages;
        public MessagesContext() => All(out AllMessages);
        ///<summary>
        ///</summary>
        ///<param name="Message">Сообщение</param>
        ///<param name="Create">Дата создания</param>
        ///<param name="IdUser">Код пользователя</param>

        public MessagesContext(string Message, DateTime Create, int IdUser) : base(Message, Create, IdUser) { }

        public void All(out List<Messages> Messages) =>
            Messages = new List<Messages>();

        public void Delete() =>
            AllMessages.Remove(this);

        public void Save(bool Update = false)
        {
            if (Update == false)
                AllMessages.Add(this);
        }
    }
}
