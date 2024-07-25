# DemandApiV2CompatibleService

A list of all methods in the `DemandApiV2CompatibleService` service. Click on the method name to view detailed information about that method.

| Methods                                                   | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| :-------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| [GetHotelsReviewScoresAsync](#gethotelsreviewscoresasync) | Gives information about review scores for specified hotel_ids and filter. The information consists of score breakdown per reviewer_type and review questions, and overall score distribution per score value (1 - 10). The available filter is input parameter reviewer_type=... . It allows generating review score information for just one reviewer type. Language in which the response is rendered can be controlled with the input parameter language=... (default: 'en'). Setting the language will reflect on the output fields question and review_score_word. One additional output field can be requested with input parameter extras=review_score_word. |
| [GetHotelsAsync](#gethotelsasync)                         | This call returns the hotel and room data. By default, only hotel_id is returned in the output. One of the argument: hotel_ids, city_ids, country_ids, region_ids, district_ids, chain_ids is mandatory. Additional data needs to be requested via extras parameter. The data is returned in English by default.                                                                                                                                                                                                                                                                                                                                                    |
| [GetHotelTypesAsync](#gethoteltypesasync)                 | This endpoint returns hotel types names and their translations. (EN is default)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| [GetHotelThemeTypesAsync](#gethotelthemetypesasync)       | This endpoint returns a list of hotel theme types (in English).                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| [GetRoomFacilityTypesAsync](#getroomfacilitytypesasync)   | This endpoint returns room facility types names and their translations (EN is default).                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [GetHotelAvailabilityAsync](#gethotelavailabilityasync)   | This endpoint returns the cheapest available room for each hotel matching your check-in and check-out dates. You can search for hotels in a city, or for a specific list of (upto 300) hotels by hotel_ids. Here you will find whether the price included breakfast or other meals, as well as whether it is possible to cancel for free. It is possible to have a breakdown of the price returned by this endpoint and to filter by property types and/or hotel facilities.                                                                                                                                                                                        |
| [GetBlockAvailabilityAsync](#getblockavailabilityasync)   | This endpoint is where you find a list of all bookable or available rooms at a property. A room can have multiple blocks, as a block is a combination of the meal, cancellation policy, occupancy and other things. You can find detailed information about one hotel per search (detail_level) which will return most of the information needed to replicate the booking.com property page. If you want to search multiple hotels, you can, but you get less detail. For searching multiple hotels, it is recommended to use hotelAvailability.                                                                                                                    |

## GetHotelsReviewScoresAsync

Gives information about review scores for specified hotel_ids and filter. The information consists of score breakdown per reviewer_type and review questions, and overall score distribution per score value (1 - 10). The available filter is input parameter reviewer_type=... . It allows generating review score information for just one reviewer type. Language in which the response is rendered can be controlled with the input parameter language=... (default: 'en'). Setting the language will reflect on the output fields question and review_score_word. One additional output field can be requested with input parameter extras=review_score_word.

- HTTP Method: `GET`
- Endpoint: `/demand-api-v2-compatible/reviewScores`

**Parameters**

| Name                 | Type                        | Required | Description |
| :------------------- | :-------------------------- | :------- | :---------- |
| reviewScoresInputDto | ReviewScoresInputDto        | ✅       |             |
| accept               | GetHotelsReviewScoresAccept | ❌       |             |

**Return Type**

`ResponseOutputV2ReviewScoresOutputDto`

**Example Usage Code Snippet**

```csharp
using BookingClient;
using BookingClient.Models;

var client = new BookingClientClient();

var hotelIds = new List<long>() { 4 };
var reviewScoresInputDto = new ReviewScoresInputDto(hotelIds);

var response = await client.DemandApiV2Compatible.GetHotelsReviewScoresAsync(reviewScoresInputDto, GetHotelsReviewScoresAccept.ApplicationJsonApplicationXml);

Console.WriteLine(response);
```

## GetHotelsAsync

This call returns the hotel and room data. By default, only hotel_id is returned in the output. One of the argument: hotel_ids, city_ids, country_ids, region_ids, district_ids, chain_ids is mandatory. Additional data needs to be requested via extras parameter. The data is returned in English by default.

- HTTP Method: `GET`
- Endpoint: `/demand-api-v2-compatible/hotels`

**Parameters**

| Name        | Type            | Required | Description |
| :---------- | :-------------- | :------- | :---------- |
| hotelsInput | HotelsInputDto  | ✅       |             |
| accept      | GetHotelsAccept | ❌       |             |

**Return Type**

`ResponseOutputV2HotelsOutputDto`

**Example Usage Code Snippet**

```csharp
using BookingClient;
using BookingClient.Models;

var client = new BookingClientClient();

var hotelsInput = new HotelsInputDto();

var response = await client.DemandApiV2Compatible.GetHotelsAsync(hotelsInput, GetHotelsAccept.ApplicationJsonApplicationXml);

Console.WriteLine(response);
```

## GetHotelTypesAsync

This endpoint returns hotel types names and their translations. (EN is default)

- HTTP Method: `GET`
- Endpoint: `/demand-api-v2-compatible/hotelTypes`

**Parameters**

| Name              | Type                | Required | Description |
| :---------------- | :------------------ | :------- | :---------- |
| hotelTypeInputDto | HotelTypeInputDto   | ✅       |             |
| accept            | GetHotelTypesAccept | ❌       |             |

**Return Type**

`ResponseOutputV2HotelTypesOutputDto`

**Example Usage Code Snippet**

```csharp
using BookingClient;
using BookingClient.Models;

var client = new BookingClientClient();

var hotelTypeInputDto = new HotelTypeInputDto();

var response = await client.DemandApiV2Compatible.GetHotelTypesAsync(hotelTypeInputDto, GetHotelTypesAccept.ApplicationJson);

Console.WriteLine(response);
```

## GetHotelThemeTypesAsync

This endpoint returns a list of hotel theme types (in English).

- HTTP Method: `GET`
- Endpoint: `/demand-api-v2-compatible/hotelThemeTypes`

**Parameters**

| Name                   | Type                     | Required | Description |
| :--------------------- | :----------------------- | :------- | :---------- |
| hotelThemeTypeInputDto | HotelThemeTypeInputDto   | ✅       |             |
| accept                 | GetHotelThemeTypesAccept | ❌       |             |

**Return Type**

`ResponseOutputV2HotelThemeTypesOutputDto`

**Example Usage Code Snippet**

```csharp
using BookingClient;
using BookingClient.Models;

var client = new BookingClientClient();

var hotelThemeTypeInputDto = new HotelThemeTypeInputDto();

var response = await client.DemandApiV2Compatible.GetHotelThemeTypesAsync(hotelThemeTypeInputDto, GetHotelThemeTypesAccept.ApplicationJson);

Console.WriteLine(response);
```

## GetRoomFacilityTypesAsync

This endpoint returns room facility types names and their translations (EN is default).

- HTTP Method: `GET`
- Endpoint: `/demand-api-v2-compatible/hotelFacilityTypes`

**Parameters**

| Name                  | Type                       | Required | Description |
| :-------------------- | :------------------------- | :------- | :---------- |
| hotelFacilityInputDto | HotelFacilityInputDto      | ✅       |             |
| accept                | GetRoomFacilityTypesAccept | ❌       |             |

**Return Type**

`ResponseOutputV2HotelFacilityTypeOutputDto`

**Example Usage Code Snippet**

```csharp
using BookingClient;
using BookingClient.Models;

var client = new BookingClientClient();

var hotelFacilityInputDto = new HotelFacilityInputDto();

var response = await client.DemandApiV2Compatible.GetRoomFacilityTypesAsync(hotelFacilityInputDto, GetRoomFacilityTypesAccept.ApplicationJson);

Console.WriteLine(response);
```

## GetHotelAvailabilityAsync

This endpoint returns the cheapest available room for each hotel matching your check-in and check-out dates. You can search for hotels in a city, or for a specific list of (upto 300) hotels by hotel_ids. Here you will find whether the price included breakfast or other meals, as well as whether it is possible to cancel for free. It is possible to have a breakdown of the price returned by this endpoint and to filter by property types and/or hotel facilities.

- HTTP Method: `GET`
- Endpoint: `/demand-api-v2-compatible/hotelAvailability`

**Parameters**

| Name                      | Type                       | Required | Description |
| :------------------------ | :------------------------- | :------- | :---------- |
| hotelAvailabilityInputDto | HotelAvailabilityInputDto  | ✅       |             |
| accept                    | GetHotelAvailabilityAccept | ❌       |             |

**Return Type**

`ResponseOutputV2HotelAvailabilityOutputDto`

**Example Usage Code Snippet**

```csharp
using BookingClient;
using BookingClient.Models;

var client = new BookingClientClient();

var hotelAvailabilityInputDto = new HotelAvailabilityInputDto("checkin", "checkout", "guest_country", 7);

var response = await client.DemandApiV2Compatible.GetHotelAvailabilityAsync(hotelAvailabilityInputDto, GetHotelAvailabilityAccept.ApplicationJson);

Console.WriteLine(response);
```

## GetBlockAvailabilityAsync

This endpoint is where you find a list of all bookable or available rooms at a property. A room can have multiple blocks, as a block is a combination of the meal, cancellation policy, occupancy and other things. You can find detailed information about one hotel per search (detail_level) which will return most of the information needed to replicate the booking.com property page. If you want to search multiple hotels, you can, but you get less detail. For searching multiple hotels, it is recommended to use hotelAvailability.

- HTTP Method: `GET`
- Endpoint: `/demand-api-v2-compatible/blockAvailability`

**Parameters**

| Name       | Type                       | Required | Description |
| :--------- | :------------------------- | :------- | :---------- |
| blockInput | BlockAvailabilityInputDto  | ✅       |             |
| accept     | GetBlockAvailabilityAccept | ❌       |             |

**Return Type**

`ResponseOutputV2BlockAvailabilityOutputDto`

**Example Usage Code Snippet**

```csharp
using BookingClient;
using BookingClient.Models;

var client = new BookingClientClient();

var hotelIds = new List<long>() { 6 };
var blockInput = new BlockAvailabilityInputDto(hotelIds, "checkin", "checkout", "guest_cc");

var response = await client.DemandApiV2Compatible.GetBlockAvailabilityAsync(blockInput, GetBlockAvailabilityAccept.ApplicationJsonApplicationXml);

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
