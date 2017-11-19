﻿namespace TraktApiSharp.Objects.Post.Responses.Json
{
    using Get.Movies.Json;
    using Implementations;
    using Newtonsoft.Json;
    using Objects.Json;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    internal class PostResponseNotFoundMovieObjectJsonReader : IObjectJsonReader<ITraktPostResponseNotFoundMovie>
    {
        public Task<ITraktPostResponseNotFoundMovie> ReadObjectAsync(string json, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrEmpty(json))
                return Task.FromResult(default(ITraktPostResponseNotFoundMovie));

            using (var reader = new StringReader(json))
            using (var jsonReader = new JsonTextReader(reader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public Task<ITraktPostResponseNotFoundMovie> ReadObjectAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (stream == null)
                return Task.FromResult(default(ITraktPostResponseNotFoundMovie));

            using (var streamReader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public async Task<ITraktPostResponseNotFoundMovie> ReadObjectAsync(JsonTextReader jsonReader, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (jsonReader == null)
                return await Task.FromResult(default(ITraktPostResponseNotFoundMovie));

            if (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.StartObject)
            {
                var movieIdsReader = new MovieIdsObjectJsonReader();
                ITraktPostResponseNotFoundMovie postResponseNotFoundMovie = new TraktPostResponseNotFoundMovie();

                while (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.PropertyName)
                {
                    var propertyName = jsonReader.Value.ToString();

                    switch (propertyName)
                    {
                        case JsonProperties.POST_RESPONSE_NOT_FOUND_MOVIE_PROPERTY_NAME_IDS:
                            postResponseNotFoundMovie.Ids = await movieIdsReader.ReadObjectAsync(jsonReader, cancellationToken);
                            break;
                        default:
                            await JsonReaderHelper.ReadAndIgnoreInvalidContentAsync(jsonReader, cancellationToken);
                            break;
                    }
                }

                return postResponseNotFoundMovie;
            }

            return await Task.FromResult(default(ITraktPostResponseNotFoundMovie));
        }
    }
}
