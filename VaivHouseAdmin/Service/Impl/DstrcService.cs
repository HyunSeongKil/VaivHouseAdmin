using System.Net.Http.Json;
using System.Text.Json;
using VaivHouseAdmin.Domain;
using VaivHouseAdmin.Shared;

namespace VaivHouseAdmin.Service.Impl
{
    public class DstrcService : IDstrcService
    {
        private readonly IPropertyService _propertyService;
        private readonly IApiGatewayService _apiGatewayService;

        private string _apiUrl;

        public DstrcService(IPropertyService propertyService, IApiGatewayService apiGatewayService)
        {
            _propertyService = propertyService;
            _apiGatewayService = apiGatewayService;

            _apiUrl = _propertyService.Get("apiUrl")+"";
		}

        public async Task<IList<DstrcDto>> GetAll()
        {
            //
            string jsonString = await _apiGatewayService.GetAsync($"{_apiUrl}/dstrcs");

			//
			CmmnResultMapDto<IList<DstrcDto>> resultMap = Util.Deserialize<CmmnResultMapDto<IList<DstrcDto>>>(jsonString);

            //
            if(null == resultMap)
            {
                return new List<DstrcDto>();
            }

            return resultMap.Data;
        }

        public async Task<DstrcDto> GetByDstrcId(int dstrcId)
        {
            //
            string jsonString = await _apiGatewayService.GetAsync($"{_apiUrl}/dstrcs/{dstrcId}");

            //
            CmmnResultMapDto<DstrcDto> resultMap = Util.Deserialize<CmmnResultMapDto<DstrcDto>>(jsonString);

            //
            if(null == resultMap)
            {
                return null;
            }

            //
            return resultMap.Data;
        }
    }
}
