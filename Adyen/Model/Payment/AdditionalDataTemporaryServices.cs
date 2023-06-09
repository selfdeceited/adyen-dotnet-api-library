/*
* Adyen Payment API
*
*
* The version of the OpenAPI document: 68
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Payment
{
    /// <summary>
    /// AdditionalDataTemporaryServices
    /// </summary>
    [DataContract(Name = "AdditionalDataTemporaryServices")]
    public partial class AdditionalDataTemporaryServices : IEquatable<AdditionalDataTemporaryServices>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataTemporaryServices" /> class.
        /// </summary>
        /// <param name="enhancedSchemeDataCustomerReference">Customer code, if supplied by a customer. * Encoding: ASCII * maxLength: 25.</param>
        /// <param name="enhancedSchemeDataEmployeeName">Name or ID associated with the individual working in a temporary capacity. * maxLength: 40.</param>
        /// <param name="enhancedSchemeDataJobDescription">Description of the job or task of the individual working in a temporary capacity. * maxLength: 40.</param>
        /// <param name="enhancedSchemeDataRegularHoursRate">Amount paid per regular hours worked, minor units. * maxLength: 7.</param>
        /// <param name="enhancedSchemeDataRegularHoursWorked">Amount of time worked during a normal operation for the task or job. * maxLength: 7.</param>
        /// <param name="enhancedSchemeDataRequestName">Name of the individual requesting temporary services. * maxLength: 40.</param>
        /// <param name="enhancedSchemeDataTempStartDate">Date for the beginning of the pay period. * Format: ddMMyy * maxLength: 6.</param>
        /// <param name="enhancedSchemeDataTempWeekEnding">Date of the end of the billing cycle. * Format: ddMMyy * maxLength: 6.</param>
        /// <param name="enhancedSchemeDataTotalTaxAmount">Total tax amount, in minor units. For example, 2000 means USD 20.00 * maxLength: 12.</param>
        public AdditionalDataTemporaryServices(string enhancedSchemeDataCustomerReference = default(string), string enhancedSchemeDataEmployeeName = default(string), string enhancedSchemeDataJobDescription = default(string), string enhancedSchemeDataRegularHoursRate = default(string), string enhancedSchemeDataRegularHoursWorked = default(string), string enhancedSchemeDataRequestName = default(string), string enhancedSchemeDataTempStartDate = default(string), string enhancedSchemeDataTempWeekEnding = default(string), string enhancedSchemeDataTotalTaxAmount = default(string))
        {
            this.EnhancedSchemeDataCustomerReference = enhancedSchemeDataCustomerReference;
            this.EnhancedSchemeDataEmployeeName = enhancedSchemeDataEmployeeName;
            this.EnhancedSchemeDataJobDescription = enhancedSchemeDataJobDescription;
            this.EnhancedSchemeDataRegularHoursRate = enhancedSchemeDataRegularHoursRate;
            this.EnhancedSchemeDataRegularHoursWorked = enhancedSchemeDataRegularHoursWorked;
            this.EnhancedSchemeDataRequestName = enhancedSchemeDataRequestName;
            this.EnhancedSchemeDataTempStartDate = enhancedSchemeDataTempStartDate;
            this.EnhancedSchemeDataTempWeekEnding = enhancedSchemeDataTempWeekEnding;
            this.EnhancedSchemeDataTotalTaxAmount = enhancedSchemeDataTotalTaxAmount;
        }

        /// <summary>
        /// Customer code, if supplied by a customer. * Encoding: ASCII * maxLength: 25
        /// </summary>
        /// <value>Customer code, if supplied by a customer. * Encoding: ASCII * maxLength: 25</value>
        [DataMember(Name = "enhancedSchemeData.customerReference", EmitDefaultValue = false)]
        public string EnhancedSchemeDataCustomerReference { get; set; }

        /// <summary>
        /// Name or ID associated with the individual working in a temporary capacity. * maxLength: 40
        /// </summary>
        /// <value>Name or ID associated with the individual working in a temporary capacity. * maxLength: 40</value>
        [DataMember(Name = "enhancedSchemeData.employeeName", EmitDefaultValue = false)]
        public string EnhancedSchemeDataEmployeeName { get; set; }

        /// <summary>
        /// Description of the job or task of the individual working in a temporary capacity. * maxLength: 40
        /// </summary>
        /// <value>Description of the job or task of the individual working in a temporary capacity. * maxLength: 40</value>
        [DataMember(Name = "enhancedSchemeData.jobDescription", EmitDefaultValue = false)]
        public string EnhancedSchemeDataJobDescription { get; set; }

        /// <summary>
        /// Amount paid per regular hours worked, minor units. * maxLength: 7
        /// </summary>
        /// <value>Amount paid per regular hours worked, minor units. * maxLength: 7</value>
        [DataMember(Name = "enhancedSchemeData.regularHoursRate", EmitDefaultValue = false)]
        public string EnhancedSchemeDataRegularHoursRate { get; set; }

        /// <summary>
        /// Amount of time worked during a normal operation for the task or job. * maxLength: 7
        /// </summary>
        /// <value>Amount of time worked during a normal operation for the task or job. * maxLength: 7</value>
        [DataMember(Name = "enhancedSchemeData.regularHoursWorked", EmitDefaultValue = false)]
        public string EnhancedSchemeDataRegularHoursWorked { get; set; }

        /// <summary>
        /// Name of the individual requesting temporary services. * maxLength: 40
        /// </summary>
        /// <value>Name of the individual requesting temporary services. * maxLength: 40</value>
        [DataMember(Name = "enhancedSchemeData.requestName", EmitDefaultValue = false)]
        public string EnhancedSchemeDataRequestName { get; set; }

        /// <summary>
        /// Date for the beginning of the pay period. * Format: ddMMyy * maxLength: 6
        /// </summary>
        /// <value>Date for the beginning of the pay period. * Format: ddMMyy * maxLength: 6</value>
        [DataMember(Name = "enhancedSchemeData.tempStartDate", EmitDefaultValue = false)]
        public string EnhancedSchemeDataTempStartDate { get; set; }

        /// <summary>
        /// Date of the end of the billing cycle. * Format: ddMMyy * maxLength: 6
        /// </summary>
        /// <value>Date of the end of the billing cycle. * Format: ddMMyy * maxLength: 6</value>
        [DataMember(Name = "enhancedSchemeData.tempWeekEnding", EmitDefaultValue = false)]
        public string EnhancedSchemeDataTempWeekEnding { get; set; }

        /// <summary>
        /// Total tax amount, in minor units. For example, 2000 means USD 20.00 * maxLength: 12
        /// </summary>
        /// <value>Total tax amount, in minor units. For example, 2000 means USD 20.00 * maxLength: 12</value>
        [DataMember(Name = "enhancedSchemeData.totalTaxAmount", EmitDefaultValue = false)]
        public string EnhancedSchemeDataTotalTaxAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdditionalDataTemporaryServices {\n");
            sb.Append("  EnhancedSchemeDataCustomerReference: ").Append(EnhancedSchemeDataCustomerReference).Append("\n");
            sb.Append("  EnhancedSchemeDataEmployeeName: ").Append(EnhancedSchemeDataEmployeeName).Append("\n");
            sb.Append("  EnhancedSchemeDataJobDescription: ").Append(EnhancedSchemeDataJobDescription).Append("\n");
            sb.Append("  EnhancedSchemeDataRegularHoursRate: ").Append(EnhancedSchemeDataRegularHoursRate).Append("\n");
            sb.Append("  EnhancedSchemeDataRegularHoursWorked: ").Append(EnhancedSchemeDataRegularHoursWorked).Append("\n");
            sb.Append("  EnhancedSchemeDataRequestName: ").Append(EnhancedSchemeDataRequestName).Append("\n");
            sb.Append("  EnhancedSchemeDataTempStartDate: ").Append(EnhancedSchemeDataTempStartDate).Append("\n");
            sb.Append("  EnhancedSchemeDataTempWeekEnding: ").Append(EnhancedSchemeDataTempWeekEnding).Append("\n");
            sb.Append("  EnhancedSchemeDataTotalTaxAmount: ").Append(EnhancedSchemeDataTotalTaxAmount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdditionalDataTemporaryServices);
        }

        /// <summary>
        /// Returns true if AdditionalDataTemporaryServices instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalDataTemporaryServices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalDataTemporaryServices input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EnhancedSchemeDataCustomerReference == input.EnhancedSchemeDataCustomerReference ||
                    (this.EnhancedSchemeDataCustomerReference != null &&
                    this.EnhancedSchemeDataCustomerReference.Equals(input.EnhancedSchemeDataCustomerReference))
                ) && 
                (
                    this.EnhancedSchemeDataEmployeeName == input.EnhancedSchemeDataEmployeeName ||
                    (this.EnhancedSchemeDataEmployeeName != null &&
                    this.EnhancedSchemeDataEmployeeName.Equals(input.EnhancedSchemeDataEmployeeName))
                ) && 
                (
                    this.EnhancedSchemeDataJobDescription == input.EnhancedSchemeDataJobDescription ||
                    (this.EnhancedSchemeDataJobDescription != null &&
                    this.EnhancedSchemeDataJobDescription.Equals(input.EnhancedSchemeDataJobDescription))
                ) && 
                (
                    this.EnhancedSchemeDataRegularHoursRate == input.EnhancedSchemeDataRegularHoursRate ||
                    (this.EnhancedSchemeDataRegularHoursRate != null &&
                    this.EnhancedSchemeDataRegularHoursRate.Equals(input.EnhancedSchemeDataRegularHoursRate))
                ) && 
                (
                    this.EnhancedSchemeDataRegularHoursWorked == input.EnhancedSchemeDataRegularHoursWorked ||
                    (this.EnhancedSchemeDataRegularHoursWorked != null &&
                    this.EnhancedSchemeDataRegularHoursWorked.Equals(input.EnhancedSchemeDataRegularHoursWorked))
                ) && 
                (
                    this.EnhancedSchemeDataRequestName == input.EnhancedSchemeDataRequestName ||
                    (this.EnhancedSchemeDataRequestName != null &&
                    this.EnhancedSchemeDataRequestName.Equals(input.EnhancedSchemeDataRequestName))
                ) && 
                (
                    this.EnhancedSchemeDataTempStartDate == input.EnhancedSchemeDataTempStartDate ||
                    (this.EnhancedSchemeDataTempStartDate != null &&
                    this.EnhancedSchemeDataTempStartDate.Equals(input.EnhancedSchemeDataTempStartDate))
                ) && 
                (
                    this.EnhancedSchemeDataTempWeekEnding == input.EnhancedSchemeDataTempWeekEnding ||
                    (this.EnhancedSchemeDataTempWeekEnding != null &&
                    this.EnhancedSchemeDataTempWeekEnding.Equals(input.EnhancedSchemeDataTempWeekEnding))
                ) && 
                (
                    this.EnhancedSchemeDataTotalTaxAmount == input.EnhancedSchemeDataTotalTaxAmount ||
                    (this.EnhancedSchemeDataTotalTaxAmount != null &&
                    this.EnhancedSchemeDataTotalTaxAmount.Equals(input.EnhancedSchemeDataTotalTaxAmount))
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
                if (this.EnhancedSchemeDataCustomerReference != null)
                {
                    hashCode = (hashCode * 59) + this.EnhancedSchemeDataCustomerReference.GetHashCode();
                }
                if (this.EnhancedSchemeDataEmployeeName != null)
                {
                    hashCode = (hashCode * 59) + this.EnhancedSchemeDataEmployeeName.GetHashCode();
                }
                if (this.EnhancedSchemeDataJobDescription != null)
                {
                    hashCode = (hashCode * 59) + this.EnhancedSchemeDataJobDescription.GetHashCode();
                }
                if (this.EnhancedSchemeDataRegularHoursRate != null)
                {
                    hashCode = (hashCode * 59) + this.EnhancedSchemeDataRegularHoursRate.GetHashCode();
                }
                if (this.EnhancedSchemeDataRegularHoursWorked != null)
                {
                    hashCode = (hashCode * 59) + this.EnhancedSchemeDataRegularHoursWorked.GetHashCode();
                }
                if (this.EnhancedSchemeDataRequestName != null)
                {
                    hashCode = (hashCode * 59) + this.EnhancedSchemeDataRequestName.GetHashCode();
                }
                if (this.EnhancedSchemeDataTempStartDate != null)
                {
                    hashCode = (hashCode * 59) + this.EnhancedSchemeDataTempStartDate.GetHashCode();
                }
                if (this.EnhancedSchemeDataTempWeekEnding != null)
                {
                    hashCode = (hashCode * 59) + this.EnhancedSchemeDataTempWeekEnding.GetHashCode();
                }
                if (this.EnhancedSchemeDataTotalTaxAmount != null)
                {
                    hashCode = (hashCode * 59) + this.EnhancedSchemeDataTotalTaxAmount.GetHashCode();
                }
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
