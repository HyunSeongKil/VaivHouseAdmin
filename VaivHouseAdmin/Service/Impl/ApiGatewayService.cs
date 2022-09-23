
using Microsoft.AspNetCore.Components;

namespace VaivHouseAdmin.Service.Impl
{
	public class ApiGatewayService : IApiGatewayService
	{
		private HttpClient _httpClient;

		public ApiGatewayService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public Task<string> GetAsync(string uri)
		{
			return _httpClient.GetStringAsync(uri);
		}
	}
}
