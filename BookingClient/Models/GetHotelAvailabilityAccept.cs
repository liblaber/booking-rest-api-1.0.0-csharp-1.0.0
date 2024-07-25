// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using BookingClient.Json;

namespace BookingClient.Models;

public record GetHotelAvailabilityAccept : ValueEnum<string>
{
    internal GetHotelAvailabilityAccept(string value)
        : base(value) { }

    public GetHotelAvailabilityAccept()
        : base("application/json") { }

    public static GetHotelAvailabilityAccept ApplicationJson = new("application/json");
}
