/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Twilio.Types;

namespace Twilio.TwiML.Voice
{

    /// <summary>
    /// Using Phonetic Pronunciation in Say
    /// </summary>
    public class SsmlPhoneme : TwiML
    {
        public sealed class AlphabetEnum : StringEnum
        {
            private AlphabetEnum(string value) : base(value) {}
            public AlphabetEnum() {}
            public static implicit operator AlphabetEnum(string value)
            {
                return new AlphabetEnum(value);
            }

            public static readonly AlphabetEnum Ipa = new AlphabetEnum("ipa");
            public static readonly AlphabetEnum XSampa = new AlphabetEnum("x-sampa");
            public static readonly AlphabetEnum XAmazonJyutping = new AlphabetEnum("x-amazon-jyutping");
            public static readonly AlphabetEnum XAmazonPinyin = new AlphabetEnum("x-amazon-pinyin");
            public static readonly AlphabetEnum XAmazonPronKana = new AlphabetEnum("x-amazon-pron-kana");
            public static readonly AlphabetEnum XAmazonYomigana = new AlphabetEnum("x-amazon-yomigana");
        }

        /// <summary>
        /// Words to speak
        /// </summary>
        public string Words { get; set; }
        /// <summary>
        /// Specify the phonetic alphabet
        /// </summary>
        public SsmlPhoneme.AlphabetEnum Alphabet { get; set; }
        /// <summary>
        /// Specifiy the phonetic symbols for pronunciation
        /// </summary>
        public string Ph { get; set; }

        /// <summary>
        /// Create a new SsmlPhoneme
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="alphabet"> Specify the phonetic alphabet </param>
        /// <param name="ph"> Specifiy the phonetic symbols for pronunciation </param>
        public SsmlPhoneme(string words = null, SsmlPhoneme.AlphabetEnum alphabet = null, string ph = null) : base("phoneme")
        {
            this.Words = words;
            this.Alphabet = alphabet;
            this.Ph = ph;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.Words != null ? this.Words : string.Empty;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Alphabet != null)
            {
                attributes.Add(new XAttribute("alphabet", this.Alphabet.ToString()));
            }
            if (this.Ph != null)
            {
                attributes.Add(new XAttribute("ph", this.Ph));
            }
            return attributes;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new SsmlPhoneme Append(TwiML childElem)
        {
            return (SsmlPhoneme) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new SsmlPhoneme SetOption(string key, object value)
        {
            return (SsmlPhoneme) base.SetOption(key, value);
        }
    }

}