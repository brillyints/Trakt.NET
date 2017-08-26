﻿namespace TraktApiSharp.Requests.Shows.OAuth
{
    using Objects.Get.Shows;

    internal sealed class TraktShowCollectionProgressRequest : AShowProgressRequest<ITraktShowCollectionProgress>
    {
        public override string UriTemplate => "shows/{id}/progress/collection{?hidden,specials,count_specials}";
    }
}
