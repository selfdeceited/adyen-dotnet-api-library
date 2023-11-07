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
    /// CheckoutVoucherAction
    /// </summary>
    [DataContract(Name = "CheckoutVoucherAction")]
    public partial class CheckoutVoucherAction : IEquatable<CheckoutVoucherAction>, IValidatableObject
    {
        /// <summary>
        /// **voucher**
        /// </summary>
        /// <value>**voucher**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Voucher for value: voucher
            /// </summary>
            [EnumMember(Value = "voucher")]
            Voucher = 1

        }


        /// <summary>
        /// **voucher**
        /// </summary>
        /// <value>**voucher**</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutVoucherAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckoutVoucherAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutVoucherAction" /> class.
        /// </summary>
        /// <param name="alternativeReference">The voucher alternative reference code..</param>
        /// <param name="collectionInstitutionNumber">A collection institution number (store number) for Econtext Pay-Easy ATM..</param>
        /// <param name="downloadUrl">The URL to download the voucher..</param>
        /// <param name="entity">An entity number of Multibanco..</param>
        /// <param name="expiresAt">The date time of the voucher expiry..</param>
        /// <param name="initialAmount">initialAmount.</param>
        /// <param name="instructionsUrl">The URL to the detailed instructions to make payment using the voucher..</param>
        /// <param name="issuer">The issuer of the voucher..</param>
        /// <param name="maskedTelephoneNumber">The shopper telephone number (partially masked)..</param>
        /// <param name="merchantName">The merchant name..</param>
        /// <param name="merchantReference">The merchant reference..</param>
        /// <param name="passCreationToken">A base64 encoded signature of all properties.</param>
        /// <param name="paymentData">A value that must be submitted to the &#x60;/payments/details&#x60; endpoint to verify this payment..</param>
        /// <param name="paymentMethodType">Specifies the payment method..</param>
        /// <param name="reference">The voucher reference code..</param>
        /// <param name="shopperEmail">The shopper email..</param>
        /// <param name="shopperName">The shopper name..</param>
        /// <param name="surcharge">surcharge.</param>
        /// <param name="totalAmount">totalAmount.</param>
        /// <param name="type">**voucher** (required).</param>
        /// <param name="url">Specifies the URL to redirect to..</param>
        public CheckoutVoucherAction(string alternativeReference = default(string), string collectionInstitutionNumber = default(string), string downloadUrl = default(string), string entity = default(string), string expiresAt = default(string), Amount initialAmount = default(Amount), string instructionsUrl = default(string), string issuer = default(string), string maskedTelephoneNumber = default(string), string merchantName = default(string), string merchantReference = default(string), string passCreationToken = default(string), string paymentData = default(string), string paymentMethodType = default(string), string reference = default(string), string shopperEmail = default(string), string shopperName = default(string), Amount surcharge = default(Amount), Amount totalAmount = default(Amount), TypeEnum type = default(TypeEnum), string url = default(string))
        {
            this.Type = type;
            this.AlternativeReference = alternativeReference;
            this.CollectionInstitutionNumber = collectionInstitutionNumber;
            this.DownloadUrl = downloadUrl;
            this.Entity = entity;
            this.ExpiresAt = expiresAt;
            this.InitialAmount = initialAmount;
            this.InstructionsUrl = instructionsUrl;
            this.Issuer = issuer;
            this.MaskedTelephoneNumber = maskedTelephoneNumber;
            this.MerchantName = merchantName;
            this.MerchantReference = merchantReference;
            this.PassCreationToken = passCreationToken;
            this.PaymentData = paymentData;
            this.PaymentMethodType = paymentMethodType;
            this.Reference = reference;
            this.ShopperEmail = shopperEmail;
            this.ShopperName = shopperName;
            this.Surcharge = surcharge;
            this.TotalAmount = totalAmount;
            this.Url = url;
        }

        /// <summary>
        /// The voucher alternative reference code.
        /// </summary>
        /// <value>The voucher alternative reference code.</value>
        [DataMember(Name = "alternativeReference", EmitDefaultValue = false)]
        public string AlternativeReference { get; set; }

        /// <summary>
        /// A collection institution number (store number) for Econtext Pay-Easy ATM.
        /// </summary>
        /// <value>A collection institution number (store number) for Econtext Pay-Easy ATM.</value>
        [DataMember(Name = "collectionInstitutionNumber", EmitDefaultValue = false)]
        public string CollectionInstitutionNumber { get; set; }

        /// <summary>
        /// The URL to download the voucher.
        /// </summary>
        /// <value>The URL to download the voucher.</value>
        [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// An entity number of Multibanco.
        /// </summary>
        /// <value>An entity number of Multibanco.</value>
        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public string Entity { get; set; }

        /// <summary>
        /// The date time of the voucher expiry.
        /// </summary>
        /// <value>The date time of the voucher expiry.</value>
        [DataMember(Name = "expiresAt", EmitDefaultValue = false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets InitialAmount
        /// </summary>
        [DataMember(Name = "initialAmount", EmitDefaultValue = false)]
        public Amount InitialAmount { get; set; }

        /// <summary>
        /// The URL to the detailed instructions to make payment using the voucher.
        /// </summary>
        /// <value>The URL to the detailed instructions to make payment using the voucher.</value>
        [DataMember(Name = "instructionsUrl", EmitDefaultValue = false)]
        public string InstructionsUrl { get; set; }

        /// <summary>
        /// The issuer of the voucher.
        /// </summary>
        /// <value>The issuer of the voucher.</value>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        public string Issuer { get; set; }

        /// <summary>
        /// The shopper telephone number (partially masked).
        /// </summary>
        /// <value>The shopper telephone number (partially masked).</value>
        [DataMember(Name = "maskedTelephoneNumber", EmitDefaultValue = false)]
        public string MaskedTelephoneNumber { get; set; }

        /// <summary>
        /// The merchant name.
        /// </summary>
        /// <value>The merchant name.</value>
        [DataMember(Name = "merchantName", EmitDefaultValue = false)]
        public string MerchantName { get; set; }

        /// <summary>
        /// The merchant reference.
        /// </summary>
        /// <value>The merchant reference.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// A base64 encoded signature of all properties
        /// </summary>
        /// <value>A base64 encoded signature of all properties</value>
        [DataMember(Name = "passCreationToken", EmitDefaultValue = false)]
        public string PassCreationToken { get; set; }

        /// <summary>
        /// A value that must be submitted to the &#x60;/payments/details&#x60; endpoint to verify this payment.
        /// </summary>
        /// <value>A value that must be submitted to the &#x60;/payments/details&#x60; endpoint to verify this payment.</value>
        [DataMember(Name = "paymentData", EmitDefaultValue = false)]
        public string PaymentData { get; set; }

        /// <summary>
        /// Specifies the payment method.
        /// </summary>
        /// <value>Specifies the payment method.</value>
        [DataMember(Name = "paymentMethodType", EmitDefaultValue = false)]
        public string PaymentMethodType { get; set; }

        /// <summary>
        /// The voucher reference code.
        /// </summary>
        /// <value>The voucher reference code.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The shopper email.
        /// </summary>
        /// <value>The shopper email.</value>
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// The shopper name.
        /// </summary>
        /// <value>The shopper name.</value>
        [DataMember(Name = "shopperName", EmitDefaultValue = false)]
        public string ShopperName { get; set; }

        /// <summary>
        /// Gets or Sets Surcharge
        /// </summary>
        [DataMember(Name = "surcharge", EmitDefaultValue = false)]
        public Amount Surcharge { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmount
        /// </summary>
        [DataMember(Name = "totalAmount", EmitDefaultValue = false)]
        public Amount TotalAmount { get; set; }

        /// <summary>
        /// Specifies the URL to redirect to.
        /// </summary>
        /// <value>Specifies the URL to redirect to.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckoutVoucherAction {\n");
            sb.Append("  AlternativeReference: ").Append(AlternativeReference).Append("\n");
            sb.Append("  CollectionInstitutionNumber: ").Append(CollectionInstitutionNumber).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  InitialAmount: ").Append(InitialAmount).Append("\n");
            sb.Append("  InstructionsUrl: ").Append(InstructionsUrl).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  MaskedTelephoneNumber: ").Append(MaskedTelephoneNumber).Append("\n");
            sb.Append("  MerchantName: ").Append(MerchantName).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  PassCreationToken: ").Append(PassCreationToken).Append("\n");
            sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
            sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  ShopperName: ").Append(ShopperName).Append("\n");
            sb.Append("  Surcharge: ").Append(Surcharge).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as CheckoutVoucherAction);
        }

        /// <summary>
        /// Returns true if CheckoutVoucherAction instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutVoucherAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutVoucherAction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AlternativeReference == input.AlternativeReference ||
                    (this.AlternativeReference != null &&
                    this.AlternativeReference.Equals(input.AlternativeReference))
                ) && 
                (
                    this.CollectionInstitutionNumber == input.CollectionInstitutionNumber ||
                    (this.CollectionInstitutionNumber != null &&
                    this.CollectionInstitutionNumber.Equals(input.CollectionInstitutionNumber))
                ) && 
                (
                    this.DownloadUrl == input.DownloadUrl ||
                    (this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(input.DownloadUrl))
                ) && 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.InitialAmount == input.InitialAmount ||
                    (this.InitialAmount != null &&
                    this.InitialAmount.Equals(input.InitialAmount))
                ) && 
                (
                    this.InstructionsUrl == input.InstructionsUrl ||
                    (this.InstructionsUrl != null &&
                    this.InstructionsUrl.Equals(input.InstructionsUrl))
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.MaskedTelephoneNumber == input.MaskedTelephoneNumber ||
                    (this.MaskedTelephoneNumber != null &&
                    this.MaskedTelephoneNumber.Equals(input.MaskedTelephoneNumber))
                ) && 
                (
                    this.MerchantName == input.MerchantName ||
                    (this.MerchantName != null &&
                    this.MerchantName.Equals(input.MerchantName))
                ) && 
                (
                    this.MerchantReference == input.MerchantReference ||
                    (this.MerchantReference != null &&
                    this.MerchantReference.Equals(input.MerchantReference))
                ) && 
                (
                    this.PassCreationToken == input.PassCreationToken ||
                    (this.PassCreationToken != null &&
                    this.PassCreationToken.Equals(input.PassCreationToken))
                ) && 
                (
                    this.PaymentData == input.PaymentData ||
                    (this.PaymentData != null &&
                    this.PaymentData.Equals(input.PaymentData))
                ) && 
                (
                    this.PaymentMethodType == input.PaymentMethodType ||
                    (this.PaymentMethodType != null &&
                    this.PaymentMethodType.Equals(input.PaymentMethodType))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.ShopperEmail == input.ShopperEmail ||
                    (this.ShopperEmail != null &&
                    this.ShopperEmail.Equals(input.ShopperEmail))
                ) && 
                (
                    this.ShopperName == input.ShopperName ||
                    (this.ShopperName != null &&
                    this.ShopperName.Equals(input.ShopperName))
                ) && 
                (
                    this.Surcharge == input.Surcharge ||
                    (this.Surcharge != null &&
                    this.Surcharge.Equals(input.Surcharge))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.AlternativeReference != null)
                {
                    hashCode = (hashCode * 59) + this.AlternativeReference.GetHashCode();
                }
                if (this.CollectionInstitutionNumber != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionInstitutionNumber.GetHashCode();
                }
                if (this.DownloadUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DownloadUrl.GetHashCode();
                }
                if (this.Entity != null)
                {
                    hashCode = (hashCode * 59) + this.Entity.GetHashCode();
                }
                if (this.ExpiresAt != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                }
                if (this.InitialAmount != null)
                {
                    hashCode = (hashCode * 59) + this.InitialAmount.GetHashCode();
                }
                if (this.InstructionsUrl != null)
                {
                    hashCode = (hashCode * 59) + this.InstructionsUrl.GetHashCode();
                }
                if (this.Issuer != null)
                {
                    hashCode = (hashCode * 59) + this.Issuer.GetHashCode();
                }
                if (this.MaskedTelephoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.MaskedTelephoneNumber.GetHashCode();
                }
                if (this.MerchantName != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantName.GetHashCode();
                }
                if (this.MerchantReference != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantReference.GetHashCode();
                }
                if (this.PassCreationToken != null)
                {
                    hashCode = (hashCode * 59) + this.PassCreationToken.GetHashCode();
                }
                if (this.PaymentData != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentData.GetHashCode();
                }
                if (this.PaymentMethodType != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethodType.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.ShopperEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperEmail.GetHashCode();
                }
                if (this.ShopperName != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperName.GetHashCode();
                }
                if (this.Surcharge != null)
                {
                    hashCode = (hashCode * 59) + this.Surcharge.GetHashCode();
                }
                if (this.TotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
