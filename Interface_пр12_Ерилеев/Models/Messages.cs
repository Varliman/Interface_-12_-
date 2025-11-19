using Interface_пр12_Ерилеев.Interfaces;
using System;
using System.Windows.Forms;

namespace Interface_пр12_Ерилеев.Models
{
    internal class Messages
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime Create { get; set; }
        public int IdUser { get; set; }
        public Messages() { }

        public Messages(string Message, DateTime Create, int IdUser) 
        {
            this.Message = Message;
            this.Create = Create;
            this.IdUser = IdUser;
        }
    }
}
