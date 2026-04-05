public class SayaMusikTrack
{
    private int id;
    private string playCount;
    private string title;

    public SayaMusikTrack(string title)
    {
        this.id = id;
        this.title = title;
        this.playCount = "0";
    }

    void IncreasePlayCount(int count)
    {
        this.playCount += count;
    }

    void PrintTrackInfo()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}