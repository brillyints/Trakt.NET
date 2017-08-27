﻿namespace TraktApiSharp.Objects.Get.Collections.JsonReader.Factories
{
    using Objects.JsonReader;

    internal class CollectionShowEpisodeJsonReaderFactory : IJsonReaderFactory<ITraktCollectionShowEpisode>
    {
        public IObjectJsonReader<ITraktCollectionShowEpisode> CreateObjectReader() => new TraktCollectionShowEpisodeObjectJsonReader();

        public IArrayJsonReader<ITraktCollectionShowEpisode> CreateArrayReader() => new CollectionShowEpisodeArrayJsonReader();
    }
}
