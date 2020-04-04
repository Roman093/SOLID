using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I
{
    interface IMessages
    {
        void Send();
        string ToAddress { get; set; }
        string FromAddress { get; set; }
    }
    interface IVoiceMessages : IMessages
    {
        byte[] Voice { get; set; }
    }
    interface ITextMessages : IMessages
    {
        string Text { get; set; }
    }

    interface IEmailMessages : ITextMessages
    {
        string Subject { get; set; }
    }

    class VoiceMessages : IVoiceMessages
    {
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }

        public byte[] Voice { get; set; }
        public void Send()
        {
            Console.WriteLine("Передача голосовой почты");
        }
    }
    class EmailMessages : IEmailMessages
    {
        public string Text { get; set; }
        public string Subject { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }

        public void Send()
        {
            Console.WriteLine("Отправляем по Email сообщение: {0}", Text);
        }
    }

    class SmsMessages : ITextMessages
    {
        public string Text { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public void Send()
        {
            Console.WriteLine("Отправляем по Sms сообщение: {0}", Text);
        }
    }
}
