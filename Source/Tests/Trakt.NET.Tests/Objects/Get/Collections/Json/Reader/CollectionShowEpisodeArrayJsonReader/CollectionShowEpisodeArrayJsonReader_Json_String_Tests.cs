﻿namespace TraktNet.Tests.Objects.Get.Collections.Json.Reader
{
    using FluentAssertions;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Traits;
    using TraktNet.Enums;
    using TraktNet.Objects.Get.Collections.Json.Reader;
    using Xunit;

    [Category("Objects.Get.Collections.JsonReader")]
    public partial class CollectionShowEpisodeArrayJsonReader_Tests
    {
        [Fact]
        public async Task Test_CollectionShowEpisodeArrayJsonReader_ReadArray_From_Json_String_Empty_Array()
        {
            var jsonReader = new CollectionShowEpisodeArrayJsonReader();

            var traktCollectionShowEpisodes = await jsonReader.ReadArrayAsync(JSON_EMPTY_ARRAY);
            traktCollectionShowEpisodes.Should().NotBeNull().And.BeEmpty();
        }

        [Fact]
        public async Task Test_CollectionShowEpisodeArrayJsonReader_ReadArray_From_Json_String_Complete()
        {
            var jsonReader = new CollectionShowEpisodeArrayJsonReader();

            var traktCollectionShowEpisodes = await jsonReader.ReadArrayAsync(JSON_COMPLETE);
            traktCollectionShowEpisodes.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(3);

            var collectionShowEpisodes = traktCollectionShowEpisodes.ToArray();

            collectionShowEpisodes[0].Should().NotBeNull();
            collectionShowEpisodes[0].Number.Should().Be(1);
            collectionShowEpisodes[0].CollectedAt.Should().Be(DateTime.Parse("2014-07-14T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[0].Metadata.Should().NotBeNull();
            collectionShowEpisodes[0].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[0].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[0].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[0].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[0].Metadata.ThreeDimensional.Should().BeTrue();

            collectionShowEpisodes[1].Should().NotBeNull();
            collectionShowEpisodes[1].Number.Should().Be(2);
            collectionShowEpisodes[1].CollectedAt.Should().Be(DateTime.Parse("2014-07-15T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[1].Metadata.Should().NotBeNull();
            collectionShowEpisodes[1].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[1].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[1].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[1].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[1].Metadata.ThreeDimensional.Should().BeFalse();

            collectionShowEpisodes[2].Should().NotBeNull();
            collectionShowEpisodes[2].Number.Should().Be(3);
            collectionShowEpisodes[2].CollectedAt.Should().Be(DateTime.Parse("2014-07-16T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[2].Metadata.Should().NotBeNull();
            collectionShowEpisodes[2].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[2].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[2].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[2].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[2].Metadata.ThreeDimensional.Should().BeTrue();
        }

        [Fact]
        public async Task Test_CollectionShowEpisodeArrayJsonReader_ReadArray_From_Json_String_Incomplete_1()
        {
            var jsonReader = new CollectionShowEpisodeArrayJsonReader();

            var traktCollectionShowEpisodes = await jsonReader.ReadArrayAsync(JSON_INCOMPLETE_1);
            traktCollectionShowEpisodes.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(3);

            var collectionShowEpisodes = traktCollectionShowEpisodes.ToArray();

            collectionShowEpisodes[0].Should().NotBeNull();
            collectionShowEpisodes[0].Number.Should().BeNull();
            collectionShowEpisodes[0].CollectedAt.Should().Be(DateTime.Parse("2014-07-14T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[0].Metadata.Should().NotBeNull();
            collectionShowEpisodes[0].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[0].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[0].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[0].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[0].Metadata.ThreeDimensional.Should().BeTrue();

            collectionShowEpisodes[1].Should().NotBeNull();
            collectionShowEpisodes[1].Number.Should().Be(2);
            collectionShowEpisodes[1].CollectedAt.Should().Be(DateTime.Parse("2014-07-15T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[1].Metadata.Should().NotBeNull();
            collectionShowEpisodes[1].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[1].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[1].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[1].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[1].Metadata.ThreeDimensional.Should().BeFalse();

            collectionShowEpisodes[2].Should().NotBeNull();
            collectionShowEpisodes[2].Number.Should().Be(3);
            collectionShowEpisodes[2].CollectedAt.Should().Be(DateTime.Parse("2014-07-16T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[2].Metadata.Should().NotBeNull();
            collectionShowEpisodes[2].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[2].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[2].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[2].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[2].Metadata.ThreeDimensional.Should().BeTrue();
        }

        [Fact]
        public async Task Test_CollectionShowEpisodeArrayJsonReader_ReadArray_From_Json_String_Incomplete_2()
        {
            var jsonReader = new CollectionShowEpisodeArrayJsonReader();

            var traktCollectionShowEpisodes = await jsonReader.ReadArrayAsync(JSON_INCOMPLETE_2);
            traktCollectionShowEpisodes.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(3);

            var collectionShowEpisodes = traktCollectionShowEpisodes.ToArray();

            collectionShowEpisodes[0].Should().NotBeNull();
            collectionShowEpisodes[0].Number.Should().Be(1);
            collectionShowEpisodes[0].CollectedAt.Should().Be(DateTime.Parse("2014-07-14T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[0].Metadata.Should().NotBeNull();
            collectionShowEpisodes[0].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[0].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[0].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[0].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[0].Metadata.ThreeDimensional.Should().BeTrue();

            collectionShowEpisodes[1].Should().NotBeNull();
            collectionShowEpisodes[1].Number.Should().Be(2);
            collectionShowEpisodes[1].CollectedAt.Should().BeNull();
            collectionShowEpisodes[1].Metadata.Should().NotBeNull();
            collectionShowEpisodes[1].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[1].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[1].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[1].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[1].Metadata.ThreeDimensional.Should().BeFalse();

            collectionShowEpisodes[2].Should().NotBeNull();
            collectionShowEpisodes[2].Number.Should().Be(3);
            collectionShowEpisodes[2].CollectedAt.Should().Be(DateTime.Parse("2014-07-16T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[2].Metadata.Should().NotBeNull();
            collectionShowEpisodes[2].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[2].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[2].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[2].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[2].Metadata.ThreeDimensional.Should().BeTrue();
        }

        [Fact]
        public async Task Test_CollectionShowEpisodeArrayJsonReader_ReadArray_From_Json_String_Incomplete_3()
        {
            var jsonReader = new CollectionShowEpisodeArrayJsonReader();

            var traktCollectionShowEpisodes = await jsonReader.ReadArrayAsync(JSON_INCOMPLETE_3);
            traktCollectionShowEpisodes.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(3);

            var collectionShowEpisodes = traktCollectionShowEpisodes.ToArray();

            collectionShowEpisodes[0].Should().NotBeNull();
            collectionShowEpisodes[0].Number.Should().Be(1);
            collectionShowEpisodes[0].CollectedAt.Should().Be(DateTime.Parse("2014-07-14T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[0].Metadata.Should().NotBeNull();
            collectionShowEpisodes[0].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[0].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[0].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[0].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[0].Metadata.ThreeDimensional.Should().BeTrue();

            collectionShowEpisodes[1].Should().NotBeNull();
            collectionShowEpisodes[1].Number.Should().Be(2);
            collectionShowEpisodes[1].CollectedAt.Should().Be(DateTime.Parse("2014-07-15T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[1].Metadata.Should().NotBeNull();
            collectionShowEpisodes[1].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[1].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[1].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[1].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[1].Metadata.ThreeDimensional.Should().BeFalse();

            collectionShowEpisodes[2].Should().NotBeNull();
            collectionShowEpisodes[2].Number.Should().Be(3);
            collectionShowEpisodes[2].CollectedAt.Should().Be(DateTime.Parse("2014-07-16T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[2].Metadata.Should().BeNull();
        }

        [Fact]
        public async Task Test_CollectionShowEpisodeArrayJsonReader_ReadArray_From_Json_String_Incomplete_4()
        {
            var jsonReader = new CollectionShowEpisodeArrayJsonReader();

            var traktCollectionShowEpisodes = await jsonReader.ReadArrayAsync(JSON_INCOMPLETE_4);
            traktCollectionShowEpisodes.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(3);

            var collectionShowEpisodes = traktCollectionShowEpisodes.ToArray();

            collectionShowEpisodes[0].Should().NotBeNull();
            collectionShowEpisodes[0].Number.Should().Be(1);
            collectionShowEpisodes[0].CollectedAt.Should().BeNull();
            collectionShowEpisodes[0].Metadata.Should().BeNull();

            collectionShowEpisodes[1].Should().NotBeNull();
            collectionShowEpisodes[1].Number.Should().Be(2);
            collectionShowEpisodes[1].CollectedAt.Should().Be(DateTime.Parse("2014-07-15T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[1].Metadata.Should().NotBeNull();
            collectionShowEpisodes[1].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[1].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[1].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[1].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[1].Metadata.ThreeDimensional.Should().BeFalse();

            collectionShowEpisodes[2].Should().NotBeNull();
            collectionShowEpisodes[2].Number.Should().Be(3);
            collectionShowEpisodes[2].CollectedAt.Should().Be(DateTime.Parse("2014-07-16T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[2].Metadata.Should().NotBeNull();
            collectionShowEpisodes[2].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[2].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[2].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[2].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[2].Metadata.ThreeDimensional.Should().BeTrue();
        }

        [Fact]
        public async Task Test_CollectionShowEpisodeArrayJsonReader_ReadArray_From_Json_String_Incomplete_5()
        {
            var jsonReader = new CollectionShowEpisodeArrayJsonReader();

            var traktCollectionShowEpisodes = await jsonReader.ReadArrayAsync(JSON_INCOMPLETE_5);
            traktCollectionShowEpisodes.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(3);

            var collectionShowEpisodes = traktCollectionShowEpisodes.ToArray();

            collectionShowEpisodes[0].Should().NotBeNull();
            collectionShowEpisodes[0].Number.Should().Be(1);
            collectionShowEpisodes[0].CollectedAt.Should().Be(DateTime.Parse("2014-07-14T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[0].Metadata.Should().NotBeNull();
            collectionShowEpisodes[0].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[0].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[0].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[0].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[0].Metadata.ThreeDimensional.Should().BeTrue();

            collectionShowEpisodes[1].Should().NotBeNull();
            collectionShowEpisodes[1].Number.Should().BeNull();
            collectionShowEpisodes[1].CollectedAt.Should().Be(DateTime.Parse("2014-07-15T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[1].Metadata.Should().BeNull();

            collectionShowEpisodes[2].Should().NotBeNull();
            collectionShowEpisodes[2].Number.Should().Be(3);
            collectionShowEpisodes[2].CollectedAt.Should().Be(DateTime.Parse("2014-07-16T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[2].Metadata.Should().NotBeNull();
            collectionShowEpisodes[2].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[2].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[2].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[2].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[2].Metadata.ThreeDimensional.Should().BeTrue();
        }

        [Fact]
        public async Task Test_CollectionShowEpisodeArrayJsonReader_ReadArray_From_Json_String_Incomplete_6()
        {
            var jsonReader = new CollectionShowEpisodeArrayJsonReader();

            var traktCollectionShowEpisodes = await jsonReader.ReadArrayAsync(JSON_INCOMPLETE_6);
            traktCollectionShowEpisodes.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(3);

            var collectionShowEpisodes = traktCollectionShowEpisodes.ToArray();

            collectionShowEpisodes[0].Should().NotBeNull();
            collectionShowEpisodes[0].Number.Should().Be(1);
            collectionShowEpisodes[0].CollectedAt.Should().Be(DateTime.Parse("2014-07-14T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[0].Metadata.Should().NotBeNull();
            collectionShowEpisodes[0].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[0].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[0].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[0].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[0].Metadata.ThreeDimensional.Should().BeTrue();

            collectionShowEpisodes[1].Should().NotBeNull();
            collectionShowEpisodes[1].Number.Should().Be(2);
            collectionShowEpisodes[1].CollectedAt.Should().Be(DateTime.Parse("2014-07-15T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[1].Metadata.Should().NotBeNull();
            collectionShowEpisodes[1].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[1].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[1].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[1].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[1].Metadata.ThreeDimensional.Should().BeFalse();

            collectionShowEpisodes[2].Should().NotBeNull();
            collectionShowEpisodes[2].Number.Should().BeNull();
            collectionShowEpisodes[2].CollectedAt.Should().BeNull();
            collectionShowEpisodes[2].Metadata.Should().NotBeNull();
            collectionShowEpisodes[2].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[2].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[2].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[2].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[2].Metadata.ThreeDimensional.Should().BeTrue();
        }

        [Fact]
        public async Task Test_CollectionShowEpisodeArrayJsonReader_ReadArray_From_Json_String_Not_Valid_1()
        {
            var jsonReader = new CollectionShowEpisodeArrayJsonReader();

            var traktCollectionShowEpisodes = await jsonReader.ReadArrayAsync(JSON_NOT_VALID_1);
            traktCollectionShowEpisodes.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(3);

            var collectionShowEpisodes = traktCollectionShowEpisodes.ToArray();

            collectionShowEpisodes[0].Should().NotBeNull();
            collectionShowEpisodes[0].Number.Should().BeNull();
            collectionShowEpisodes[0].CollectedAt.Should().Be(DateTime.Parse("2014-07-14T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[0].Metadata.Should().NotBeNull();
            collectionShowEpisodes[0].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[0].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[0].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[0].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[0].Metadata.ThreeDimensional.Should().BeTrue();

            collectionShowEpisodes[1].Should().NotBeNull();
            collectionShowEpisodes[1].Number.Should().Be(2);
            collectionShowEpisodes[1].CollectedAt.Should().Be(DateTime.Parse("2014-07-15T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[1].Metadata.Should().NotBeNull();
            collectionShowEpisodes[1].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[1].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[1].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[1].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[1].Metadata.ThreeDimensional.Should().BeFalse();

            collectionShowEpisodes[2].Should().NotBeNull();
            collectionShowEpisodes[2].Number.Should().Be(3);
            collectionShowEpisodes[2].CollectedAt.Should().Be(DateTime.Parse("2014-07-16T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[2].Metadata.Should().NotBeNull();
            collectionShowEpisodes[2].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[2].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[2].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[2].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[2].Metadata.ThreeDimensional.Should().BeTrue();
        }

        [Fact]
        public async Task Test_CollectionShowEpisodeArrayJsonReader_ReadArray_From_Json_String_Not_Valid_2()
        {
            var jsonReader = new CollectionShowEpisodeArrayJsonReader();

            var traktCollectionShowEpisodes = await jsonReader.ReadArrayAsync(JSON_NOT_VALID_2);
            traktCollectionShowEpisodes.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(3);

            var collectionShowEpisodes = traktCollectionShowEpisodes.ToArray();

            collectionShowEpisodes[0].Should().NotBeNull();
            collectionShowEpisodes[0].Number.Should().Be(1);
            collectionShowEpisodes[0].CollectedAt.Should().Be(DateTime.Parse("2014-07-14T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[0].Metadata.Should().NotBeNull();
            collectionShowEpisodes[0].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[0].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[0].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[0].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[0].Metadata.ThreeDimensional.Should().BeTrue();

            collectionShowEpisodes[1].Should().NotBeNull();
            collectionShowEpisodes[1].Number.Should().Be(2);
            collectionShowEpisodes[1].CollectedAt.Should().BeNull();
            collectionShowEpisodes[1].Metadata.Should().NotBeNull();
            collectionShowEpisodes[1].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[1].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[1].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[1].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[1].Metadata.ThreeDimensional.Should().BeFalse();

            collectionShowEpisodes[2].Should().NotBeNull();
            collectionShowEpisodes[2].Number.Should().Be(3);
            collectionShowEpisodes[2].CollectedAt.Should().Be(DateTime.Parse("2014-07-16T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[2].Metadata.Should().NotBeNull();
            collectionShowEpisodes[2].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[2].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[2].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[2].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[2].Metadata.ThreeDimensional.Should().BeTrue();
        }

        [Fact]
        public async Task Test_CollectionShowEpisodeArrayJsonReader_ReadArray_From_Json_String_Not_Valid_3()
        {
            var jsonReader = new CollectionShowEpisodeArrayJsonReader();

            var traktCollectionShowEpisodes = await jsonReader.ReadArrayAsync(JSON_NOT_VALID_3);
            traktCollectionShowEpisodes.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(3);

            var collectionShowEpisodes = traktCollectionShowEpisodes.ToArray();

            collectionShowEpisodes[0].Should().NotBeNull();
            collectionShowEpisodes[0].Number.Should().Be(1);
            collectionShowEpisodes[0].CollectedAt.Should().Be(DateTime.Parse("2014-07-14T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[0].Metadata.Should().NotBeNull();
            collectionShowEpisodes[0].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[0].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[0].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[0].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[0].Metadata.ThreeDimensional.Should().BeTrue();

            collectionShowEpisodes[1].Should().NotBeNull();
            collectionShowEpisodes[1].Number.Should().Be(2);
            collectionShowEpisodes[1].CollectedAt.Should().Be(DateTime.Parse("2014-07-15T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[1].Metadata.Should().NotBeNull();
            collectionShowEpisodes[1].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[1].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[1].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[1].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[1].Metadata.ThreeDimensional.Should().BeFalse();

            collectionShowEpisodes[2].Should().NotBeNull();
            collectionShowEpisodes[2].Number.Should().Be(3);
            collectionShowEpisodes[2].CollectedAt.Should().Be(DateTime.Parse("2014-07-16T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[2].Metadata.Should().BeNull();
        }

        [Fact]
        public async Task Test_CollectionShowEpisodeArrayJsonReader_ReadArray_From_Json_String_Not_Valid_4()
        {
            var jsonReader = new CollectionShowEpisodeArrayJsonReader();

            var traktCollectionShowEpisodes = await jsonReader.ReadArrayAsync(JSON_NOT_VALID_4);
            traktCollectionShowEpisodes.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(3);

            var collectionShowEpisodes = traktCollectionShowEpisodes.ToArray();

            collectionShowEpisodes[0].Should().NotBeNull();
            collectionShowEpisodes[0].Number.Should().BeNull();
            collectionShowEpisodes[0].CollectedAt.Should().Be(DateTime.Parse("2014-07-14T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[0].Metadata.Should().NotBeNull();
            collectionShowEpisodes[0].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[0].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[0].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[0].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[0].Metadata.ThreeDimensional.Should().BeTrue();

            collectionShowEpisodes[1].Should().NotBeNull();
            collectionShowEpisodes[1].Number.Should().Be(2);
            collectionShowEpisodes[1].CollectedAt.Should().BeNull();
            collectionShowEpisodes[1].Metadata.Should().NotBeNull();
            collectionShowEpisodes[1].Metadata.MediaType.Should().Be(TraktMediaType.Digital);
            collectionShowEpisodes[1].Metadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            collectionShowEpisodes[1].Metadata.Audio.Should().Be(TraktMediaAudio.AAC);
            collectionShowEpisodes[1].Metadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            collectionShowEpisodes[1].Metadata.ThreeDimensional.Should().BeFalse();

            collectionShowEpisodes[2].Should().NotBeNull();
            collectionShowEpisodes[2].Number.Should().Be(3);
            collectionShowEpisodes[2].CollectedAt.Should().Be(DateTime.Parse("2014-07-16T01:00:00.000Z").ToUniversalTime());
            collectionShowEpisodes[2].Metadata.Should().BeNull();
        }

        [Fact]
        public async Task Test_CollectionShowEpisodeArrayJsonReader_ReadArray_From_Json_String_Null()
        {
            var jsonReader = new CollectionShowEpisodeArrayJsonReader();

            var traktEpisodeCollectionProgress = await jsonReader.ReadArrayAsync(default(string));
            traktEpisodeCollectionProgress.Should().BeNull();
        }

        [Fact]
        public async Task Test_CollectionShowEpisodeArrayJsonReader_ReadArray_From_Json_String_Empty()
        {
            var jsonReader = new CollectionShowEpisodeArrayJsonReader();

            var traktEpisodeCollectionProgress = await jsonReader.ReadArrayAsync(string.Empty);
            traktEpisodeCollectionProgress.Should().BeNull();
        }
    }
}
