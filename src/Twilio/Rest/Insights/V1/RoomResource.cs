/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// RoomResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Insights.V1
{

    public class RoomResource : Resource
    {
        public sealed class RoomTypeEnum : StringEnum
        {
            private RoomTypeEnum(string value) : base(value) {}
            public RoomTypeEnum() {}
            public static implicit operator RoomTypeEnum(string value)
            {
                return new RoomTypeEnum(value);
            }

            public static readonly RoomTypeEnum Go = new RoomTypeEnum("go");
            public static readonly RoomTypeEnum PeerToPeer = new RoomTypeEnum("peer_to_peer");
            public static readonly RoomTypeEnum Group = new RoomTypeEnum("group");
            public static readonly RoomTypeEnum GroupSmall = new RoomTypeEnum("group_small");
        }

        public sealed class RoomStatusEnum : StringEnum
        {
            private RoomStatusEnum(string value) : base(value) {}
            public RoomStatusEnum() {}
            public static implicit operator RoomStatusEnum(string value)
            {
                return new RoomStatusEnum(value);
            }

            public static readonly RoomStatusEnum InProgress = new RoomStatusEnum("in_progress");
            public static readonly RoomStatusEnum Completed = new RoomStatusEnum("completed");
        }

        public sealed class CreatedMethodEnum : StringEnum
        {
            private CreatedMethodEnum(string value) : base(value) {}
            public CreatedMethodEnum() {}
            public static implicit operator CreatedMethodEnum(string value)
            {
                return new CreatedMethodEnum(value);
            }

            public static readonly CreatedMethodEnum Sdk = new CreatedMethodEnum("sdk");
            public static readonly CreatedMethodEnum AdHoc = new CreatedMethodEnum("ad_hoc");
            public static readonly CreatedMethodEnum Api = new CreatedMethodEnum("api");
        }

        public sealed class EndReasonEnum : StringEnum
        {
            private EndReasonEnum(string value) : base(value) {}
            public EndReasonEnum() {}
            public static implicit operator EndReasonEnum(string value)
            {
                return new EndReasonEnum(value);
            }

            public static readonly EndReasonEnum RoomEndedViaApi = new EndReasonEnum("room_ended_via_api");
            public static readonly EndReasonEnum Timeout = new EndReasonEnum("timeout");
        }

        public sealed class CodecEnum : StringEnum
        {
            private CodecEnum(string value) : base(value) {}
            public CodecEnum() {}
            public static implicit operator CodecEnum(string value)
            {
                return new CodecEnum(value);
            }

            public static readonly CodecEnum Vp8 = new CodecEnum("VP8");
            public static readonly CodecEnum H264 = new CodecEnum("H264");
            public static readonly CodecEnum Vp9 = new CodecEnum("VP9");
        }

        public sealed class TwilioRealmEnum : StringEnum
        {
            private TwilioRealmEnum(string value) : base(value) {}
            public TwilioRealmEnum() {}
            public static implicit operator TwilioRealmEnum(string value)
            {
                return new TwilioRealmEnum(value);
            }

            public static readonly TwilioRealmEnum Us1 = new TwilioRealmEnum("us1");
            public static readonly TwilioRealmEnum Us2 = new TwilioRealmEnum("us2");
            public static readonly TwilioRealmEnum Au1 = new TwilioRealmEnum("au1");
            public static readonly TwilioRealmEnum Br1 = new TwilioRealmEnum("br1");
            public static readonly TwilioRealmEnum Ie1 = new TwilioRealmEnum("ie1");
            public static readonly TwilioRealmEnum Jp1 = new TwilioRealmEnum("jp1");
            public static readonly TwilioRealmEnum Sg1 = new TwilioRealmEnum("sg1");
            public static readonly TwilioRealmEnum In1 = new TwilioRealmEnum("in1");
            public static readonly TwilioRealmEnum De1 = new TwilioRealmEnum("de1");
            public static readonly TwilioRealmEnum Gll = new TwilioRealmEnum("gll");
            public static readonly TwilioRealmEnum Outside = new TwilioRealmEnum("outside");
            public static readonly TwilioRealmEnum StageUs1 = new TwilioRealmEnum("stage_us1");
            public static readonly TwilioRealmEnum StageUs2 = new TwilioRealmEnum("stage_us2");
            public static readonly TwilioRealmEnum StageAu1 = new TwilioRealmEnum("stage_au1");
            public static readonly TwilioRealmEnum StageBr1 = new TwilioRealmEnum("stage_br1");
            public static readonly TwilioRealmEnum StageIe1 = new TwilioRealmEnum("stage_ie1");
            public static readonly TwilioRealmEnum StageJp1 = new TwilioRealmEnum("stage_jp1");
            public static readonly TwilioRealmEnum StageSg1 = new TwilioRealmEnum("stage_sg1");
            public static readonly TwilioRealmEnum StageIn1 = new TwilioRealmEnum("stage_in1");
            public static readonly TwilioRealmEnum StageDe1 = new TwilioRealmEnum("stage_de1");
            public static readonly TwilioRealmEnum DevUs1 = new TwilioRealmEnum("dev_us1");
            public static readonly TwilioRealmEnum DevUs2 = new TwilioRealmEnum("dev_us2");
        }

        public sealed class ProcessingStateEnum : StringEnum
        {
            private ProcessingStateEnum(string value) : base(value) {}
            public ProcessingStateEnum() {}
            public static implicit operator ProcessingStateEnum(string value)
            {
                return new ProcessingStateEnum(value);
            }

            public static readonly ProcessingStateEnum Complete = new ProcessingStateEnum("complete");
            public static readonly ProcessingStateEnum InProgress = new ProcessingStateEnum("in_progress");
        }

        public sealed class EdgeLocationEnum : StringEnum
        {
            private EdgeLocationEnum(string value) : base(value) {}
            public EdgeLocationEnum() {}
            public static implicit operator EdgeLocationEnum(string value)
            {
                return new EdgeLocationEnum(value);
            }

            public static readonly EdgeLocationEnum Ashburn = new EdgeLocationEnum("ashburn");
            public static readonly EdgeLocationEnum Dublin = new EdgeLocationEnum("dublin");
            public static readonly EdgeLocationEnum Frankfurt = new EdgeLocationEnum("frankfurt");
            public static readonly EdgeLocationEnum Singapore = new EdgeLocationEnum("singapore");
            public static readonly EdgeLocationEnum Sydney = new EdgeLocationEnum("sydney");
            public static readonly EdgeLocationEnum SaoPaulo = new EdgeLocationEnum("sao_paulo");
            public static readonly EdgeLocationEnum Roaming = new EdgeLocationEnum("roaming");
            public static readonly EdgeLocationEnum Umatilla = new EdgeLocationEnum("umatilla");
            public static readonly EdgeLocationEnum Tokyo = new EdgeLocationEnum("tokyo");
        }

        private static Request BuildFetchRequest(FetchRoomOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Insights,
                "/v1/Video/Rooms/" + options.PathRoomSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns>
        public static RoomResource Fetch(FetchRoomOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns>
        public static async System.Threading.Tasks.Task<RoomResource> FetchAsync(FetchRoomOptions options,
                                                                                 ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathRoomSid"> The room_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns>
        public static RoomResource Fetch(string pathRoomSid, ITwilioRestClient client = null)
        {
            var options = new FetchRoomOptions(pathRoomSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathRoomSid"> The room_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns>
        public static async System.Threading.Tasks.Task<RoomResource> FetchAsync(string pathRoomSid,
                                                                                 ITwilioRestClient client = null)
        {
            var options = new FetchRoomOptions(pathRoomSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadRoomOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Insights,
                "/v1/Video/Rooms",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns>
        public static ResourceSet<RoomResource> Read(ReadRoomOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<RoomResource>.FromJson("rooms", response.Content);
            return new ResourceSet<RoomResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<RoomResource>> ReadAsync(ReadRoomOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<RoomResource>.FromJson("rooms", response.Content);
            return new ResourceSet<RoomResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="roomType"> The room_type </param>
        /// <param name="codec"> The codec </param>
        /// <param name="roomName"> The room_name </param>
        /// <param name="createdAfter"> The created_after </param>
        /// <param name="createdBefore"> The created_before </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns>
        public static ResourceSet<RoomResource> Read(List<RoomResource.RoomTypeEnum> roomType = null,
                                                     List<RoomResource.CodecEnum> codec = null,
                                                     string roomName = null,
                                                     DateTime? createdAfter = null,
                                                     DateTime? createdBefore = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadRoomOptions(){RoomType = roomType, Codec = codec, RoomName = roomName, CreatedAfter = createdAfter, CreatedBefore = createdBefore, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="roomType"> The room_type </param>
        /// <param name="codec"> The codec </param>
        /// <param name="roomName"> The room_name </param>
        /// <param name="createdAfter"> The created_after </param>
        /// <param name="createdBefore"> The created_before </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<RoomResource>> ReadAsync(List<RoomResource.RoomTypeEnum> roomType = null,
                                                                                             List<RoomResource.CodecEnum> codec = null,
                                                                                             string roomName = null,
                                                                                             DateTime? createdAfter = null,
                                                                                             DateTime? createdBefore = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadRoomOptions(){RoomType = roomType, Codec = codec, RoomName = roomName, CreatedAfter = createdAfter, CreatedBefore = createdBefore, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<RoomResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<RoomResource>.FromJson("rooms", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<RoomResource> NextPage(Page<RoomResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Insights)
            );

            var response = client.Request(request);
            return Page<RoomResource>.FromJson("rooms", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<RoomResource> PreviousPage(Page<RoomResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Insights)
            );

            var response = client.Request(request);
            return Page<RoomResource>.FromJson("rooms", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a RoomResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> RoomResource object represented by the provided JSON </returns>
        public static RoomResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<RoomResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The room_sid
        /// </summary>
        [JsonProperty("room_sid")]
        public string RoomSid { get; private set; }
        /// <summary>
        /// The room_name
        /// </summary>
        [JsonProperty("room_name")]
        public string RoomName { get; private set; }
        /// <summary>
        /// The create_time
        /// </summary>
        [JsonProperty("create_time")]
        public DateTime? CreateTime { get; private set; }
        /// <summary>
        /// The end_time
        /// </summary>
        [JsonProperty("end_time")]
        public DateTime? EndTime { get; private set; }
        /// <summary>
        /// The room_type
        /// </summary>
        [JsonProperty("room_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RoomResource.RoomTypeEnum RoomType { get; private set; }
        /// <summary>
        /// The room_status
        /// </summary>
        [JsonProperty("room_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RoomResource.RoomStatusEnum RoomStatus { get; private set; }
        /// <summary>
        /// The status_callback
        /// </summary>
        [JsonProperty("status_callback")]
        public Uri StatusCallback { get; private set; }
        /// <summary>
        /// The status_callback_method
        /// </summary>
        [JsonProperty("status_callback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; private set; }
        /// <summary>
        /// The created_method
        /// </summary>
        [JsonProperty("created_method")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RoomResource.CreatedMethodEnum CreatedMethod { get; private set; }
        /// <summary>
        /// The end_reason
        /// </summary>
        [JsonProperty("end_reason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RoomResource.EndReasonEnum EndReason { get; private set; }
        /// <summary>
        /// The max_participants
        /// </summary>
        [JsonProperty("max_participants")]
        public int? MaxParticipants { get; private set; }
        /// <summary>
        /// The unique_participants
        /// </summary>
        [JsonProperty("unique_participants")]
        public int? UniqueParticipants { get; private set; }
        /// <summary>
        /// The unique_participant_identities
        /// </summary>
        [JsonProperty("unique_participant_identities")]
        public int? UniqueParticipantIdentities { get; private set; }
        /// <summary>
        /// The concurrent_participants
        /// </summary>
        [JsonProperty("concurrent_participants")]
        public int? ConcurrentParticipants { get; private set; }
        /// <summary>
        /// The max_concurrent_participants
        /// </summary>
        [JsonProperty("max_concurrent_participants")]
        public int? MaxConcurrentParticipants { get; private set; }
        /// <summary>
        /// The codecs
        /// </summary>
        [JsonProperty("codecs")]
        [JsonConverter(typeof(StringEnumConverter))]
        public List<RoomResource.CodecEnum> Codecs { get; private set; }
        /// <summary>
        /// The media_region
        /// </summary>
        [JsonProperty("media_region")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RoomResource.TwilioRealmEnum MediaRegion { get; private set; }
        /// <summary>
        /// The duration_sec
        /// </summary>
        [JsonProperty("duration_sec")]
        public long? DurationSec { get; private set; }
        /// <summary>
        /// The total_participant_duration_sec
        /// </summary>
        [JsonProperty("total_participant_duration_sec")]
        public long? TotalParticipantDurationSec { get; private set; }
        /// <summary>
        /// The total_recording_duration_sec
        /// </summary>
        [JsonProperty("total_recording_duration_sec")]
        public long? TotalRecordingDurationSec { get; private set; }
        /// <summary>
        /// The processing_state
        /// </summary>
        [JsonProperty("processing_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RoomResource.ProcessingStateEnum ProcessingState { get; private set; }
        /// <summary>
        /// The recording_enabled
        /// </summary>
        [JsonProperty("recording_enabled")]
        public bool? RecordingEnabled { get; private set; }
        /// <summary>
        /// The edge_location
        /// </summary>
        [JsonProperty("edge_location")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RoomResource.EdgeLocationEnum EdgeLocation { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private RoomResource()
        {

        }
    }

}