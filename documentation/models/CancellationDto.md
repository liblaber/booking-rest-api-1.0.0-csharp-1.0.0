# CancellationDto

The cancellation policy for this product.

**Properties**

| Name                  | Type   | Required | Description                                                      |
| :-------------------- | :----- | :------- | :--------------------------------------------------------------- |
| FreeCancellationUntil | string | ❌       | Until when the order for this product can be cancelled for free. |
| Type_1                | Type\_ | ❌       | The cancellation scheme supported by this product.               |

# Type\_

The cancellation scheme supported by this product.

**Properties**

| Name              | Type   | Required | Description          |
| :---------------- | :----- | :------- | :------------------- |
| FreeCancellation  | string | ✅       | "FREE_CANCELLATION"  |
| NonRefundable     | string | ✅       | "NON_REFUNDABLE"     |
| SpecialConditions | string | ✅       | "SPECIAL_CONDITIONS" |

<!-- This file was generated by liblab | https://liblab.com/ -->
