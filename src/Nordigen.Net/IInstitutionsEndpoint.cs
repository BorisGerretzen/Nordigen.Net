﻿namespace Nordigen.Net
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Nordigen.Net.Responses;
    using OneOf;

    public interface IInstitutionsEndpoint
    {
        /// <summary>
        /// List all available institutions
        /// </summary>
        /// <param name="country">The id of the account</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/></param>
        /// <returns>A list of <see cref="Institution"/> or <see cref="Error"/></returns>
        Task<OneOf<Institution[], Error>> GetByCountryIso3166Code(string country, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get details about a specific Institution.
        /// </summary>
        /// <param name="id">The id of the institution</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/></param>
        /// <returns>The <see cref="Institution"/> or <see cref="Error"/></returns>
        /// <returns></returns>
        Task<OneOf<Institution, Error>> Get(Guid id, CancellationToken cancellationToken = default);
    }
}
