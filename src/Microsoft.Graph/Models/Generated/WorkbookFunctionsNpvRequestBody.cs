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

    /// <summary>
    /// The type WorkbookFunctionsNpvRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsNpvRequestBody
    {
    
        /// <summary>
        /// Gets or sets Rate.
        /// </summary>
        [DataMember(Name = "rate", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Rate { get; set; }
    
        /// <summary>
        /// Gets or sets Values.
        /// </summary>
        [DataMember(Name = "values", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Values { get; set; }
    
    }
}
