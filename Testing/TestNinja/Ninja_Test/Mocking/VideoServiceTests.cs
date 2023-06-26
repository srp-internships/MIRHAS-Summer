using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using TestNinja.Mocking;
using TestNinja.Mocking.ActionsOnVideoService;

namespace Ninja_Test.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        [Test]
        public void TestGetUnprocessedVideosAsCsv_ListOfSomeVideos_UnprocessedVideos()
        {
            var list = new List<Video>()
            {
                new Video() {Id=1,Title="a",IsProcessed=true},
                new Video() {Id=2,Title="b",IsProcessed=false},
                new Video() {Id=3,Title="c",IsProcessed=false},
                new Video() {Id=4,Title="d",IsProcessed=true},
                new Video() {Id=5,Title="e",IsProcessed=false},
                new Video() {Id=6,Title="f",IsProcessed=false}
            };

            var getVideos = new Mock<IGetVideos>();
            getVideos.Setup(gv => gv.Get()).Returns(list);

            var service = new VideoService(getVideos.Object);
            var ids = service.GetUnprocessedVideosAsCsv();

            Assert.AreEqual("2,3,5", ids);
        }
    }
}
