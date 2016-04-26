using NSubstitute;
using NUnit.Framework;
using System;
using Twilio;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Resources.Pricing.V1.Voice;

namespace Twilio.Tests.Pricing.V1.Voice {

    [TestFixture]
    public class NumberTest : TwilioTest {
        [SetUp]
        public void SetUp() {
        }
    
        [Test]
        public void TestFetchResponse() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(System.Threading.Tasks.Task.FromResult(
                                new Response(System.Net.HttpStatusCode.OK,
                                             "{\"country\": \"United States\",\"inbound_call_price\": {\"base_price\": null,\"current_price\": null,\"number_type\": null},\"iso_country\": \"US\",\"number\": \"+987654321\",\"outbound_call_price\": {\"base_price\": \"0.015\",\"current_price\": \"0.015\"},\"price_unit\": \"USD\",\"url\": \"https://pricing.twilio.com/v1/Voice/Numbers/+987654321\"}")));
            
            var task = NumberResource.Fetch(new Twilio.Types.PhoneNumber("+987654321")).ExecuteAsync(twilioRestClient);
            task.Wait();
            Assert.NotNull(task.Result);
        }
    }
}