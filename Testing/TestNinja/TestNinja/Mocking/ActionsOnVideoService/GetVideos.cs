using System.Collections.Generic;
using System.Linq;

namespace TestNinja.Mocking.ActionsOnVideoService
{
    public interface IGetVideos
    {
        List<Video> Get();
    }

    public class GetVideos : IGetVideos
    {

        public List<Video> Get()
        {
            using (var context = new VideoContext())
            {
                return context.Videos.ToList<Video>();
            }
        }
    }
}
