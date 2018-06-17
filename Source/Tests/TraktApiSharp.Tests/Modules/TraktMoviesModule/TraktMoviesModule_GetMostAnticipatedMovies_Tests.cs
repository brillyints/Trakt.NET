﻿namespace TraktApiSharp.Tests.Modules.TraktMoviesModule
{
    using FluentAssertions;
    using System;
    using System.Net;
    using System.Threading.Tasks;
    using TestUtils;
    using Traits;
    using TraktApiSharp.Exceptions;
    using TraktApiSharp.Objects.Get.Movies;
    using TraktApiSharp.Requests.Parameters;
    using TraktApiSharp.Responses;
    using Xunit;

    [Category("Modules.Movies")]
    public partial class TraktMoviesModule_Tests
    {
        private const string GET_MOST_ANTICIPATED_MOVIES_URI = "movies/anticipated";

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostAnticipatedMovies()
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_ANTICIPATED_MOVIES_URI,
                                                           MOST_ANTICIPATED_MOVIES_JSON, 1, 10, 1, ITEM_COUNT);

            TraktPagedResponse<ITraktMostAnticipatedMovie> response = await client.Movies.GetMostAnticipatedMoviesAsync();

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostAnticipatedMovies_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_ANTICIPATED_MOVIES_URI}?{FILTER}",
                                                           MOST_ANTICIPATED_MOVIES_JSON, 1, 10, 1, ITEM_COUNT);

            TraktPagedResponse<ITraktMostAnticipatedMovie> response = await client.Movies.GetMostAnticipatedMoviesAsync(null, FILTER);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostAnticipatedMovies_With_ExtendedInfo()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_ANTICIPATED_MOVIES_URI}?extended={EXTENDED_INFO}",
                                                           MOST_ANTICIPATED_MOVIES_JSON, 1, 10, 1, ITEM_COUNT);

            TraktPagedResponse<ITraktMostAnticipatedMovie> response = await client.Movies.GetMostAnticipatedMoviesAsync(EXTENDED_INFO);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostAnticipatedMovies_With_ExtendedInfo_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_ANTICIPATED_MOVIES_URI}?extended={EXTENDED_INFO}&{FILTER}",
                                                           MOST_ANTICIPATED_MOVIES_JSON, 1, 10, 1, ITEM_COUNT);

            TraktPagedResponse<ITraktMostAnticipatedMovie> response = await client.Movies.GetMostAnticipatedMoviesAsync(EXTENDED_INFO, FILTER);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostAnticipatedMovies_With_Page()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_ANTICIPATED_MOVIES_URI}?page={PAGE}",
                                                           MOST_ANTICIPATED_MOVIES_JSON, PAGE, 10, 1, ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE);
            TraktPagedResponse<ITraktMostAnticipatedMovie> response = await client.Movies.GetMostAnticipatedMoviesAsync(null, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostAnticipatedMovies_With_Page_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_ANTICIPATED_MOVIES_URI}?page={PAGE}&{FILTER}",
                                                           MOST_ANTICIPATED_MOVIES_JSON, PAGE, 10, 1, ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE);
            TraktPagedResponse<ITraktMostAnticipatedMovie> response = await client.Movies.GetMostAnticipatedMoviesAsync(null, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostAnticipatedMovies_With_ExtendedInfo_And_Page()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_ANTICIPATED_MOVIES_URI}?extended={EXTENDED_INFO}&page={PAGE}",
                                                           MOST_ANTICIPATED_MOVIES_JSON, PAGE, 10, 1, ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE);
            TraktPagedResponse<ITraktMostAnticipatedMovie> response = await client.Movies.GetMostAnticipatedMoviesAsync(EXTENDED_INFO, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostAnticipatedMovies_With_ExtendedInfo_And_Page_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_ANTICIPATED_MOVIES_URI}?extended={EXTENDED_INFO}&{FILTER}&page={PAGE}",
                                                           MOST_ANTICIPATED_MOVIES_JSON, PAGE, 10, 1, ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE);
            TraktPagedResponse<ITraktMostAnticipatedMovie> response = await client.Movies.GetMostAnticipatedMoviesAsync(EXTENDED_INFO, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostAnticipatedMovies_With_Limit()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_ANTICIPATED_MOVIES_URI}?limit={LIMIT}",
                                                           MOST_ANTICIPATED_MOVIES_JSON, 1, LIMIT, 1, ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(null, LIMIT);
            TraktPagedResponse<ITraktMostAnticipatedMovie> response = await client.Movies.GetMostAnticipatedMoviesAsync(null, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostAnticipatedMovies_With_Limit_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_ANTICIPATED_MOVIES_URI}?limit={LIMIT}&{FILTER}",
                                                           MOST_ANTICIPATED_MOVIES_JSON, 1, LIMIT, 1, ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(null, LIMIT);
            TraktPagedResponse<ITraktMostAnticipatedMovie> response = await client.Movies.GetMostAnticipatedMoviesAsync(null, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostAnticipatedMovies_With_ExtendedInfo_And_Limit()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_ANTICIPATED_MOVIES_URI}?extended={EXTENDED_INFO}&limit={LIMIT}",
                                                           MOST_ANTICIPATED_MOVIES_JSON, 1, LIMIT, 1, ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(null, LIMIT);
            TraktPagedResponse<ITraktMostAnticipatedMovie> response = await client.Movies.GetMostAnticipatedMoviesAsync(EXTENDED_INFO, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostAnticipatedMovies_With_ExtendedInfo_And_Limit_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_ANTICIPATED_MOVIES_URI}?extended={EXTENDED_INFO}&limit={LIMIT}&{FILTER}",
                                                           MOST_ANTICIPATED_MOVIES_JSON, 1, LIMIT, 1, ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(null, LIMIT);
            TraktPagedResponse<ITraktMostAnticipatedMovie> response = await client.Movies.GetMostAnticipatedMoviesAsync(EXTENDED_INFO, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostAnticipatedMovies_With_Page_And_Limit()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_ANTICIPATED_MOVIES_URI}?page={PAGE}&limit={LIMIT}",
                                                           MOST_ANTICIPATED_MOVIES_JSON, PAGE, LIMIT, 1, ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE, LIMIT);
            TraktPagedResponse<ITraktMostAnticipatedMovie> response = await client.Movies.GetMostAnticipatedMoviesAsync(null, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostAnticipatedMovies_With_Page_And_Limit_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_ANTICIPATED_MOVIES_URI}?page={PAGE}&limit={LIMIT}&{FILTER}",
                                                           MOST_ANTICIPATED_MOVIES_JSON, PAGE, LIMIT, 1, ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE, LIMIT);
            TraktPagedResponse<ITraktMostAnticipatedMovie> response = await client.Movies.GetMostAnticipatedMoviesAsync(null, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostAnticipatedMovies_Complete()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_ANTICIPATED_MOVIES_URI}?extended={EXTENDED_INFO}&page={PAGE}&limit={LIMIT}",
                                                           MOST_ANTICIPATED_MOVIES_JSON, PAGE, LIMIT, 1, ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE, LIMIT);
            TraktPagedResponse<ITraktMostAnticipatedMovie> response = await client.Movies.GetMostAnticipatedMoviesAsync(EXTENDED_INFO, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostAnticipatedMovies_Complete_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_ANTICIPATED_MOVIES_URI}?extended={EXTENDED_INFO}&page={PAGE}&{FILTER}&limit={LIMIT}",
                                                           MOST_ANTICIPATED_MOVIES_JSON, PAGE, LIMIT, 1, ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE, LIMIT);
            TraktPagedResponse<ITraktMostAnticipatedMovie> response = await client.Movies.GetMostAnticipatedMoviesAsync(EXTENDED_INFO, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public void Test_TraktMoviesModule_GetMostAnticipatedMovies_Throws_NotFoundException()
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_ANTICIPATED_MOVIES_URI, HttpStatusCode.NotFound);
            Func<Task<TraktPagedResponse<ITraktMostAnticipatedMovie>>> act = () => client.Movies.GetMostAnticipatedMoviesAsync();
            act.Should().Throw<TraktNotFoundException>();
        }

        [Fact]
        public void Test_TraktMoviesModule_GetMostAnticipatedMovies_Throws_AuthorizationException()
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_ANTICIPATED_MOVIES_URI, HttpStatusCode.Unauthorized);
            Func<Task<TraktPagedResponse<ITraktMostAnticipatedMovie>>> act = () => client.Movies.GetMostAnticipatedMoviesAsync();
            act.Should().Throw<TraktAuthorizationException>();
        }

        [Fact]
        public void Test_TraktMoviesModule_GetMostAnticipatedMovies_Throws_BadRequestException()
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_ANTICIPATED_MOVIES_URI, HttpStatusCode.BadRequest);
            Func<Task<TraktPagedResponse<ITraktMostAnticipatedMovie>>> act = () => client.Movies.GetMostAnticipatedMoviesAsync();
            act.Should().Throw<TraktBadRequestException>();
        }

        [Fact]
        public void Test_TraktMoviesModule_GetMostAnticipatedMovies_Throws_ForbiddenException()
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_ANTICIPATED_MOVIES_URI, HttpStatusCode.Forbidden);
            Func<Task<TraktPagedResponse<ITraktMostAnticipatedMovie>>> act = () => client.Movies.GetMostAnticipatedMoviesAsync();
            act.Should().Throw<TraktForbiddenException>();
        }

        [Fact]
        public void Test_TraktMoviesModule_GetMostAnticipatedMovies_Throws_MethodNotFoundException()
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_ANTICIPATED_MOVIES_URI, HttpStatusCode.MethodNotAllowed);
            Func<Task<TraktPagedResponse<ITraktMostAnticipatedMovie>>> act = () => client.Movies.GetMostAnticipatedMoviesAsync();
            act.Should().Throw<TraktMethodNotFoundException>();
        }

        [Fact]
        public void Test_TraktMoviesModule_GetMostAnticipatedMovies_Throws_ConflictException()
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_ANTICIPATED_MOVIES_URI, HttpStatusCode.Conflict);
            Func<Task<TraktPagedResponse<ITraktMostAnticipatedMovie>>> act = () => client.Movies.GetMostAnticipatedMoviesAsync();
            act.Should().Throw<TraktConflictException>();
        }

        [Fact]
        public void Test_TraktMoviesModule_GetMostAnticipatedMovies_Throws_ServerException()
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_ANTICIPATED_MOVIES_URI, HttpStatusCode.InternalServerError);
            Func<Task<TraktPagedResponse<ITraktMostAnticipatedMovie>>> act = () => client.Movies.GetMostAnticipatedMoviesAsync();
            act.Should().Throw<TraktServerException>();
        }

        [Fact]
        public void Test_TraktMoviesModule_GetMostAnticipatedMovies_Throws_BadGatewayException()
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_ANTICIPATED_MOVIES_URI, HttpStatusCode.BadGateway);
            Func<Task<TraktPagedResponse<ITraktMostAnticipatedMovie>>> act = () => client.Movies.GetMostAnticipatedMoviesAsync();
            act.Should().Throw<TraktBadGatewayException>();
        }

        [Fact]
        public void Test_TraktMoviesModule_GetMostAnticipatedMovies_Throws_PreconditionFailedException()
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_ANTICIPATED_MOVIES_URI, (HttpStatusCode)412);
            Func<Task<TraktPagedResponse<ITraktMostAnticipatedMovie>>> act = () => client.Movies.GetMostAnticipatedMoviesAsync();
            act.Should().Throw<TraktPreconditionFailedException>();
        }

        [Fact]
        public void Test_TraktMoviesModule_GetMostAnticipatedMovies_Throws_ValidationException()
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_ANTICIPATED_MOVIES_URI, (HttpStatusCode)422);
            Func<Task<TraktPagedResponse<ITraktMostAnticipatedMovie>>> act = () => client.Movies.GetMostAnticipatedMoviesAsync();
            act.Should().Throw<TraktValidationException>();
        }

        [Fact]
        public void Test_TraktMoviesModule_GetMostAnticipatedMovies_Throws_RateLimitException()
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_ANTICIPATED_MOVIES_URI, (HttpStatusCode)429);
            Func<Task<TraktPagedResponse<ITraktMostAnticipatedMovie>>> act = () => client.Movies.GetMostAnticipatedMoviesAsync();
            act.Should().Throw<TraktRateLimitException>();
        }

        [Fact]
        public void Test_TraktMoviesModule_GetMostAnticipatedMovies_Throws_ServerUnavailableException_503()
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_ANTICIPATED_MOVIES_URI, (HttpStatusCode)503);
            Func<Task<TraktPagedResponse<ITraktMostAnticipatedMovie>>> act = () => client.Movies.GetMostAnticipatedMoviesAsync();
            act.Should().Throw<TraktServerUnavailableException>();
        }

        [Fact]
        public void Test_TraktMoviesModule_GetMostAnticipatedMovies_Throws_ServerUnavailableException_504()
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_ANTICIPATED_MOVIES_URI, (HttpStatusCode)504);
            Func<Task<TraktPagedResponse<ITraktMostAnticipatedMovie>>> act = () => client.Movies.GetMostAnticipatedMoviesAsync();
            act.Should().Throw<TraktServerUnavailableException>();
        }

        [Fact]
        public void Test_TraktMoviesModule_GetMostAnticipatedMovies_Throws_ServerUnavailableException_520()
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_ANTICIPATED_MOVIES_URI, (HttpStatusCode)520);
            Func<Task<TraktPagedResponse<ITraktMostAnticipatedMovie>>> act = () => client.Movies.GetMostAnticipatedMoviesAsync();
            act.Should().Throw<TraktServerUnavailableException>();
        }

        [Fact]
        public void Test_TraktMoviesModule_GetMostAnticipatedMovies_Throws_ServerUnavailableException_521()
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_ANTICIPATED_MOVIES_URI, (HttpStatusCode)521);
            Func<Task<TraktPagedResponse<ITraktMostAnticipatedMovie>>> act = () => client.Movies.GetMostAnticipatedMoviesAsync();
            act.Should().Throw<TraktServerUnavailableException>();
        }

        [Fact]
        public void Test_TraktMoviesModule_GetMostAnticipatedMovies_Throws_ServerUnavailableException_522()
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_ANTICIPATED_MOVIES_URI, (HttpStatusCode)522);
            Func<Task<TraktPagedResponse<ITraktMostAnticipatedMovie>>> act = () => client.Movies.GetMostAnticipatedMoviesAsync();
            act.Should().Throw<TraktServerUnavailableException>();
        }
    }
}