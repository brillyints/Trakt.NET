﻿namespace TraktNet.Objects.Get.Movies.Json.Reader
{
    using Newtonsoft.Json;
    using Objects.Json;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    internal class MovieIdsArrayJsonReader : AArrayJsonReader<ITraktMovieIds>
    {
        public override async Task<IEnumerable<ITraktMovieIds>> ReadArrayAsync(JsonTextReader jsonReader, CancellationToken cancellationToken = default)
        {
            if (jsonReader == null)
                return await Task.FromResult(default(IEnumerable<ITraktMovieIds>));

            if (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.StartArray)
            {
                var movieIdsReader = new MovieIdsObjectJsonReader();
                var movieIdss = new List<ITraktMovieIds>();
                ITraktMovieIds movieIds = await movieIdsReader.ReadObjectAsync(jsonReader, cancellationToken);

                while (movieIds != null)
                {
                    movieIdss.Add(movieIds);
                    movieIds = await movieIdsReader.ReadObjectAsync(jsonReader, cancellationToken);
                }

                return movieIdss;
            }

            return await Task.FromResult(default(IEnumerable<ITraktMovieIds>));
        }
    }
}
