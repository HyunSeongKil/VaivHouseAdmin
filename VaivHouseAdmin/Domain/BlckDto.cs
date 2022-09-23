using Newtonsoft.Json;

namespace VaivHouseAdmin.Domain
{
	public class BlckDto
	{
		[JsonProperty("dstrcBlckId")]
		public long DstrcBlckId { get; set; }

		[JsonProperty("dstrcId")]
		public long DstrcId { get; set; }

		[JsonProperty("dstrcBlckNm")]
		public string DstrcBlckNm { get; set; }

		[JsonProperty("dstrcBlckDc")]
		public string DstrcBlckDc { get; set; }

		[JsonProperty("referUrl")]
		public object ReferUrl { get; set; }

		[JsonProperty("atchmnflGroupId")]
		public long AtchmnflGroupId { get; set; }

		[JsonProperty("plotArValue")]
		public long PlotArValue { get; set; }

		[JsonProperty("plotLcNm")]
		public string PlotLcNm { get; set; }

		[JsonProperty("hshldCo")]
		public long HshldCo { get; set; }

		[JsonProperty("measrmtRateValue")]
		public long MeasrmtRateValue { get; set; }

		[JsonProperty("bdtldrValue")]
		public long BdtldrValue { get; set; }

		[JsonProperty("lotPrposNm")]
		public string LotPrposNm { get; set; }

		[JsonProperty("mxmmFloorCo")]
		public long MxmmFloorCo { get; set; }

		[JsonProperty("lttotTyNm")]
		public string LttotTyNm { get; set; }

		[JsonProperty("bildngArValue")]
		public double BildngArValue { get; set; }

		[JsonProperty("totarValue")]
		public double TotarValue { get; set; }

		[JsonProperty("objectKeyValue")]
		public long ObjectKeyValue { get; set; }

		[JsonProperty("registDt")]
		public DateTimeOffset RegistDt { get; set; }

		[JsonProperty("updtDt")]
		public DateTimeOffset UpdtDt { get; set; }

		[JsonProperty("dongs")]
		public IList<DongDto> Dongs { get; set; }
	}
}
