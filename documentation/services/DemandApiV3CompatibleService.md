# DemandApiV3CompatibleService

A list of all methods in the `DemandApiV3CompatibleService` service. Click on the method name to view detailed information about that method.

| Methods                                                           | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| :---------------------------------------------------------------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [SearchAsync](#searchasync)                                       | This endpoint returns the cheapest available product for each hotel matching the search criteria.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [PostDetailsAsync](#postdetailsasync)                             | This endpoint returns detailed information on all accommodation properties matching a given search criteria. By default, only basic information is returned. To receive extended information use the `extras` parameter. Is is mandatory to pass one of the input parameters: accommodations, airport, city, country or region.                                                                                                                                                                                                                                                    |
| [GetAccommodationConstantsAsync](#getaccommodationconstantsasync) | This endpoint enumerates the internal codes and names, in the selected languages, for relevant accommodation specific types. These accommodation specific types include the list of facilities that may be available at a property like "Elevator" or "Swimmingpool Outdoor". For example, the following parameters will return the full list in English (US) and French: `{"languages":"en-us","fr"}`. To get the full list call the endpoint passing an empty body. The codes returned are what is used as input and output for other endpoints in the accommodations namespace. |

## SearchAsync

This endpoint returns the cheapest available product for each hotel matching the search criteria.

- HTTP Method: `POST`
- Endpoint: `/demand-api-v3-compatible/search`

**Parameters**

| Name   | Type           | Required | Description       |
| :----- | :------------- | :------- | :---------------- |
| input  | SearchInputDto | ✅       | The request body. |
| accept | SearchAccept   | ❌       |                   |

**Return Type**

`ResponseOutputListSearchOutputDto`

**Example Usage Code Snippet**

```csharp
using BookingClient;
using BookingClient.Models;

var client = new BookingClientClient();

var booker = new BookerInputDto("gt", BookerInputDto.Platform.Android);
var guests = new GuestsInputDto(5, 0);
var input = new SearchInputDto("checkin", "checkout", booker, guests);

var response = await client.DemandApiV3Compatible.SearchAsync(input, SearchAccept.ApplicationJson);

Console.WriteLine(response);
```

## PostDetailsAsync

This endpoint returns detailed information on all accommodation properties matching a given search criteria. By default, only basic information is returned. To receive extended information use the `extras` parameter. Is is mandatory to pass one of the input parameters: accommodations, airport, city, country or region.

- HTTP Method: `POST`
- Endpoint: `/demand-api-v3-compatible/details`

**Parameters**

| Name   | Type              | Required | Description       |
| :----- | :---------------- | :------- | :---------------- |
| input  | DetailsInputDto   | ✅       | The request body. |
| accept | PostDetailsAccept | ❌       |                   |

**Return Type**

`ResponseOutputListDetailsOutputDto`

**Example Usage Code Snippet**

```csharp
using BookingClient;
using BookingClient.Models;

var client = new BookingClientClient();

var input = new DetailsInputDto();

var response = await client.DemandApiV3Compatible.PostDetailsAsync(input, PostDetailsAccept.ApplicationJson);

Console.WriteLine(response);
```

## GetAccommodationConstantsAsync

This endpoint enumerates the internal codes and names, in the selected languages, for relevant accommodation specific types. These accommodation specific types include the list of facilities that may be available at a property like "Elevator" or "Swimmingpool Outdoor". For example, the following parameters will return the full list in English (US) and French: `{"languages":"en-us","fr"}`. To get the full list call the endpoint passing an empty body. The codes returned are what is used as input and output for other endpoints in the accommodations namespace.

- HTTP Method: `POST`
- Endpoint: `/demand-api-v3-compatible/constants`

**Parameters**

| Name   | Type                            | Required | Description       |
| :----- | :------------------------------ | :------- | :---------------- |
| input  | ConstantInputDto                | ❌       | The request body. |
| accept | GetAccommodationConstantsAccept | ❌       |                   |

**Return Type**

`ResponseOutputConstantsOutputDto`

**Example Usage Code Snippet**

```csharp
using BookingClient;
using BookingClient.Models;

var client = new BookingClientClient();

var input = new ConstantInputDto();

var response = await client.DemandApiV3Compatible.GetAccommodationConstantsAsync(input, GetAccommodationConstantsAccept.ApplicationJson);

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
