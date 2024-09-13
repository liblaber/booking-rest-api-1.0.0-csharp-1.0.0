# DetailsInputDto

**Properties**

| Name                    | Type                             | Required | Description                                                                                                                                                                                                                                                                                                                                         |
| :---------------------- | :------------------------------- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Accommodations          | List`<long>`                     | ❌       | A signed integer number that uniquely identifies an accommodation property.                                                                                                                                                                                                                                                                         |
| AccommodationFacilities | List`<long>`                     | ❌       | A signed integer number that uniquely identifies an accommodation property facility. Examples of facilities are: Parking, Restaurant, Room service etc.                                                                                                                                                                                             |
| AccommodationTypes      | List`<long>`                     | ❌       | A signed integer number that uniquely identifies an accommodation property type. Examples of accommodation types are: Apartment, Hostel, Hotel etc.                                                                                                                                                                                                 |
| Airport                 | string                           | ❌       | A three-letter code that uniquely identifies an airport as defined by the International Air Transport Association (IATA).                                                                                                                                                                                                                           |
| Brands                  | List`<long>`                     | ❌       | A signed integer number that uniquely identifies an accommodation brand. Examples of brands are: Radisson Blu, WestCord Hotels, Westin etc.                                                                                                                                                                                                         |
| City                    | long                             | ❌       | A signed integer number that uniquely identifies a city.                                                                                                                                                                                                                                                                                            |
| Country                 | string                           | ❌       | A two-letter code that uniquely identifies a country. This code is defined by the ISO 3166-1 alpha-2 standard (ISO2) as described here: https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2.                                                                                                                                                           |
| Region                  | long                             | ❌       | A signed integer number that uniquely identifies a geographical region. Regions usually define official administrative areas within a country, but may also include multiple countries and in some cases un-official but popular designations for geographical areas. An example of a region that crosses multiple countries is the Alps in Europe. |
| Extras                  | List`<DetailsInputDtoExtras>`    | ❌       | Input parameter to request for additional information about the accommodation property. It should be passed as a JSON array with one or more items.                                                                                                                                                                                                 |
| Languages               | List`<DetailsInputDtoLanguages>` | ❌       | An IETF language tag code that uniquely identifies a supported human language or dialect as described here: https://en.wikipedia.org/wiki/IETF_language_tag. Note that in in demand-api-v3-compatible the whole tag is always lowercase. Examples: "nl" for Dutch/Nederlands or "en-us" for English (US).                                           |
| Rows                    | long                             | ❌       | The maximum number of results to return.                                                                                                                                                                                                                                                                                                            |
| Page                    | string                           | ❌       | Pagination token used to retrieve the next page of results. Obtained from `next_page`.                                                                                                                                                                                                                                                              |

# DetailsInputDtoExtras

Input parameter to request for additional information about the accommodation property. It should be passed as a JSON array with one or more items.

**Properties**

| Name        | Type   | Required | Description   |
| :---------- | :----- | :------- | :------------ |
| Description | string | ✅       | "DESCRIPTION" |
| Facilities  | string | ✅       | "FACILITIES"  |
| Payment     | string | ✅       | "PAYMENT"     |
| Photos      | string | ✅       | "PHOTOS"      |
| Policies    | string | ✅       | "POLICIES"    |
| Rooms       | string | ✅       | "ROOMS"       |

# DetailsInputDtoLanguages

An IETF language tag code that uniquely identifies a supported human language or dialect as described here: https://en.wikipedia.org/wiki/IETF_language_tag. Note that in in demand-api-v3-compatible the whole tag is always lowercase. Examples: "nl" for Dutch/Nederlands or "en-us" for English (US).

**Properties**

| Name | Type   | Required | Description |
| :--- | :----- | :------- | :---------- |
| Ar   | string | ✅       | "AR"        |
| Bg   | string | ✅       | "BG"        |
| Ca   | string | ✅       | "CA"        |
| Cs   | string | ✅       | "CS"        |
| Da   | string | ✅       | "DA"        |
| De   | string | ✅       | "DE"        |
| El   | string | ✅       | "EL"        |
| En   | string | ✅       | "EN"        |
| EnGb | string | ✅       | "EN_GB"     |
| EnUs | string | ✅       | "EN_US"     |
| Es   | string | ✅       | "ES"        |
| EsAr | string | ✅       | "ES_AR"     |
| EsMx | string | ✅       | "ES_MX"     |
| Et   | string | ✅       | "ET"        |
| Fi   | string | ✅       | "FI"        |
| Fr   | string | ✅       | "FR"        |
| He   | string | ✅       | "HE"        |
| Hi   | string | ✅       | "HI"        |
| Hr   | string | ✅       | "HR"        |
| Hu   | string | ✅       | "HU"        |
| Id   | string | ✅       | "ID"        |
| Is\_ | string | ✅       | "IS"        |
| It   | string | ✅       | "IT"        |
| Ja   | string | ✅       | "JA"        |
| Ka   | string | ✅       | "KA"        |
| Ko   | string | ✅       | "KO"        |
| Lt   | string | ✅       | "LT"        |
| Lv   | string | ✅       | "LV"        |
| Ms   | string | ✅       | "MS"        |
| Nl   | string | ✅       | "NL"        |
| No   | string | ✅       | "NO"        |
| Pl   | string | ✅       | "PL"        |
| PtBr | string | ✅       | "PT_BR"     |
| PtPt | string | ✅       | "PT_PT"     |
| Ro   | string | ✅       | "RO"        |
| Ru   | string | ✅       | "RU"        |
| Sk   | string | ✅       | "SK"        |
| Sl   | string | ✅       | "SL"        |
| Sr   | string | ✅       | "SR"        |
| Sv   | string | ✅       | "SV"        |
| Th   | string | ✅       | "TH"        |
| Tl   | string | ✅       | "TL"        |
| Tr   | string | ✅       | "TR"        |
| Uk   | string | ✅       | "UK"        |
| Vi   | string | ✅       | "VI"        |
| ZhCn | string | ✅       | "ZH_CN"     |
| ZhTw | string | ✅       | "ZH_TW"     |

<!-- This file was generated by liblab | https://liblab.com/ -->
