﻿namespace TraktApiSharp.Tests.Experimental.Requests.Shows
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TraktApiSharp.Experimental.Requests.Shows;
    using TraktApiSharp.Objects.Get.Shows.Common;

    [TestClass]
    public class TraktShowsTrendingRequestTests
    {
        [TestMethod, TestCategory("Requests"), TestCategory("Shows"), TestCategory("Lists")]
        public void TestTraktShowsTrendingRequestIsNotAbstract()
        {
            typeof(TraktShowsTrendingRequest).IsAbstract.Should().BeFalse();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Shows"), TestCategory("Lists")]
        public void TestTraktShowsTrendingRequestIsSealed()
        {
            typeof(TraktShowsTrendingRequest).IsSealed.Should().BeTrue();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Shows"), TestCategory("Lists")]
        public void TestTraktShowsTrendingRequestIsSubclassOfATraktShowsRequest()
        {
            typeof(TraktShowsTrendingRequest).IsSubclassOf(typeof(ATraktShowsRequest<TraktTrendingShow>)).Should().BeTrue();
        }
    }
}
