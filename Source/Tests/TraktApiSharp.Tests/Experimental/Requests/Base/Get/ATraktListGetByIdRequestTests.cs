﻿namespace TraktApiSharp.Tests.Experimental.Requests.Base.Get
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TraktApiSharp.Experimental.Requests.Base;
    using TraktApiSharp.Experimental.Requests.Base.Get;
    using TraktApiSharp.Experimental.Requests.Interfaces;

    [TestClass]
    public class ATraktListGetByIdRequestTests
    {
        [TestMethod]
        public void TestATraktListGetByIdRequestIsAbstract()
        {
            typeof(ATraktListGetByIdRequest<>).IsAbstract.Should().BeTrue();
        }

        [TestMethod]
        public void TestATraktListGetByIdRequestIsSubclassOfATraktListRequest()
        {
            typeof(ATraktListGetByIdRequest<int>).IsSubclassOf(typeof(ATraktListRequest<int>)).Should().BeTrue();
        }

        [TestMethod]
        public void TestATraktListGetByIdRequestHasGenericTypeParameter()
        {
            typeof(ATraktListGetByIdRequest<>).ContainsGenericParameters.Should().BeTrue();
            typeof(ATraktListGetByIdRequest<int>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(1);
        }

        [TestMethod]
        public void TestATraktListGetByIdRequestImplementsITraktRequestInterface()
        {
            typeof(ATraktListGetByIdRequest<>).GetInterfaces().Should().Contain(typeof(ITraktRequest));
        }

        [TestMethod]
        public void TestATraktListGetByIdRequestImplementsITraktHasIdInterface()
        {
            typeof(ATraktListGetByIdRequest<>).GetInterfaces().Should().Contain(typeof(ITraktHasId));
        }
    }
}
