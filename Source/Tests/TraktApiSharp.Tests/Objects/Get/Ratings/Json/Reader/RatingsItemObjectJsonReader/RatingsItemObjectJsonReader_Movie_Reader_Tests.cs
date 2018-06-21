﻿namespace TraktNet.Tests.Objects.Get.Ratings.Json.Reader
{
    using FluentAssertions;
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using Traits;
    using TraktNet.Enums;
    using TraktNet.Objects.Get.Ratings.Json.Reader;
    using Xunit;

    [Category("Objects.Get.Ratings.JsonReader")]
    public partial class RatingsItemObjectJsonReader_Tests
    {
        [Fact]
        public async Task Test_RatingsItemObjectJsonReader_Movie_ReadObject_From_JsonReader_Complete()
        {
            var traktJsonReader = new RatingsItemObjectJsonReader();

            using (var reader = new StringReader(TYPE_MOVIE_JSON_COMPLETE))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktRatingItem = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktRatingItem.Should().NotBeNull();
                traktRatingItem.RatedAt.Should().Be(DateTime.Parse("2014-09-01T09:10:11.000Z").ToUniversalTime());
                traktRatingItem.Rating.Should().Be(10);
                traktRatingItem.Type.Should().Be(TraktRatingsItemType.Movie);
                traktRatingItem.Movie.Should().NotBeNull();
                traktRatingItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktRatingItem.Movie.Year.Should().Be(2015);
                traktRatingItem.Movie.Ids.Should().NotBeNull();
                traktRatingItem.Movie.Ids.Trakt.Should().Be(94024U);
                traktRatingItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktRatingItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktRatingItem.Movie.Ids.Tmdb.Should().Be(140607U);

                traktRatingItem.Show.Should().BeNull();
                traktRatingItem.Season.Should().BeNull();
                traktRatingItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_RatingsItemObjectJsonReader_Movie_ReadObject_From_JsonReader_Incomplete_1()
        {
            var traktJsonReader = new RatingsItemObjectJsonReader();

            using (var reader = new StringReader(TYPE_MOVIE_JSON_INCOMPLETE_1))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktRatingItem = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktRatingItem.Should().NotBeNull();
                traktRatingItem.RatedAt.Should().BeNull();
                traktRatingItem.Rating.Should().Be(10);
                traktRatingItem.Type.Should().Be(TraktRatingsItemType.Movie);
                traktRatingItem.Movie.Should().NotBeNull();
                traktRatingItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktRatingItem.Movie.Year.Should().Be(2015);
                traktRatingItem.Movie.Ids.Should().NotBeNull();
                traktRatingItem.Movie.Ids.Trakt.Should().Be(94024U);
                traktRatingItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktRatingItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktRatingItem.Movie.Ids.Tmdb.Should().Be(140607U);

                traktRatingItem.Show.Should().BeNull();
                traktRatingItem.Season.Should().BeNull();
                traktRatingItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_RatingsItemObjectJsonReader_Movie_ReadObject_From_JsonReader_Incomplete_2()
        {
            var traktJsonReader = new RatingsItemObjectJsonReader();

            using (var reader = new StringReader(TYPE_MOVIE_JSON_INCOMPLETE_2))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktRatingItem = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktRatingItem.Should().NotBeNull();
                traktRatingItem.RatedAt.Should().Be(DateTime.Parse("2014-09-01T09:10:11.000Z").ToUniversalTime());
                traktRatingItem.Rating.Should().BeNull();
                traktRatingItem.Type.Should().Be(TraktRatingsItemType.Movie);
                traktRatingItem.Movie.Should().NotBeNull();
                traktRatingItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktRatingItem.Movie.Year.Should().Be(2015);
                traktRatingItem.Movie.Ids.Should().NotBeNull();
                traktRatingItem.Movie.Ids.Trakt.Should().Be(94024U);
                traktRatingItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktRatingItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktRatingItem.Movie.Ids.Tmdb.Should().Be(140607U);

                traktRatingItem.Show.Should().BeNull();
                traktRatingItem.Season.Should().BeNull();
                traktRatingItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_RatingsItemObjectJsonReader_Movie_ReadObject_From_JsonReader_Incomplete_3()
        {
            var traktJsonReader = new RatingsItemObjectJsonReader();

            using (var reader = new StringReader(TYPE_MOVIE_JSON_INCOMPLETE_3))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktRatingItem = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktRatingItem.Should().NotBeNull();
                traktRatingItem.RatedAt.Should().Be(DateTime.Parse("2014-09-01T09:10:11.000Z").ToUniversalTime());
                traktRatingItem.Rating.Should().Be(10);
                traktRatingItem.Type.Should().BeNull();
                traktRatingItem.Movie.Should().NotBeNull();
                traktRatingItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktRatingItem.Movie.Year.Should().Be(2015);
                traktRatingItem.Movie.Ids.Should().NotBeNull();
                traktRatingItem.Movie.Ids.Trakt.Should().Be(94024U);
                traktRatingItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktRatingItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktRatingItem.Movie.Ids.Tmdb.Should().Be(140607U);

                traktRatingItem.Show.Should().BeNull();
                traktRatingItem.Season.Should().BeNull();
                traktRatingItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_RatingsItemObjectJsonReader_Movie_ReadObject_From_JsonReader_Incomplete_4()
        {
            var traktJsonReader = new RatingsItemObjectJsonReader();

            using (var reader = new StringReader(TYPE_MOVIE_JSON_INCOMPLETE_4))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktRatingItem = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktRatingItem.Should().NotBeNull();
                traktRatingItem.RatedAt.Should().Be(DateTime.Parse("2014-09-01T09:10:11.000Z").ToUniversalTime());
                traktRatingItem.Rating.Should().Be(10);
                traktRatingItem.Type.Should().Be(TraktRatingsItemType.Movie);
                traktRatingItem.Movie.Should().BeNull();

                traktRatingItem.Show.Should().BeNull();
                traktRatingItem.Season.Should().BeNull();
                traktRatingItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_RatingsItemObjectJsonReader_Movie_ReadObject_From_JsonReader_Incomplete_5()
        {
            var traktJsonReader = new RatingsItemObjectJsonReader();

            using (var reader = new StringReader(TYPE_MOVIE_JSON_INCOMPLETE_5))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktRatingItem = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktRatingItem.Should().NotBeNull();
                traktRatingItem.RatedAt.Should().Be(DateTime.Parse("2014-09-01T09:10:11.000Z").ToUniversalTime());
                traktRatingItem.Rating.Should().BeNull();
                traktRatingItem.Type.Should().BeNull();
                traktRatingItem.Movie.Should().BeNull();

                traktRatingItem.Show.Should().BeNull();
                traktRatingItem.Season.Should().BeNull();
                traktRatingItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_RatingsItemObjectJsonReader_Movie_ReadObject_From_JsonReader_Incomplete_6()
        {
            var traktJsonReader = new RatingsItemObjectJsonReader();

            using (var reader = new StringReader(TYPE_MOVIE_JSON_INCOMPLETE_6))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktRatingItem = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktRatingItem.Should().NotBeNull();
                traktRatingItem.RatedAt.Should().BeNull();
                traktRatingItem.Rating.Should().Be(10);
                traktRatingItem.Type.Should().BeNull();
                traktRatingItem.Movie.Should().BeNull();

                traktRatingItem.Show.Should().BeNull();
                traktRatingItem.Season.Should().BeNull();
                traktRatingItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_RatingsItemObjectJsonReader_Movie_ReadObject_From_JsonReader_Incomplete_7()
        {
            var traktJsonReader = new RatingsItemObjectJsonReader();

            using (var reader = new StringReader(TYPE_MOVIE_JSON_INCOMPLETE_7))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktRatingItem = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktRatingItem.Should().NotBeNull();
                traktRatingItem.RatedAt.Should().BeNull();
                traktRatingItem.Rating.Should().BeNull();
                traktRatingItem.Type.Should().Be(TraktRatingsItemType.Movie);
                traktRatingItem.Movie.Should().BeNull();

                traktRatingItem.Show.Should().BeNull();
                traktRatingItem.Season.Should().BeNull();
                traktRatingItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_RatingsItemObjectJsonReader_Movie_ReadObject_From_JsonReader_Incomplete_8()
        {
            var traktJsonReader = new RatingsItemObjectJsonReader();

            using (var reader = new StringReader(TYPE_MOVIE_JSON_INCOMPLETE_8))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktRatingItem = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktRatingItem.Should().NotBeNull();
                traktRatingItem.RatedAt.Should().BeNull();
                traktRatingItem.Rating.Should().BeNull();
                traktRatingItem.Type.Should().BeNull();
                traktRatingItem.Movie.Should().NotBeNull();
                traktRatingItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktRatingItem.Movie.Year.Should().Be(2015);
                traktRatingItem.Movie.Ids.Should().NotBeNull();
                traktRatingItem.Movie.Ids.Trakt.Should().Be(94024U);
                traktRatingItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktRatingItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktRatingItem.Movie.Ids.Tmdb.Should().Be(140607U);

                traktRatingItem.Show.Should().BeNull();
                traktRatingItem.Season.Should().BeNull();
                traktRatingItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_RatingsItemObjectJsonReader_Movie_ReadObject_From_JsonReader_Not_Valid_1()
        {
            var traktJsonReader = new RatingsItemObjectJsonReader();

            using (var reader = new StringReader(TYPE_MOVIE_JSON_NOT_VALID_1))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktRatingItem = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktRatingItem.Should().NotBeNull();
                traktRatingItem.RatedAt.Should().BeNull();
                traktRatingItem.Rating.Should().Be(10);
                traktRatingItem.Type.Should().Be(TraktRatingsItemType.Movie);
                traktRatingItem.Movie.Should().NotBeNull();
                traktRatingItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktRatingItem.Movie.Year.Should().Be(2015);
                traktRatingItem.Movie.Ids.Should().NotBeNull();
                traktRatingItem.Movie.Ids.Trakt.Should().Be(94024U);
                traktRatingItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktRatingItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktRatingItem.Movie.Ids.Tmdb.Should().Be(140607U);

                traktRatingItem.Show.Should().BeNull();
                traktRatingItem.Season.Should().BeNull();
                traktRatingItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_RatingsItemObjectJsonReader_Movie_ReadObject_From_JsonReader_Not_Valid_2()
        {
            var traktJsonReader = new RatingsItemObjectJsonReader();

            using (var reader = new StringReader(TYPE_MOVIE_JSON_NOT_VALID_2))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktRatingItem = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktRatingItem.Should().NotBeNull();
                traktRatingItem.RatedAt.Should().Be(DateTime.Parse("2014-09-01T09:10:11.000Z").ToUniversalTime());
                traktRatingItem.Rating.Should().BeNull();
                traktRatingItem.Type.Should().Be(TraktRatingsItemType.Movie);
                traktRatingItem.Movie.Should().NotBeNull();
                traktRatingItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktRatingItem.Movie.Year.Should().Be(2015);
                traktRatingItem.Movie.Ids.Should().NotBeNull();
                traktRatingItem.Movie.Ids.Trakt.Should().Be(94024U);
                traktRatingItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktRatingItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktRatingItem.Movie.Ids.Tmdb.Should().Be(140607U);

                traktRatingItem.Show.Should().BeNull();
                traktRatingItem.Season.Should().BeNull();
                traktRatingItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_RatingsItemObjectJsonReader_Movie_ReadObject_From_JsonReader_Not_Valid_3()
        {
            var traktJsonReader = new RatingsItemObjectJsonReader();

            using (var reader = new StringReader(TYPE_MOVIE_JSON_NOT_VALID_3))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktRatingItem = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktRatingItem.Should().NotBeNull();
                traktRatingItem.RatedAt.Should().Be(DateTime.Parse("2014-09-01T09:10:11.000Z").ToUniversalTime());
                traktRatingItem.Rating.Should().Be(10);
                traktRatingItem.Type.Should().BeNull();
                traktRatingItem.Movie.Should().NotBeNull();
                traktRatingItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktRatingItem.Movie.Year.Should().Be(2015);
                traktRatingItem.Movie.Ids.Should().NotBeNull();
                traktRatingItem.Movie.Ids.Trakt.Should().Be(94024U);
                traktRatingItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktRatingItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktRatingItem.Movie.Ids.Tmdb.Should().Be(140607U);

                traktRatingItem.Show.Should().BeNull();
                traktRatingItem.Season.Should().BeNull();
                traktRatingItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_RatingsItemObjectJsonReader_Movie_ReadObject_From_JsonReader_Not_Valid_4()
        {
            var traktJsonReader = new RatingsItemObjectJsonReader();

            using (var reader = new StringReader(TYPE_MOVIE_JSON_NOT_VALID_4))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktRatingItem = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktRatingItem.Should().NotBeNull();
                traktRatingItem.RatedAt.Should().Be(DateTime.Parse("2014-09-01T09:10:11.000Z").ToUniversalTime());
                traktRatingItem.Rating.Should().Be(10);
                traktRatingItem.Type.Should().Be(TraktRatingsItemType.Movie);
                traktRatingItem.Movie.Should().BeNull();

                traktRatingItem.Show.Should().BeNull();
                traktRatingItem.Season.Should().BeNull();
                traktRatingItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_RatingsItemObjectJsonReader_Movie_ReadObject_From_JsonReader_Not_Valid_5()
        {
            var traktJsonReader = new RatingsItemObjectJsonReader();

            using (var reader = new StringReader(TYPE_MOVIE_JSON_NOT_VALID_5))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktRatingItem = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktRatingItem.Should().NotBeNull();
                traktRatingItem.RatedAt.Should().BeNull();
                traktRatingItem.Rating.Should().BeNull();
                traktRatingItem.Type.Should().BeNull();
                traktRatingItem.Movie.Should().BeNull();
                traktRatingItem.Show.Should().BeNull();
                traktRatingItem.Season.Should().BeNull();
                traktRatingItem.Episode.Should().BeNull();
            }
        }
    }
}
