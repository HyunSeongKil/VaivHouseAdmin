namespace VaivHouseAdmin.Service
{
	public interface IApiGatewayService
	{
		Task<string> GetAsync(string uri);
	}
}
