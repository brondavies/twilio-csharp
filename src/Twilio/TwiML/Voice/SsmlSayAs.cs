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
    /// Controlling How Special Types of Words Are Spoken in Say
    /// </summary>
    public class SsmlSayAs : TwiML
    {
        public sealed class InterpretAsEnum : StringEnum
        {
            private InterpretAsEnum(string value) : base(value) {}
            public InterpretAsEnum() {}
            public static implicit operator InterpretAsEnum(string value)
            {
                return new InterpretAsEnum(value);
            }

            public static readonly InterpretAsEnum Characters = new InterpretAsEnum("characters");
            public static readonly InterpretAsEnum SpellOut = new InterpretAsEnum("spell-out");
            public static readonly InterpretAsEnum Cardinal = new InterpretAsEnum("cardinal");
            public static readonly InterpretAsEnum Number = new InterpretAsEnum("number");
            public static readonly InterpretAsEnum Ordinal = new InterpretAsEnum("ordinal");
            public static readonly InterpretAsEnum Digits = new InterpretAsEnum("digits");
            public static readonly InterpretAsEnum Fraction = new InterpretAsEnum("fraction");
            public static readonly InterpretAsEnum Unit = new InterpretAsEnum("unit");
            public static readonly InterpretAsEnum Date = new InterpretAsEnum("date");
            public static readonly InterpretAsEnum Time = new InterpretAsEnum("time");
            public static readonly InterpretAsEnum Address = new InterpretAsEnum("address");
            public static readonly InterpretAsEnum Expletive = new InterpretAsEnum("expletive");
            public static readonly InterpretAsEnum Telephone = new InterpretAsEnum("telephone");
        }

        public sealed class FormatEnum : StringEnum
        {
            private FormatEnum(string value) : base(value) {}
            public FormatEnum() {}
            public static implicit operator FormatEnum(string value)
            {
                return new FormatEnum(value);
            }

            public static readonly FormatEnum Mdy = new FormatEnum("mdy");
            public static readonly FormatEnum Dmy = new FormatEnum("dmy");
            public static readonly FormatEnum Ymd = new FormatEnum("ymd");
            public static readonly FormatEnum Md = new FormatEnum("md");
            public static readonly FormatEnum Dm = new FormatEnum("dm");
            public static readonly FormatEnum Ym = new FormatEnum("ym");
            public static readonly FormatEnum My = new FormatEnum("my");
            public static readonly FormatEnum D = new FormatEnum("d");
            public static readonly FormatEnum M = new FormatEnum("m");
            public static readonly FormatEnum Y = new FormatEnum("y");
            public static readonly FormatEnum Yyyymmdd = new FormatEnum("yyyymmdd");
        }

        /// <summary>
        /// Words to be interpreted
        /// </summary>
        public string Words { get; set; }
        /// <summary>
        /// Specify the type of words are spoken
        /// </summary>
        public SsmlSayAs.InterpretAsEnum InterpretAs { get; set; }
        /// <summary>
        /// Specify the format of the date when interpret-as is set to date
        /// </summary>
        public SsmlSayAs.FormatEnum Format { get; set; }

        /// <summary>
        /// Create a new SsmlSayAs
        /// </summary>
        /// <param name="words"> Words to be interpreted, the body of the TwiML Element. </param>
        /// <param name="interpret-As"> Specify the type of words are spoken </param>
        /// <param name="format"> Specify the format of the date when interpret-as is set to date </param>
        public SsmlSayAs(string words = null,
                         SsmlSayAs.InterpretAsEnum interpretAs = null,
                         SsmlSayAs.FormatEnum format = null) : base("say-as")
        {
            this.Words = words;
            this.InterpretAs = interpretAs;
            this.Format = format;
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
            if (this.InterpretAs != null)
            {
                attributes.Add(new XAttribute("interpret-as", this.InterpretAs.ToString()));
            }
            if (this.Format != null)
            {
                attributes.Add(new XAttribute("format", this.Format.ToString()));
            }
            return attributes;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new SsmlSayAs Append(TwiML childElem)
        {
            return (SsmlSayAs) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new SsmlSayAs SetOption(string key, object value)
        {
            return (SsmlSayAs) base.SetOption(key, value);
        }
    }

}