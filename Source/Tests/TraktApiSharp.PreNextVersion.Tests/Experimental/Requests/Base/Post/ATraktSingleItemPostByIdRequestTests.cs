﻿namespace TraktApiSharp.Tests.Experimental.Requests.Base.Post
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TraktApiSharp.Experimental.Requests.Base.Post;
    using TraktApiSharp.Experimental.Requests.Interfaces.Base.Post;

    [TestClass]
    public class ATraktSingleItemPostByIdRequestTests
    {
        [TestMethod, TestCategory("Requests"), TestCategory("Base"), TestCategory("Post")]
        public void TestATraktSingleItemPostByIdRequestIsAbstract()
        {
            typeof(ATraktSingleItemPostByIdRequest<,>).IsAbstract.Should().BeTrue();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Base"), TestCategory("Post")]
        public void TestATraktSingleItemPostByIdRequestIsSubclassOfATraktSingleItemPostRequest()
        {
            typeof(ATraktSingleItemPostByIdRequest<int, float>).IsSubclassOf(typeof(ATraktSingleItemPostRequest<int, float>)).Should().BeTrue();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Base"), TestCategory("Post")]
        public void TestATraktSingleItemPostByIdRequestHasGenericTypeParameter()
        {
            typeof(ATraktSingleItemPostByIdRequest<,>).ContainsGenericParameters.Should().BeTrue();
            typeof(ATraktSingleItemPostByIdRequest<int, float>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(2);
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Base"), TestCategory("Post")]
        public void TestATraktSingleItemPostByIdRequestImplementsITraktSingleItemPostByIdRequestInterface()
        {
            typeof(ATraktSingleItemPostByIdRequest<int, float>).GetInterfaces().Should().Contain(typeof(ITraktSingleItemPostByIdRequest<int, float>));
        }
    }
}