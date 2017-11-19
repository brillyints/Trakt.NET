﻿namespace TraktApiSharp.Objects.Post.Scrobbles.Responses.Json
{
    using Basic.Json;
    using Enums;
    using Get.Episodes.Json;
    using Get.Shows.Json;
    using Implementations;
    using Newtonsoft.Json;
    using Objects.Json;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    internal class EpisodeScrobblePostResponseObjectJsonReader : IObjectJsonReader<ITraktEpisodeScrobblePostResponse>
    {
        public Task<ITraktEpisodeScrobblePostResponse> ReadObjectAsync(string json, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrEmpty(json))
                return Task.FromResult(default(ITraktEpisodeScrobblePostResponse));

            using (var reader = new StringReader(json))
            using (var jsonReader = new JsonTextReader(reader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public Task<ITraktEpisodeScrobblePostResponse> ReadObjectAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (stream == null)
                return Task.FromResult(default(ITraktEpisodeScrobblePostResponse));

            using (var streamReader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public async Task<ITraktEpisodeScrobblePostResponse> ReadObjectAsync(JsonTextReader jsonReader, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (jsonReader == null)
                return await Task.FromResult(default(ITraktEpisodeScrobblePostResponse));

            if (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.StartObject)
            {
                var sharingReader = new SharingObjectJsonReader();
                var episodeReader = new EpisodeObjectJsonReader();
                var showReader = new ShowObjectJsonReader();
                ITraktEpisodeScrobblePostResponse episodeScrobbleResponse = new TraktEpisodeScrobblePostResponse();

                while (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.PropertyName)
                {
                    var propertyName = jsonReader.Value.ToString();

                    switch (propertyName)
                    {
                        case JsonProperties.EPISODE_SCROBBLE_POST_RESPONSE_PROPERTY_NAME_ID:
                            {
                                var value = await JsonReaderHelper.ReadUnsignedLongIntegerAsync(jsonReader, cancellationToken);

                                if (value.First)
                                    episodeScrobbleResponse.Id = value.Second;

                                break;
                            }
                        case JsonProperties.EPISODE_SCROBBLE_POST_RESPONSE_PROPERTY_NAME_ACTION:
                            episodeScrobbleResponse.Action = await JsonReaderHelper.ReadEnumerationValueAsync<TraktScrobbleActionType>(jsonReader, cancellationToken);
                            break;
                        case JsonProperties.EPISODE_SCROBBLE_POST_RESPONSE_PROPERTY_NAME_PROGRESS:
                            {
                                var value = await JsonReaderHelper.ReadFloatValueAsync(jsonReader, cancellationToken);

                                if (value.First)
                                    episodeScrobbleResponse.Progress = value.Second;

                                break;
                            }
                        case JsonProperties.EPISODE_SCROBBLE_POST_RESPONSE_PROPERTY_NAME_SHARING:
                            episodeScrobbleResponse.Sharing = await sharingReader.ReadObjectAsync(jsonReader, cancellationToken);
                            break;
                        case JsonProperties.EPISODE_SCROBBLE_POST_RESPONSE_PROPERTY_NAME_EPISODE:
                            episodeScrobbleResponse.Episode = await episodeReader.ReadObjectAsync(jsonReader, cancellationToken);
                            break;
                        case JsonProperties.EPISODE_SCROBBLE_POST_RESPONSE_PROPERTY_NAME_SHOW:
                            episodeScrobbleResponse.Show = await showReader.ReadObjectAsync(jsonReader, cancellationToken);
                            break;
                        default:
                            await JsonReaderHelper.ReadAndIgnoreInvalidContentAsync(jsonReader, cancellationToken);
                            break;
                    }
                }

                return episodeScrobbleResponse;
            }

            return await Task.FromResult(default(ITraktEpisodeScrobblePostResponse));
        }
    }
}
