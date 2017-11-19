﻿namespace TraktApiSharp.Objects.Get.Movies.Json
{
    using Enums;
    using Implementations;
    using Newtonsoft.Json;
    using Objects.Json;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    internal class MovieReleaseObjectJsonReader : IObjectJsonReader<ITraktMovieRelease>
    {
        public Task<ITraktMovieRelease> ReadObjectAsync(string json, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrEmpty(json))
                return Task.FromResult(default(ITraktMovieRelease));

            using (var reader = new StringReader(json))
            using (var jsonReader = new JsonTextReader(reader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public Task<ITraktMovieRelease> ReadObjectAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (stream == null)
                return Task.FromResult(default(ITraktMovieRelease));

            using (var streamReader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public async Task<ITraktMovieRelease> ReadObjectAsync(JsonTextReader jsonReader, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (jsonReader == null)
                return await Task.FromResult(default(ITraktMovieRelease));

            if (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.StartObject)
            {
                ITraktMovieRelease traktMovieRelease = new TraktMovieRelease();

                while (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.PropertyName)
                {
                    var propertyName = jsonReader.Value.ToString();

                    switch (propertyName)
                    {
                        case JsonProperties.MOVIE_RELEASE_PROPERTY_NAME_COUNTRY:
                            traktMovieRelease.CountryCode = await jsonReader.ReadAsStringAsync(cancellationToken);
                            break;
                        case JsonProperties.MOVIE_RELEASE_PROPERTY_NAME_CERTIFICATION:
                            traktMovieRelease.Certification = await jsonReader.ReadAsStringAsync(cancellationToken);
                            break;
                        case JsonProperties.MOVIE_RELEASE_PROPERTY_NAME_RELEASE_DATE:
                            {
                                var value = await JsonReaderHelper.ReadDateTimeValueAsync(jsonReader, cancellationToken);

                                if (value.First)
                                    traktMovieRelease.ReleaseDate = value.Second;

                                break;
                            }
                        case JsonProperties.MOVIE_RELEASE_PROPERTY_NAME_RELEASE_TYPE:
                            traktMovieRelease.ReleaseType = await JsonReaderHelper.ReadEnumerationValueAsync<TraktReleaseType>(jsonReader, cancellationToken);
                            break;
                        case JsonProperties.MOVIE_RELEASE_PROPERTY_NAME_NOTE:
                            traktMovieRelease.Note = await jsonReader.ReadAsStringAsync(cancellationToken);
                            break;
                        default:
                            await JsonReaderHelper.ReadAndIgnoreInvalidContentAsync(jsonReader, cancellationToken);
                            break;
                    }
                }

                return traktMovieRelease;
            }

            return await Task.FromResult(default(ITraktMovieRelease));
        }
    }
}
