/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// AccountSupportingEntityCapability
    /// </summary>
    [DataContract(Name = "AccountSupportingEntityCapability")]
    public partial class AccountSupportingEntityCapability : IEquatable<AccountSupportingEntityCapability>, IValidatableObject
    {
        /// <summary>
        /// The capability level that is allowed for the account holder.  Possible values: **notApplicable**, **low**, **medium**, **high**.
        /// </summary>
        /// <value>The capability level that is allowed for the account holder.  Possible values: **notApplicable**, **low**, **medium**, **high**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AllowedLevelEnum
        {
            /// <summary>
            /// Enum High for value: high
            /// </summary>
            [EnumMember(Value = "high")]
            High = 1,

            /// <summary>
            /// Enum Low for value: low
            /// </summary>
            [EnumMember(Value = "low")]
            Low = 2,

            /// <summary>
            /// Enum Medium for value: medium
            /// </summary>
            [EnumMember(Value = "medium")]
            Medium = 3,

            /// <summary>
            /// Enum NotApplicable for value: notApplicable
            /// </summary>
            [EnumMember(Value = "notApplicable")]
            NotApplicable = 4

        }


        /// <summary>
        /// The capability level that is allowed for the account holder.  Possible values: **notApplicable**, **low**, **medium**, **high**.
        /// </summary>
        /// <value>The capability level that is allowed for the account holder.  Possible values: **notApplicable**, **low**, **medium**, **high**.</value>
        [DataMember(Name = "allowedLevel", EmitDefaultValue = false)]
        public AllowedLevelEnum? AllowedLevel { get; set; }

        /// <summary>
        /// Returns false as AllowedLevel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAllowedLevel()
        {
            return false;
        }
        /// <summary>
        /// The requested level of the capability. Some capabilities, such as those used in [card issuing](https://docs.adyen.com/issuing/add-capabilities#capability-levels), have different levels. Levels increase the capability, but also require additional checks and increased monitoring.  Possible values: **notApplicable**, **low**, **medium**, **high**.
        /// </summary>
        /// <value>The requested level of the capability. Some capabilities, such as those used in [card issuing](https://docs.adyen.com/issuing/add-capabilities#capability-levels), have different levels. Levels increase the capability, but also require additional checks and increased monitoring.  Possible values: **notApplicable**, **low**, **medium**, **high**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RequestedLevelEnum
        {
            /// <summary>
            /// Enum High for value: high
            /// </summary>
            [EnumMember(Value = "high")]
            High = 1,

            /// <summary>
            /// Enum Low for value: low
            /// </summary>
            [EnumMember(Value = "low")]
            Low = 2,

            /// <summary>
            /// Enum Medium for value: medium
            /// </summary>
            [EnumMember(Value = "medium")]
            Medium = 3,

            /// <summary>
            /// Enum NotApplicable for value: notApplicable
            /// </summary>
            [EnumMember(Value = "notApplicable")]
            NotApplicable = 4

        }


        /// <summary>
        /// The requested level of the capability. Some capabilities, such as those used in [card issuing](https://docs.adyen.com/issuing/add-capabilities#capability-levels), have different levels. Levels increase the capability, but also require additional checks and increased monitoring.  Possible values: **notApplicable**, **low**, **medium**, **high**.
        /// </summary>
        /// <value>The requested level of the capability. Some capabilities, such as those used in [card issuing](https://docs.adyen.com/issuing/add-capabilities#capability-levels), have different levels. Levels increase the capability, but also require additional checks and increased monitoring.  Possible values: **notApplicable**, **low**, **medium**, **high**.</value>
        [DataMember(Name = "requestedLevel", EmitDefaultValue = false)]
        public RequestedLevelEnum? RequestedLevel { get; set; }
        /// <summary>
        /// The status of the verification checks for the supporting entity capability.  Possible values:  * **pending**: Adyen is running the verification.  * **invalid**: The verification failed. Check if the &#x60;errors&#x60; array contains more information.  * **valid**: The verification has been successfully completed.  * **rejected**: Adyen has verified the information, but found reasons to not allow the capability. 
        /// </summary>
        /// <value>The status of the verification checks for the supporting entity capability.  Possible values:  * **pending**: Adyen is running the verification.  * **invalid**: The verification failed. Check if the &#x60;errors&#x60; array contains more information.  * **valid**: The verification has been successfully completed.  * **rejected**: Adyen has verified the information, but found reasons to not allow the capability. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerificationStatusEnum
        {
            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 1,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 2,

            /// <summary>
            /// Enum Rejected for value: rejected
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected = 3,

            /// <summary>
            /// Enum Valid for value: valid
            /// </summary>
            [EnumMember(Value = "valid")]
            Valid = 4

        }


        /// <summary>
        /// The status of the verification checks for the supporting entity capability.  Possible values:  * **pending**: Adyen is running the verification.  * **invalid**: The verification failed. Check if the &#x60;errors&#x60; array contains more information.  * **valid**: The verification has been successfully completed.  * **rejected**: Adyen has verified the information, but found reasons to not allow the capability. 
        /// </summary>
        /// <value>The status of the verification checks for the supporting entity capability.  Possible values:  * **pending**: Adyen is running the verification.  * **invalid**: The verification failed. Check if the &#x60;errors&#x60; array contains more information.  * **valid**: The verification has been successfully completed.  * **rejected**: Adyen has verified the information, but found reasons to not allow the capability. </value>
        [DataMember(Name = "verificationStatus", EmitDefaultValue = false)]
        public VerificationStatusEnum? VerificationStatus { get; set; }

        /// <summary>
        /// Returns false as VerificationStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVerificationStatus()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountSupportingEntityCapability" /> class.
        /// </summary>
        /// <param name="enabled">Indicates whether the capability is enabled. If **false**, the capability is temporarily disabled for the account holder..</param>
        /// <param name="requested">Indicates whether the capability is requested. To check whether the account holder is permitted to use the capability, refer to the &#x60;allowed&#x60; field..</param>
        /// <param name="requestedLevel">The requested level of the capability. Some capabilities, such as those used in [card issuing](https://docs.adyen.com/issuing/add-capabilities#capability-levels), have different levels. Levels increase the capability, but also require additional checks and increased monitoring.  Possible values: **notApplicable**, **low**, **medium**, **high**..</param>
        public AccountSupportingEntityCapability(bool enabled = default(bool), bool requested = default(bool), RequestedLevelEnum? requestedLevel = default(RequestedLevelEnum?))
        {
            this.Enabled = enabled;
            this.Requested = requested;
            this.RequestedLevel = requestedLevel;
        }

        /// <summary>
        /// Indicates whether the supporting entity capability is allowed. Adyen sets this to **true** if the verification is successful and the account holder is permitted to use the capability.
        /// </summary>
        /// <value>Indicates whether the supporting entity capability is allowed. Adyen sets this to **true** if the verification is successful and the account holder is permitted to use the capability.</value>
        [DataMember(Name = "allowed", EmitDefaultValue = false)]
        public bool Allowed { get; private set; }

        /// <summary>
        /// Indicates whether the capability is enabled. If **false**, the capability is temporarily disabled for the account holder.
        /// </summary>
        /// <value>Indicates whether the capability is enabled. If **false**, the capability is temporarily disabled for the account holder.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The ID of the supporting entity.
        /// </summary>
        /// <value>The ID of the supporting entity.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Indicates whether the capability is requested. To check whether the account holder is permitted to use the capability, refer to the &#x60;allowed&#x60; field.
        /// </summary>
        /// <value>Indicates whether the capability is requested. To check whether the account holder is permitted to use the capability, refer to the &#x60;allowed&#x60; field.</value>
        [DataMember(Name = "requested", EmitDefaultValue = false)]
        public bool Requested { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountSupportingEntityCapability {\n");
            sb.Append("  Allowed: ").Append(Allowed).Append("\n");
            sb.Append("  AllowedLevel: ").Append(AllowedLevel).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Requested: ").Append(Requested).Append("\n");
            sb.Append("  RequestedLevel: ").Append(RequestedLevel).Append("\n");
            sb.Append("  VerificationStatus: ").Append(VerificationStatus).Append("\n");
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
            return this.Equals(input as AccountSupportingEntityCapability);
        }

        /// <summary>
        /// Returns true if AccountSupportingEntityCapability instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountSupportingEntityCapability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountSupportingEntityCapability input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Allowed == input.Allowed ||
                    this.Allowed.Equals(input.Allowed)
                ) && 
                (
                    this.AllowedLevel == input.AllowedLevel ||
                    this.AllowedLevel.Equals(input.AllowedLevel)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Requested == input.Requested ||
                    this.Requested.Equals(input.Requested)
                ) && 
                (
                    this.RequestedLevel == input.RequestedLevel ||
                    this.RequestedLevel.Equals(input.RequestedLevel)
                ) && 
                (
                    this.VerificationStatus == input.VerificationStatus ||
                    this.VerificationStatus.Equals(input.VerificationStatus)
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
                hashCode = (hashCode * 59) + this.Allowed.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowedLevel.GetHashCode();
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Requested.GetHashCode();
                hashCode = (hashCode * 59) + this.RequestedLevel.GetHashCode();
                hashCode = (hashCode * 59) + this.VerificationStatus.GetHashCode();
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
