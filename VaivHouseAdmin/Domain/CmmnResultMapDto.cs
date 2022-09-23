using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace VaivHouseAdmin.Domain
{
	public class CmmnResultMapDto<T>
	{
		public T Data { get; set; }

	}
}
