using System.Dynamic;

namespace VaivHouseAdmin.Service
{
	public interface IPropertyService
	{
		void SetProfile(string profile);

		void SetPropertiesByProfile(string profile);


		object Get(string name);
	}
}
