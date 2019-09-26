using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace WhatsApp
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            TwilioClient.Init(
                "AC2940e764b1b882be5333eb41c3cdcdae",
                "6262a00a83696c0cac2dfc12e7582163"
            );

            List<Uri> uriList = new List<Uri>();

            Uri newUri = new Uri("https://demo.twilio.com/owl.png");

            uriList.Add(newUri);

            for (int i = 0; i < 20; i++)
            {
                await SendMessageASync(uriList, i);
            }
            

            //var message3 = MessageResource.Create(
            //    from: new PhoneNumber("whatsapp:+14155238886"),
            //    to: new PhoneNumber("whatsapp:+905343971007"),
            //    body: "Ahoy Serdar! Ahoy Ahoy",
            //    mediaUrl: uriList
            //);


            // Console.WriteLine("Message SID: " + message3.Sid);
        }
        public static async Task<bool> SendMessageASync(List<Uri> uriList, int count)
        {
            try
            {
                var message = await MessageResource.CreateAsync(
                    from: new PhoneNumber("whatsapp:+14155238886"),
                    to: new PhoneNumber("whatsapp:+905383977377"),
                    body: "Ahoy from A-101! Ahoy Ahoy " + count
                // mediaUrl: uriList
                );
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
