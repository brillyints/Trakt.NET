﻿namespace TraktNet.Objects.Post.Checkins.Responses.Json.Factories
{
    using Objects.Json;
    using Reader;
    using Writer;

    internal class EpisodeCheckinPostResponseJsonIOFactory : IJsonIOFactory<ITraktEpisodeCheckinPostResponse>
    {
        public IObjectJsonReader<ITraktEpisodeCheckinPostResponse> CreateObjectReader() => new EpisodeCheckinPostResponseObjectJsonReader();

        public IArrayJsonReader<ITraktEpisodeCheckinPostResponse> CreateArrayReader() => new EpisodeCheckinPostResponseArrayJsonReader();

        public IObjectJsonWriter<ITraktEpisodeCheckinPostResponse> CreateObjectWriter() => new EpisodeCheckinPostResponseObjectJsonWriter();
    }
}
