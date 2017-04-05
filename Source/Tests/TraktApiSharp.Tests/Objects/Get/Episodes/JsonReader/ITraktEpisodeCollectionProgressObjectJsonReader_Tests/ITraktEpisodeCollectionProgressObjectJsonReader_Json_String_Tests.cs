﻿namespace TraktApiSharp.Tests.Objects.Get.Episodes.JsonReader
{
    using FluentAssertions;
    using System;
    using System.Threading.Tasks;
    using Traits;
    using TraktApiSharp.Objects.Get.Episodes.JsonReader;
    using Xunit;

    [Category("Objects.Get.Episodes.JsonReader")]
    public partial class ITraktEpisodeCollectionProgressObjectJsonReader_Tests
    {
        [Fact]
        public async Task Test_ITraktEpisodeCollectionProgressObjectJsonReader_ReadObject_From_Json_String_Complete()
        {
            var jsonReader = new ITraktEpisodeCollectionProgressObjectJsonReader();

            var traktEpisodeCollectionProgress = await jsonReader.ReadObjectAsync(JSON_COMPLETE);

            traktEpisodeCollectionProgress.Should().NotBeNull();
            traktEpisodeCollectionProgress.Number.Should().Be(2);
            traktEpisodeCollectionProgress.Completed.Should().BeTrue();
            traktEpisodeCollectionProgress.CollectedAt.Should().Be(DateTime.Parse("2011-04-18T01:00:00.000Z").ToUniversalTime());
        }

        [Fact]
        public async Task Test_ITraktEpisodeCollectionProgressObjectJsonReader_ReadObject_From_Json_String_Incomplete_1()
        {
            var jsonReader = new ITraktEpisodeCollectionProgressObjectJsonReader();

            var traktEpisodeCollectionProgress = await jsonReader.ReadObjectAsync(JSON_INCOMPLETE_1);

            traktEpisodeCollectionProgress.Should().NotBeNull();
            traktEpisodeCollectionProgress.Number.Should().BeNull();
            traktEpisodeCollectionProgress.Completed.Should().BeTrue();
            traktEpisodeCollectionProgress.CollectedAt.Should().Be(DateTime.Parse("2011-04-18T01:00:00.000Z").ToUniversalTime());
        }

        [Fact]
        public async Task Test_ITraktEpisodeCollectionProgressObjectJsonReader_ReadObject_From_Json_String_Incomplete_2()
        {
            var jsonReader = new ITraktEpisodeCollectionProgressObjectJsonReader();

            var traktEpisodeCollectionProgress = await jsonReader.ReadObjectAsync(JSON_INCOMPLETE_2);

            traktEpisodeCollectionProgress.Should().NotBeNull();
            traktEpisodeCollectionProgress.Number.Should().Be(2);
            traktEpisodeCollectionProgress.Completed.Should().BeNull();
            traktEpisodeCollectionProgress.CollectedAt.Should().Be(DateTime.Parse("2011-04-18T01:00:00.000Z").ToUniversalTime());
        }

        [Fact]
        public async Task Test_ITraktEpisodeCollectionProgressObjectJsonReader_ReadObject_From_Json_String_Incomplete_3()
        {
            var jsonReader = new ITraktEpisodeCollectionProgressObjectJsonReader();

            var traktEpisodeCollectionProgress = await jsonReader.ReadObjectAsync(JSON_INCOMPLETE_3);

            traktEpisodeCollectionProgress.Should().NotBeNull();
            traktEpisodeCollectionProgress.Number.Should().Be(2);
            traktEpisodeCollectionProgress.Completed.Should().BeTrue();
            traktEpisodeCollectionProgress.CollectedAt.Should().BeNull();
        }

        [Fact]
        public async Task Test_ITraktEpisodeCollectionProgressObjectJsonReader_ReadObject_From_Json_String_Incomplete_4()
        {
            var jsonReader = new ITraktEpisodeCollectionProgressObjectJsonReader();

            var traktEpisodeCollectionProgress = await jsonReader.ReadObjectAsync(JSON_INCOMPLETE_4);

            traktEpisodeCollectionProgress.Should().NotBeNull();
            traktEpisodeCollectionProgress.Number.Should().Be(2);
            traktEpisodeCollectionProgress.Completed.Should().BeNull();
            traktEpisodeCollectionProgress.CollectedAt.Should().BeNull();
        }

        [Fact]
        public async Task Test_ITraktEpisodeCollectionProgressObjectJsonReader_ReadObject_From_Json_String_Incomplete_5()
        {
            var jsonReader = new ITraktEpisodeCollectionProgressObjectJsonReader();

            var traktEpisodeCollectionProgress = await jsonReader.ReadObjectAsync(JSON_INCOMPLETE_5);

            traktEpisodeCollectionProgress.Should().NotBeNull();
            traktEpisodeCollectionProgress.Number.Should().BeNull();
            traktEpisodeCollectionProgress.Completed.Should().BeTrue();
            traktEpisodeCollectionProgress.CollectedAt.Should().BeNull();
        }

        [Fact]
        public async Task Test_ITraktEpisodeCollectionProgressObjectJsonReader_ReadObject_From_Json_String_Incomplete_6()
        {
            var jsonReader = new ITraktEpisodeCollectionProgressObjectJsonReader();

            var traktEpisodeCollectionProgress = await jsonReader.ReadObjectAsync(JSON_INCOMPLETE_6);

            traktEpisodeCollectionProgress.Should().NotBeNull();
            traktEpisodeCollectionProgress.Number.Should().BeNull();
            traktEpisodeCollectionProgress.Completed.Should().BeNull();
            traktEpisodeCollectionProgress.CollectedAt.Should().Be(DateTime.Parse("2011-04-18T01:00:00.000Z").ToUniversalTime());
        }

        [Fact]
        public async Task Test_ITraktEpisodeCollectionProgressObjectJsonReader_ReadObject_From_Json_String_Not_Valid_1()
        {
            var jsonReader = new ITraktEpisodeCollectionProgressObjectJsonReader();

            var traktEpisodeCollectionProgress = await jsonReader.ReadObjectAsync(JSON_NOT_VALID_1);

            traktEpisodeCollectionProgress.Should().NotBeNull();
            traktEpisodeCollectionProgress.Number.Should().BeNull();
            traktEpisodeCollectionProgress.Completed.Should().BeTrue();
            traktEpisodeCollectionProgress.CollectedAt.Should().Be(DateTime.Parse("2011-04-18T01:00:00.000Z").ToUniversalTime());
        }

        [Fact]
        public async Task Test_ITraktEpisodeCollectionProgressObjectJsonReader_ReadObject_From_Json_String_Not_Valid_2()
        {
            var jsonReader = new ITraktEpisodeCollectionProgressObjectJsonReader();

            var traktEpisodeCollectionProgress = await jsonReader.ReadObjectAsync(JSON_NOT_VALID_2);

            traktEpisodeCollectionProgress.Should().NotBeNull();
            traktEpisodeCollectionProgress.Number.Should().Be(2);
            traktEpisodeCollectionProgress.Completed.Should().BeNull();
            traktEpisodeCollectionProgress.CollectedAt.Should().Be(DateTime.Parse("2011-04-18T01:00:00.000Z").ToUniversalTime());
        }

        [Fact]
        public async Task Test_ITraktEpisodeCollectionProgressObjectJsonReader_ReadObject_From_Json_String_Not_Valid_3()
        {
            var jsonReader = new ITraktEpisodeCollectionProgressObjectJsonReader();

            var traktEpisodeCollectionProgress = await jsonReader.ReadObjectAsync(JSON_NOT_VALID_3);

            traktEpisodeCollectionProgress.Should().NotBeNull();
            traktEpisodeCollectionProgress.Number.Should().Be(2);
            traktEpisodeCollectionProgress.Completed.Should().BeTrue();
            traktEpisodeCollectionProgress.CollectedAt.Should().BeNull();
        }

        [Fact]
        public async Task Test_ITraktEpisodeCollectionProgressObjectJsonReader_ReadObject_From_Json_String_Not_Valid_4()
        {
            var jsonReader = new ITraktEpisodeCollectionProgressObjectJsonReader();

            var traktEpisodeCollectionProgress = await jsonReader.ReadObjectAsync(JSON_NOT_VALID_4);

            traktEpisodeCollectionProgress.Should().NotBeNull();
            traktEpisodeCollectionProgress.Number.Should().BeNull();
            traktEpisodeCollectionProgress.Completed.Should().BeNull();
            traktEpisodeCollectionProgress.CollectedAt.Should().BeNull();
        }

        [Fact]
        public async Task Test_ITraktEpisodeCollectionProgressObjectJsonReader_ReadObject_From_Json_String_Null()
        {
            var jsonReader = new ITraktEpisodeCollectionProgressObjectJsonReader();

            var traktEpisodeCollectionProgress = await jsonReader.ReadObjectAsync(default(string));
            traktEpisodeCollectionProgress.Should().BeNull();
        }

        [Fact]
        public async Task Test_ITraktEpisodeCollectionProgressObjectJsonReader_ReadObject_From_Json_String_Empty()
        {
            var jsonReader = new ITraktEpisodeCollectionProgressObjectJsonReader();

            var traktEpisodeCollectionProgress = await jsonReader.ReadObjectAsync(string.Empty);
            traktEpisodeCollectionProgress.Should().BeNull();
        }
    }
}
