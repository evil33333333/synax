using System;
using Newtonsoft.Json;

namespace Synax.Models
{
	// Token: 0x02000023 RID: 35
	public class GeoLocation
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00007614 File Offset: 0x00007614
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0000761C File Offset: 0x0000761C
		[JsonProperty("ip")]
		public string Ip { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00007625 File Offset: 0x00007625
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000762D File Offset: 0x0000762D
		[JsonProperty("success")]
		public bool Success { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00007636 File Offset: 0x00007636
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0000763E File Offset: 0x0000763E
		[JsonProperty("type")]
		public string Type { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00007647 File Offset: 0x00007647
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0000764F File Offset: 0x0000764F
		[JsonProperty("continent")]
		public string Continent { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00007658 File Offset: 0x00007658
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00007660 File Offset: 0x00007660
		[JsonProperty("continent_code")]
		public string ContinentCode { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00007669 File Offset: 0x00007669
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00007671 File Offset: 0x00007671
		[JsonProperty("country")]
		public string Country { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000767A File Offset: 0x0000767A
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00007682 File Offset: 0x00007682
		[JsonProperty("country_code")]
		public string CountryCode { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000768B File Offset: 0x0000768B
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00007693 File Offset: 0x00007693
		[JsonProperty("country_flag")]
		public Uri CountryFlag { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0000769C File Offset: 0x0000769C
		// (set) Token: 0x0600011C RID: 284 RVA: 0x000076A4 File Offset: 0x000076A4
		[JsonProperty("country_capital")]
		public string CountryCapital { get; set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600011D RID: 285 RVA: 0x000076AD File Offset: 0x000076AD
		// (set) Token: 0x0600011E RID: 286 RVA: 0x000076B5 File Offset: 0x000076B5
		[JsonProperty("country_phone")]
		public string CountryPhone { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600011F RID: 287 RVA: 0x000076BE File Offset: 0x000076BE
		// (set) Token: 0x06000120 RID: 288 RVA: 0x000076C6 File Offset: 0x000076C6
		[JsonProperty("country_neighbours")]
		public string CountryNeighbours { get; set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000121 RID: 289 RVA: 0x000076CF File Offset: 0x000076CF
		// (set) Token: 0x06000122 RID: 290 RVA: 0x000076D7 File Offset: 0x000076D7
		[JsonProperty("region")]
		public string Region { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000123 RID: 291 RVA: 0x000076E0 File Offset: 0x000076E0
		// (set) Token: 0x06000124 RID: 292 RVA: 0x000076E8 File Offset: 0x000076E8
		[JsonProperty("city")]
		public string City { get; set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000125 RID: 293 RVA: 0x000076F1 File Offset: 0x000076F1
		// (set) Token: 0x06000126 RID: 294 RVA: 0x000076F9 File Offset: 0x000076F9
		[JsonProperty("latitude")]
		public double Latitude { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00007702 File Offset: 0x00007702
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0000770A File Offset: 0x0000770A
		[JsonProperty("longitude")]
		public double Longitude { get; set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00007713 File Offset: 0x00007713
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000771B File Offset: 0x0000771B
		[JsonProperty("asn")]
		public string Asn { get; set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00007724 File Offset: 0x00007724
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000772C File Offset: 0x0000772C
		[JsonProperty("org")]
		public string Org { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00007735 File Offset: 0x00007735
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0000773D File Offset: 0x0000773D
		[JsonProperty("isp")]
		public string Isp { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00007746 File Offset: 0x00007746
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0000774E File Offset: 0x0000774E
		[JsonProperty("timezone")]
		public string Timezone { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00007757 File Offset: 0x00007757
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0000775F File Offset: 0x0000775F
		[JsonProperty("timezone_name")]
		public string TimezoneName { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00007768 File Offset: 0x00007768
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00007770 File Offset: 0x00007770
		[JsonProperty("timezone_dstOffset")]
		public long TimezoneDstOffset { get; set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00007779 File Offset: 0x00007779
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00007781 File Offset: 0x00007781
		[JsonProperty("timezone_gmtOffset")]
		public long TimezoneGmtOffset { get; set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000778A File Offset: 0x0000778A
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00007792 File Offset: 0x00007792
		[JsonProperty("timezone_gmt")]
		public string TimezoneGmt { get; set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000779B File Offset: 0x0000779B
		// (set) Token: 0x0600013A RID: 314 RVA: 0x000077A3 File Offset: 0x000077A3
		[JsonProperty("currency")]
		public string Currency { get; set; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600013B RID: 315 RVA: 0x000077AC File Offset: 0x000077AC
		// (set) Token: 0x0600013C RID: 316 RVA: 0x000077B4 File Offset: 0x000077B4
		[JsonProperty("currency_code")]
		public string CurrencyCode { get; set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000077BD File Offset: 0x000077BD
		// (set) Token: 0x0600013E RID: 318 RVA: 0x000077C5 File Offset: 0x000077C5
		[JsonProperty("currency_symbol")]
		public string CurrencySymbol { get; set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600013F RID: 319 RVA: 0x000077CE File Offset: 0x000077CE
		// (set) Token: 0x06000140 RID: 320 RVA: 0x000077D6 File Offset: 0x000077D6
		[JsonProperty("currency_rates")]
		public double CurrencyRates { get; set; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000077DF File Offset: 0x000077DF
		// (set) Token: 0x06000142 RID: 322 RVA: 0x000077E7 File Offset: 0x000077E7
		[JsonProperty("currency_plural")]
		public string CurrencyPlural { get; set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000077F0 File Offset: 0x000077F0
		// (set) Token: 0x06000144 RID: 324 RVA: 0x000077F8 File Offset: 0x000077F8
		[JsonProperty("completed_requests")]
		public long CompletedRequests { get; set; }
	}
}
