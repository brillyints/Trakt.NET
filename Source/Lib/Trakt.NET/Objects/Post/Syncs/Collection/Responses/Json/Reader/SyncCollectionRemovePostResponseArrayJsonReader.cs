﻿namespace TraktNet.Objects.Post.Syncs.Collection.Responses.Json.Reader
{
    using Newtonsoft.Json;
    using Objects.Json;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    internal class SyncCollectionRemovePostResponseArrayJsonReader : AArrayJsonReader<ITraktSyncCollectionRemovePostResponse>
    {
        public override async Task<IEnumerable<ITraktSyncCollectionRemovePostResponse>> ReadArrayAsync(JsonTextReader jsonReader, CancellationToken cancellationToken = default)
        {
            if (jsonReader == null)
                return await Task.FromResult(default(IEnumerable<ITraktSyncCollectionRemovePostResponse>));

            if (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.StartArray)
            {
                var syncCollectionRemovePostResponseReader = new SyncCollectionRemovePostResponseObjectJsonReader();
                //var syncCollectionRemovePostResponseReadingTasks = new List<Task<ITraktSyncCollectionRemovePostResponse>>();
                var syncCollectionRemovePostResponses = new List<ITraktSyncCollectionRemovePostResponse>();

                //syncCollectionRemovePostResponseReadingTasks.Add(syncCollectionRemovePostResponseReader.ReadObjectAsync(jsonReader, cancellationToken));
                ITraktSyncCollectionRemovePostResponse syncCollectionRemovePostResponse = await syncCollectionRemovePostResponseReader.ReadObjectAsync(jsonReader, cancellationToken);

                while (syncCollectionRemovePostResponse != null)
                {
                    syncCollectionRemovePostResponses.Add(syncCollectionRemovePostResponse);
                    //syncCollectionRemovePostResponseReadingTasks.Add(syncCollectionRemovePostResponseReader.ReadObjectAsync(jsonReader, cancellationToken));
                    syncCollectionRemovePostResponse = await syncCollectionRemovePostResponseReader.ReadObjectAsync(jsonReader, cancellationToken);
                }

                //var readSyncCollectionRemovePostResponses = await Task.WhenAll(syncCollectionRemovePostResponseReadingTasks);
                //return (IEnumerable<ITraktSyncCollectionRemovePostResponse>)readSyncCollectionRemovePostResponses.GetEnumerator();
                return syncCollectionRemovePostResponses;
            }

            return await Task.FromResult(default(IEnumerable<ITraktSyncCollectionRemovePostResponse>));
        }
    }
}
