using System.Text.Json;
using VaivHouseAdmin.Domain;

namespace VaivHouseAdmin.Shared
{
	public class Util
	{
		public static T Deserialize<T>(string jsonString)
		{
			return JsonSerializer.Deserialize<T>(jsonString, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
		}
	}
}
