// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type EventSnoozeReminderRequestBuilder.
    /// </summary>
    public partial class EventSnoozeReminderRequestBuilder : BaseActionMethodRequestBuilder<IEventSnoozeReminderRequest>, IEventSnoozeReminderRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="EventSnoozeReminderRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="NewReminderTime">A NewReminderTime parameter for the OData method call.</param>
        public EventSnoozeReminderRequestBuilder(
            string requestUrl,
            IBaseClient client,
            DateTimeTimeZone NewReminderTime)
            : base(requestUrl, client)
        {
            this.SetParameter("newReminderTime", NewReminderTime, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IEventSnoozeReminderRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new EventSnoozeReminderRequest(functionUrl, this.Client, options);

            if (this.HasParameter("newReminderTime"))
            {
                request.RequestBody.NewReminderTime = this.GetParameter<DateTimeTimeZone>("newReminderTime");
            }

            return request;
        }
    }
}
