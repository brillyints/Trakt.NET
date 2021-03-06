﻿namespace TraktNet.Objects.Post.Syncs.Ratings.Json.Factories
{
    using Objects.Json;
    using Reader;
    using Writer;

    internal class SyncRatingsPostJsonIOFactory : IJsonIOFactory<ITraktSyncRatingsPost>
    {
        public IObjectJsonReader<ITraktSyncRatingsPost> CreateObjectReader() => new SyncRatingsPostObjectJsonReader();

        public IArrayJsonReader<ITraktSyncRatingsPost> CreateArrayReader() => new SyncRatingsPostArrayJsonReader();

        public IObjectJsonWriter<ITraktSyncRatingsPost> CreateObjectWriter() => new SyncRatingsPostObjectJsonWriter();
    }
}
