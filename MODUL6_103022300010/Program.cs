using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL6_103022300010
{
    class Program
    {
        static void Main()
        {
            SayaTubeUser user = new SayaTubeUser("Yudha Harwanto");

            for (int i = 0; i <= 8; i++) 
            {
                SayaTubeVideo video = new SayaTubeVideo($"Review Film {i} oleh {user}");
                video.IncreasePlayCount(5000 * i);
                user.AddVideo(video);
            }

            user.PrintAllVideoPlayCount();

            Console.WriteLine($"total play video: {user.GetTotalVideoPlayCount()}");
        }

    }
}
