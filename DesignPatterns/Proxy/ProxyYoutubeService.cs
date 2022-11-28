namespace DesignPatterns.Proxy;

public class ProxyYoutubeService : IYoutubeService
{
    private YoutubeService _youtubeService;
    private Dictionary<int, byte[]> _dictionaryCache = new Dictionary<int, byte[]>();

    public ProxyYoutubeService(YoutubeService youtubeService)
    {
        _youtubeService = youtubeService;
    }

    public byte[] GetVideo(int videoId)
    {
        byte[]? video;
        
        if (_dictionaryCache.ContainsKey(videoId))
        {
            Console.WriteLine($"video from cache {videoId}");
            video = _dictionaryCache.Where(s => s.Key == videoId).FirstOrDefault().Value;
        }
        else
        {
            video = _youtubeService.GetVideo(videoId);
            _dictionaryCache.Add(videoId, video);
        }


        return video;
    }
}