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



namespace Twilio.Rest.FlexApi.V2
{
    public class WebChannelsResource : Resource
    {
    

        
        private static Request BuildCreateRequest(CreateWebChannelsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/WebChats";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create WebChannels parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WebChannels </returns>
        public static WebChannelsResource Create(CreateWebChannelsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create WebChannels parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WebChannels </returns>
        public static async System.Threading.Tasks.Task<WebChannelsResource> CreateAsync(CreateWebChannelsOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="addressSid"> The SID of the Conversations Address. See [Address Configuration Resource](https://www.twilio.com/docs/conversations/api/address-configuration-resource) for configuration details. When a conversation is created on the Flex backend, the callback URL will be set to the corresponding Studio Flow SID or webhook URL in your address configuration. </param>
        /// <param name="chatFriendlyName"> The Conversation's friendly name. See the [Conversation resource](https://www.twilio.com/docs/conversations/api/conversation-resource) for an example. </param>
        /// <param name="customerFriendlyName"> The Conversation participant's friendly name. See the [Conversation Participant Resource](https://www.twilio.com/docs/conversations/api/conversation-participant-resource) for an example. </param>
        /// <param name="preEngagementData"> The pre-engagement data. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WebChannels </returns>
        public static WebChannelsResource Create(
                                          string addressSid,
                                          string chatFriendlyName = null,
                                          string customerFriendlyName = null,
                                          string preEngagementData = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateWebChannelsOptions(addressSid){  ChatFriendlyName = chatFriendlyName, CustomerFriendlyName = customerFriendlyName, PreEngagementData = preEngagementData };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="addressSid"> The SID of the Conversations Address. See [Address Configuration Resource](https://www.twilio.com/docs/conversations/api/address-configuration-resource) for configuration details. When a conversation is created on the Flex backend, the callback URL will be set to the corresponding Studio Flow SID or webhook URL in your address configuration. </param>
        /// <param name="chatFriendlyName"> The Conversation's friendly name. See the [Conversation resource](https://www.twilio.com/docs/conversations/api/conversation-resource) for an example. </param>
        /// <param name="customerFriendlyName"> The Conversation participant's friendly name. See the [Conversation Participant Resource](https://www.twilio.com/docs/conversations/api/conversation-participant-resource) for an example. </param>
        /// <param name="preEngagementData"> The pre-engagement data. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WebChannels </returns>
        public static async System.Threading.Tasks.Task<WebChannelsResource> CreateAsync(
                                                                                  string addressSid,
                                                                                  string chatFriendlyName = null,
                                                                                  string customerFriendlyName = null,
                                                                                  string preEngagementData = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateWebChannelsOptions(addressSid){  ChatFriendlyName = chatFriendlyName, CustomerFriendlyName = customerFriendlyName, PreEngagementData = preEngagementData };
            return await CreateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a WebChannelsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WebChannelsResource object represented by the provided JSON </returns>
        public static WebChannelsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<WebChannelsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string representing the Conversation resource created </summary> 
        [JsonProperty("conversation_sid")]
        public string ConversationSid { get; private set; }

        ///<summary> The unique string representing the User created </summary> 
        [JsonProperty("identity")]
        public string Identity { get; private set; }



        private WebChannelsResource() {

        }
    }
}

