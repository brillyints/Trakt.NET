﻿namespace TraktApiSharp.Objects.Get.Shows
{
    using Basic;
    using Newtonsoft.Json;

    /// <summary>A collection of images and image sets for a Trakt show.</summary>
    public class TraktShowImages
    {
        /// <summary>Gets or sets the fan art image set. See also <seealso cref="TraktImageSet" />.<para>Nullable</para></summary>
        [JsonProperty(PropertyName = "fanart")]
        public TraktImageSet FanArt { get; set; }

        /// <summary>Gets or sets the poster image set. See also <seealso cref="TraktImageSet" />.<para>Nullable</para></summary>
        [JsonProperty(PropertyName = "poster")]
        public TraktImageSet Poster { get; set; }

        /// <summary>Gets or sets the loge image. See also <seealso cref="TraktImage" />.<para>Nullable</para></summary>
        [JsonProperty(PropertyName = "logo")]
        public TraktImage Logo { get; set; }

        /// <summary>Gets or sets the clear art image. See also <seealso cref="TraktImage" />.<para>Nullable</para></summary>
        [JsonProperty(PropertyName = "clearart")]
        public TraktImage ClearArt { get; set; }

        /// <summary>Gets or sets the banner image. See also <seealso cref="TraktImage" />.<para>Nullable</para></summary>
        [JsonProperty(PropertyName = "banner")]
        public TraktImage Banner { get; set; }

        /// <summary>Gets or sets the thumb image. See also <seealso cref="TraktImage" />.<para>Nullable</para></summary>
        [JsonProperty(PropertyName = "thumb")]
        public TraktImage Thumb { get; set; }
    }
}
