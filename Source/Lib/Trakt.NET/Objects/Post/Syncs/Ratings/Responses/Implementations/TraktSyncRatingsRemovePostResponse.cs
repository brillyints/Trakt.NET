﻿namespace TraktNet.Objects.Post.Syncs.Ratings.Responses
{
    using Syncs.Responses;

    /// <summary>
    /// Represents the response for a ratings remove post. See also <see cref="ITraktSyncRatingsPost" />.
    /// <para>Contains the number of deleted and not found movies, shows, seasons and episodes.</para>
    /// </summary>
    public class TraktSyncRatingsRemovePostResponse : ITraktSyncRatingsRemovePostResponse
    {
        /// <summary>
        /// A collection containing the number of deleted movies, shows, seasons and episodes.
        /// <para>Nullable</para>
        /// </summary>
        public ITraktSyncPostResponseGroup Deleted { get; set; }

        /// <summary>
        /// A collection containing the ids of movies, shows, seasons and episodes, which were not found.
        /// <para>Nullable</para>
        /// </summary>
        public ITraktSyncPostResponseNotFoundGroup NotFound { get; set; }
    }
}
