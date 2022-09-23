using Newtonsoft.Json;

namespace VaivHouseAdmin.Domain
{
	public class LineDto
	{
		[JsonProperty("id")]
		public object Id { get; set; }

		[JsonProperty("registDt")]
		public DateTimeOffset RegistDt { get; set; }

		[JsonProperty("updtDt")]
		public DateTimeOffset UpdtDt { get; set; }

		[JsonProperty("lineId")]
		public long LineId { get; set; }

		[JsonProperty("lineNm")]
		public string LineNm { get; set; }

		[JsonProperty("hshdCo")]
		public object HshdCo { get; set; }

		[JsonProperty("dongId")]
		public long DongId { get; set; }

		[JsonProperty("slotPytpId")]
		public object SlotPytpId { get; set; }

		[JsonProperty("aimCd")]
		public object AimCd { get; set; }

		[JsonProperty("aimCdNm")]
		public object AimCdNm { get; set; }

		[JsonProperty("dong")]
		public object Dong { get; set; }

		[JsonProperty("slotPytp")]
		public object SlotPytp { get; set; }

		[JsonProperty("inner3dId")]
		public object Inner3DId { get; set; }

		[JsonProperty("imageAtchmnflGroupId")]
		public object ImageAtchmnflGroupId { get; set; }

		[JsonProperty("allFloorCo")]
		public long AllFloorCo { get; set; }

		[JsonProperty("hgPerFloorValue")]
		public double HgPerFloorValue { get; set; }

		[JsonProperty("objectKeyValue")]
		public string ObjectKeyValue { get; set; }
	}
}
