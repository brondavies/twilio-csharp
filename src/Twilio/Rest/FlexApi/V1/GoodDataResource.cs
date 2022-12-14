/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Flex
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;



namespace Twilio.Rest.FlexApi.V1
{
    public class GoodDataResource : Resource
    {
    

        
        private static Request BuildCreateRequest(CreateGoodDataOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Insights/Session";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                path,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> To obtain session details for fetching reports and dashboards </summary>
        /// <param name="options"> Create GoodData parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of GoodData </returns>
        public static GoodDataResource Create(CreateGoodDataOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> To obtain session details for fetching reports and dashboards </summary>
        /// <param name="options"> Create GoodData parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of GoodData </returns>
        public static async System.Threading.Tasks.Task<GoodDataResource> CreateAsync(CreateGoodDataOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> To obtain session details for fetching reports and dashboards </summary>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of GoodData </returns>
        public static GoodDataResource Create(
                                          string token = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateGoodDataOptions(){  Token = token };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> To obtain session details for fetching reports and dashboards </summary>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of GoodData </returns>
        public static async System.Threading.Tasks.Task<GoodDataResource> CreateAsync(
                                                                                  string token = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateGoodDataOptions(){  Token = token };
            return await CreateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a GoodDataResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> GoodDataResource object represented by the provided JSON </returns>
        public static GoodDataResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<GoodDataResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> Unique ID to identify the user's workspace </summary> 
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; private set; }

        ///<summary> The session expiry date and time </summary> 
        [JsonProperty("session_expiry")]
        public string SessionExpiry { get; private set; }

        ///<summary> Unique session ID </summary> 
        [JsonProperty("session_id")]
        public string SessionId { get; private set; }

        ///<summary> Base URL to fetch reports and dashboards </summary> 
        [JsonProperty("base_url")]
        public string BaseUrl { get; private set; }

        ///<summary> The URL of this resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private GoodDataResource() {

        }
    }
}

