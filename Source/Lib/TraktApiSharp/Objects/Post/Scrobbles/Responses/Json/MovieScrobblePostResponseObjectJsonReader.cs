﻿namespace TraktApiSharp.Objects.Post.Scrobbles.Responses.Json
{
    using Basic.Json;
    using Enums;
    using Get.Movies.Json;
    using Implementations;
    using Newtonsoft.Json;
    using Objects.Json;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    internal class MovieScrobblePostResponseObjectJsonReader : IObjectJsonReader<ITraktMovieScrobblePostResponse>
    {
        public Task<ITraktMovieScrobblePostResponse> ReadObjectAsync(string json, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrEmpty(json))
                return Task.FromResult(default(ITraktMovieScrobblePostResponse));

            using (var reader = new StringReader(json))
            using (var jsonReader = new JsonTextReader(reader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public Task<ITraktMovieScrobblePostResponse> ReadObjectAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (stream == null)
                return Task.FromResult(default(ITraktMovieScrobblePostResponse));

            using (var streamReader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public async Task<ITraktMovieScrobblePostResponse> ReadObjectAsync(JsonTextReader jsonReader, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (jsonReader == null)
                return await Task.FromResult(default(ITraktMovieScrobblePostResponse));

            if (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.StartObject)
            {
                var sharingReader = new SharingObjectJsonReader();
                var movieReader = new MovieObjectJsonReader();
                ITraktMovieScrobblePostResponse movieScrobbleResponse = new TraktMovieScrobblePostResponse();

                while (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.PropertyName)
                {
                    var propertyName = jsonReader.Value.ToString();

                    switch (propertyName)
                    {
                        case JsonProperties.MOVIE_SCROBBLE_POST_RESPONSE_PROPERTY_NAME_ID:
                            {
                                var value = await JsonReaderHelper.ReadUnsignedLongIntegerAsync(jsonReader, cancellationToken);

                                if (value.First)
                                    movieScrobbleResponse.Id = value.Second;

                                break;
                            }
                        case JsonProperties.MOVIE_SCROBBLE_POST_RESPONSE_PROPERTY_NAME_ACTION:
                            movieScrobbleResponse.Action = await JsonReaderHelper.ReadEnumerationValueAsync<TraktScrobbleActionType>(jsonReader, cancellationToken);
                            break;
                        case JsonProperties.MOVIE_SCROBBLE_POST_RESPONSE_PROPERTY_NAME_PROGRESS:
                            {
                                var value = await JsonReaderHelper.ReadFloatValueAsync(jsonReader, cancellationToken);

                                if (value.First)
                                    movieScrobbleResponse.Progress = value.Second;

                                break;
                            }
                        case JsonProperties.MOVIE_SCROBBLE_POST_RESPONSE_PROPERTY_NAME_SHARING:
                            movieScrobbleResponse.Sharing = await sharingReader.ReadObjectAsync(jsonReader, cancellationToken);
                            break;
                        case JsonProperties.MOVIE_SCROBBLE_POST_RESPONSE_PROPERTY_NAME_MOVIE:
                            movieScrobbleResponse.Movie = await movieReader.ReadObjectAsync(jsonReader, cancellationToken);
                            break;
                        default:
                            await JsonReaderHelper.ReadAndIgnoreInvalidContentAsync(jsonReader, cancellationToken);
                            break;
                    }
                }

                return movieScrobbleResponse;
            }

            return await Task.FromResult(default(ITraktMovieScrobblePostResponse));
        }
    }
}
