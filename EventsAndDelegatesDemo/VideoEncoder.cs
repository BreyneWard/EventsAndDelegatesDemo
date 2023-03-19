using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesDemo
{
    public class VideoEventArgs: EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        // 1. Define a delegate contract between publisher and the subsciber(s)
        // 2. Define an event based on that delegate
        // 3. Raise the event

        // 1.
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // 2.
        //public event VideoEncodedEventHandler VideoEncoded;

        // New way of working with an generic eventhandler -> no need to make your own delegate
        // public event EventHandler VideoEncoded // default with parameters (object source, eventargs e)
        public event EventHandler<VideoEventArgs> VideoEncoded;
        
        public void Encode(Video video) 
        {
            //encoding logic...
            //....
            Console.WriteLine("Encoding video ...");
            Thread.Sleep(3000);



            // after encoding
            //_mailService.Send(new Mail());
            //_messageService.Send(new Text());


            //OnVideoEncoded(); // method to inform the subscribers
            //Pass object video to the method
            OnVideoEncoded(video);
        }

        //3. EventPublisher methods
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video});
            }
        }
    }
}
