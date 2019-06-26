/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Wireless.V1.Sim;

namespace Twilio.Tests.Rest.Wireless.V1.Sim
{

    [TestFixture]
    public class UsageRecordTest : TwilioTest
    {
        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Wireless,
                "/v1/Sims/DEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/UsageRecords",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                UsageRecordResource.Read("DEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"usage_records\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"commands\": {\"billing_units\": \"USD\",\"billed\": 0,\"total\": 3,\"from_sim\": 1,\"to_sim\": 2,\"home\": {\"billing_units\": \"USD\",\"billed\": 0,\"total\": 3,\"from_sim\": 1,\"to_sim\": 2},\"national_roaming\": {\"billing_units\": \"USD\",\"billed\": 0,\"total\": 0,\"from_sim\": 0,\"to_sim\": 0},\"international_roaming\": []},\"data\": {\"billing_units\": \"USD\",\"billed\": 0.35,\"total\": 3494609,\"upload\": 731560,\"download\": 2763049,\"units\": \"bytes\",\"home\": {\"billing_units\": \"USD\",\"billed\": 0.35,\"total\": 3494609,\"upload\": 731560,\"download\": 2763049,\"units\": \"bytes\"},\"national_roaming\": {\"billing_units\": \"USD\",\"billed\": 0,\"total\": 0,\"upload\": 0,\"download\": 0,\"units\": \"bytes\"},\"international_roaming\": []},\"sim_sid\": \"DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"period\": {\"start\": \"2015-07-30T20:00:00Z\",\"end\": \"2015-07-30T20:00:00Z\"}},{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"commands\": {},\"data\": {},\"sim_sid\": \"DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"period\": {}}],\"meta\": {\"first_page_url\": \"https://wireless.twilio.com/v1/Sims/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/UsageRecords?Start=2015-07-30T20%3A00%3A00Z&End=2015-07-30T20%3A00%3A00Z&PageSize=50&Page=0\",\"key\": \"usage_records\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://wireless.twilio.com/v1/Sims/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/UsageRecords?Start=2015-07-30T20%3A00%3A00Z&End=2015-07-30T20%3A00%3A00Z&PageSize=50&Page=0\"}}"
                                     ));

            var response = UsageRecordResource.Read("DEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}