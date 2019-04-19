// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.EventHub.Models
{
    using Microsoft.Azure.Management.EventHub.Models;
    using System.Linq;
    using System.Collections.Generic;

    /// <summary>
    /// Description of VirtualNetworkRules - NetworkRules resource.
    /// </summary>
    public class PSNWRuleSetVirtualNetworkRulesAttributes
    {
        /// <summary>
        /// Initializes a new instance of the NWRuleSetVirtualNetworkRules
        /// class.
        /// </summary>
        public PSNWRuleSetVirtualNetworkRulesAttributes()
        {
            Subnet = new PSSubnetAttributes();
        }

        /// <summary>
        /// Initializes a new instance of the NWRuleSetVirtualNetworkRules
        /// class.
        /// </summary>
        /// <param name="subnet">Subnet properties</param>
        /// <param name="ignoreMissingVnetServiceEndpoint">Value that indicates
        /// whether to ignore missing VNet Service Endpoint</param>
        public static IList<PSNWRuleSetVirtualNetworkRulesAttributes> PSNWRuleSetVirtualNetworkRulesAttributesCollection(IList<NWRuleSetVirtualNetworkRules> nwVirtualNetworkRules)
        {
            List<PSNWRuleSetVirtualNetworkRulesAttributes> VNetRules = new List<PSNWRuleSetVirtualNetworkRulesAttributes>(); 

            foreach (NWRuleSetVirtualNetworkRules nwRuleSetVirtualNetworkRules in nwVirtualNetworkRules)
            {
                VNetRules.Add(new PSNWRuleSetVirtualNetworkRulesAttributes(nwRuleSetVirtualNetworkRules));                
            }

            return VNetRules;
        }

        public PSNWRuleSetVirtualNetworkRulesAttributes(NWRuleSetVirtualNetworkRules nwVirtualNetworkRules)
        {
            Subnet = new PSSubnetAttributes(nwVirtualNetworkRules.Subnet);
            IgnoreMissingVnetServiceEndpoint = nwVirtualNetworkRules.IgnoreMissingVnetServiceEndpoint;
        }



        /// <summary>
        /// Gets or sets subnet properties
        /// </summary>
        public PSSubnetAttributes Subnet { get; set; }

        /// <summary>
        /// Gets or sets value that indicates whether to ignore missing VNet
        /// Service Endpoint
        /// </summary>
        public bool? IgnoreMissingVnetServiceEndpoint { get; set; }
       
    }
}
