// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using BookingClient.Json;

namespace BookingClient.Models;

public record GetBlockAvailabilityAccept : ValueEnum<string>
{
    internal GetBlockAvailabilityAccept(string value)
        : base(value) { }

    public GetBlockAvailabilityAccept()
        : base("application/json, application/xml") { }

    public static GetBlockAvailabilityAccept ApplicationJsonApplicationXml =
        new("application/json, application/xml");
}
