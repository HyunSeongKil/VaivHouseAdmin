using VaivHouseAdmin.Domain;

namespace VaivHouseAdmin.Service
{
	public interface IDstrcService
	{
		Task<IList<DstrcDto>> GetAll();

		Task<DstrcDto> GetByDstrcId(int dstrcId);
	}
}
