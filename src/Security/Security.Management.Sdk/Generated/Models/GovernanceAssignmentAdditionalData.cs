// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describe the additional data of GovernanceAssignment - optional
    /// </summary>
    public partial class GovernanceAssignmentAdditionalData
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GovernanceAssignmentAdditionalData class.
        /// </summary>
        public GovernanceAssignmentAdditionalData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GovernanceAssignmentAdditionalData class.
        /// </summary>
        /// <param name="ticketNumber">Ticket number associated with this
        /// GovernanceAssignment</param>
        /// <param name="ticketLink">Ticket link associated with this
        /// GovernanceAssignment - for example: https://snow.com</param>
        /// <param name="ticketStatus">The ticket status associated with this
        /// GovernanceAssignment - for example: Active</param>
        public GovernanceAssignmentAdditionalData(int? ticketNumber = default(int?), string ticketLink = default(string), string ticketStatus = default(string))
        {
            TicketNumber = ticketNumber;
            TicketLink = ticketLink;
            TicketStatus = ticketStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ticket number associated with this
        /// GovernanceAssignment
        /// </summary>
        [JsonProperty(PropertyName = "ticketNumber")]
        public int? TicketNumber { get; set; }

        /// <summary>
        /// Gets or sets ticket link associated with this GovernanceAssignment
        /// - for example: https://snow.com
        /// </summary>
        [JsonProperty(PropertyName = "ticketLink")]
        public string TicketLink { get; set; }

        /// <summary>
        /// Gets or sets the ticket status associated with this
        /// GovernanceAssignment - for example: Active
        /// </summary>
        [JsonProperty(PropertyName = "ticketStatus")]
        public string TicketStatus { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TicketNumber != null)
            {
                if (TicketNumber < 0)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "TicketNumber", 0);
                }
            }
        }
    }
}
