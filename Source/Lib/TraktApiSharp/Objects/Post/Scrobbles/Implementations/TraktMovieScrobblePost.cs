﻿namespace TraktApiSharp.Objects.Post.Scrobbles.Implementations
{
    using Get.Movies;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>A scrobble post for a Trakt movie.</summary>
    public class TraktMovieScrobblePost : TraktScrobblePost, ITraktMovieScrobblePost
    {
        /// <summary>
        /// Gets or sets the required Trakt movie for the scrobble post.
        /// See also <seealso cref="ITraktMovie" />.
        /// </summary>
        public ITraktMovie Movie { get; set; }

        public override Task<string> ToJson(CancellationToken cancellationToken = default) => Task.FromResult("");

        public override void Validate()
        {
            // TODO
        }
    }
}
