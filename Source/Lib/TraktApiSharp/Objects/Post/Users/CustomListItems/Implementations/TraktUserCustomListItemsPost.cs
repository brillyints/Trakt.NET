﻿namespace TraktApiSharp.Objects.Post.Users.CustomListItems.Implementations
{
    using Get.People;
    using System.Collections.Generic;

    /// <summary>
    /// An user custom list items post, containing all movies, shows, episodes and / or people,
    /// which should be added to an user's custom list.
    /// </summary>
    public class TraktUserCustomListItemsPost : ITraktUserCustomListItemsPost
    {
        /// <summary>
        /// An optional list of <see cref="ITraktUserCustomListItemsPostMovie" />s.
        /// <para>Each <see cref="ITraktUserCustomListItemsPostMovie" /> must have at least a valid Trakt id.</para>
        /// </summary>
        public IEnumerable<ITraktUserCustomListItemsPostMovie> Movies { get; set; }

        /// <summary>
        /// An optional list of <see cref="ITraktUserCustomListItemsPostShow" />s.
        /// <para>Each <see cref="ITraktUserCustomListItemsPostShow" /> must have at least a valid Trakt id.</para>
        /// </summary>
        public IEnumerable<ITraktUserCustomListItemsPostShow> Shows { get; set; }

        /// <summary>
        /// An optional list of <see cref="ITraktPerson" />s.
        /// <para>Each <see cref="ITraktPerson" /> must have at least a valid Trakt id and a name.</para>
        /// </summary>
        public IEnumerable<ITraktPerson> People { get; set; }

        /// <summary>Returns a new <see cref="TraktUserCustomListItemsPostBuilder" /> instance.</summary>
        /// <returns>A new <see cref="TraktUserCustomListItemsPostBuilder" /> instance.</returns>
        public static TraktUserCustomListItemsPostBuilder Builder() => new TraktUserCustomListItemsPostBuilder();

        public string ToJson() => "";

        public void Validate()
        {
            // TODO
        }
    }
}
