/*
* Transfers API
*
*
* The version of the OpenAPI document: 4
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

namespace Adyen.Model.Transfers
{
    /// <summary>
    /// ReturnTransferResponse
    /// </summary>
    [DataContract(Name = "ReturnTransferResponse")]
    public partial class ReturnTransferResponse : IEquatable<ReturnTransferResponse>, IValidatableObject
    {
        /// <summary>
        /// The resulting status of the return.  For example: **authorised**, **booked**, **error**.
        /// </summary>
        /// <value>The resulting status of the return.  For example: **authorised**, **booked**, **error**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Authorised for value: Authorised
            /// </summary>
            [EnumMember(Value = "Authorised")]
            Authorised = 1,

            /// <summary>
            /// Enum Declined for value: Declined
            /// </summary>
            [EnumMember(Value = "Declined")]
            Declined = 2

        }


        /// <summary>
        /// The resulting status of the return.  For example: **authorised**, **booked**, **error**.
        /// </summary>
        /// <value>The resulting status of the return.  For example: **authorised**, **booked**, **error**.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnTransferResponse" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the return..</param>
        /// <param name="reference">Your internal reference for the return..</param>
        /// <param name="status">The resulting status of the return.  For example: **authorised**, **booked**, **error**..</param>
        /// <param name="transferId">The unique identifier of the original transfer..</param>
        public ReturnTransferResponse(string id = default(string), string reference = default(string), StatusEnum? status = default(StatusEnum?), string transferId = default(string))
        {
            this.Id = id;
            this.Reference = reference;
            this.Status = status;
            this.TransferId = transferId;
        }

        /// <summary>
        /// The unique identifier of the return.
        /// </summary>
        /// <value>The unique identifier of the return.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Your internal reference for the return.
        /// </summary>
        /// <value>Your internal reference for the return.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The unique identifier of the original transfer.
        /// </summary>
        /// <value>The unique identifier of the original transfer.</value>
        [DataMember(Name = "transferId", EmitDefaultValue = false)]
        public string TransferId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReturnTransferResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TransferId: ").Append(TransferId).Append("\n");
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
            return this.Equals(input as ReturnTransferResponse);
        }

        /// <summary>
        /// Returns true if ReturnTransferResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ReturnTransferResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReturnTransferResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.TransferId == input.TransferId ||
                    (this.TransferId != null &&
                    this.TransferId.Equals(input.TransferId))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.TransferId != null)
                {
                    hashCode = (hashCode * 59) + this.TransferId.GetHashCode();
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
