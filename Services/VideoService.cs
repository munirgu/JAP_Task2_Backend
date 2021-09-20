using JAP_Task_Backend.Database;
using JAP_Task_Backend.DTO;
using JAP_Task_Backend.Enums;
using JAP_Task_Backend.Interfaces;
using JAP_Task_Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_Backend.Services
{
    public class VideoService : IVideoService
    {
        private readonly ApplicationDbContext _context;
        private const int pageSize = 10;

        public VideoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<VideoDto> GetTopTenVideos(VideoType videoType, int currentPage = 1)
        {
            if (currentPage < 1)
                currentPage = 1;
            var videos = _context.Videos
                .Where(w => w.Type == videoType)
                .Select(s => new VideoDto
                {
                    Id = s.Id,
                    Title = s.Title,
                    Description = s.Description,
                    ReleaseDate = s.ReleaseDate,
                    ImageUrl = s.ImageUrl,
                    Rating = Math.Round(s.Ratings.Average(a => a.Score), 1),
                    Actors = s.Actors.Select(x => x.Name).ToList()
                })
                .OrderByDescending(o => o.Rating)
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            return videos;
        }


        public List<VideoDto> SearchMovies(VideoType videoType, string quickSearch)
        {
            List<VideoDto> videos = new List<VideoDto>();

            // at least X stars
            if (quickSearch.ToLower().StartsWith("at least ") && quickSearch.ToLower().EndsWith(" stars"))
            {
                quickSearch = quickSearch.ToLower().Replace("at least ", "").Replace(" stars", "");
                if (int.TryParse(quickSearch, out int score))
                {
                    videos = SearchByAtLeastRating(videoType, score);
                }
            }
            // ends with stars (X stars)
            else if (quickSearch.ToLower().EndsWith(" stars"))
            {
                quickSearch = quickSearch.ToLower().Replace(" stars", "");
                if (int.TryParse(quickSearch, out int score))
                {
                    videos = SearchByRating(videoType, score);
                }
            }
            // after years
            else if (quickSearch.ToLower().StartsWith("after "))
            {
                quickSearch = quickSearch.ToLower().Replace("after ", "");
                if (int.TryParse(quickSearch, out int score))
                {
                    videos = SearchByAfterYear(videoType, score);
                }
            }
            // older than X years
            else if (quickSearch.ToLower().StartsWith("older than ") && quickSearch.ToLower().EndsWith(" years"))
            {
                quickSearch = quickSearch.ToLower().Replace("older than ", "").Replace(" years", "");
                if (int.TryParse(quickSearch, out int score))
                {
                    videos = SearchByOlderThanYears(videoType, score);
                }
            }
            else
            {
                videos = SearchByTitleAndDescription(videoType, quickSearch);
            }

            return videos;
        }

        private List<VideoDto> SearchByTitleAndDescription(VideoType videoType, string quickSearch)
        {
            return _context.Videos
                        .Where(w => w.Type == videoType &&
                                (w.Title.ToLower().Contains(quickSearch.ToLower()) ||
                                w.Description.ToLower().Contains(quickSearch.ToLower())))
                        .Select(s => new VideoDto
                        {
                            Id = s.Id,
                            Title = s.Title,
                            Description = s.Description,
                            ReleaseDate = s.ReleaseDate,
                            ImageUrl = s.ImageUrl,
                            Rating = Math.Round(s.Ratings.Average(a => a.Score), 1),
                            Actors = s.Actors.Select(x => x.Name).ToList()
                        })
                        .OrderByDescending(o => o.Rating)
                        .ToList();
        }

        private List<VideoDto> SearchByAtLeastRating(VideoType videoType, int score)
        {
            return _context.Videos
                        .Where(w => w.Type == videoType &&
                                    w.Ratings.Average(a => a.Score) >= score)
                        .Select(s => new VideoDto
                        {
                            Id = s.Id,
                            Title = s.Title,
                            Description = s.Description,
                            ReleaseDate = s.ReleaseDate,
                            ImageUrl = s.ImageUrl,
                            Rating = Math.Round(s.Ratings.Average(a => a.Score), 1),
                            Actors = s.Actors.Select(x => x.Name).ToList()
                        })
                        .OrderByDescending(o => o.Rating)
                        .ToList();
        }
        private List<VideoDto> SearchByRating(VideoType videoType, int score)
        {
            return _context.Videos
                        .Where(w => w.Type == videoType &&
                                    w.Ratings.Average(a => a.Score) == score)
                        .Select(s => new VideoDto
                        {
                            Id = s.Id,
                            Title = s.Title,
                            Description = s.Description,
                            ReleaseDate = s.ReleaseDate,
                            ImageUrl = s.ImageUrl,
                            Rating = Math.Round(s.Ratings.Average(a => a.Score), 1),
                            Actors = s.Actors.Select(x => x.Name).ToList()
                        })
                        .OrderByDescending(o => o.Rating)
                        .ToList();
        }
        private List<VideoDto> SearchByAfterYear(VideoType videoType, int year)
        {
            
            return _context.Videos
                        .Where(w => w.Type == videoType &&
                                    w.ReleaseDate.Year > year)
                        .Select(s => new VideoDto
                        {
                            Id = s.Id,
                            Title = s.Title,
                            Description = s.Description,
                            ReleaseDate = s.ReleaseDate,
                            ImageUrl = s.ImageUrl,
                            Rating = Math.Round(s.Ratings.Average(a => a.Score), 1),
                            Actors = s.Actors.Select(x => x.Name).ToList()
                        })
                        .OrderByDescending(o => o.Rating)
                        .ToList();
        }

        private List<VideoDto> SearchByOlderThanYears(VideoType videoType, int years)
        {
            return _context.Videos
                        .Where(w => w.Type == videoType &&
                                    w.ReleaseDate < DateTime.Now.AddYears(-years))
                        .Select(s => new VideoDto
                        {
                            Id = s.Id,
                            Title = s.Title,
                            Description = s.Description,
                            ReleaseDate = s.ReleaseDate,
                            ImageUrl = s.ImageUrl,
                            Rating = Math.Round(s.Ratings.Average(a => a.Score), 1),
                            Actors = s.Actors.Select(x => x.Name).ToList()
                        })
                        .OrderByDescending(o => o.Rating)
                        .ToList();
        }

        public void RateVideo(int id, int score)
        {
            var rating = new Rating()
            {
                VideoId = id,
                Score = score
            };
            _context.Ratings.Add(rating);
            _context.SaveChanges();
        }

        public List<TopTenMoviesByRatings> GetTopTenMoviesByRatings()
        {
            List<TopTenMoviesByRatings> result = _context.TopTenMoviesByRatings
                .FromSqlRaw("EXEC [dbo].[GetTopTenMovies]")
                .ToList();

            return result;
        }
    }


}
