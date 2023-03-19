namespace EventsAndDelegatesDemo
{
    public class MessageService
    {
        internal void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Video: " + e.Video.Title + " was sent by message");
        }
    }
}


