namespace DesignPatterns.Proxy;

public class YoutubeService : IYoutubeService
{
    public byte[] GetVideo(int videoId)
    {
        Console.WriteLine($"Yutube service downloading video: {videoId}");
        return new Byte[videoId];
    }
}