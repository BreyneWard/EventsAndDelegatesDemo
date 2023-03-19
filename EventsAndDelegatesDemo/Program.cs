namespace EventsAndDelegatesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber for mailservice
            var messageService = new MessageService(); // subscriber for messageservice


            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //VideoEncoded is list of pointers to methods
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}


