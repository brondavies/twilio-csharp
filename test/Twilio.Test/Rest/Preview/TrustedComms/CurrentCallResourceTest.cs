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
using Twilio.Rest.Preview.TrustedComms;

namespace Twilio.Tests.Rest.Preview.TrustedComms
{

    [TestFixture]
    public class CurrentCallTest : TwilioTest
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Preview,
                "/TrustedComms/CurrentCall",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                CurrentCallResource.Fetch(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadFoundResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"from\": \"+1500123\",\"to\": \"+1500456\",\"status\": \"ringing\",\"reason\": \"Hello Jhon, your bank appointment has been confirmed.\",\"created_at\": \"2019-05-01T20:00:00Z\",\"caller\": \"Owl Bank\",\"logo\": \"https://www.twilio.com/marketing/bundles/company/img/logos/red/twilio-logo-red.png\",\"bg_color\": \"#fff\",\"font_color\": \"#f22f46\",\"use_case\": \"conversational\",\"manager\": \"Twilio\",\"shield_img\": \"https://www.twilio.com/marketing/bundles/company/img/badges/red/twilio-badge-red.png\",\"url\": \"https://preview.twilio.com/TrustedComms/CurrentCall\"}"
                                     ));

            var response = CurrentCallResource.Fetch(client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}