namespace EventsAndDelegatesDemo
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sending video: " + e.Video.Title + " by mail");
            
        }



    }
}
