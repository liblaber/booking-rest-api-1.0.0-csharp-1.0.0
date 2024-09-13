# BlockAvailabilityInputDto

**Properties**

| Name         | Type                                    | Required | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| :----------- | :-------------------------------------- | :------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| HotelIds     | List`<long>`                            | ✅       | Hotel ID(s) to check availability for.                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| Checkin      | string                                  | ✅       | The arrival date.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| Checkout     | string                                  | ✅       | The departure date. Must be later than (checkin).                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| GuestCc      | string                                  | ✅       | Guest country code. Used to accurately display the best prices and price details for people from that country.                                                                                                                                                                                                                                                                                                                                                                                                   |
| Currency     | string                                  | ❌       | Returns the prices in this currency, in addition to the hotel currency.                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| Extras       | List`<BlockAvailabilityInputDtoExtras>` | ❌       | The extra items for this request. See the documentation for more details about each extra.                                                                                                                                                                                                                                                                                                                                                                                                                       |
| AffiliateId  | string                                  | ❌       | Application affiliate id                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| BlockIds     | List`<string>`                          | ❌       | Return only availability hits with these particular block IDs                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| GuestIp      | string                                  | ❌       | Guest IP address for determining guest country and showing the best price for that user and obeying laws regarding the display of taxes and fees.                                                                                                                                                                                                                                                                                                                                                                |
| GuestQty     | List`<long>`                            | ❌       | Number of guests for which blocks will be found. The total number of guests is used for calculating city tax charges. It is specified as an array of guest numbers. If you use this parameter and make bookings through the API, you should also set the exact same value in the guest_quantities parameter for the processBooking call, otherwise per-person included charges may result in pricing problems, causing the booking to fail. NOTE: After version 2.6 either this or `room1` needs to be provided. |
| Language     | BlockAvailabilityInputDtoLanguage       | ❌       | Specify the language for: block_id, policies, room texts and hotel descriptions. Note: not all text is translated in all languages. Please check the "Possible Values" section of the documentation for the accepted language codes.                                                                                                                                                                                                                                                                             |
| NumRooms     | long                                    | ❌       | Takes a number of rooms to put guests into                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| Room1        | List`<string>`                          | ❌       | Which guests to put in which rooms. Syntax: comma-separated list, `A` for each adult, a number in the range 0..17 for each child.                                                                                                                                                                                                                                                                                                                                                                                |
| UserPlatform | BlockAvailabilityInputDtoUserPlatform   | ❌       | The user's platform.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |

# BlockAvailabilityInputDtoExtras

The extra items for this request. See the documentation for more details about each extra.

**Properties**

| Name                   | Type   | Required | Description                |
| :--------------------- | :----- | :------- | :------------------------- |
| AddonType              | string | ✅       | "ADDON_TYPE"               |
| NetPrice               | string | ✅       | "NET_PRICE"                |
| RackRates              | string | ✅       | "RACK_RATES"               |
| MaxRoomsInReservation  | string | ✅       | "MAX_ROOMS_IN_RESERVATION" |
| SmokingStatus          | string | ✅       | "SMOKING_STATUS"           |
| ImportantInformation   | string | ✅       | "IMPORTANT_INFORMATION"    |
| AllExtraCharges        | string | ✅       | "ALL_EXTRA_CHARGES"        |
| AdditionalRoomInfo     | string | ✅       | "ADDITIONAL_ROOM_INFO"     |
| GroupRecommendations   | string | ✅       | "GROUP_RECOMMENDATIONS"    |
| RoomTypeId             | string | ✅       | "ROOM_TYPE_ID"             |
| CcRequired             | string | ✅       | "CC_REQUIRED"              |
| ShowConditionalCharges | string | ✅       | "SHOW_CONDITIONAL_CHARGES" |
| PostcardPhoto          | string | ✅       | "POSTCARD_PHOTO"           |
| ExtraCharges           | string | ✅       | "EXTRA_CHARGES"            |
| Photos                 | string | ✅       | "PHOTOS"                   |
| Internet               | string | ✅       | "INTERNET"                 |
| IfDomesticNoCc         | string | ✅       | "IF_DOMESTIC_NO_CC"        |
| Facilities             | string | ✅       | "FACILITIES"               |
| ExtraBeds              | string | ✅       | "EXTRA_BEDS"               |
| CancellationInfo       | string | ✅       | "CANCELLATION_INFO"        |
| Mealplans              | string | ✅       | "MEALPLANS"                |
| DealLastm              | string | ✅       | "DEAL_LASTM"               |
| PaymentTerms           | string | ✅       | "PAYMENT_TERMS"            |
| AllPrices              | string | ✅       | "ALL_PRICES"               |
| BlockPaymentOptions    | string | ✅       | "BLOCK_PAYMENT_OPTIONS"    |
| MaxChildrenFreeAge     | string | ✅       | "MAX_CHILDREN_FREE_AGE"    |
| NumberOfRoomsLeft      | string | ✅       | "NUMBER_OF_ROOMS_LEFT"     |
| MaxChildrenFree        | string | ✅       | "MAX_CHILDREN_FREE"        |
| Policies               | string | ✅       | "POLICIES"                 |
| PrepaymentInfo         | string | ✅       | "PREPAYMENT_INFO"          |
| DealFlash              | string | ✅       | "DEAL_FLASH"               |
| IfNoCcAllowed          | string | ✅       | "IF_NO_CC_ALLOWED"         |
| DealSmart              | string | ✅       | "DEAL_SMART"               |
| Addons                 | string | ✅       | "ADDONS"                   |
| AddressRequired        | string | ✅       | "ADDRESS_REQUIRED"         |

# BlockAvailabilityInputDtoLanguage

Specify the language for: block_id, policies, room texts and hotel descriptions. Note: not all text is translated in all languages. Please check the "Possible Values" section of the documentation for the accepted language codes.

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

# BlockAvailabilityInputDtoUserPlatform

The user's platform.

**Properties**

| Name    | Type   | Required | Description |
| :------ | :----- | :------- | :---------- |
| Android | string | ✅       | "ANDROID"   |
| Desktop | string | ✅       | "DESKTOP"   |
| Ios     | string | ✅       | "IOS"       |
| Mobile  | string | ✅       | "MOBILE"    |
| Tablet  | string | ✅       | "TABLET"    |

<!-- This file was generated by liblab | https://liblab.com/ -->
