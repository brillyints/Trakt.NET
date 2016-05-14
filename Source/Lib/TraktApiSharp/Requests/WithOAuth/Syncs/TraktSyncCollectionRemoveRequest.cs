﻿namespace TraktApiSharp.Requests.WithOAuth.Syncs
{
    using Base.Post;
    using Objects.Post.Syncs.Collection;
    using Objects.Post.Syncs.Collection.Responses;

    internal class TraktSyncCollectionRemoveRequest : TraktPostRequest<TraktSyncCollectionRemovePostResponse, TraktSyncCollectionRemovePostResponse, TraktSyncCollectionRemovePost>
    {
        internal TraktSyncCollectionRemoveRequest(TraktClient client) : base(client) { }

        protected override string UriTemplate => "sync/collection/remove";

        protected override void Validate()
        {
            base.Validate();
            RequestBody.Validate();
        }
    }
}