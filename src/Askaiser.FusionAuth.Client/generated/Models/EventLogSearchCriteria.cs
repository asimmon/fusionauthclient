// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// Search criteria for the event log.
    /// </summary>
    public class EventLogSearchCriteria : IParsable {
        /// <summary>The number of milliseconds since the unix epoch: January 1, 1970 00:00:00 UTC. This value is always in UTC.</summary>
        public long? End { get; set; }
        /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message { get; set; }
#nullable restore
#else
        public string Message { get; set; }
#endif
        /// <summary>The numberOfResults property</summary>
        public int? NumberOfResults { get; set; }
        /// <summary>The orderBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderBy { get; set; }
#nullable restore
#else
        public string OrderBy { get; set; }
#endif
        /// <summary>The number of milliseconds since the unix epoch: January 1, 1970 00:00:00 UTC. This value is always in UTC.</summary>
        public long? Start { get; set; }
        /// <summary>The startRow property</summary>
        public int? StartRow { get; set; }
        /// <summary>Event Log Type</summary>
        public EventLogType? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EventLogSearchCriteria CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EventLogSearchCriteria();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"end", n => { End = n.GetLongValue(); } },
                {"message", n => { Message = n.GetStringValue(); } },
                {"numberOfResults", n => { NumberOfResults = n.GetIntValue(); } },
                {"orderBy", n => { OrderBy = n.GetStringValue(); } },
                {"start", n => { Start = n.GetLongValue(); } },
                {"startRow", n => { StartRow = n.GetIntValue(); } },
                {"type", n => { Type = n.GetEnumValue<EventLogType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("end", End);
            writer.WriteStringValue("message", Message);
            writer.WriteIntValue("numberOfResults", NumberOfResults);
            writer.WriteStringValue("orderBy", OrderBy);
            writer.WriteLongValue("start", Start);
            writer.WriteIntValue("startRow", StartRow);
            writer.WriteEnumValue<EventLogType>("type", Type);
        }
    }
}