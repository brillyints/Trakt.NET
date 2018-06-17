﻿namespace TraktApiSharp.Tests.Requests.Base
{
    using FluentAssertions;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Traits;
    using TraktApiSharp.Requests.Base;
    using TraktApiSharp.Requests.Interfaces;
    using Xunit;

    [Category("Requests.Base")]
    public class APostRequest_1_Tests
    {
        internal class RequestBodyMock : IRequestBody
        {
            public HttpContent ToHttpContent()
            {
                throw new NotImplementedException();
            }

            public Task<string> ToJson(CancellationToken cancellationToken = default(CancellationToken)) => Task.FromResult("");

            public void Validate()
            {
            }
        }

        internal class PostRequestMock : APostRequest<RequestBodyMock>
        {
            public override RequestBodyMock RequestBody { get; set; }
            public override string UriTemplate { get { throw new NotImplementedException(); } }
            public override IDictionary<string, object> GetUriPathParameters() => throw new NotImplementedException();
        }

        [Fact]
        public void Test_APostRequest_1_Returns_Valid_AuthorizationRequirement()
        {
            var requestMock = new PostRequestMock();
            requestMock.AuthorizationRequirement.Should().Be(AuthorizationRequirement.Required);
        }

        [Fact]
        public void Test_APostRequest_1_Returns_Valid_Method()
        {
            var requestMock = new PostRequestMock();
            requestMock.Method.Should().Be(HttpMethod.Post);
        }

        [Fact]
        public void Test_APostRequest_1_Validate_Throws_ArgumentNullException()
        {
            var requestMock = new PostRequestMock();

            Action act = () => requestMock.Validate();
            act.Should().Throw<ArgumentNullException>();
        }
    }
}