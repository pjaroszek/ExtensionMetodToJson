namespace Jaroszek.ProofOfConcept.ExtensionMetodToJson
{
    using System.Text.Json;

    public static class JsonDocumentExtensions
    {
        public static T FromJson<T>(this string input) where T : IToJson
        {
            return JsonSerializer.Deserialize<T>(input);
        }

        public static string ToJson<T>(this T source) where T : IToJson
        {
            return JsonSerializer.Serialize(source);
        }
    }
}