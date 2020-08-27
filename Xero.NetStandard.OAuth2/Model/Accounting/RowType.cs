/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.2.14
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// Defines RowType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RowType
    {
        /// <summary>
        /// Enum Header for value: Header
        /// </summary>
        [EnumMember(Value = "Header")]
        Header = 1,

        /// <summary>
        /// Enum Section for value: Section
        /// </summary>
        [EnumMember(Value = "Section")]
        Section = 2,

        /// <summary>
        /// Enum Row for value: Row
        /// </summary>
        [EnumMember(Value = "Row")]
        Row = 3,

        /// <summary>
        /// Enum SummaryRow for value: SummaryRow
        /// </summary>
        [EnumMember(Value = "SummaryRow")]
        SummaryRow = 4

    }

}
