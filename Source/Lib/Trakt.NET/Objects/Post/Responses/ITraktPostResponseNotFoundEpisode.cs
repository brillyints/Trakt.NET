﻿namespace TraktNet.Objects.Post.Responses
{
    using Get.Episodes;

    public interface ITraktPostResponseNotFoundEpisode
    {
        ITraktEpisodeIds Ids { get; set; }
    }
}
