﻿namespace TraktApiSharp.Tests.Objects.Post.Scrobbles.Responses
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Newtonsoft.Json;
    using TraktApiSharp.Enums;
    using TraktApiSharp.Objects.Post.Scrobbles.Responses;
    using Utils;
    [TestClass]
    public class TraktEpisodeScrobblePostResponseTests
    {
        [TestMethod]
        public void TestTraktEpisodeScrobblePostResponseDefaultConstructor()
        {
            var episodeScrobbleResponse = new TraktEpisodeScrobblePostResponse();

            episodeScrobbleResponse.Action.Should().Be(TraktScrobbleActionType.Unspecified);
            episodeScrobbleResponse.Progress.Should().Be(0.0f);
            episodeScrobbleResponse.Sharing.Should().BeNull();
            episodeScrobbleResponse.Episode.Should().BeNull();
            episodeScrobbleResponse.Show.Should().BeNull();
        }

        [TestMethod]
        public void TestTraktEpisodeScrobblePostResponseStartReadFromJson()
        {
            var jsonFile = TestUtility.ReadFileContents(@"Objects\Post\Scrobbles\Responses\EpisodeStartScrobblePostResponse.json");

            jsonFile.Should().NotBeNullOrEmpty();

            var episodeScrobbleResponse = JsonConvert.DeserializeObject<TraktEpisodeScrobblePostResponse>(jsonFile);

            episodeScrobbleResponse.Should().NotBeNull();
            episodeScrobbleResponse.Action.Should().Be(TraktScrobbleActionType.Start);
            episodeScrobbleResponse.Progress.Should().Be(10.0f);
            episodeScrobbleResponse.Sharing.Should().NotBeNull();
            episodeScrobbleResponse.Sharing.Facebook.Should().BeTrue();
            episodeScrobbleResponse.Sharing.Twitter.Should().BeTrue();
            episodeScrobbleResponse.Sharing.Tumblr.Should().BeFalse();
            episodeScrobbleResponse.Episode.Should().NotBeNull();
            episodeScrobbleResponse.Episode.SeasonNumber.Should().Be(1);
            episodeScrobbleResponse.Episode.Number.Should().Be(1);
            episodeScrobbleResponse.Episode.Title.Should().Be("Pilot");
            episodeScrobbleResponse.Episode.Ids.Should().NotBeNull();
            episodeScrobbleResponse.Episode.Ids.Trakt.Should().Be(16);
            episodeScrobbleResponse.Episode.Ids.Tvdb.Should().Be(349232);
            episodeScrobbleResponse.Episode.Ids.Imdb.Should().Be("tt0959621");
            episodeScrobbleResponse.Episode.Ids.Tmdb.Should().Be(62085);
            episodeScrobbleResponse.Episode.Ids.TvRage.Should().Be(637041);
            episodeScrobbleResponse.Show.Should().NotBeNull();
            episodeScrobbleResponse.Show.Title.Should().Be("Breaking Bad");
            episodeScrobbleResponse.Show.Year.Should().Be(2008);
            episodeScrobbleResponse.Show.Ids.Should().NotBeNull();
            episodeScrobbleResponse.Show.Ids.Trakt.Should().Be(1);
            episodeScrobbleResponse.Show.Ids.Slug.Should().Be("breaking-bad");
            episodeScrobbleResponse.Show.Ids.Tvdb.Should().Be(81189);
            episodeScrobbleResponse.Show.Ids.Imdb.Should().Be("tt0903747");
            episodeScrobbleResponse.Show.Ids.Tmdb.Should().Be(1396);
            episodeScrobbleResponse.Show.Ids.TvRage.Should().Be(18164);
        }

        [TestMethod]
        public void TestTraktEpisodeScrobblePostResponsePauseReadFromJson()
        {
            var jsonFile = TestUtility.ReadFileContents(@"Objects\Post\Scrobbles\Responses\EpisodePauseScrobblePostResponse.json");

            jsonFile.Should().NotBeNullOrEmpty();

            var episodeScrobbleResponse = JsonConvert.DeserializeObject<TraktEpisodeScrobblePostResponse>(jsonFile);

            episodeScrobbleResponse.Should().NotBeNull();
            episodeScrobbleResponse.Action.Should().Be(TraktScrobbleActionType.Pause);
            episodeScrobbleResponse.Progress.Should().Be(75.0f);
            episodeScrobbleResponse.Sharing.Should().NotBeNull();
            episodeScrobbleResponse.Sharing.Facebook.Should().BeFalse();
            episodeScrobbleResponse.Sharing.Twitter.Should().BeTrue();
            episodeScrobbleResponse.Sharing.Tumblr.Should().BeFalse();
            episodeScrobbleResponse.Episode.Should().NotBeNull();
            episodeScrobbleResponse.Episode.SeasonNumber.Should().Be(1);
            episodeScrobbleResponse.Episode.Number.Should().Be(1);
            episodeScrobbleResponse.Episode.Title.Should().Be("Pilot");
            episodeScrobbleResponse.Episode.Ids.Should().NotBeNull();
            episodeScrobbleResponse.Episode.Ids.Trakt.Should().Be(16);
            episodeScrobbleResponse.Episode.Ids.Tvdb.Should().Be(349232);
            episodeScrobbleResponse.Episode.Ids.Imdb.Should().Be("tt0959621");
            episodeScrobbleResponse.Episode.Ids.Tmdb.Should().Be(62085);
            episodeScrobbleResponse.Episode.Ids.TvRage.Should().Be(637041);
            episodeScrobbleResponse.Show.Should().NotBeNull();
            episodeScrobbleResponse.Show.Title.Should().Be("Breaking Bad");
            episodeScrobbleResponse.Show.Year.Should().Be(2008);
            episodeScrobbleResponse.Show.Ids.Should().NotBeNull();
            episodeScrobbleResponse.Show.Ids.Trakt.Should().Be(1);
            episodeScrobbleResponse.Show.Ids.Slug.Should().Be("breaking-bad");
            episodeScrobbleResponse.Show.Ids.Tvdb.Should().Be(81189);
            episodeScrobbleResponse.Show.Ids.Imdb.Should().Be("tt0903747");
            episodeScrobbleResponse.Show.Ids.Tmdb.Should().Be(1396);
            episodeScrobbleResponse.Show.Ids.TvRage.Should().Be(18164);
        }

        [TestMethod]
        public void TestTraktEpisodeScrobblePostResponseStopReadFromJson()
        {
            var jsonFile = TestUtility.ReadFileContents(@"Objects\Post\Scrobbles\Responses\EpisodeStopScrobblePostResponse.json");

            jsonFile.Should().NotBeNullOrEmpty();

            var episodeScrobbleResponse = JsonConvert.DeserializeObject<TraktEpisodeScrobblePostResponse>(jsonFile);

            episodeScrobbleResponse.Should().NotBeNull();
            episodeScrobbleResponse.Action.Should().Be(TraktScrobbleActionType.Stop);
            episodeScrobbleResponse.Progress.Should().Be(85.0f);
            episodeScrobbleResponse.Sharing.Should().NotBeNull();
            episodeScrobbleResponse.Sharing.Facebook.Should().BeTrue();
            episodeScrobbleResponse.Sharing.Twitter.Should().BeTrue();
            episodeScrobbleResponse.Sharing.Tumblr.Should().BeFalse();
            episodeScrobbleResponse.Episode.Should().NotBeNull();
            episodeScrobbleResponse.Episode.SeasonNumber.Should().Be(1);
            episodeScrobbleResponse.Episode.Number.Should().Be(1);
            episodeScrobbleResponse.Episode.Title.Should().Be("Pilot");
            episodeScrobbleResponse.Episode.Ids.Should().NotBeNull();
            episodeScrobbleResponse.Episode.Ids.Trakt.Should().Be(16);
            episodeScrobbleResponse.Episode.Ids.Tvdb.Should().Be(349232);
            episodeScrobbleResponse.Episode.Ids.Imdb.Should().Be("tt0959621");
            episodeScrobbleResponse.Episode.Ids.Tmdb.Should().Be(62085);
            episodeScrobbleResponse.Episode.Ids.TvRage.Should().Be(637041);
            episodeScrobbleResponse.Show.Should().NotBeNull();
            episodeScrobbleResponse.Show.Title.Should().Be("Breaking Bad");
            episodeScrobbleResponse.Show.Year.Should().Be(2008);
            episodeScrobbleResponse.Show.Ids.Should().NotBeNull();
            episodeScrobbleResponse.Show.Ids.Trakt.Should().Be(1);
            episodeScrobbleResponse.Show.Ids.Slug.Should().Be("breaking-bad");
            episodeScrobbleResponse.Show.Ids.Tvdb.Should().Be(81189);
            episodeScrobbleResponse.Show.Ids.Imdb.Should().Be("tt0903747");
            episodeScrobbleResponse.Show.Ids.Tmdb.Should().Be(1396);
            episodeScrobbleResponse.Show.Ids.TvRage.Should().Be(18164);
        }
    }
}