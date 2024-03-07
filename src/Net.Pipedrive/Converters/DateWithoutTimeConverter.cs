using Newtonsoft.Json.Converters;

namespace Net.Pipedrive.Converters
{
    class DateWithoutTimeConverter : IsoDateTimeConverter
    {
        public DateWithoutTimeConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
