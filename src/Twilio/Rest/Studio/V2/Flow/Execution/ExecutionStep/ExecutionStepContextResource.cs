/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// ExecutionStepContextResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Studio.V2.Flow.Execution.ExecutionStep
{

    public class ExecutionStepContextResource : Resource
    {
        private static Request BuildFetchRequest(FetchExecutionStepContextOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                "/v2/Flows/" + options.PathFlowSid + "/Executions/" + options.PathExecutionSid + "/Steps/" + options.PathStepSid + "/Context",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve the context for an Execution Step.
        /// </summary>
        /// <param name="options"> Fetch ExecutionStepContext parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ExecutionStepContext </returns>
        public static ExecutionStepContextResource Fetch(FetchExecutionStepContextOptions options,
                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Retrieve the context for an Execution Step.
        /// </summary>
        /// <param name="options"> Fetch ExecutionStepContext parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ExecutionStepContext </returns>
        public static async System.Threading.Tasks.Task<ExecutionStepContextResource> FetchAsync(FetchExecutionStepContextOptions options,
                                                                                                 ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Retrieve the context for an Execution Step.
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        /// <param name="pathExecutionSid"> The SID of the Execution </param>
        /// <param name="pathStepSid"> Step SID </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ExecutionStepContext </returns>
        public static ExecutionStepContextResource Fetch(string pathFlowSid,
                                                         string pathExecutionSid,
                                                         string pathStepSid,
                                                         ITwilioRestClient client = null)
        {
            var options = new FetchExecutionStepContextOptions(pathFlowSid, pathExecutionSid, pathStepSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve the context for an Execution Step.
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        /// <param name="pathExecutionSid"> The SID of the Execution </param>
        /// <param name="pathStepSid"> Step SID </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ExecutionStepContext </returns>
        public static async System.Threading.Tasks.Task<ExecutionStepContextResource> FetchAsync(string pathFlowSid,
                                                                                                 string pathExecutionSid,
                                                                                                 string pathStepSid,
                                                                                                 ITwilioRestClient client = null)
        {
            var options = new FetchExecutionStepContextOptions(pathFlowSid, pathExecutionSid, pathStepSid);
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a ExecutionStepContextResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ExecutionStepContextResource object represented by the provided JSON </returns>
        public static ExecutionStepContextResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ExecutionStepContextResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The current state of the flow
        /// </summary>
        [JsonProperty("context")]
        public object Context { get; private set; }
        /// <summary>
        /// The SID of the Execution
        /// </summary>
        [JsonProperty("execution_sid")]
        public string ExecutionSid { get; private set; }
        /// <summary>
        /// The SID of the Flow
        /// </summary>
        [JsonProperty("flow_sid")]
        public string FlowSid { get; private set; }
        /// <summary>
        /// Step SID
        /// </summary>
        [JsonProperty("step_sid")]
        public string StepSid { get; private set; }
        /// <summary>
        /// The absolute URL of the resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private ExecutionStepContextResource()
        {

        }
    }

}