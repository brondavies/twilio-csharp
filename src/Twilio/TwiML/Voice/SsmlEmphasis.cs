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
    /// Emphasizing Words in Say
    /// </summary>
    public class SsmlEmphasis : TwiML
    {
        public sealed class LevelEnum : StringEnum
        {
            private LevelEnum(string value) : base(value) {}
            public LevelEnum() {}
            public static implicit operator LevelEnum(string value)
            {
                return new LevelEnum(value);
            }

            public static readonly LevelEnum Strong = new LevelEnum("strong");
            public static readonly LevelEnum Moderate = new LevelEnum("moderate");
            public static readonly LevelEnum Reduced = new LevelEnum("reduced");
        }

        /// <summary>
        /// Words to emphasize
        /// </summary>
        public string Words { get; set; }
        /// <summary>
        /// Specify the degree of emphasis
        /// </summary>
        public SsmlEmphasis.LevelEnum Level { get; set; }

        /// <summary>
        /// Create a new SsmlEmphasis
        /// </summary>
        /// <param name="words"> Words to emphasize, the body of the TwiML Element. </param>
        /// <param name="level"> Specify the degree of emphasis </param>
        public SsmlEmphasis(string words = null, SsmlEmphasis.LevelEnum level = null) : base("emphasis")
        {
            this.Words = words;
            this.Level = level;
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
            if (this.Level != null)
            {
                attributes.Add(new XAttribute("level", this.Level.ToString()));
            }
            return attributes;
        }

        /// <summary>
        /// Create a new <Break/> element and append it as a child of this element.
        /// </summary>
        /// <param name="strength"> Set a pause based on strength </param>
        /// <param name="time"> Set a pause to a specific length of time in seconds or milliseconds, available values:
        ///            [number]s, [number]ms </param>
        public SsmlEmphasis Break(SsmlBreak.StrengthEnum strength = null, string time = null)
        {
            var newChild = new SsmlBreak(strength, time);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Break/> element as a child of this element
        /// </summary>
        /// <param name="ssmlBreak"> A SsmlBreak instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlEmphasis SsmlBreak(SsmlBreak ssmlBreak)
        {
            this.Append(ssmlBreak);
            return this;
        }

        /// <summary>
        /// Create a new <Break/> element and append it as a child of this element.
        /// </summary>
        /// <param name="strength"> Set a pause based on strength </param>
        /// <param name="time"> Set a pause to a specific length of time in seconds or milliseconds, available values:
        ///            [number]s, [number]ms </param>
        [System.Obsolete("This method is deprecated, use .Break() instead.")]
        public SsmlEmphasis SsmlBreak(SsmlBreak.StrengthEnum strength = null, string time = null)
        {
            return Break(strength, time);
        }

        /// <summary>
        /// Create a new <Emphasis/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to emphasize, the body of the TwiML Element. </param>
        /// <param name="level"> Specify the degree of emphasis </param>
        public SsmlEmphasis Emphasis(string words = null, SsmlEmphasis.LevelEnum level = null)
        {
            var newChild = new SsmlEmphasis(words, level);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Emphasis/> element as a child of this element
        /// </summary>
        /// <param name="ssmlEmphasis"> A SsmlEmphasis instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlEmphasis AppendSsmlEmphasis(SsmlEmphasis ssmlEmphasis)
        {
            this.Append(ssmlEmphasis);
            return this;
        }

        /// <summary>
        /// Create a new <Emphasis/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to emphasize, the body of the TwiML Element. </param>
        /// <param name="level"> Specify the degree of emphasis </param>
        [System.Obsolete("This method is deprecated, use .Emphasis() instead.")]
        public SsmlEmphasis AppendSsmlEmphasis(string words = null, SsmlEmphasis.LevelEnum level = null)
        {
            return Emphasis(words, level);
        }

        /// <summary>
        /// Create a new <Lang/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="xml:Lang"> Specify the language </param>
        public SsmlEmphasis Lang(string words = null, SsmlLang.XmlLangEnum xmlLang = null)
        {
            var newChild = new SsmlLang(words, xmlLang);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Lang/> element as a child of this element
        /// </summary>
        /// <param name="ssmlLang"> A SsmlLang instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlEmphasis SsmlLang(SsmlLang ssmlLang)
        {
            this.Append(ssmlLang);
            return this;
        }

        /// <summary>
        /// Create a new <Lang/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="xml:Lang"> Specify the language </param>
        [System.Obsolete("This method is deprecated, use .Lang() instead.")]
        public SsmlEmphasis SsmlLang(string words = null, SsmlLang.XmlLangEnum xmlLang = null)
        {
            return Lang(words, xmlLang);
        }

        /// <summary>
        /// Create a new <Phoneme/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="alphabet"> Specify the phonetic alphabet </param>
        /// <param name="ph"> Specifiy the phonetic symbols for pronunciation </param>
        public SsmlEmphasis Phoneme(string words = null, SsmlPhoneme.AlphabetEnum alphabet = null, string ph = null)
        {
            var newChild = new SsmlPhoneme(words, alphabet, ph);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Phoneme/> element as a child of this element
        /// </summary>
        /// <param name="ssmlPhoneme"> A SsmlPhoneme instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlEmphasis SsmlPhoneme(SsmlPhoneme ssmlPhoneme)
        {
            this.Append(ssmlPhoneme);
            return this;
        }

        /// <summary>
        /// Create a new <Phoneme/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="alphabet"> Specify the phonetic alphabet </param>
        /// <param name="ph"> Specifiy the phonetic symbols for pronunciation </param>
        [System.Obsolete("This method is deprecated, use .Phoneme() instead.")]
        public SsmlEmphasis SsmlPhoneme(string words = null, SsmlPhoneme.AlphabetEnum alphabet = null, string ph = null)
        {
            return Phoneme(words, alphabet, ph);
        }

        /// <summary>
        /// Create a new <Prosody/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="volume"> Specify the volume, available values: default, silent, x-soft, soft, medium, loud, x-loud,
        ///              +ndB, -ndB </param>
        /// <param name="rate"> Specify the rate, available values: x-slow, slow, medium, fast, x-fast, n% </param>
        /// <param name="pitch"> Specify the pitch, available values: default, x-low, low, medium, high, x-high, +n%, -n%
        ///             </param>
        public SsmlEmphasis Prosody(string words = null, string volume = null, string rate = null, string pitch = null)
        {
            var newChild = new SsmlProsody(words, volume, rate, pitch);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Prosody/> element as a child of this element
        /// </summary>
        /// <param name="ssmlProsody"> A SsmlProsody instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlEmphasis SsmlProsody(SsmlProsody ssmlProsody)
        {
            this.Append(ssmlProsody);
            return this;
        }

        /// <summary>
        /// Create a new <Prosody/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="volume"> Specify the volume, available values: default, silent, x-soft, soft, medium, loud, x-loud,
        ///              +ndB, -ndB </param>
        /// <param name="rate"> Specify the rate, available values: x-slow, slow, medium, fast, x-fast, n% </param>
        /// <param name="pitch"> Specify the pitch, available values: default, x-low, low, medium, high, x-high, +n%, -n%
        ///             </param>
        [System.Obsolete("This method is deprecated, use .Prosody() instead.")]
        public SsmlEmphasis SsmlProsody(string words = null, string volume = null, string rate = null, string pitch = null)
        {
            return Prosody(words, volume, rate, pitch);
        }

        /// <summary>
        /// Create a new <Say-As/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to be interpreted, the body of the TwiML Element. </param>
        /// <param name="interpret-As"> Specify the type of words are spoken </param>
        /// <param name="format"> Specify the format of the date when interpret-as is set to date </param>
        public SsmlEmphasis SayAs(string words = null,
                                  SsmlSayAs.InterpretAsEnum interpretAs = null,
                                  SsmlSayAs.FormatEnum format = null)
        {
            var newChild = new SsmlSayAs(words, interpretAs, format);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Say-As/> element as a child of this element
        /// </summary>
        /// <param name="ssmlSayAs"> A SsmlSayAs instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlEmphasis SsmlSayAs(SsmlSayAs ssmlSayAs)
        {
            this.Append(ssmlSayAs);
            return this;
        }

        /// <summary>
        /// Create a new <Say-As/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to be interpreted, the body of the TwiML Element. </param>
        /// <param name="interpret-As"> Specify the type of words are spoken </param>
        /// <param name="format"> Specify the format of the date when interpret-as is set to date </param>
        [System.Obsolete("This method is deprecated, use .SayAs() instead.")]
        public SsmlEmphasis SsmlSayAs(string words = null,
                                      SsmlSayAs.InterpretAsEnum interpretAs = null,
                                      SsmlSayAs.FormatEnum format = null)
        {
            return SayAs(words, interpretAs, format);
        }

        /// <summary>
        /// Create a new <Sub/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to be substituted, the body of the TwiML Element. </param>
        /// <param name="alias"> Substitute a different word (or pronunciation) for selected text such as an acronym or
        ///             abbreviation </param>
        public SsmlEmphasis Sub(string words = null, string alias = null)
        {
            var newChild = new SsmlSub(words, alias);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Sub/> element as a child of this element
        /// </summary>
        /// <param name="ssmlSub"> A SsmlSub instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlEmphasis SsmlSub(SsmlSub ssmlSub)
        {
            this.Append(ssmlSub);
            return this;
        }

        /// <summary>
        /// Create a new <Sub/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to be substituted, the body of the TwiML Element. </param>
        /// <param name="alias"> Substitute a different word (or pronunciation) for selected text such as an acronym or
        ///             abbreviation </param>
        [System.Obsolete("This method is deprecated, use .Sub() instead.")]
        public SsmlEmphasis SsmlSub(string words = null, string alias = null)
        {
            return Sub(words, alias);
        }

        /// <summary>
        /// Create a new <W/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="role"> Customize the pronunciation of words by specifying the word’s part of speech or alternate
        ///            meaning </param>
        public SsmlEmphasis W(string words = null, string role = null)
        {
            var newChild = new SsmlW(words, role);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <W/> element as a child of this element
        /// </summary>
        /// <param name="ssmlW"> A SsmlW instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlEmphasis SsmlW(SsmlW ssmlW)
        {
            this.Append(ssmlW);
            return this;
        }

        /// <summary>
        /// Create a new <W/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="role"> Customize the pronunciation of words by specifying the word’s part of speech or alternate
        ///            meaning </param>
        [System.Obsolete("This method is deprecated, use .W() instead.")]
        public SsmlEmphasis SsmlW(string words = null, string role = null)
        {
            return W(words, role);
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new SsmlEmphasis Append(TwiML childElem)
        {
            return (SsmlEmphasis) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new SsmlEmphasis SetOption(string key, object value)
        {
            return (SsmlEmphasis) base.SetOption(key, value);
        }
    }

}