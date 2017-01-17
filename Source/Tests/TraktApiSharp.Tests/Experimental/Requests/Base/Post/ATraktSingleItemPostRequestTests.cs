﻿namespace TraktApiSharp.Tests.Experimental.Requests.Base.Post
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TraktApiSharp.Experimental.Requests.Base;
    using TraktApiSharp.Experimental.Requests.Base.Post;
    using TraktApiSharp.Experimental.Requests.Interfaces.Base.Post;

    [TestClass]
    public class ATraktSingleItemPostRequestTests
    {
        [TestMethod, TestCategory("Requests"), TestCategory("Base"), TestCategory("Post")]
        public void TestATraktSingleItemPostRequestIsAbstract()
        {
            typeof(ATraktSingleItemPostRequest<,>).IsAbstract.Should().BeTrue();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Base"), TestCategory("Post")]
        public void TestATraktSingleItemPostRequestIsSubclassOfATraktSingleItemRequest()
        {
            typeof(ATraktSingleItemPostRequest<int, float>).IsSubclassOf(typeof(ATraktSingleItemRequest<int>)).Should().BeTrue();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Base"), TestCategory("Post")]
        public void TestATraktSingleItemPostRequestHasGenericTypeParameter()
        {
            typeof(ATraktSingleItemPostRequest<,>).ContainsGenericParameters.Should().BeTrue();
            typeof(ATraktSingleItemPostRequest<int, float>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(2);
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Base"), TestCategory("Post")]
        public void TestATraktSingleItemPostRequestImplementsITraktSingleItemPostRequestInterface()
        {
            typeof(ATraktSingleItemPostRequest<int, float>).GetInterfaces().Should().Contain(typeof(ITraktSingleItemPostRequest<int, float>));
        }
    }
}
