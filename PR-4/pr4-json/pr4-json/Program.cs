using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using ConsoleApp;

var person = new Person
{
    Title = "Introduction to Quantum Computing",
    Duration = 90,
    Start = new DateTime(2024, 11, 10, 09, 00, 0),

    Title1 = "AI Ethics in Modern World",
    Duration1 = 60,
    Start1 = new DateTime(2024, 11, 10, 11, 00, 0)

};

var jsonString = JsonSerializer.Serialize(person);
Console.WriteLine($"Person: {jsonString}");

var deserializedPerson = JsonSerializer.Deserialize<Person>(jsonString);
if (deserializedPerson == null)
    throw new NullReferenceException("Person could not be deserialized");

Console.WriteLine($"Title: {deserializedPerson.Title}, " +
                  $"Duration: {deserializedPerson.Duration * 60}, " +
                  $"Start: {deserializedPerson.Start:dd - MM - yyyy HH: mm: ss}");
Console.WriteLine($"Title1: {deserializedPerson.Title1}, " +
                  $"Duration1: {deserializedPerson.Duration1 * 60}, " +
                  $"Start1: {deserializedPerson.Start1:dd - MM - yyyy HH: mm: ss}");


namespace ConsoleApp
{
    internal class Person
    {
        public string Title { get; init; } = null!;
        public int Duration { get; init; }
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime Start { get; set; }
        public string Title1 { get; init; } = null!;
        public int Duration1 { get; init; }
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime Start1 { get; set; }
    }
    internal class CustomDateTimeConverter : JsonConverter<DateTime>
    {
        private const string Format = "MM-dd-yy";

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var dateString = reader.GetString();
            return DateTime.ParseExact(dateString!, Format, CultureInfo.InvariantCulture);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(Format, CultureInfo.InvariantCulture));
        }
    }
}