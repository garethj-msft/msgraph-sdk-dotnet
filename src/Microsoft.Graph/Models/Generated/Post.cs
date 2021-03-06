// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Post.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Post : OutlookItem
    {
    
        /// <summary>
        /// Gets or sets body.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "body", Required = Required.Default)]
        public ItemBody Body { get; set; }
    
        /// <summary>
        /// Gets or sets received date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "receivedDateTime", Required = Required.Default)]
        public DateTimeOffset? ReceivedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets has attachments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasAttachments", Required = Required.Default)]
        public bool? HasAttachments { get; set; }
    
        /// <summary>
        /// Gets or sets from.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "from", Required = Required.Default)]
        public Recipient From { get; set; }
    
        /// <summary>
        /// Gets or sets sender.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sender", Required = Required.Default)]
        public Recipient Sender { get; set; }
    
        /// <summary>
        /// Gets or sets conversation thread id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conversationThreadId", Required = Required.Default)]
        public string ConversationThreadId { get; set; }
    
        /// <summary>
        /// Gets or sets new participants.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "newParticipants", Required = Required.Default)]
        public IEnumerable<Recipient> NewParticipants { get; set; }
    
        /// <summary>
        /// Gets or sets conversation id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conversationId", Required = Required.Default)]
        public string ConversationId { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extensions", Required = Required.Default)]
        public IPostExtensionsCollectionPage Extensions { get; set; }
    
        /// <summary>
        /// Gets or sets in reply to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inReplyTo", Required = Required.Default)]
        public Post InReplyTo { get; set; }
    
        /// <summary>
        /// Gets or sets attachments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attachments", Required = Required.Default)]
        public IPostAttachmentsCollectionPage Attachments { get; set; }
    
    }
}

