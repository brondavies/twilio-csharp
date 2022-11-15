/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Preview
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



namespace Twilio.Rest.Preview.TrustedComms
{
    public class CpsResource : Resource
    {
    

        
        private static Request BuildFetchRequest(FetchCpsOptions options, ITwilioRestClient client)
        {
            
            string path = "/TrustedComms/CPS";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> Fetch a specific Call Placement Service (CPS) given a phone number via `X-XCNAM-Sensitive-Phone-Number` header. </summary>
        /// <param name="options"> Fetch Cps parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Cps </returns>
        public static CpsResource Fetch(FetchCpsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific Call Placement Service (CPS) given a phone number via `X-XCNAM-Sensitive-Phone-Number` header. </summary>
        /// <param name="options"> Fetch Cps parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Cps </returns>
        public static async System.Threading.Tasks.Task<CpsResource> FetchAsync(FetchCpsOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific Call Placement Service (CPS) given a phone number via `X-XCNAM-Sensitive-Phone-Number` header. </summary>
        /// <param name="xXcnamSensitivePhoneNumber"> Phone number used to retrieve its corresponding CPS. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Cps </returns>
        public static CpsResource Fetch(
                                         string xXcnamSensitivePhoneNumber = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchCpsOptions(){ XXcnamSensitivePhoneNumber = xXcnamSensitivePhoneNumber };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific Call Placement Service (CPS) given a phone number via `X-XCNAM-Sensitive-Phone-Number` header. </summary>
        /// <param name="xXcnamSensitivePhoneNumber"> Phone number used to retrieve its corresponding CPS. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Cps </returns>
        public static async System.Threading.Tasks.Task<CpsResource> FetchAsync(string xXcnamSensitivePhoneNumber = null, ITwilioRestClient client = null)
        {
            var options = new FetchCpsOptions(){ XXcnamSensitivePhoneNumber = xXcnamSensitivePhoneNumber };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a CpsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CpsResource object represented by the provided JSON </returns>
        public static CpsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<CpsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> CPS URL of the phone number. </summary> 
        [JsonProperty("cps_url")]
        public Uri CpsUrl { get; private set; }

        ///<summary> Phone number passed. </summary> 
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; private set; }

        ///<summary> The URL of this resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private CpsResource() {

        }
    }
}

