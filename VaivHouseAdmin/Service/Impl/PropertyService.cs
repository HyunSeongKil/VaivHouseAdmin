using System.Text.Json;

namespace VaivHouseAdmin.Service.Impl
{
	public class PropertyService : IPropertyService
	{
		private string _profile = "local";
		private readonly HttpClient _httpClient;

		private IDictionary<string,object> _dic = new Dictionary<string,object>();



		public PropertyService(HttpClient httpClient)
		{
			_httpClient = httpClient;
			SetPropertiesByProfile(_profile);
		}

		public object Get(string name)
		{			
			if (_dic.TryGetValue(name, out var value))
			{
				return value;
			}

			return null;
		}

		public void SetProfile(string profile)
		{
			_profile = profile;
		}

		public async void SetPropertiesByProfile(string profile)
		{
			string jsonString = await _httpClient.GetStringAsync("properties.json");

			IDictionary<string, IDictionary<string, object>>? dic = JsonSerializer.Deserialize<IDictionary<string, IDictionary<string, object>>>(jsonString);
			_dic = dic![profile];
		}
	}
}
