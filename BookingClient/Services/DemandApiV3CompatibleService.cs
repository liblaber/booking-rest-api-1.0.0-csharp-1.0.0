// This file was generated by liblab | https://liblab.com/

using System.Net.Http.Json;
using BookingClient.Http;
using BookingClient.Http.Exceptions;
using BookingClient.Http.Extensions;
using BookingClient.Http.Serialization;
using BookingClient.Models;

namespace BookingClient.Services;

public class DemandApiV3CompatibleService : BaseService
{
    internal DemandApiV3CompatibleService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>This endpoint returns the cheapest available product for each hotel matching the search criteria.</summary>
    public async Task<ResponseOutputListSearchOutputDto> SearchAsync(
        SearchInputDto input,
        SearchAccept? accept = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "demand-api-v3-compatible/search")
            .SetOptionalHeader("Accept", accept?.Value)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<ResponseOutputListSearchOutputDto>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// This endpoint returns detailed information on all accommodation properties matching a given search criteria.
    /// By default, only basic information is returned. To receive extended information use the `extras` parameter.
    /// Is is mandatory to pass one of the input parameters: accommodations, airport, city, country or region.
    /// </summary>
    public async Task<ResponseOutputListDetailsOutputDto> PostDetailsAsync(
        DetailsInputDto input,
        PostDetailsAccept? accept = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "demand-api-v3-compatible/details")
            .SetOptionalHeader("Accept", accept?.Value)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<ResponseOutputListDetailsOutputDto>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// This endpoint enumerates the internal codes and names, in the selected languages,
    /// for relevant accommodation specific types.
    ///
    /// These accommodation specific types include the list of facilities
    /// that may be available at a property like "Elevator" or "Swimmingpool Outdoor".
    ///
    /// For example, the following parameters will return
    /// the full list in English (US) and French: `{"languages":"en-us","fr"}`.
    ///
    /// To get the full list call the endpoint passing an empty body.
    /// The codes returned are what is used as input and output for other endpoints in the accommodations namespace.
    /// </summary>
    public async Task<ResponseOutputConstantsOutputDto> GetAccommodationConstantsAsync(
        ConstantInputDto input,
        GetAccommodationConstantsAccept? accept = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "demand-api-v3-compatible/constants")
            .SetOptionalHeader("Accept", accept?.Value)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<ResponseOutputConstantsOutputDto>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
