/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Insights.V1
{

    /// <summary>
    /// Fetch a specific Conference.
    /// </summary>
    public class FetchConferenceOptions : IOptions<ConferenceResource>
    {
        /// <summary>
        /// Conference SID.
        /// </summary>
        public string PathConferenceSid { get; }

        /// <summary>
        /// Construct a new FetchConferenceOptions
        /// </summary>
        /// <param name="pathConferenceSid"> Conference SID. </param>
        public FetchConferenceOptions(string pathConferenceSid)
        {
            PathConferenceSid = pathConferenceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Retrieve a list of Conferences.
    /// </summary>
    public class ReadConferenceOptions : ReadOptions<ConferenceResource>
    {
        /// <summary>
        /// The SID of the conference.
        /// </summary>
        public string ConferenceSid { get; set; }
        /// <summary>
        /// Custom label for the conference.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// Conference status.
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Conferences created after timestamp.
        /// </summary>
        public string CreatedAfter { get; set; }
        /// <summary>
        /// Conferences created before timestamp.
        /// </summary>
        public string CreatedBefore { get; set; }
        /// <summary>
        /// Region where the conference was mixed.
        /// </summary>
        public string MixerRegion { get; set; }
        /// <summary>
        /// Tags applied by Twilio for common issues.
        /// </summary>
        public string Tags { get; set; }
        /// <summary>
        /// Account SID for the subaccount.
        /// </summary>
        public string Subaccount { get; set; }
        /// <summary>
        /// Potential issues detected during the conference.
        /// </summary>
        public string DetectedIssues { get; set; }
        /// <summary>
        /// Conference end reason.
        /// </summary>
        public string EndReason { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (ConferenceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceSid", ConferenceSid));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status));
            }

            if (CreatedAfter != null)
            {
                p.Add(new KeyValuePair<string, string>("CreatedAfter", CreatedAfter));
            }

            if (CreatedBefore != null)
            {
                p.Add(new KeyValuePair<string, string>("CreatedBefore", CreatedBefore));
            }

            if (MixerRegion != null)
            {
                p.Add(new KeyValuePair<string, string>("MixerRegion", MixerRegion));
            }

            if (Tags != null)
            {
                p.Add(new KeyValuePair<string, string>("Tags", Tags));
            }

            if (Subaccount != null)
            {
                p.Add(new KeyValuePair<string, string>("Subaccount", Subaccount.ToString()));
            }

            if (DetectedIssues != null)
            {
                p.Add(new KeyValuePair<string, string>("DetectedIssues", DetectedIssues));
            }

            if (EndReason != null)
            {
                p.Add(new KeyValuePair<string, string>("EndReason", EndReason));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}