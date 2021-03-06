﻿namespace TraktNet.Objects.Post.Syncs.Watchlist.Json.Factories
{
    using Objects.Json;
    using Reader;
    using Writer;

    internal class SyncWatchlistPostEpisodeJsonIOFactory : IJsonIOFactory<ITraktSyncWatchlistPostEpisode>
    {
        public IObjectJsonReader<ITraktSyncWatchlistPostEpisode> CreateObjectReader() => new SyncWatchlistPostEpisodeObjectJsonReader();

        public IArrayJsonReader<ITraktSyncWatchlistPostEpisode> CreateArrayReader() => new SyncWatchlistPostEpisodeArrayJsonReader();

        public IObjectJsonWriter<ITraktSyncWatchlistPostEpisode> CreateObjectWriter() => new SyncWatchlistPostEpisodeObjectJsonWriter();
    }
}
