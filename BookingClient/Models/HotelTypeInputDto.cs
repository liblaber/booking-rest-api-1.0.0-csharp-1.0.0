// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using BookingClient.Json;

namespace BookingClient.Models;

public record HotelTypeInputDto(
    /// <value>Limit the results to these hotel types.</value>
    [property:
        JsonPropertyName("hotel_type_ids"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<long>? HotelTypeIds = null,
    /// <value>
    /// Limit the results to these languages.
    /// Please check the "Possible Values" section of the documentation for the accepted language codes.
    /// </value>
    [property:
        JsonPropertyName("languages"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<HotelTypeInputDto.HotelTypeInputDtoLanguages>? Languages = null,
    /// <value>The number of rows to offset the results by. NOTE: this needs to be 0 or a multiple of 100.</value>
    [property:
        JsonPropertyName("offset"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Offset = null,
    /// <value>The maximum number of rows to return. NOTE: this needs to be a multiple of 100.</value>
    [property:
        JsonPropertyName("row"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Row = null
)
{
    /// <summary>
    /// Limit the results to these languages.
    /// Please check the "Possible Values" section of the documentation for the accepted language codes.
    /// </summary>
    public record HotelTypeInputDtoLanguages : ValueEnum<string>
    {
        internal HotelTypeInputDtoLanguages(string value)
            : base(value) { }

        public HotelTypeInputDtoLanguages()
            : base("AR") { }

        public static HotelTypeInputDtoLanguages Ar = new("AR");
        public static HotelTypeInputDtoLanguages Bg = new("BG");
        public static HotelTypeInputDtoLanguages Ca = new("CA");
        public static HotelTypeInputDtoLanguages Cs = new("CS");
        public static HotelTypeInputDtoLanguages Da = new("DA");
        public static HotelTypeInputDtoLanguages De = new("DE");
        public static HotelTypeInputDtoLanguages El = new("EL");
        public static HotelTypeInputDtoLanguages En = new("EN");
        public static HotelTypeInputDtoLanguages EnGb = new("EN_GB");
        public static HotelTypeInputDtoLanguages EnUs = new("EN_US");
        public static HotelTypeInputDtoLanguages Es = new("ES");
        public static HotelTypeInputDtoLanguages EsAr = new("ES_AR");
        public static HotelTypeInputDtoLanguages EsMx = new("ES_MX");
        public static HotelTypeInputDtoLanguages Et = new("ET");
        public static HotelTypeInputDtoLanguages Fi = new("FI");
        public static HotelTypeInputDtoLanguages Fr = new("FR");
        public static HotelTypeInputDtoLanguages He = new("HE");
        public static HotelTypeInputDtoLanguages Hi = new("HI");
        public static HotelTypeInputDtoLanguages Hr = new("HR");
        public static HotelTypeInputDtoLanguages Hu = new("HU");
        public static HotelTypeInputDtoLanguages Id = new("ID");
        public static HotelTypeInputDtoLanguages Is_ = new("IS");
        public static HotelTypeInputDtoLanguages It = new("IT");
        public static HotelTypeInputDtoLanguages Ja = new("JA");
        public static HotelTypeInputDtoLanguages Ka = new("KA");
        public static HotelTypeInputDtoLanguages Ko = new("KO");
        public static HotelTypeInputDtoLanguages Lt = new("LT");
        public static HotelTypeInputDtoLanguages Lv = new("LV");
        public static HotelTypeInputDtoLanguages Ms = new("MS");
        public static HotelTypeInputDtoLanguages Nl = new("NL");
        public static HotelTypeInputDtoLanguages No = new("NO");
        public static HotelTypeInputDtoLanguages Pl = new("PL");
        public static HotelTypeInputDtoLanguages PtBr = new("PT_BR");
        public static HotelTypeInputDtoLanguages PtPt = new("PT_PT");
        public static HotelTypeInputDtoLanguages Ro = new("RO");
        public static HotelTypeInputDtoLanguages Ru = new("RU");
        public static HotelTypeInputDtoLanguages Sk = new("SK");
        public static HotelTypeInputDtoLanguages Sl = new("SL");
        public static HotelTypeInputDtoLanguages Sr = new("SR");
        public static HotelTypeInputDtoLanguages Sv = new("SV");
        public static HotelTypeInputDtoLanguages Th = new("TH");
        public static HotelTypeInputDtoLanguages Tl = new("TL");
        public static HotelTypeInputDtoLanguages Tr = new("TR");
        public static HotelTypeInputDtoLanguages Uk = new("UK");
        public static HotelTypeInputDtoLanguages Vi = new("VI");
        public static HotelTypeInputDtoLanguages ZhCn = new("ZH_CN");
        public static HotelTypeInputDtoLanguages ZhTw = new("ZH_TW");
    }
}
