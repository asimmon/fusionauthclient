// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>&lt;ul&gt;  &lt;li&gt;Bearer Token type as defined by &lt;a href=&quot;https:tools.ietf.orghtmlrfc6750&quot;&gt;RFC 6750&lt;a&gt;.&lt;li&gt;  &lt;li&gt;MAC Token type as referenced by &lt;a href=&quot;https:tools.ietf.orghtmlrfc6749&quot;&gt;RFC 6749&lt;a&gt; and  &lt;a href=&quot;https:tools.ietf.orghtmldraft-ietf-oauth-v2-http-mac-05&quot;&gt;  Draft RFC on OAuth 2.0 Message Authentication Code (MAC) Tokens&lt;a&gt;  &lt;li&gt;  &lt;ul&gt;</summary>
    public enum TokenType {
        [EnumMember(Value = "Bearer")]
        Bearer,
        [EnumMember(Value = "MAC")]
        MAC,
    }
}