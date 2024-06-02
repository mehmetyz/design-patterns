namespace DesignPatterns.Facade;

public class MultimediaPlayer
{
    public void Play()
    {
        var video = new Video("A GOOD VIDEO");
        var videoService = new VideoService(video);
        var audioService = new AudioService();
        var imageService = new ImageService();

        videoService.Run();
        audioService.Run();
        imageService.Run();
    }
}