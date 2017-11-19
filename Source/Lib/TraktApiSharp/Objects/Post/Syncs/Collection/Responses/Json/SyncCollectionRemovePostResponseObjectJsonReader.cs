﻿namespace TraktApiSharp.Objects.Post.Syncs.Collection.Responses.Json
{
    using Implementations;
    using Newtonsoft.Json;
    using Objects.Json;
    using Syncs.Responses.Json;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    internal class SyncCollectionRemovePostResponseObjectJsonReader : IObjectJsonReader<ITraktSyncCollectionRemovePostResponse>
    {
        public Task<ITraktSyncCollectionRemovePostResponse> ReadObjectAsync(string json, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrEmpty(json))
                return Task.FromResult(default(ITraktSyncCollectionRemovePostResponse));

            using (var reader = new StringReader(json))
            using (var jsonReader = new JsonTextReader(reader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public Task<ITraktSyncCollectionRemovePostResponse> ReadObjectAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (stream == null)
                return Task.FromResult(default(ITraktSyncCollectionRemovePostResponse));

            using (var streamReader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public async Task<ITraktSyncCollectionRemovePostResponse> ReadObjectAsync(JsonTextReader jsonReader, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (jsonReader == null)
                return await Task.FromResult(default(ITraktSyncCollectionRemovePostResponse));

            if (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.StartObject)
            {
                var groupReader = new SyncPostResponseGroupObjectJsonReader();
                var notFoundGroupReader = new SyncPostResponseNotFoundGroupObjectJsonReader();
                ITraktSyncCollectionRemovePostResponse syncCollectionPostResponse = new TraktSyncCollectionRemovePostResponse();

                while (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.PropertyName)
                {
                    var propertyName = jsonReader.Value.ToString();

                    switch (propertyName)
                    {
                        case JsonProperties.SYNC_COLLECTION_REMOVE_POST_RESPONSE_PROPERTY_NAME_DELETED:
                            syncCollectionPostResponse.Deleted = await groupReader.ReadObjectAsync(jsonReader, cancellationToken);
                            break;
                        case JsonProperties.SYNC_COLLECTION_REMOVE_POST_RESPONSE_PROPERTY_NAME_NOT_FOUND:
                            syncCollectionPostResponse.NotFound = await notFoundGroupReader.ReadObjectAsync(jsonReader, cancellationToken);
                            break;
                        default:
                            await JsonReaderHelper.ReadAndIgnoreInvalidContentAsync(jsonReader, cancellationToken);
                            break;
                    }
                }

                return syncCollectionPostResponse;
            }

            return await Task.FromResult(default(ITraktSyncCollectionRemovePostResponse));
        }
    }
}
