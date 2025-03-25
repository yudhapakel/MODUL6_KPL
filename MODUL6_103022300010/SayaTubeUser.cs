using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL6_103022300010
{
    public class SayaTubeUser
    {
        private int id;
        private string username;
        private List<SayaTubeVideo> uploadedVideo;

        public SayaTubeUser(String username)
        {
            Debug.Assert(!String.IsNullOrEmpty(username) || username.Length > 100);
            {

                //throw new ArgumentException("Username Tidak boleh kosong atau melebihi 100 karakter");
                Random rand = new Random();
                this.id = rand.Next(10000, 99999);
                this.username = username;
                this.uploadedVideo = new List<SayaTubeVideo>();
            }
            
        }

        public void AddVideo(SayaTubeVideo video)
        {
            if (video == null)
            {
                throw new ArgumentNullException("video tidak ada, null");
            }
            uploadedVideo.Add(video);
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var video in uploadedVideo)
            {
                total += video.GetPlayCount();
            }
            return total;
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine($"User : {username}");
            int count = 1;
            for (int i = 0; i < Math.Min(uploadedVideo.Count, 8); i++)
            {
                Console.WriteLine($"Video: {count} judul: {uploadedVideo[i].GetTItle()}");
                count++;
            }
        }
    }
}
