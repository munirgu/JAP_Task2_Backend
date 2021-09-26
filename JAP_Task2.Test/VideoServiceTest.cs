using JAP_Task_Backend.Database;
using JAP_Task_Backend.Enums;
using JAP_Task_Backend.Interfaces;
using JAP_Task_Backend.Models;
using JAP_Task_Backend.Services;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task2.Test
{
    [TestFixture]
    public class VideoServiceTest
    {
        ApplicationDbContext _context;
        IVideoService videoService;

        [OneTimeSetUp]
        public async Task SetupAsync()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "moviesapp")
                .Options;

            _context = new ApplicationDbContext(options);
            _context.Videos.Add(new Video { Id = 1, Title = "Saving Private Ryan", Type = VideoType.Movie, Description = "Movie 1", ReleaseDate = new DateTime(2015, 5, 6) });
            _context.Videos.Add(new Video { Id = 2, Title = "Terminator", Type = VideoType.Movie, Description = "Movie 2", ReleaseDate = new DateTime(2017, 5, 6) });
            _context.Videos.Add(new Video { Id = 3, Title = "Blade", Type = VideoType.Movie, Description = "Movie 3", ReleaseDate = new DateTime(2019, 5, 6) });
            _context.Ratings.Add(new Rating { Id = 1, VideoId = 1, Score = 3 });
            _context.Ratings.Add(new Rating { Id = 2, VideoId = 1, Score = 5 });
            _context.Ratings.Add(new Rating { Id = 3, VideoId = 2, Score = 3 });
            _context.Ratings.Add(new Rating { Id = 4, VideoId = 2, Score = 1 });
            _context.Ratings.Add(new Rating { Id = 5, VideoId = 3, Score = 5 });
            _context.Ratings.Add(new Rating { Id = 6, VideoId = 3, Score = 4 });

            _context.Screenings.Add(new Screening { Id = 1, VideoId = 1, AvailableTickets = 11, SoldTickets = 9, DateAndTime = DateTime.Now.AddDays(-10) });
            _context.Screenings.Add(new Screening { Id = 2, VideoId = 1, AvailableTickets = 10, SoldTickets = 10, DateAndTime = DateTime.Now.AddDays(-5) });
            _context.Screenings.Add(new Screening { Id = 3, VideoId = 1, AvailableTickets = 9, SoldTickets = 11, DateAndTime = DateTime.Now.AddDays(-1) });
            await _context.SaveChangesAsync();
            videoService = new VideoService(_context);
        }

        [Test,Order(1)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 1)]
        public void BuyTicketInThePast_InputScreeningIdAndNumberOfTickets_ThrowsError(int screeningId, int numberOfTickets)
        {
            Exception exception = Assert.Throws<Exception>(() => { videoService.BuyTicket(screeningId, numberOfTickets); });
            Assert.AreEqual("You can't buy tickets for past screenings.", exception.Message);
        }

        [Test, Order(2)]
        [TestCase(1, 4)]
        [TestCase(2, 2)]
        [TestCase(3, 4.5)]
        public void GetTopTenVideos_InputVideoIdAndExpectedRating_GetRatingCalculatedCorrectly(int videoId, double expectedRating)
        {
            var videos = videoService.GetTopTenVideos(VideoType.Movie, 0);
            var video = videos.Single(x => x.Id == videoId);
            Assert.AreEqual(expectedRating, video.Rating);
        }

        [Test, Order(3)]
        [TestCase("Ryan", new int[] { 1 })]
        [TestCase("Movie", new int[] { 1, 2, 3 })]
        [TestCase("at least 4 stars", new int[] { 1, 3 })]
        [TestCase("2 stars", new int[] {2})]
        [TestCase("older than 5 years", new int[] { 1 })]
        [TestCase("Movie 2", new int[] { 2 })]
        public void SearchByTitle_InputQuickSearchAndVideoId_ReturnsExpectedVideos(string quickSearch, int[] expectedVideoIds)
        {
            var videos = videoService.SearchMovies(VideoType.Movie, quickSearch);
            var videoIds = videos.Select(s => s.Id).OrderBy(o => o).ToArray();
            Assert.AreEqual(expectedVideoIds, videoIds);
        }

        [Test, Order(4)]
        [TestCase(1, 3, 3)]
        [TestCase(1, 2, 4)]
        public void RateVideo_InputVideoIdAndScoreAndExpectedRatingCount_GetRatingAddedSuccessfully(int videoId, int score, int expectedRatingCount)
        {
            videoService.RateVideo(videoId, score);
            var count = _context.Ratings.Where(r => r.VideoId == videoId).Count();
            Assert.AreEqual(expectedRatingCount, count);
          
        }

    }
}
