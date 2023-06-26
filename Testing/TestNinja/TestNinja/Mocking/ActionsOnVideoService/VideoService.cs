using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using Newtonsoft.Json;
using TestNinja.Mocking.ActionsOnVideoService;

namespace TestNinja.Mocking
{
    public class VideoService
    {
        private IGetVideos getVideos;
        public VideoService(IGetVideos getVideos)
        {
            this.getVideos = getVideos;
        }

        public string ReadVideoTitle()
        {
            var str = File.ReadAllText("video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video.";
            return video.Title;
        }

        public string GetUnprocessedVideosAsCsv()
        {
            var videoIds = new List<int>();

            var videos = (from video in getVideos.Get()
                          where !video.IsProcessed
                          select video).ToList();

            foreach (var v in videos)
                videoIds.Add(v.Id);

            return String.Join(",", videoIds);
        }
    }

    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }
    }

    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}