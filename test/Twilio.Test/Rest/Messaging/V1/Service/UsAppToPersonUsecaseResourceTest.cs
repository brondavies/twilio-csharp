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
using Twilio.Rest.Messaging.V1.Service;

namespace Twilio.Tests.Rest.Messaging.V1.Service
{

    [TestFixture]
    public class UsAppToPersonUsecaseTest : TwilioTest
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Messaging,
                "/v1/Services/MGXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Compliance/Usa2p/Usecases",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                UsAppToPersonUsecaseResource.Fetch("MGXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchWithBrandRegistrationSidResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"us_app_to_person_usecases\": [{\"code\": \"2FA\",\"name\": \"Two-Factor authentication (2FA)\",\"description\": \"Two-Factor authentication, one-time use password, password reset\"},{\"code\": \"ACCOUNT_NOTIFICATION\",\"name\": \"Account Notification\",\"description\": \"All reminders, alerts, and notifications. (Examples include: flight delayed, hotel booked, appointment reminders.)\"},{\"code\": \"AGENTS_FRANCHISES\",\"name\": \"Agents and Franchises\",\"description\": \"For brands that have multiple agents, franchises or offices in the same brand vertical, but require individual localised numbers per agent/location/office.\"},{\"code\": \"CHARITY\",\"name\": \"Charity\",\"description\": \"Includes:5013C Charity\\nDoes not include: Religious organizations\"},{\"code\": \"CONVERSATIONAL\",\"name\": \"Conversational Messaging\",\"description\": \"Peer-to-peer app-based group messaging with proxy/pooled numbers (For example: GroupMe)\\nSupporting personalized services and non-exposure of personal numbers for enterprise or A2P communications. (Examples include: Uber and AirBnb.)\"},{\"code\": \"CUSTOMER_CARE\",\"name\": \"Customer Care\",\"description\": \"All customer care messaging, including account management and support\"},{\"code\": \"DELIVERY_NOTIFICATION\",\"name\": \"Delivery Notification\",\"description\": \"Information about the status of the delivery of a product or service\"},{\"code\": \"EMERGENCY\",\"name\": \"Emergency\",\"description\": \"Notification services designed to support public safety / health during natural disasters, armed conflicts, pandemics and other national or regional emergencies\"},{\"code\": \"FRAUD_ALERT\",\"name\": \"Fraud Alert Messaging\",\"description\": \"Fraud alert notification\"},{\"code\": \"HIGHER_EDUCATION\",\"name\": \"Higher Education\",\"description\": \"For campaigns created on behalf of Colleges or Universities and will also include School Districts etc that fall outside of any \\\"free to the consumer\\\" messaging model\"},{\"code\": \"LOW_VOLUME\",\"name\": \"Low Volume Mixed\",\"description\": \"Low throughput, any combination of use-cases. Examples include:test, demo accounts\"},{\"code\": \"MARKETING\",\"name\": \"Marketing\",\"description\": \"Any communication with marketing and/or promotional content\"},{\"code\": \"MIXED\",\"name\": \"Mixed\",\"description\": \"Mixed messaging reserved for specific consumer service industry\"},{\"code\": \"POLLING_VOTING\",\"name\": \"Polling and voting\",\"description\": \"Polling and voting\"},{\"code\": \"PUBLIC_SERVICE_ANNOUNCEMENT\",\"name\": \"Public Service Announcement\",\"description\": \"An informational message that is meant to raise the audience awareness about an important issue\"},{\"code\": \"SECURITY_ALERT\",\"name\": \"Security Alert\",\"description\": \"A notification that the security of a system, either software or hardware, has been compromised in some way and there is an action you need to take\"},{\"code\": \"SOCIAL\",\"name\": \"Social\",\"description\": \"Communication within or between closed communities (For example: influencers alerts)\"},{\"code\": \"SWEEPSTAKE\",\"name\": \"Sweepstake\",\"description\": \"Sweepstake\"}]}"
                                     ));

            var response = UsAppToPersonUsecaseResource.Fetch("MGXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchWithoutBrandRegistrationSidResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"us_app_to_person_usecases\": [{\"code\": \"2FA\",\"name\": \"Two-Factor authentication (2FA)\",\"description\": \"Two-Factor authentication, one-time use password, password reset\"},{\"code\": \"ACCOUNT_NOTIFICATION\",\"name\": \"Account Notification\",\"description\": \"All reminders, alerts, and notifications. (Examples include: flight delayed, hotel booked, appointment reminders.)\"},{\"code\": \"AGENTS_FRANCHISES\",\"name\": \"Agents and Franchises\",\"description\": \"For brands that have multiple agents, franchises or offices in the same brand vertical, but require individual localised numbers per agent/location/office.\"},{\"code\": \"CHARITY\",\"name\": \"Charity\",\"description\": \"Includes:5013C Charity\\nDoes not include: Religious organizations\"},{\"code\": \"CONVERSATIONAL\",\"name\": \"Conversational Messaging\",\"description\": \"Peer-to-peer app-based group messaging with proxy/pooled numbers (For example: GroupMe)\\nSupporting personalized services and non-exposure of personal numbers for enterprise or A2P communications. (Examples include: Uber and AirBnb.)\"},{\"code\": \"CUSTOMER_CARE\",\"name\": \"Customer Care\",\"description\": \"All customer care messaging, including account management and support\"},{\"code\": \"DELIVERY_NOTIFICATION\",\"name\": \"Delivery Notification\",\"description\": \"Information about the status of the delivery of a product or service\"},{\"code\": \"EMERGENCY\",\"name\": \"Emergency\",\"description\": \"Notification services designed to support public safety / health during natural disasters, armed conflicts, pandemics and other national or regional emergencies\"},{\"code\": \"FRAUD_ALERT\",\"name\": \"Fraud Alert Messaging\",\"description\": \"Fraud alert notification\"},{\"code\": \"HIGHER_EDUCATION\",\"name\": \"Higher Education\",\"description\": \"For campaigns created on behalf of Colleges or Universities and will also include School Districts etc that fall outside of any \\\"free to the consumer\\\" messaging model\"},{\"code\": \"LOW_VOLUME\",\"name\": \"Low Volume Mixed\",\"description\": \"Low throughput, any combination of use-cases. Examples include:test, demo accounts\"},{\"code\": \"MARKETING\",\"name\": \"Marketing\",\"description\": \"Any communication with marketing and/or promotional content\"},{\"code\": \"MIXED\",\"name\": \"Mixed\",\"description\": \"Mixed messaging reserved for specific consumer service industry\"},{\"code\": \"POLLING_VOTING\",\"name\": \"Polling and voting\",\"description\": \"Polling and voting\"},{\"code\": \"PUBLIC_SERVICE_ANNOUNCEMENT\",\"name\": \"Public Service Announcement\",\"description\": \"An informational message that is meant to raise the audience awareness about an important issue\"},{\"code\": \"SECURITY_ALERT\",\"name\": \"Security Alert\",\"description\": \"A notification that the security of a system, either software or hardware, has been compromised in some way and there is an action you need to take\"},{\"code\": \"SOCIAL\",\"name\": \"Social\",\"description\": \"Communication within or between closed communities (For example: influencers alerts)\"},{\"code\": \"SWEEPSTAKE\",\"name\": \"Sweepstake\",\"description\": \"Sweepstake\"}]}"
                                     ));

            var response = UsAppToPersonUsecaseResource.Fetch("MGXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}