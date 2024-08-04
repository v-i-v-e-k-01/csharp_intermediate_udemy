using System;
using System.Collections.Generic;

namespace InterfacesPolymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }
        public void Encode(int video)
        {
            //Video encoding logic
            //...

            foreach (var channel in _notificationChannels)
            {
                channel.Send("Encoded video"); 
            }
        }

        public void RegisterNotificationChannel(INotificationChannel notificationChannel)
        {
            _notificationChannels.Add(notificationChannel);
        }
    }
   

    public interface INotificationChannel
    {
        void Send(string message);
    }

    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending mail ..."+message);
        }
    }

    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending sms ..."+message);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel( new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.Encode(4); // 4 is video file (here not used)
        }
    }

}
 