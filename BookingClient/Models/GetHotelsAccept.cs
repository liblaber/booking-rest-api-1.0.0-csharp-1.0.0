// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using BookingClient.Json;

namespace BookingClient.Models;

public record GetHotelsAccept : ValueEnum<string>
{
    internal GetHotelsAccept(string value)
        : base(value) { }

    public GetHotelsAccept()
        : base("application/json, application/xml") { }

    public static GetHotelsAccept ApplicationJsonApplicationXml =
        new("application/json, application/xml");
}
