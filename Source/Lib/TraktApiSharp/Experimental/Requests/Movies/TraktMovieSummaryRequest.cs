﻿namespace TraktApiSharp.Experimental.Requests.Movies
{
    using Base.Get;
    using Objects.Get.Movies;
    using System;
    using TraktApiSharp.Requests;

    internal sealed class TraktMovieSummaryRequest : ATraktSingleItemGetByIdRequest<TraktMovie>
    {
        internal TraktMovieSummaryRequest(TraktClient client) : base(client) { }

        public override TraktAuthorizationRequirement AuthorizationRequirement
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string UriTemplate
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
