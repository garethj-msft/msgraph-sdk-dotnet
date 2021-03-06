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
    /// The type WorkbookFilterApplyCustomFilterRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFilterApplyCustomFilterRequestBody
    {
    
        /// <summary>
        /// Gets or sets Criteria1.
        /// </summary>
        [DataMember(Name = "criteria1", EmitDefaultValue = false, IsRequired = false)]
        public string Criteria1 { get; set; }
    
        /// <summary>
        /// Gets or sets Criteria2.
        /// </summary>
        [DataMember(Name = "criteria2", EmitDefaultValue = false, IsRequired = false)]
        public string Criteria2 { get; set; }
    
        /// <summary>
        /// Gets or sets Oper.
        /// </summary>
        [DataMember(Name = "oper", EmitDefaultValue = false, IsRequired = false)]
        public string Oper { get; set; }
    
    }
}
