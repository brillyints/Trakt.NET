﻿namespace TraktNet.Requests.Syncs.OAuth
{
    using Base;
    using System.Collections.Generic;

    internal abstract class ASyncGetRequest<TResponseContentType> : AGetRequest<TResponseContentType>
    {
        public override AuthorizationRequirement AuthorizationRequirement => AuthorizationRequirement.Required;

        public override IDictionary<string, object> GetUriPathParameters() => new Dictionary<string, object>();

        public override void Validate() { }
    }
}
