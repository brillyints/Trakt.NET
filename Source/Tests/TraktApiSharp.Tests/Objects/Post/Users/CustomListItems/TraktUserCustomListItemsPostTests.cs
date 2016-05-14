﻿namespace TraktApiSharp.Tests.Objects.Post.Users.ListItems
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Linq;
    using TraktApiSharp.Objects.Get.Movies;
    using TraktApiSharp.Objects.Get.People;
    using TraktApiSharp.Objects.Get.Shows;
    using TraktApiSharp.Objects.Post.Users.CustomListItems;

    [TestClass]
    public class TraktUserCustomListItemsPostTests
    {
        [TestMethod]
        public void TestTraktUserCustomListItemsPostDefaultConstructor()
        {
            var userListItemsPost = new TraktUserCustomListItemsPost();

            userListItemsPost.Movies.Should().BeNull();
            userListItemsPost.Shows.Should().BeNull();
            userListItemsPost.People.Should().BeNull();
        }

        [TestMethod]
        public void TestTraktUserCustomListItemsPostWriteJson()
        {
            var userListItemsPost = new TraktUserCustomListItemsPost
            {
                Movies = new List<TraktUserCustomListItemsPostMovieItem>()
                {
                    new TraktUserCustomListItemsPostMovieItem
                    {
                        Ids = new TraktMovieIds { Trakt = 1 }
                    },
                    new TraktUserCustomListItemsPostMovieItem
                    {
                        Ids = new TraktMovieIds { Imdb = "tt0000111" }
                    }
                },
                Shows = new List<TraktUserCustomListItemsShowItem>()
                {
                    new TraktUserCustomListItemsShowItem
                    {
                        Ids = new TraktShowIds { Trakt = 1 }
                    },
                    new TraktUserCustomListItemsShowItem
                    {
                        Seasons = new List<TraktUserCustomListItemsShowSeasonItem>()
                        {
                            new TraktUserCustomListItemsShowSeasonItem
                            {
                                Number = 1
                            }
                        },
                        Ids = new TraktShowIds
                        {
                            Trakt = 1
                        }
                    },
                    new TraktUserCustomListItemsShowItem
                    {
                        Seasons = new List<TraktUserCustomListItemsShowSeasonItem>()
                        {
                            new TraktUserCustomListItemsShowSeasonItem
                            {
                                Number = 1,
                                Episodes = new List<TraktUserCustomListItemsShowEpisodeItem>()
                                {
                                    new TraktUserCustomListItemsShowEpisodeItem
                                    {
                                        Number = 1
                                    },
                                    new TraktUserCustomListItemsShowEpisodeItem
                                    {
                                        Number = 2
                                    }
                                }
                            }
                        },
                        Ids = new TraktShowIds
                        {
                            Trakt = 1
                        }
                    }
                },
                People = new List<TraktPerson>()
                {
                    new TraktPerson
                    {
                        Name = "Jeff Bridges",
                        Ids = new TraktPersonIds
                        {
                            Trakt = 2,
                            Slug = "jeff-bridges",
                            Imdb = "nm0000313",
                            Tmdb = 1229,
                            TvRage = 59067
                        }
                    }
                }
            };

            var strJson = JsonConvert.SerializeObject(userListItemsPost);

            strJson.Should().NotBeNullOrEmpty();

            var userListItemsPostFromJson = JsonConvert.DeserializeObject<TraktUserCustomListItemsPost>(strJson);

            userListItemsPostFromJson.Should().NotBeNull();

            userListItemsPostFromJson.Movies.Should().NotBeNull().And.HaveCount(2);
            userListItemsPostFromJson.Shows.Should().NotBeNull().And.HaveCount(3);
            userListItemsPostFromJson.People.Should().NotBeNull().And.HaveCount(1);

            var movies = userListItemsPostFromJson.Movies.ToArray();

            movies[0].Ids.Should().NotBeNull();
            movies[0].Ids.Trakt.Should().Be(1);
            movies[0].Ids.Slug.Should().BeNullOrEmpty();
            movies[0].Ids.Imdb.Should().BeNullOrEmpty();
            movies[0].Ids.Tmdb.Should().NotHaveValue();

            movies[1].Ids.Should().NotBeNull();
            movies[1].Ids.Trakt.Should().Be(0);
            movies[1].Ids.Slug.Should().BeNullOrEmpty();
            movies[1].Ids.Imdb.Should().Be("tt0000111");
            movies[1].Ids.Tmdb.Should().NotHaveValue();

            var shows = userListItemsPostFromJson.Shows.ToArray();

            shows[0].Ids.Should().NotBeNull();
            shows[0].Ids.Trakt.Should().Be(1);
            shows[0].Ids.Slug.Should().BeNullOrEmpty();
            shows[0].Ids.Imdb.Should().BeNullOrEmpty();
            shows[0].Ids.Tmdb.Should().NotHaveValue();
            shows[0].Ids.Tvdb.Should().NotHaveValue();
            shows[0].Ids.TvRage.Should().NotHaveValue();
            shows[0].Seasons.Should().BeNull();

            shows[1].Ids.Should().NotBeNull();
            shows[1].Ids.Trakt.Should().Be(1);
            shows[1].Ids.Slug.Should().BeNullOrEmpty();
            shows[1].Ids.Imdb.Should().BeNullOrEmpty();
            shows[1].Ids.Tmdb.Should().NotHaveValue();
            shows[1].Ids.Tvdb.Should().NotHaveValue();
            shows[1].Ids.TvRage.Should().NotHaveValue();
            shows[1].Seasons.Should().NotBeNull().And.HaveCount(1);

            var show1Seasons = shows[1].Seasons.ToArray();

            show1Seasons[0].Number.Should().Be(1);
            show1Seasons[0].Episodes.Should().BeNull();

            shows[2].Ids.Should().NotBeNull();
            shows[2].Ids.Trakt.Should().Be(1);
            shows[2].Ids.Slug.Should().BeNullOrEmpty();
            shows[2].Ids.Imdb.Should().BeNullOrEmpty();
            shows[2].Ids.Tmdb.Should().NotHaveValue();
            shows[2].Ids.Tvdb.Should().NotHaveValue();
            shows[2].Ids.TvRage.Should().NotHaveValue();
            shows[2].Seasons.Should().NotBeNull().And.HaveCount(1);

            var show2Seasons = shows[2].Seasons.ToArray();

            show2Seasons[0].Number.Should().Be(1);
            show2Seasons[0].Episodes.Should().NotBeNull().And.HaveCount(2);

            var show2SeasonEpisodes = show2Seasons[0].Episodes.ToArray();

            show2SeasonEpisodes[0].Number.Should().Be(1);
            show2SeasonEpisodes[1].Number.Should().Be(2);

            var people = userListItemsPostFromJson.People.ToArray();

            people[0].Name.Should().Be("Jeff Bridges");
            people[0].Ids.Should().NotBeNull();
            people[0].Ids.Trakt.Should().Be(2);
            people[0].Ids.Slug.Should().Be("jeff-bridges");
            people[0].Ids.Imdb.Should().Be("nm0000313");
            people[0].Ids.Tmdb.Should().Be(1229);
            people[0].Ids.TvRage.Should().Be(59067);
        }
    }
}