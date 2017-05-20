﻿namespace TraktApiSharp.Tests.Objects.Get.People.Credits.JsonReader
{
    using FluentAssertions;
    using Traits;
    using TraktApiSharp.Objects.Get.People.Credits;
    using TraktApiSharp.Objects.Get.People.Credits.JsonReader;
    using TraktApiSharp.Objects.JsonReader;
    using Xunit;

    [Category("Objects.Get.People.Credits.JsonReader")]
    public partial class TraktPersonShowCreditsCastItemObjectJsonReader_Tests
    {
        [Fact]
        public void Test_TraktPersonShowCreditsCastItemObjectJsonReader_Implements_ITraktObjectJsonReader_Interface()
        {
            typeof(TraktPersonShowCreditsCastItemObjectJsonReader).GetInterfaces().Should().Contain(typeof(ITraktObjectJsonReader<ITraktPersonShowCreditsCastItem>));
        }
    }
}
