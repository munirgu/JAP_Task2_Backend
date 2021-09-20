using JAP_Task_Backend.Enums;
using JAP_Task_Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace JAP_Task_Backend.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Video> Videos { get; set; }

        public DbSet<VideoActor> VideoActors { get; set; }

        public DbSet<Rating> Ratings { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Videos Data
            modelBuilder.Entity<Video>().HasData(

                /// Movies
                new Video
                {
                    Id = 1,
                    Title = "Saving Private Ryan",
                    Description = "Saving Private Ryan is a 1998 American epic war film directed by Steven Spielberg and written by Robert Rodat. Set during the Invasion of Normandy in World War II, the film is known for its graphic portrayal of war, especially its depiction of the Omaha Beach assault during the Normandy landings.",
                    ReleaseDate = new DateTime(1998, 7, 21),
                    Type = VideoType.Movie,
                    ImageUrl = "https://fanart.tv/fanart/movies/857/movieposter/saving-private-ryan-521a5ad8ab73e.jpg",

                },


                new Video
                {
                    Id = 2,
                    Title = "Inception",
                    Description = "Dominic Cobb is an industrial spy who instead of breaking into a person's home, office, or even computer, gets the information he needs by getting into the person's mind through their dreams.",
                    ReleaseDate = new DateTime(2010, 7, 22),
                    Type = VideoType.Movie,
                    ImageUrl = "https://www.syfy.com/sites/syfy/files/styles/1170xauto/public/the-witcher-season-2-poster-vertical.jpg"

                },

                 new Video
                 {
                     Id = 3,
                     Title = "The Witcher",
                     Description = "The witcher Geralt, a mutated monster hunter, struggles to find his place in a world in which people often prove more wicked than beasts.",
                     ReleaseDate = new DateTime(2019, 12, 20),
                     Type = VideoType.Movie,
                     ImageUrl = "https://www.syfy.com/sites/syfy/files/styles/1170xauto/public/the-witcher-season-2-poster-vertical.jpg"

                 },


                 new Video
                 {
                     Id = 4,
                     Title = "Forrest Gump",
                     Description = "Forrest Gump is a 1994 American drama film directed by Robert Zemeckis and written by Eric Roth with comedic aspects. It is based on the 1986 novel of the same name by Winston Groom and stars Tom Hanks, Robin Wright, Gary Sinise, Mykelti Williamson and Sally Field.",
                     ReleaseDate = new DateTime(1994, 6, 23),
                     Type = VideoType.Movie,
                     ImageUrl = "https://cinecalidad.in/wp-content/uploads/2020/03/forrest-gump-7240-poster-683x1024.jpg"

                 },

                 new Video
                 {
                     Id = 5,
                     Title = "Fight Club",
                     Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                     ReleaseDate = new DateTime(1999, 9, 10),
                     Type = VideoType.Movie,
                     ImageUrl = "https://www.new-video.de/co/fightclu.jpg"

                 },

                 new Video
                 {
                     Id = 6,
                     Title = "Bad Boys",
                     Description = "Two loose-cannon narcotics cops investigate the flow of Ecstasy into Florida from a Cuban drug cartel.",
                     ReleaseDate = new DateTime(1995, 4, 6),
                     Type = VideoType.Movie,
                     ImageUrl = "https://i.pinimg.com/736x/f8/a5/5d/f8a55dd993b59363dcf4b6e410305f44--hd-movies-action-movies.jpg"

                 },

                   new Video
                   {
                       Id = 7,
                       Title = "Bad Boys II",
                       Description = "Two hip detectives protect a witness to a murder while investigating a case of stolen heroin from the evidence storage room from their police precinct.",
                       ReleaseDate = new DateTime(2003, 6, 9),
                       Type = VideoType.Movie,
                       ImageUrl = "https://th.bing.com/th/id/OIP.M5Y738m_1kCMg-Fef-fI2gHaLH?pid=ImgDet&rs=1"

                   },

                   new Video
                   {
                       Id = 8,
                       Title = "Bad Boys For Life",
                       Description = "Miami detectives Mike Lowrey and Marcus Burnett must face off against a mother-and-son pair of drug lords who wreak vengeful havoc on their city.",
                       ReleaseDate = new DateTime(2020, 1, 7),
                       Type = VideoType.Movie,
                       ImageUrl = "https://th.bing.com/th/id/OIP.Ox-F7hWGAUkWLucz4B7ggwHaLH?pid=ImgDet&rs=1"

                   },

                    new Video
                    {
                        Id = 9,
                        Title = "The Tomorrow War",
                        Description = "A family man is drafted to fight in a future war where the fate of humanity relies on his ability to confront the past.",
                        ReleaseDate = new DateTime(2021, 7, 2),
                        Type = VideoType.Movie,
                        ImageUrl = "https://www.okdrama.com/wp-content/uploads/2021/07/The-Tomorrow-War.jpg"

                    },

                     new Video
                     {
                         Id = 10,
                         Title = "Jurassic Park",
                         Description = "A pragmatic paleontologist visiting an almost complete theme park is tasked with protecting a couple of kids after a power failure causes the park's cloned dinosaurs to run loose.",
                         ReleaseDate = new DateTime(1993, 6, 9),
                         Type = VideoType.Movie,
                         ImageUrl = "https://th.bing.com/th/id/R.795762624b2ebe035d8ebe1000397e70?rik=tM2O0EXzddMb7g&riu=http%3a%2f%2fwww.sf-fan.de%2fwp-content%2fuploads%2f2011%2f07%2fjurassic-park-poster.jpg&ehk=ISz78v6xTLdiIOGEtMFG9Qxj29cLWqZWOeZ9OUA8rGk%3d&risl=&pid=ImgRaw&r=0"

                     },
                      new Video
                      {
                          Id = 11,
                          Title = "The Lost World: Jurassic Park",
                          Description = "A research team is sent to the Jurassic Park Site B island to study the dinosaurs there, while an InGen team approaches with another agenda.",
                          ReleaseDate = new DateTime(1997, 5, 19),
                          Type = VideoType.Movie,
                          ImageUrl = "https://vignette.wikia.nocookie.net/cinemorgue/images/d/d8/11168888_800.jpg/revision/latest?cb=20150519044035"

                      },
                      new Video
                      {
                          Id = 12,
                          Title = "Jurassic Park III",
                          Description = "A decidedly odd couple with ulterior motives convince Dr. Grant to go to Isla Sorna for a holiday, but their unexpected landing startles the island's new inhabitants.",
                          ReleaseDate = new DateTime(2001, 7, 16),
                          Type = VideoType.Movie,
                          ImageUrl = "https://th.bing.com/th/id/OIP.mMwLmfEru8a0Y86217RLJwHaLH?pid=ImgDet&rs=1"

                      },
                      new Video
                      {
                          Id = 13,
                          Title = "Jurassic World",
                          Description = "A new theme park, built on the original site of Jurassic Park, creates a genetically modified hybrid dinosaur, the Indominus Rex, which escapes containment and goes on a killing spree.",
                          ReleaseDate = new DateTime(2015, 5, 29).ToUniversalTime(),
                          Type = VideoType.Movie,
                          ImageUrl = "https://th.bing.com/th/id/OIP.-3smAFf-8f3Xye1-VODc5AHaLH?pid=ImgDet&rs=1"

                      },
                       new Video
                       {
                           Id = 14,
                           Title = "Jurassic World: Fallen Kingdom",
                           Description = "When the island's dormant volcano begins roaring to life, Owen and Claire mount a campaign to rescue the remaining dinosaurs from this extinction-level event.",
                           ReleaseDate = new DateTime(2018, 5, 21),

                           Type = VideoType.Movie,
                           ImageUrl = "https://vignette.wikia.nocookie.net/cinemorgue/images/d/df/322699f120c17c2728457969b59af12c.jpg/revision/latest?cb=20180325190743"

                       },
                        new Video
                        {
                            Id = 15,
                            Title = "Spider-Man",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2002, 4, 30),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"

                        },
                        new Video
                        {
                            Id = 31,
                            Title = "Spider",
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            ReleaseDate = new DateTime(2012, 4, 12),
                            Type = VideoType.Movie,
                            ImageUrl = "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg"

                        },




                        /// TvShow videos
                        new Video
                        {
                            Id = 16,
                            Title = "Clickbait",
                            Description = "When family man Nick Brewer is abducted in a crime with a sinister online twist, those closest to him race to uncover who is behind it and why.",
                            ReleaseDate = new DateTime(2021, 8, 25),
                            Type = VideoType.TvShow,
                            ImageUrl = "https://www.what-song.com/_next/image?url=https:%2F%2Fimage.tmdb.org%2Ft%2Fp%2Fw500%2Fq42t4S113jebD1khigJt8z3m1mD.jpg&w=828&q=75"

                        },
                         new Video
                         {
                             Id = 17,
                             Title = "Money Heist",
                             Description = "An unusual group of robbers attempt to carry out the most perfect robbery in Spanish history - stealing 2.4 billion euros from the Royal Mint of Spain.",
                             ReleaseDate = new DateTime(2017, 5, 2),
                             Type = VideoType.TvShow,
                             ImageUrl = "https://i1.wp.com/www.realhypegh.com/wp-content/uploads/2021/09/Money-Heist.jpg?resize=696%2C1031&ssl=1"

                         },
                         new Video
                         {
                             Id = 18,
                             Title = "Nine Perfect Strangers",
                             Description = "Nine stressed city dwellers visit a boutique health-and-wellness resort that promises healing and transformation. The resort's director is a woman on a mission to reinvigorate their tired minds and bodies.",
                             ReleaseDate = new DateTime(2021, 8, 18),
                             Type = VideoType.TvShow,
                             ImageUrl = "https://th.bing.com/th/id/OIP.yclr5qYMsedWaCB1yJRQdgHaLU?pid=ImgDet&rs=1"

                         },
                          new Video
                          {
                              Id = 19,
                              Title = "The Walking Dead",
                              Description = "Sheriff Deputy Rick Grimes wakes up from a coma to learn the world is in ruins and must lead a group of survivors to stay alive.",
                              ReleaseDate = new DateTime(2010, 10, 31),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://th.bing.com/th/id/R.b904983728868f3ed5ce79fb819c8699?rik=LmhMRcd0HZRPew&riu=http%3a%2f%2fpics.filmaffinity.com%2fThe_Walking_Dead_TV_Series-285470099-large.jpg&ehk=8lZYkdu%2fiSDQQ%2f9RKV8aveMd7qagFCj573%2fZ1rNnfzQ%3d&risl=&pid=ImgRaw&r=0"

                          },
                          new Video
                          {
                              Id = 20,
                              Title = "Game of Thrones",
                              Description = "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.",
                              ReleaseDate = new DateTime(2011, 4, 17),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://th.bing.com/th/id/R.e024c02d31c823d7d68e23550207fb3e?rik=p3JUYI%2bmYV91RA&pid=ImgRaw&r=0"

                          },
                          new Video
                          {
                              Id = 21,
                              Title = "Manifest",
                              Description = "A commercial airliner suddenly reappears after being missing for five years. As those aboard reintegrate into society, they experience guiding voices and visions of events yet to occur, and soon a deeper mystery unfolds.",
                              ReleaseDate = new DateTime(2018, 9, 24),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://image.tmdb.org/t/p/original/moaCMoZYVifaQnNJGDr3M6rBglB.jpg"

                          },
                          new Video
                          {
                              Id = 22,
                              Title = "Brooklyn Nine-Nine",
                              Description = "Comedy series following the exploits of Det. Jake Peralta and his diverse, lovable colleagues as they police the NYPD's 99th Precinct.",
                              ReleaseDate = new DateTime(2013, 9, 17),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://th.bing.com/th/id/R.6ed153b03e7aae27d1c14006c3ffd4eb?rik=E9ceeJRcwZwm5w&pid=ImgRaw&r=0"

                          },
                          new Video
                          {
                              Id = 23,
                              Title = "Breaking Bad",
                              Description = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                              ReleaseDate = new DateTime(2008, 1, 20),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://th.bing.com/th/id/R.7daca6eab99b67e6cd63f01bfdf3a41a?rik=QqKBdpltIOVmrw&riu=http%3a%2f%2fwww.notrecinema.com%2fimages%2fcache%2fbreaking-bad-poster_399299_31440.jpg&ehk=YPzSvSux8LNPKZgfHqAfYce7Rz6%2fafdR6GZvT1TE6J8%3d&risl=&pid=ImgRaw&r=0"

                          },
                          new Video
                          {
                              Id = 24,
                              Title = "Friends",
                              Description = "Follows the personal and professional lives of six twenty to thirty-something-year-old friends living in Manhattan.",
                              ReleaseDate = new DateTime(1994, 9, 22),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://images.saymedia-content.com/.image/t_share/MTc2NTc0ODUzMDQ0Nzc0NjE5/tv-shows-like-friends.jpg"

                          },
                          new Video
                          {
                              Id = 25,
                              Title = "Prison Break",
                              Description = "Due to a political conspiracy, an innocent man is sent to death row and his only hope is his brother, who makes it his mission to deliberately get himself sent to the same prison in order to break the both of them out, from the inside.",
                              ReleaseDate = new DateTime(2005, 8, 29),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://cdn.cinematerial.com/p/500x/rkevtzje/prison-break-movie-cover.jpg"

                          },
                          new Video
                          {
                              Id = 26,
                              Title = "Criminal Minds",
                              Description = "The cases of the F.B.I. Behavioral Analysis Unit (B.A.U.), an elite group of profilers who analyze the nation's most dangerous serial killers and individual heinous crimes in an effort to anticipate their next moves before they strike again.",
                              ReleaseDate = new DateTime(2005, 9, 22),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://th.bing.com/th/id/OIP.ZUzAwzdzq780bQ9KjtJ2xgHaKd?pid=ImgDet&rs=1"

                          },
                          new Video
                          {
                              Id = 27,
                              Title = "The Empire",
                              Description = "The series focuses on the rise and fall of Mughal Empire through generations from Babur to Aurangzeb.",
                              ReleaseDate = new DateTime(2021, 8, 27),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://i1.wp.com/hdmoviez.biz/wp-content/uploads/2021/08/The-Empire-2021-S01.png?w=500"

                          },
                          new Video
                          {
                              Id = 28,
                              Title = "The Blacklist",
                              Description = "A new FBI profiler, Elizabeth Keen, has her entire life uprooted when a mysterious criminal, Raymond Reddington, who has eluded capture for decades, turns himself in and insists on speaking only to her.",
                              ReleaseDate = new DateTime(2013, 9, 23),
                              Type = VideoType.TvShow,
                              ImageUrl = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6259/6259110_so.jpg"

                          },
                           new Video
                           {
                               Id = 29,
                               Title = "House",
                               Description = "An antisocial maverick doctor who specializes in diagnostic medicine does whatever it takes to solve puzzling cases that come his way using his crack team of doctors and his wits.",
                               ReleaseDate = new DateTime(2004, 11, 16),
                               Type = VideoType.TvShow,
                               ImageUrl = "https://www.pelisxd.com/wp-content/uploads/2020/04/house-15611-poster.jpg"

                           },
                            new Video
                            {
                                Id = 30,
                                Title = "The Defeated",
                                Description = "Max McLaughlin is an American cop who arrives in Berlin in the summer of 1946 to help create a police force in the chaotic aftermath of the war.",
                                ReleaseDate = new DateTime(2020, 10, 10),
                                Type = VideoType.TvShow,
                                ImageUrl = "https://d2iltjk184xms5.cloudfront.net/uploads/photo/file/382771/e6aace1d14a77a2badd179ba926ac1b3-defeatedposter.jpg"

                            }

            );
            #endregion


            /// Actors and related movies and Tv Shows
            #region VideosActors Data
            modelBuilder.Entity<VideoActor>().HasData(
                new VideoActor { Id = 1, Name = "Tom Hanks", VideoId = 1 },
                new VideoActor { Id = 2, Name = "Matt Damon", VideoId = 1 },
                new VideoActor { Id = 3, Name = "Leonardo DiCaprio", VideoId = 2 },
                new VideoActor { Id = 4, Name = "Joseph Gordon-Levitt", VideoId = 2 },
                new VideoActor { Id = 5, Name = "Henry Cavill", VideoId = 3 },
                new VideoActor { Id = 6, Name = "Anna Shaffer", VideoId = 3 },
                new VideoActor { Id = 7, Name = "Tom Hanks", VideoId = 4 },
                new VideoActor { Id = 8, Name = "Robin Wright", VideoId = 4 },
                new VideoActor { Id = 9, Name = "Brad Pitt", VideoId = 5 },
                new VideoActor { Id = 10, Name = "Edward Norton", VideoId = 5 },
                new VideoActor { Id = 11, Name = "Will Smith", VideoId = 6 },
                new VideoActor { Id = 12, Name = "Martin Lawrence", VideoId = 6 },
                new VideoActor { Id = 13, Name = "Will Smith", VideoId = 7 },
                new VideoActor { Id = 14, Name = "Martin Lawrence", VideoId = 7 },
                new VideoActor { Id = 15, Name = "Will Smith", VideoId = 8 },
                new VideoActor { Id = 16, Name = "Martin Lawrence", VideoId = 8 },
                new VideoActor { Id = 17, Name = "Chris Pratt", VideoId = 9 },
                new VideoActor { Id = 18, Name = "Yvonne Strahovski", VideoId = 9 },
                new VideoActor { Id = 19, Name = "Sam Neill", VideoId = 10 },
                new VideoActor { Id = 20, Name = "Laura Dern", VideoId = 10 },
                new VideoActor { Id = 21, Name = "Jeff Goldblum", VideoId = 11 },
                new VideoActor { Id = 22, Name = "Julianne Moore", VideoId = 11 },
                new VideoActor { Id = 23, Name = "Sam Neill", VideoId = 12 },
                new VideoActor { Id = 24, Name = "William H. Macy", VideoId = 12 },
                new VideoActor { Id = 25, Name = "Chris Pratt", VideoId = 13 },
                new VideoActor { Id = 26, Name = "Bryce Dallas Howard", VideoId = 13 },
                new VideoActor { Id = 27, Name = "Chris Pratt", VideoId = 14 },
                new VideoActor { Id = 28, Name = "Bryce Dallas Howard", VideoId = 14 },
                new VideoActor { Id = 29, Name = "Tobey Maguire", VideoId = 15 },
                new VideoActor { Id = 30, Name = "Kristen Dunst", VideoId = 15 },

                ///Tv Shows
                new VideoActor { Id = 31, Name = "Zoe Kazan", VideoId = 16 },
                new VideoActor { Id = 32, Name = "Betty Gabriel", VideoId = 16 },
                new VideoActor { Id = 33, Name = "Ursula Cobero", VideoId = 17 },
                new VideoActor { Id = 34, Name = "Alvaro Morte", VideoId = 17 },
                new VideoActor { Id = 35, Name = "Nicole Kidman", VideoId = 18 },
                new VideoActor { Id = 36, Name = "Melissa McCarthy", VideoId = 18 },
                new VideoActor { Id = 37, Name = "Andrew Lincoln", VideoId = 19 },
                new VideoActor { Id = 38, Name = "Norman Reedus", VideoId = 19 },
                new VideoActor { Id = 39, Name = "Emilia Clarke", VideoId = 20 },
                new VideoActor { Id = 40, Name = "Peter Dinklage", VideoId = 20 },
                new VideoActor { Id = 41, Name = "Melissa Roxburgh", VideoId = 21 },
                new VideoActor { Id = 42, Name = "Josh Dallas", VideoId = 21 },
                new VideoActor { Id = 43, Name = "Andy Samberg", VideoId = 22 },
                new VideoActor { Id = 44, Name = "Stephanie Beatriz", VideoId = 22 },
                new VideoActor { Id = 45, Name = "Bryan Cranston", VideoId = 23 },
                new VideoActor { Id = 46, Name = "Aaron Paul", VideoId = 23 },
                new VideoActor { Id = 47, Name = "Jennifer Aniston", VideoId = 24 },
                new VideoActor { Id = 48, Name = "Courteney Cox", VideoId = 24 },
                new VideoActor { Id = 49, Name = "Dominic Purcell", VideoId = 25 },
                new VideoActor { Id = 50, Name = "Wentworth Miller", VideoId = 25 },
                new VideoActor { Id = 51, Name = "Matthew Gray Gubler", VideoId = 26 },
                new VideoActor { Id = 52, Name = "Kristen Vangsness", VideoId = 26 },
                new VideoActor { Id = 53, Name = "Shabana Azmi", VideoId = 27 },
                new VideoActor { Id = 54, Name = "Kunal Kapoor", VideoId = 27 },
                new VideoActor { Id = 55, Name = "James Spader", VideoId = 28 },
                new VideoActor { Id = 56, Name = "Megane Boone", VideoId = 28 },
                new VideoActor { Id = 57, Name = "Hugh Lauri", VideoId = 29 },
                new VideoActor { Id = 58, Name = "Omar Epps", VideoId = 29 },
                new VideoActor { Id = 59, Name = "Taylor Kitsch", VideoId = 30 },
                new VideoActor { Id = 60, Name = "Michael C. Hall", VideoId = 30 }



            );
            #endregion

            /// Rating for every movie and Tv Show
            #region VideosActors Data
            modelBuilder.Entity<Rating>().HasData(
                new Rating { Id = 1, Score = 5, VideoId = 1 },
                new Rating { Id = 2, Score = 5, VideoId = 1 },
                new Rating { Id = 3, Score = 4, VideoId = 2 },
                new Rating { Id = 4, Score = 4, VideoId = 2 },
                new Rating { Id = 5, Score = 3, VideoId = 3 },
                new Rating { Id = 6, Score = 2, VideoId = 3 },
                new Rating { Id = 7, Score = 3, VideoId = 4 },
                new Rating { Id = 8, Score = 5, VideoId = 4 },
                new Rating { Id = 9, Score = 4, VideoId = 5 },
                new Rating { Id = 10, Score = 4, VideoId = 5 },
                new Rating { Id = 11, Score = 2, VideoId = 6 },
                new Rating { Id = 12, Score = 3, VideoId = 6 },
                new Rating { Id = 13, Score = 5, VideoId = 7 },
                new Rating { Id = 14, Score = 5, VideoId = 7 },
                new Rating { Id = 15, Score = 4, VideoId = 8 },
                new Rating { Id = 16, Score = 2, VideoId = 8 },
                new Rating { Id = 17, Score = 4, VideoId = 9 },
                new Rating { Id = 18, Score = 5, VideoId = 9 },
                new Rating { Id = 19, Score = 3, VideoId = 10 },
                new Rating { Id = 20, Score = 3, VideoId = 10 },
                new Rating { Id = 21, Score = 4, VideoId = 11 },
                new Rating { Id = 22, Score = 5, VideoId = 11 },
                new Rating { Id = 23, Score = 4, VideoId = 12 },
                new Rating { Id = 24, Score = 4, VideoId = 12 },
                new Rating { Id = 25, Score = 3, VideoId = 13 },
                new Rating { Id = 26, Score = 4, VideoId = 13 },
                new Rating { Id = 27, Score = 2, VideoId = 14 },
                new Rating { Id = 28, Score = 1, VideoId = 14 },
                new Rating { Id = 29, Score = 5, VideoId = 15 },
                new Rating { Id = 30, Score = 2, VideoId = 15 },

                ///TvShows Rating
                new Rating { Id = 31, Score = 4, VideoId = 16 },
                new Rating { Id = 32, Score = 2, VideoId = 16 },
                new Rating { Id = 33, Score = 5, VideoId = 17 },
                new Rating { Id = 34, Score = 3, VideoId = 17 },
                new Rating { Id = 35, Score = 3, VideoId = 18 },
                new Rating { Id = 36, Score = 4, VideoId = 18 },
                new Rating { Id = 37, Score = 5, VideoId = 19 },
                new Rating { Id = 38, Score = 2, VideoId = 19 },
                new Rating { Id = 39, Score = 3, VideoId = 20 },
                new Rating { Id = 40, Score = 4, VideoId = 20 },
                new Rating { Id = 41, Score = 5, VideoId = 21 },
                new Rating { Id = 42, Score = 3, VideoId = 21 },
                new Rating { Id = 43, Score = 3, VideoId = 22 },
                new Rating { Id = 44, Score = 2, VideoId = 22 },
                new Rating { Id = 45, Score = 4, VideoId = 23 },
                new Rating { Id = 46, Score = 5, VideoId = 23 },
                new Rating { Id = 47, Score = 5, VideoId = 24 },
                new Rating { Id = 48, Score = 4, VideoId = 24 },
                new Rating { Id = 49, Score = 5, VideoId = 25 },
                new Rating { Id = 50, Score = 5, VideoId = 25 },
                new Rating { Id = 51, Score = 3, VideoId = 26 },
                new Rating { Id = 52, Score = 4, VideoId = 26 },
                new Rating { Id = 53, Score = 3, VideoId = 27 },
                new Rating { Id = 54, Score = 4, VideoId = 27 },
                new Rating { Id = 55, Score = 3, VideoId = 28 },
                new Rating { Id = 56, Score = 4, VideoId = 28 },
                new Rating { Id = 57, Score = 5, VideoId = 29 },
                new Rating { Id = 58, Score = 4, VideoId = 29 },
                new Rating { Id = 59, Score = 3, VideoId = 30 },
                new Rating { Id = 60, Score = 3, VideoId = 30 }





            );
            #endregion




        }

    }

}
