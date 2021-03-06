﻿namespace TraktNet.Objects.Basic
{
    using System.Collections.Generic;

    public class TraktCertifications : ITraktCertifications
    {
        /// <summary>
        /// Gets or sets the certifications for the country code "us". See also <seealso cref="ITraktCertification" />.
        /// <para>Nullable</para>
        /// </summary>
        public IEnumerable<ITraktCertification> US { get; set; }
    }
}
