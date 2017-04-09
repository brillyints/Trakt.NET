﻿namespace TraktApiSharp.Tests.Objects.Basic.JsonReader
{
    using FluentAssertions;
    using Newtonsoft.Json;
    using System.IO;
    using System.Threading.Tasks;
    using Traits;
    using TraktApiSharp.Objects.Basic.JsonReader;
    using Xunit;

    [Category("Objects.Basic.JsonReader")]
    public partial class ITraktImageObjectJsonReader_Tests
    {
        [Fact]
        public async Task Test_ITraktImageObjectJsonReader_ReadObject_From_JsonReader_Complete()
        {
            var traktJsonReader = new ITraktImageObjectJsonReader();

            using (var reader = new StringReader(JSON_COMPLETE))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktImage = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktImage.Should().NotBeNull();
                traktImage.Full.Should().Be("https://walter.trakt.us/images/shows/000/060/300/logos/original/ab151d1043.png");
            }
        }

        [Fact]
        public async Task Test_ITraktImageObjectJsonReader_ReadObject_From_JsonReader_Not_Valid()
        {
            var traktJsonReader = new ITraktImageObjectJsonReader();

            using (var reader = new StringReader(JSON_NOT_VALID))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktImage = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktImage.Should().NotBeNull();
                traktImage.Full.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_ITraktImageObjectJsonReader_ReadObject_From_JsonReader_Null()
        {
            var traktJsonReader = new ITraktImageObjectJsonReader();

            var traktImage = await traktJsonReader.ReadObjectAsync(default(JsonTextReader));
            traktImage.Should().BeNull();
        }

        [Fact]
        public async Task Test_ITraktImageObjectJsonReader_ReadObject_From_JsonReader_Empty()
        {
            var traktJsonReader = new ITraktImageObjectJsonReader();

            using (var reader = new StringReader(string.Empty))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktImage = await traktJsonReader.ReadObjectAsync(jsonReader);
                traktImage.Should().BeNull();
            }
        }
    }
}
