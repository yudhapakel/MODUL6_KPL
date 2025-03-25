using System;
using System.Security.Cryptography.X509Certificates;

public class SayaTubeVideo
{
    private int id;
    private String title;
    private int playCount;

    public SayaTubeVideo(String title)
    {
        if (String.IsNullOrEmpty(title) || title.Length > 100)
        {
            throw new ArgumentNullException("judul video tidak boleh kosong dan lebih dari 100 karakter");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

    }

    public void IncreasePlayCount(int count) 
    {
        if (count < 0 || count > 10000000)
        {
            throw new ArgumentOutOfRangeException("jumlah pemutaran harus diantara 0 sampai 1000000");

            this.playCount += count;

        }
    }

    public void PrintALLVideoDetail ()
    {
        Console.WriteLine($"ID video: {id}");
        Console.WriteLine($"Judul video: {title}");
        Console.WriteLine($"Jumlah Play: {playCount}");
    }

    public int GetPlayCount()
    {
        return playCount;
    }

    public String GetTItle()
    {
        return title;
    }

}