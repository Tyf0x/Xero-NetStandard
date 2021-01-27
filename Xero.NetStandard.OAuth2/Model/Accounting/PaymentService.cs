/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.8.3
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
    /// PaymentService
    /// </summary>
    [DataContract]
    public partial class PaymentService :  IEquatable<PaymentService>, IValidatableObject
    {
        
        /// <summary>
        /// Xero identifier
        /// </summary>
        /// <value>Xero identifier</value>
        [DataMember(Name="PaymentServiceID", EmitDefaultValue=false)]
        public Guid? PaymentServiceID { get; set; }

        /// <summary>
        /// Name of payment service
        /// </summary>
        /// <value>Name of payment service</value>
        [DataMember(Name="PaymentServiceName", EmitDefaultValue=false)]
        public string PaymentServiceName { get; set; }

        /// <summary>
        /// The custom payment URL
        /// </summary>
        /// <value>The custom payment URL</value>
        [DataMember(Name="PaymentServiceUrl", EmitDefaultValue=false)]
        public string PaymentServiceUrl { get; set; }

        /// <summary>
        /// The text displayed on the Pay Now button in Xero Online Invoicing. If this is not set it will default to Pay by credit card
        /// </summary>
        /// <value>The text displayed on the Pay Now button in Xero Online Invoicing. If this is not set it will default to Pay by credit card</value>
        [DataMember(Name="PayNowText", EmitDefaultValue=false)]
        public string PayNowText { get; set; }

        /// <summary>
        /// This will always be CUSTOM for payment services created via the API.
        /// </summary>
        /// <value>This will always be CUSTOM for payment services created via the API.</value>
        [DataMember(Name="PaymentServiceType", EmitDefaultValue=false)]
        public string PaymentServiceType { get; set; }

        /// <summary>
        /// Displays array of validation error messages from the API
        /// </summary>
        /// <value>Displays array of validation error messages from the API</value>
        [DataMember(Name="ValidationErrors", EmitDefaultValue=false)]
        public List<ValidationError> ValidationErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentService {\n");
            sb.Append("  PaymentServiceID: ").Append(PaymentServiceID).Append("\n");
            sb.Append("  PaymentServiceName: ").Append(PaymentServiceName).Append("\n");
            sb.Append("  PaymentServiceUrl: ").Append(PaymentServiceUrl).Append("\n");
            sb.Append("  PayNowText: ").Append(PayNowText).Append("\n");
            sb.Append("  PaymentServiceType: ").Append(PaymentServiceType).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentService);
        }

        /// <summary>
        /// Returns true if PaymentService instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentService input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentServiceID == input.PaymentServiceID ||
                    (this.PaymentServiceID != null &&
                    this.PaymentServiceID.Equals(input.PaymentServiceID))
                ) && 
                (
                    this.PaymentServiceName == input.PaymentServiceName ||
                    (this.PaymentServiceName != null &&
                    this.PaymentServiceName.Equals(input.PaymentServiceName))
                ) && 
                (
                    this.PaymentServiceUrl == input.PaymentServiceUrl ||
                    (this.PaymentServiceUrl != null &&
                    this.PaymentServiceUrl.Equals(input.PaymentServiceUrl))
                ) && 
                (
                    this.PayNowText == input.PayNowText ||
                    (this.PayNowText != null &&
                    this.PayNowText.Equals(input.PayNowText))
                ) && 
                (
                    this.PaymentServiceType == input.PaymentServiceType ||
                    (this.PaymentServiceType != null &&
                    this.PaymentServiceType.Equals(input.PaymentServiceType))
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    input.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PaymentServiceID != null)
                    hashCode = hashCode * 59 + this.PaymentServiceID.GetHashCode();
                if (this.PaymentServiceName != null)
                    hashCode = hashCode * 59 + this.PaymentServiceName.GetHashCode();
                if (this.PaymentServiceUrl != null)
                    hashCode = hashCode * 59 + this.PaymentServiceUrl.GetHashCode();
                if (this.PayNowText != null)
                    hashCode = hashCode * 59 + this.PayNowText.GetHashCode();
                if (this.PaymentServiceType != null)
                    hashCode = hashCode * 59 + this.PaymentServiceType.GetHashCode();
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
