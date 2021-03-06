﻿namespace TraktNet.Objects.Post.Syncs.History.Json.Factories
{
    using Objects.Json;
    using Reader;
    using Writer;

    internal class SyncHistoryRemovePostJsonIOFactory : IJsonIOFactory<ITraktSyncHistoryRemovePost>
    {
        public IObjectJsonReader<ITraktSyncHistoryRemovePost> CreateObjectReader() => new SyncHistoryRemovePostObjectJsonReader();

        public IArrayJsonReader<ITraktSyncHistoryRemovePost> CreateArrayReader() => new SyncHistoryRemovePostArrayJsonReader();

        public IObjectJsonWriter<ITraktSyncHistoryRemovePost> CreateObjectWriter() => new SyncHistoryRemovePostObjectJsonWriter();
    }
}
