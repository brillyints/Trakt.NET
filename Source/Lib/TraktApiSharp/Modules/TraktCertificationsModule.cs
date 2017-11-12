﻿namespace TraktApiSharp.Modules
{
    using Exceptions;
    using Objects.Basic;
    using Requests.Certifications;
    using Requests.Handler;
    using Responses;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Provides access to data retrieving methods specific to certifications.
    /// <para>
    /// This module contains all methods of the <a href ="http://docs.trakt.apiary.io/#reference/certifications">"Trakt API Doc - Certifications"</a> section.
    /// </para>
    /// </summary>
    public class TraktCertificationsModule : ITraktModule
    {
        internal TraktCertificationsModule(TraktClient client)
        {
            Client = client;
        }

        /// <summary>Gets a reference to the associated <see cref="TraktClient" /> instance.</summary>
        public TraktClient Client { get; }

        /// <summary>
        /// Gets all movie certifications.
        /// <para>OAuth authorization not required.</para>
        /// <para>
        /// See <a href="http://docs.trakt.apiary.io/#reference/certifications/list/get-certifications">"Trakt API Doc - Certifications: List"</a> for more information.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>An <see cref="ITraktCertifications" /> instance with the queried certification's data.</returns>
        /// <exception cref="TraktException">Thrown, if the request fails.</exception>
        public Task<TraktResponse<ITraktCertifications>> GetMovieCertificationsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestHandler = new RequestHandler(Client);
            return requestHandler.ExecuteSingleItemRequestAsync(new MovieCertificationsRequest(), cancellationToken);
        }

        /// <summary>
        /// Gets all show certifications.
        /// <para>OAuth authorization not required.</para>
        /// <para>
        /// See <a href="http://docs.trakt.apiary.io/#reference/certifications/list/get-certifications">"Trakt API Doc - Certifications: List"</a> for more information.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>An <see cref="ITraktCertifications" /> instance with the queried certification's data.</returns>
        /// <exception cref="TraktException">Thrown, if the request fails.</exception>
        public Task<TraktResponse<ITraktCertifications>> GetShowCertificationsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestHandler = new RequestHandler(Client);
            return requestHandler.ExecuteSingleItemRequestAsync(new ShowCertificationsRequest(), cancellationToken);
        }
    }
}
