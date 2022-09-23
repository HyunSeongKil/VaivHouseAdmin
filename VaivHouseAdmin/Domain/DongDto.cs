using Newtonsoft.Json;

namespace VaivHouseAdmin.Domain
{
	public class DongDto
	{
		[JsonProperty("id")]
		public object Id { get; set; }

		[JsonProperty("registDt")]
		public DateTimeOffset RegistDt { get; set; }

		[JsonProperty("updtDt")]
		public DateTimeOffset UpdtDt { get; set; }

		[JsonProperty("dongId")]
		public long DongId { get; set; }

		[JsonProperty("dongNm")]
		public string DongNm { get; set; }

		[JsonProperty("lineCo")]
		public long LineCo { get; set; }

		[JsonProperty("hshdCo")]
		public long HshdCo { get; set; }

		[JsonProperty("slotPytpNms")]
		public string SlotPytpNms { get; set; }

		[JsonProperty("atchmnflGroupId")]
		public object AtchmnflGroupId { get; set; }

		[JsonProperty("slotId")]
		public object SlotId { get; set; }

		[JsonProperty("buildingId")]
		public object BuildingId { get; set; }

		[JsonProperty("slot")]
		public object Slot { get; set; }

		[JsonProperty("lines")]
		public IList<LineDto> Lines { get; set; }
	}
}
