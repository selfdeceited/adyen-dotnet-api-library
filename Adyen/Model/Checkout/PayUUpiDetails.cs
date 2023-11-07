/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 71
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// PayUUpiDetails
    /// </summary>
    [DataContract(Name = "PayUUpiDetails")]
    public partial class PayUUpiDetails : IEquatable<PayUUpiDetails>, IValidatableObject
    {
        /// <summary>
        /// **payu_IN_upi**
        /// </summary>
        /// <value>**payu_IN_upi**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum PayuINUpi for value: payu_IN_upi
            /// </summary>
            [EnumMember(Value = "payu_IN_upi")]
            PayuINUpi = 1

        }


        /// <summary>
        /// **payu_IN_upi**
        /// </summary>
        /// <value>**payu_IN_upi**</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayUUpiDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayUUpiDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayUUpiDetails" /> class.
        /// </summary>
        /// <param name="checkoutAttemptId">The checkout attempt identifier..</param>
        /// <param name="recurringDetailReference">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="shopperNotificationReference">The &#x60;shopperNotificationReference&#x60; returned in the response when you requested to notify the shopper. Used for recurring payment only..</param>
        /// <param name="storedPaymentMethodId">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="type">**payu_IN_upi** (required) (default to TypeEnum.PayuINUpi).</param>
        /// <param name="virtualPaymentAddress">The virtual payment address for UPI..</param>
        public PayUUpiDetails(string checkoutAttemptId = default(string), string recurringDetailReference = default(string), string shopperNotificationReference = default(string), string storedPaymentMethodId = default(string), TypeEnum type = TypeEnum.PayuINUpi, string virtualPaymentAddress = default(string))
        {
            this.Type = type;
            this.CheckoutAttemptId = checkoutAttemptId;
            this.RecurringDetailReference = recurringDetailReference;
            this.ShopperNotificationReference = shopperNotificationReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            this.VirtualPaymentAddress = virtualPaymentAddress;
        }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        /// <value>The checkout attempt identifier.</value>
        [DataMember(Name = "checkoutAttemptId", EmitDefaultValue = false)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
        [Obsolete]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// The &#x60;shopperNotificationReference&#x60; returned in the response when you requested to notify the shopper. Used for recurring payment only.
        /// </summary>
        /// <value>The &#x60;shopperNotificationReference&#x60; returned in the response when you requested to notify the shopper. Used for recurring payment only.</value>
        [DataMember(Name = "shopperNotificationReference", EmitDefaultValue = false)]
        public string ShopperNotificationReference { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// The virtual payment address for UPI.
        /// </summary>
        /// <value>The virtual payment address for UPI.</value>
        [DataMember(Name = "virtualPaymentAddress", EmitDefaultValue = false)]
        public string VirtualPaymentAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PayUUpiDetails {\n");
            sb.Append("  CheckoutAttemptId: ").Append(CheckoutAttemptId).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  ShopperNotificationReference: ").Append(ShopperNotificationReference).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VirtualPaymentAddress: ").Append(VirtualPaymentAddress).Append("\n");
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
            return this.Equals(input as PayUUpiDetails);
        }

        /// <summary>
        /// Returns true if PayUUpiDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PayUUpiDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayUUpiDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CheckoutAttemptId == input.CheckoutAttemptId ||
                    (this.CheckoutAttemptId != null &&
                    this.CheckoutAttemptId.Equals(input.CheckoutAttemptId))
                ) && 
                (
                    this.RecurringDetailReference == input.RecurringDetailReference ||
                    (this.RecurringDetailReference != null &&
                    this.RecurringDetailReference.Equals(input.RecurringDetailReference))
                ) && 
                (
                    this.ShopperNotificationReference == input.ShopperNotificationReference ||
                    (this.ShopperNotificationReference != null &&
                    this.ShopperNotificationReference.Equals(input.ShopperNotificationReference))
                ) && 
                (
                    this.StoredPaymentMethodId == input.StoredPaymentMethodId ||
                    (this.StoredPaymentMethodId != null &&
                    this.StoredPaymentMethodId.Equals(input.StoredPaymentMethodId))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.VirtualPaymentAddress == input.VirtualPaymentAddress ||
                    (this.VirtualPaymentAddress != null &&
                    this.VirtualPaymentAddress.Equals(input.VirtualPaymentAddress))
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
                if (this.CheckoutAttemptId != null)
                {
                    hashCode = (hashCode * 59) + this.CheckoutAttemptId.GetHashCode();
                }
                if (this.RecurringDetailReference != null)
                {
                    hashCode = (hashCode * 59) + this.RecurringDetailReference.GetHashCode();
                }
                if (this.ShopperNotificationReference != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperNotificationReference.GetHashCode();
                }
                if (this.StoredPaymentMethodId != null)
                {
                    hashCode = (hashCode * 59) + this.StoredPaymentMethodId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.VirtualPaymentAddress != null)
                {
                    hashCode = (hashCode * 59) + this.VirtualPaymentAddress.GetHashCode();
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
            // StoredPaymentMethodId (string) maxLength
            if (this.StoredPaymentMethodId != null && this.StoredPaymentMethodId.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StoredPaymentMethodId, length must be less than 64.", new [] { "StoredPaymentMethodId" });
            }

            yield break;
        }
    }

}
