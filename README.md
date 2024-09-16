# BookingClient C# SDK 1.0.0

Welcome to the BookingClient SDK documentation. This guide will help you get started with integrating and using the BookingClient SDK in your project.

## Versions

- API version: `1.0`
- SDK version: `1.0.0`

## About the API

Partner Connect API Service

## Table of Contents

- [Setup & Configuration](#setup--configuration)
  - [Supported Language Versions](#supported-language-versions)
  - [Installation](#installation)
- [Authentication](#authentication)
  - [Access Token Authentication](#access-token-authentication)
  - [API Key Authentication](#api-key-authentication)
- [Sample Usage](#sample-usage)
- [Services](#services)
- [Models](#models)
- [License](#license)

# Setup & Configuration

## Supported Language Versions

This SDK is compatible with the following versions: `C# >= .NET 6`

## Installation

To get started with the SDK, we recommend installing using `nuget`:

```bash
dotnet add package BookingClient
```

## Authentication

### Access Token Authentication

The BookingClient API uses an Access Token for authentication.

This token must be provided to authenticate your requests to the API.

#### Setting the Access Token

When you initialize the SDK, you can set the access token as follows:

```cs
using BookingClient;
using BookingClient.Config;

var config = new BookingClientConfig()
{
	AccessToken = "YOUR_ACCESS_TOKEN"
};

var client = new BookingClientClient(config);
```

If you need to set or update the access token after initializing the SDK, you can use:

```cs
client.SetAccessToken("YOUR_ACCESS_TOKEN")
```

### API Key Authentication

The BookingClient API uses API keys as a form of authentication. An API key is a unique identifier used to authenticate a user, developer, or a program that is calling the API.

#### Setting the API key

When you initialize the SDK, you can set the API key as follows:

```cs
using BookingClient;
using BookingClient.Config;

var config = new BookingClientConfig()
{
	ApiKeyAuth = new ApiKeyAuthConfig("YOUR_API_KEY")
};

var client = new BookingClientClient(config);
```

If you need to set or update the API key after initializing the SDK, you can use:

```cs
client.SetApiKey("YOUR_API_KEY")
```

# Sample Usage

Below is a comprehensive example demonstrating how to authenticate and call a simple endpoint:

```cs
using BookingClient;
using BookingClient.Config;
using BookingClient.Models;
using Environment = BookingClient.Http.Environment;

var apiKeyConfig = new ApiKeyAuthConfig("YOUR_API_KEY");

var config = new BookingClientConfig
{
  Environment = Environment.Default,
AccessToken = "YOUR_ACCESS_TOKEN",
ApiKeyAuth = apiKeyConfig
};

var client = new BookingClientClient(config);

var booker = new BookerInputDto("gt", BookerInputDto.Platform.Android);
var guests = new GuestsInputDto(5, 0);
var input = new SearchInputDto("checkin", "checkout", booker, guests);

var response = await client.DemandApiV3Compatible.SearchAsync(input, SearchAccept.ApplicationJson);

Console.WriteLine(response);

```

## Services

The SDK provides various services to interact with the API.

<details> 
<summary>Below is a list of all available services with links to their detailed documentation:</summary>

| Name                                                                                   |
| :------------------------------------------------------------------------------------- |
| [DemandApiV3CompatibleService](documentation/services/DemandApiV3CompatibleService.md) |
| [DemandApiV2CompatibleService](documentation/services/DemandApiV2CompatibleService.md) |

</details>

## Models

The SDK includes several models that represent the data structures used in API requests and responses. These models help in organizing and managing the data efficiently.

<details> 
<summary>Below is a list of all available models with links to their detailed documentation:</summary>

| Name                                                                                                             | Description                                                                                                                                                                                    |
| :--------------------------------------------------------------------------------------------------------------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [SearchInputDto](documentation/models/SearchInputDto.md)                                                         |                                                                                                                                                                                                |
| [ResponseOutputListSearchOutputDto](documentation/models/ResponseOutputListSearchOutputDto.md)                   |                                                                                                                                                                                                |
| [SearchAccept](documentation/models/SearchAccept.md)                                                             |                                                                                                                                                                                                |
| [DetailsInputDto](documentation/models/DetailsInputDto.md)                                                       |                                                                                                                                                                                                |
| [ResponseOutputListDetailsOutputDto](documentation/models/ResponseOutputListDetailsOutputDto.md)                 |                                                                                                                                                                                                |
| [PostDetailsAccept](documentation/models/PostDetailsAccept.md)                                                   |                                                                                                                                                                                                |
| [ConstantInputDto](documentation/models/ConstantInputDto.md)                                                     |                                                                                                                                                                                                |
| [ResponseOutputConstantsOutputDto](documentation/models/ResponseOutputConstantsOutputDto.md)                     |                                                                                                                                                                                                |
| [GetAccommodationConstantsAccept](documentation/models/GetAccommodationConstantsAccept.md)                       |                                                                                                                                                                                                |
| [ResponseOutputV2ReviewScoresOutputDto](documentation/models/ResponseOutputV2ReviewScoresOutputDto.md)           |                                                                                                                                                                                                |
| [ReviewScoresInputDto](documentation/models/ReviewScoresInputDto.md)                                             |                                                                                                                                                                                                |
| [GetHotelsReviewScoresAccept](documentation/models/GetHotelsReviewScoresAccept.md)                               |                                                                                                                                                                                                |
| [ResponseOutputV2HotelsOutputDto](documentation/models/ResponseOutputV2HotelsOutputDto.md)                       |                                                                                                                                                                                                |
| [HotelsInputDto](documentation/models/HotelsInputDto.md)                                                         |                                                                                                                                                                                                |
| [GetHotelsAccept](documentation/models/GetHotelsAccept.md)                                                       |                                                                                                                                                                                                |
| [ResponseOutputV2HotelTypesOutputDto](documentation/models/ResponseOutputV2HotelTypesOutputDto.md)               |                                                                                                                                                                                                |
| [HotelTypeInputDto](documentation/models/HotelTypeInputDto.md)                                                   |                                                                                                                                                                                                |
| [GetHotelTypesAccept](documentation/models/GetHotelTypesAccept.md)                                               |                                                                                                                                                                                                |
| [ResponseOutputV2HotelThemeTypesOutputDto](documentation/models/ResponseOutputV2HotelThemeTypesOutputDto.md)     |                                                                                                                                                                                                |
| [HotelThemeTypeInputDto](documentation/models/HotelThemeTypeInputDto.md)                                         |                                                                                                                                                                                                |
| [GetHotelThemeTypesAccept](documentation/models/GetHotelThemeTypesAccept.md)                                     |                                                                                                                                                                                                |
| [ResponseOutputV2HotelFacilityTypeOutputDto](documentation/models/ResponseOutputV2HotelFacilityTypeOutputDto.md) |                                                                                                                                                                                                |
| [HotelFacilityInputDto](documentation/models/HotelFacilityInputDto.md)                                           |                                                                                                                                                                                                |
| [GetRoomFacilityTypesAccept](documentation/models/GetRoomFacilityTypesAccept.md)                                 |                                                                                                                                                                                                |
| [ResponseOutputV2HotelAvailabilityOutputDto](documentation/models/ResponseOutputV2HotelAvailabilityOutputDto.md) |                                                                                                                                                                                                |
| [HotelAvailabilityInputDto](documentation/models/HotelAvailabilityInputDto.md)                                   |                                                                                                                                                                                                |
| [GetHotelAvailabilityAccept](documentation/models/GetHotelAvailabilityAccept.md)                                 |                                                                                                                                                                                                |
| [ResponseOutputV2BlockAvailabilityOutputDto](documentation/models/ResponseOutputV2BlockAvailabilityOutputDto.md) |                                                                                                                                                                                                |
| [BlockAvailabilityInputDto](documentation/models/BlockAvailabilityInputDto.md)                                   |                                                                                                                                                                                                |
| [GetBlockAvailabilityAccept](documentation/models/GetBlockAvailabilityAccept.md)                                 |                                                                                                                                                                                                |
| [BookerInputDto](documentation/models/BookerInputDto.md)                                                         | The booker's information.                                                                                                                                                                      |
| [GuestsInputDto](documentation/models/GuestsInputDto.md)                                                         | The guest details for the request.                                                                                                                                                             |
| [Coordinates](documentation/models/Coordinates.md)                                                               | Limit the result list to the specified coordinates.                                                                                                                                            |
| [AllocationInputDto](documentation/models/AllocationInputDto.md)                                                 | The exact allocation of guests to rooms.                                                                                                                                                       |
| [SearchOutputDto](documentation/models/SearchOutputDto.md)                                                       |                                                                                                                                                                                                |
| [PriceDataDtoDouble](documentation/models/PriceDataDtoDouble.md)                                                 | The price components of this product or selection of products. 'base' and 'extra_charges' are returned only when explicitly requested (via 'extras=extra_charges').                            |
| [ProductDto](documentation/models/ProductDto.md)                                                                 |                                                                                                                                                                                                |
| [ExtraChargesDtoDouble](documentation/models/ExtraChargesDtoDouble.md)                                           | The charge breakdown. Includes taxes and fees.                                                                                                                                                 |
| [PoliciesDto](documentation/models/PoliciesDto.md)                                                               | The policies for this product.                                                                                                                                                                 |
| [PriceDataDtoListChargeDto](documentation/models/PriceDataDtoListChargeDto.md)                                   | The price components of this product or selection of products. 'base' and 'extra_charges' are returned only when explicitly requested (via 'extras=extra_charges').                            |
| [DealDto](documentation/models/DealDto.md)                                                                       | This specifies the deal tagging for the product.                                                                                                                                               |
| [CancellationDto](documentation/models/CancellationDto.md)                                                       | The cancellation policy for this product.                                                                                                                                                      |
| [MealPlanDto](documentation/models/MealPlanDto.md)                                                               | The meal plan policy for this product.                                                                                                                                                         |
| [PaymentDto](documentation/models/PaymentDto.md)                                                                 | Payment terms and conditions for this product.                                                                                                                                                 |
| [ExtraChargesDtoListChargeDto](documentation/models/ExtraChargesDtoListChargeDto.md)                             | The charge breakdown. Includes taxes and fees.                                                                                                                                                 |
| [ChargeDto](documentation/models/ChargeDto.md)                                                                   |                                                                                                                                                                                                |
| [DetailsOutputDto](documentation/models/DetailsOutputDto.md)                                                     |                                                                                                                                                                                                |
| [TranslatedString](documentation/models/TranslatedString.md)                                                     | Translated description of this room. The maximum number of characters returned may be limited by contract.                                                                                     |
| [CheckinCheckoutTimesDto](documentation/models/CheckinCheckoutTimesDto.md)                                       |                                                                                                                                                                                                |
| [ContactsDto](documentation/models/ContactsDto.md)                                                               | Contact information of the accommodation.                                                                                                                                                      |
| [FacilityDto](documentation/models/FacilityDto.md)                                                               | The list of facilities available in this property. Requires `{"extras":["facilities"]}`.                                                                                                       |
| [DescriptionDto](documentation/models/DescriptionDto.md)                                                         | Textual information about the accommodation. Requires `{"extras":["description"]}`.                                                                                                            |
| [KeyCollectionInformationDto](documentation/models/KeyCollectionInformationDto.md)                               |                                                                                                                                                                                                |
| [LocationDto](documentation/models/LocationDto.md)                                                               | All location related information of this accommodation property.                                                                                                                               |
| [PhotoDto](documentation/models/PhotoDto.md)                                                                     |                                                                                                                                                                                                |
| [ProgramSettingsDto](documentation/models/ProgramSettingsDto.md)                                                 | Details of programmes undergone by the property.                                                                                                                                               |
| [RatingDto](documentation/models/RatingDto.md)                                                                   |                                                                                                                                                                                                |
| [RoomDto](documentation/models/RoomDto.md)                                                                       | The list of room types available at this property. Requires `{"extras":["rooms"]}`.                                                                                                            |
| [LocalTime](documentation/models/LocalTime.md)                                                                   | The time till when checkout can be done at this property.                                                                                                                                      |
| [ContactDto](documentation/models/ContactDto.md)                                                                 | Contact information of the accommodation. It can be `null` if the data is missing.                                                                                                             |
| [TranslationInformation](documentation/models/TranslationInformation.md)                                         | Text containing important information about the property. The value is translated in the requested languages.                                                                                  |
| [TruncatedString](documentation/models/TruncatedString.md)                                                       | The translated description text of this accommodation property in the requested languages. The maximum number of characters returned may be limited by contract.                               |
| [AlternativeKeyLocationDto](documentation/models/AlternativeKeyLocationDto.md)                                   | Alternate location to collect the key of this accommodation property. This is returned if the key to access the property is in another location.                                               |
| [LazyTranslatedString](documentation/models/LazyTranslatedString.md)                                             | Translated accommodation address.                                                                                                                                                              |
| [CoordinatesDto](documentation/models/CoordinatesDto.md)                                                         | A signed integer number that uniquely identifies a city.                                                                                                                                       |
| [PhotoUrlDto](documentation/models/PhotoUrlDto.md)                                                               |                                                                                                                                                                                                |
| [BedOptionDto](documentation/models/BedOptionDto.md)                                                             | Lists all possible bedding options for this room or apartment.                                                                                                                                 |
| [CribsAndExtraBedsDto](documentation/models/CribsAndExtraBedsDto.md)                                             | Lists room options regarding adding cribs and/or extra beds.                                                                                                                                   |
| [RoomMaximumOccupancyDto](documentation/models/RoomMaximumOccupancyDto.md)                                       | Occupancy limits and options.                                                                                                                                                                  |
| [NumberOfRoomsDto](documentation/models/NumberOfRoomsDto.md)                                                     | Total rooms available.                                                                                                                                                                         |
| [BedConfigurationDto](documentation/models/BedConfigurationDto.md)                                               | Lists all alternative bed configurations that are supported.                                                                                                                                   |
| [BedDto](documentation/models/BedDto.md)                                                                         | Detail list of all different types and number of beds included in this configuration.                                                                                                          |
| [Meta](documentation/models/Meta.md)                                                                             |                                                                                                                                                                                                |
| [ReviewScoresOutputDto](documentation/models/ReviewScoresOutputDto.md)                                           |                                                                                                                                                                                                |
| [ScoreBreakdown](documentation/models/ScoreBreakdown.md)                                                         | A breakdown of scores per reviewer type and review question.                                                                                                                                   |
| [ScoreDistribution](documentation/models/ScoreDistribution.md)                                                   | A breakdown of all review scores into buckets 1 - 10.                                                                                                                                          |
| [QuestionDto](documentation/models/QuestionDto.md)                                                               | Review scores per question.                                                                                                                                                                    |
| [HotelsOutputDto](documentation/models/HotelsOutputDto.md)                                                       |                                                                                                                                                                                                |
| [HotelDataDto](documentation/models/HotelDataDto.md)                                                             | Hotel specific information.                                                                                                                                                                    |
| [RoomDataDto](documentation/models/RoomDataDto.md)                                                               | This block has room data for this hotel.                                                                                                                                                       |
| [HotelPhotoDto](documentation/models/HotelPhotoDto.md)                                                           | Photos specific information of the hotel.                                                                                                                                                      |
| [RoomInfoDto](documentation/models/RoomInfoDto.md)                                                               |                                                                                                                                                                                                |
| [BedroomDto](documentation/models/BedroomDto.md)                                                                 |                                                                                                                                                                                                |
| [RoomOccupancyDto](documentation/models/RoomOccupancyDto.md)                                                     |                                                                                                                                                                                                |
| [RoomSizeDto](documentation/models/RoomSizeDto.md)                                                               |                                                                                                                                                                                                |
| [HotelTypesOutputDto](documentation/models/HotelTypesOutputDto.md)                                               |                                                                                                                                                                                                |
| [TranslationDto](documentation/models/TranslationDto.md)                                                         |                                                                                                                                                                                                |
| [HotelThemeTypesOutputDto](documentation/models/HotelThemeTypesOutputDto.md)                                     |                                                                                                                                                                                                |
| [HotelFacilityTypeOutputDto](documentation/models/HotelFacilityTypeOutputDto.md)                                 |                                                                                                                                                                                                |
| [HotelAvailabilityOutputDto](documentation/models/HotelAvailabilityOutputDto.md)                                 |                                                                                                                                                                                                |
| [BlockAvailabilityOutputDto](documentation/models/BlockAvailabilityOutputDto.md)                                 |                                                                                                                                                                                                |
| [BlockOutputDto](documentation/models/BlockOutputDto.md)                                                         | The object containing all the relevant information for the combination of room, policy, meal and occupancy that determines the price." A block is the unique entity you book with booking.com. |

</details>

## License

This SDK is licensed under the MIT License.

See the [LICENSE](LICENSE) file for more details.

<!-- This file was generated by liblab | https://liblab.com/ -->
