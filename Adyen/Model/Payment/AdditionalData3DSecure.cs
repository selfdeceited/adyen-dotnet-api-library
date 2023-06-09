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
    /// AdditionalData3DSecure
    /// </summary>
    [DataContract(Name = "AdditionalData3DSecure")]
    public partial class AdditionalData3DSecure : IEquatable<AdditionalData3DSecure>, IValidatableObject
    {
        /// <summary>
        /// Dimensions of the 3DS2 challenge window to be displayed to the cardholder.  Possible values:  * **01** - size of 250x400  * **02** - size of 390x400 * **03** - size of 500x600 * **04** - size of 600x400 * **05** - Fullscreen
        /// </summary>
        /// <value>Dimensions of the 3DS2 challenge window to be displayed to the cardholder.  Possible values:  * **01** - size of 250x400  * **02** - size of 390x400 * **03** - size of 500x600 * **04** - size of 600x400 * **05** - Fullscreen</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChallengeWindowSizeEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01 = 1,

            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")]
            _02 = 2,

            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")]
            _03 = 3,

            /// <summary>
            /// Enum _04 for value: 04
            /// </summary>
            [EnumMember(Value = "04")]
            _04 = 4,

            /// <summary>
            /// Enum _05 for value: 05
            /// </summary>
            [EnumMember(Value = "05")]
            _05 = 5

        }


        /// <summary>
        /// Dimensions of the 3DS2 challenge window to be displayed to the cardholder.  Possible values:  * **01** - size of 250x400  * **02** - size of 390x400 * **03** - size of 500x600 * **04** - size of 600x400 * **05** - Fullscreen
        /// </summary>
        /// <value>Dimensions of the 3DS2 challenge window to be displayed to the cardholder.  Possible values:  * **01** - size of 250x400  * **02** - size of 390x400 * **03** - size of 500x600 * **04** - size of 600x400 * **05** - Fullscreen</value>
        [DataMember(Name = "challengeWindowSize", EmitDefaultValue = false)]
        public ChallengeWindowSizeEnum? ChallengeWindowSize { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalData3DSecure" /> class.
        /// </summary>
        /// <param name="allow3DS2">Indicates if you are able to process 3D Secure 2 transactions natively on your payment page. Send this parameter when you are using &#x60;/payments&#x60; endpoint with any of our [native 3D Secure 2 solutions](https://docs.adyen.com/online-payments/3d-secure/native-3ds2).   &gt; This parameter only indicates readiness to support native 3D Secure 2 authentication. To specify if you _want_ to perform 3D Secure, use [Dynamic 3D Secure](/risk-management/dynamic-3d-secure) or send the &#x60;executeThreeD&#x60; parameter.  Possible values: * **true** - Ready to support native 3D Secure 2 authentication. Setting this to true does not mean always applying 3D Secure 2. Adyen still selects the version of 3D Secure based on configuration to optimize authorisation rates and improve the shopper&#39;s experience. * **false** – Not ready to support native 3D Secure 2 authentication. Adyen will not offer 3D Secure 2 to your shopper regardless of your configuration. .</param>
        /// <param name="challengeWindowSize">Dimensions of the 3DS2 challenge window to be displayed to the cardholder.  Possible values:  * **01** - size of 250x400  * **02** - size of 390x400 * **03** - size of 500x600 * **04** - size of 600x400 * **05** - Fullscreen.</param>
        /// <param name="executeThreeD">Indicates if you want to perform 3D Secure authentication on a transaction.   &gt; Alternatively, you can use [Dynamic 3D Secure](/risk-management/dynamic-3d-secure) to configure rules for applying 3D Secure.  Possible values: * **true** – Perform 3D Secure authentication. * **false** – Don&#39;t perform 3D Secure authentication. Note that this setting results in refusals if the issuer mandates 3D Secure because of the PSD2 directive  or other, national regulations.  .</param>
        /// <param name="mpiImplementationType">In case of Secure+, this field must be set to **CUPSecurePlus**..</param>
        /// <param name="scaExemption">Indicates the [exemption type](https://docs.adyen.com/payments-fundamentals/psd2-sca-compliance-and-implementation-guide#specifypreferenceinyourapirequest) that you want to request for the transaction.   Possible values: * **lowValue**  * **secureCorporate**  * **trustedBeneficiary**  * **transactionRiskAnalysis** .</param>
        /// <param name="threeDSVersion">Indicates your preference for the 3D Secure version.  &gt; If you use this parameter, you override the checks from Adyen&#39;s Authentication Engine. We recommend to use this field only if you have an extensive knowledge of 3D Secure.  Possible values: * **1.0.2**: Apply 3D Secure version 1.0.2.  * **2.1.0**: Apply 3D Secure version 2.1.0.  * **2.2.0**: Apply 3D Secure version 2.2.0. If the issuer does not support version 2.2.0, we will fall back to 2.1.0.  The following rules apply: * If you prefer 2.1.0 or 2.2.0 but we receive a negative &#x60;transStatus&#x60; in the &#x60;ARes&#x60;, we will apply the fallback policy configured in your account. For example, if the configuration is to fall back to 3D Secure 1, we will apply version 1.0.2. * If you prefer 2.1.0 or 2.2.0 but the BIN is not enrolled, you will receive an error.  .</param>
        public AdditionalData3DSecure(string allow3DS2 = default(string), ChallengeWindowSizeEnum? challengeWindowSize = default(ChallengeWindowSizeEnum?), string executeThreeD = default(string), string mpiImplementationType = default(string), string scaExemption = default(string), string threeDSVersion = default(string))
        {
            this.Allow3DS2 = allow3DS2;
            this.ChallengeWindowSize = challengeWindowSize;
            this.ExecuteThreeD = executeThreeD;
            this.MpiImplementationType = mpiImplementationType;
            this.ScaExemption = scaExemption;
            this.ThreeDSVersion = threeDSVersion;
        }

        /// <summary>
        /// Indicates if you are able to process 3D Secure 2 transactions natively on your payment page. Send this parameter when you are using &#x60;/payments&#x60; endpoint with any of our [native 3D Secure 2 solutions](https://docs.adyen.com/online-payments/3d-secure/native-3ds2).   &gt; This parameter only indicates readiness to support native 3D Secure 2 authentication. To specify if you _want_ to perform 3D Secure, use [Dynamic 3D Secure](/risk-management/dynamic-3d-secure) or send the &#x60;executeThreeD&#x60; parameter.  Possible values: * **true** - Ready to support native 3D Secure 2 authentication. Setting this to true does not mean always applying 3D Secure 2. Adyen still selects the version of 3D Secure based on configuration to optimize authorisation rates and improve the shopper&#39;s experience. * **false** – Not ready to support native 3D Secure 2 authentication. Adyen will not offer 3D Secure 2 to your shopper regardless of your configuration. 
        /// </summary>
        /// <value>Indicates if you are able to process 3D Secure 2 transactions natively on your payment page. Send this parameter when you are using &#x60;/payments&#x60; endpoint with any of our [native 3D Secure 2 solutions](https://docs.adyen.com/online-payments/3d-secure/native-3ds2).   &gt; This parameter only indicates readiness to support native 3D Secure 2 authentication. To specify if you _want_ to perform 3D Secure, use [Dynamic 3D Secure](/risk-management/dynamic-3d-secure) or send the &#x60;executeThreeD&#x60; parameter.  Possible values: * **true** - Ready to support native 3D Secure 2 authentication. Setting this to true does not mean always applying 3D Secure 2. Adyen still selects the version of 3D Secure based on configuration to optimize authorisation rates and improve the shopper&#39;s experience. * **false** – Not ready to support native 3D Secure 2 authentication. Adyen will not offer 3D Secure 2 to your shopper regardless of your configuration. </value>
        [DataMember(Name = "allow3DS2", EmitDefaultValue = false)]
        public string Allow3DS2 { get; set; }

        /// <summary>
        /// Indicates if you want to perform 3D Secure authentication on a transaction.   &gt; Alternatively, you can use [Dynamic 3D Secure](/risk-management/dynamic-3d-secure) to configure rules for applying 3D Secure.  Possible values: * **true** – Perform 3D Secure authentication. * **false** – Don&#39;t perform 3D Secure authentication. Note that this setting results in refusals if the issuer mandates 3D Secure because of the PSD2 directive  or other, national regulations.  
        /// </summary>
        /// <value>Indicates if you want to perform 3D Secure authentication on a transaction.   &gt; Alternatively, you can use [Dynamic 3D Secure](/risk-management/dynamic-3d-secure) to configure rules for applying 3D Secure.  Possible values: * **true** – Perform 3D Secure authentication. * **false** – Don&#39;t perform 3D Secure authentication. Note that this setting results in refusals if the issuer mandates 3D Secure because of the PSD2 directive  or other, national regulations.  </value>
        [DataMember(Name = "executeThreeD", EmitDefaultValue = false)]
        public string ExecuteThreeD { get; set; }

        /// <summary>
        /// In case of Secure+, this field must be set to **CUPSecurePlus**.
        /// </summary>
        /// <value>In case of Secure+, this field must be set to **CUPSecurePlus**.</value>
        [DataMember(Name = "mpiImplementationType", EmitDefaultValue = false)]
        public string MpiImplementationType { get; set; }

        /// <summary>
        /// Indicates the [exemption type](https://docs.adyen.com/payments-fundamentals/psd2-sca-compliance-and-implementation-guide#specifypreferenceinyourapirequest) that you want to request for the transaction.   Possible values: * **lowValue**  * **secureCorporate**  * **trustedBeneficiary**  * **transactionRiskAnalysis** 
        /// </summary>
        /// <value>Indicates the [exemption type](https://docs.adyen.com/payments-fundamentals/psd2-sca-compliance-and-implementation-guide#specifypreferenceinyourapirequest) that you want to request for the transaction.   Possible values: * **lowValue**  * **secureCorporate**  * **trustedBeneficiary**  * **transactionRiskAnalysis** </value>
        [DataMember(Name = "scaExemption", EmitDefaultValue = false)]
        public string ScaExemption { get; set; }

        /// <summary>
        /// Indicates your preference for the 3D Secure version.  &gt; If you use this parameter, you override the checks from Adyen&#39;s Authentication Engine. We recommend to use this field only if you have an extensive knowledge of 3D Secure.  Possible values: * **1.0.2**: Apply 3D Secure version 1.0.2.  * **2.1.0**: Apply 3D Secure version 2.1.0.  * **2.2.0**: Apply 3D Secure version 2.2.0. If the issuer does not support version 2.2.0, we will fall back to 2.1.0.  The following rules apply: * If you prefer 2.1.0 or 2.2.0 but we receive a negative &#x60;transStatus&#x60; in the &#x60;ARes&#x60;, we will apply the fallback policy configured in your account. For example, if the configuration is to fall back to 3D Secure 1, we will apply version 1.0.2. * If you prefer 2.1.0 or 2.2.0 but the BIN is not enrolled, you will receive an error.  
        /// </summary>
        /// <value>Indicates your preference for the 3D Secure version.  &gt; If you use this parameter, you override the checks from Adyen&#39;s Authentication Engine. We recommend to use this field only if you have an extensive knowledge of 3D Secure.  Possible values: * **1.0.2**: Apply 3D Secure version 1.0.2.  * **2.1.0**: Apply 3D Secure version 2.1.0.  * **2.2.0**: Apply 3D Secure version 2.2.0. If the issuer does not support version 2.2.0, we will fall back to 2.1.0.  The following rules apply: * If you prefer 2.1.0 or 2.2.0 but we receive a negative &#x60;transStatus&#x60; in the &#x60;ARes&#x60;, we will apply the fallback policy configured in your account. For example, if the configuration is to fall back to 3D Secure 1, we will apply version 1.0.2. * If you prefer 2.1.0 or 2.2.0 but the BIN is not enrolled, you will receive an error.  </value>
        [DataMember(Name = "threeDSVersion", EmitDefaultValue = false)]
        public string ThreeDSVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdditionalData3DSecure {\n");
            sb.Append("  Allow3DS2: ").Append(Allow3DS2).Append("\n");
            sb.Append("  ChallengeWindowSize: ").Append(ChallengeWindowSize).Append("\n");
            sb.Append("  ExecuteThreeD: ").Append(ExecuteThreeD).Append("\n");
            sb.Append("  MpiImplementationType: ").Append(MpiImplementationType).Append("\n");
            sb.Append("  ScaExemption: ").Append(ScaExemption).Append("\n");
            sb.Append("  ThreeDSVersion: ").Append(ThreeDSVersion).Append("\n");
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
            return this.Equals(input as AdditionalData3DSecure);
        }

        /// <summary>
        /// Returns true if AdditionalData3DSecure instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalData3DSecure to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalData3DSecure input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Allow3DS2 == input.Allow3DS2 ||
                    (this.Allow3DS2 != null &&
                    this.Allow3DS2.Equals(input.Allow3DS2))
                ) && 
                (
                    this.ChallengeWindowSize == input.ChallengeWindowSize ||
                    this.ChallengeWindowSize.Equals(input.ChallengeWindowSize)
                ) && 
                (
                    this.ExecuteThreeD == input.ExecuteThreeD ||
                    (this.ExecuteThreeD != null &&
                    this.ExecuteThreeD.Equals(input.ExecuteThreeD))
                ) && 
                (
                    this.MpiImplementationType == input.MpiImplementationType ||
                    (this.MpiImplementationType != null &&
                    this.MpiImplementationType.Equals(input.MpiImplementationType))
                ) && 
                (
                    this.ScaExemption == input.ScaExemption ||
                    (this.ScaExemption != null &&
                    this.ScaExemption.Equals(input.ScaExemption))
                ) && 
                (
                    this.ThreeDSVersion == input.ThreeDSVersion ||
                    (this.ThreeDSVersion != null &&
                    this.ThreeDSVersion.Equals(input.ThreeDSVersion))
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
                if (this.Allow3DS2 != null)
                {
                    hashCode = (hashCode * 59) + this.Allow3DS2.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChallengeWindowSize.GetHashCode();
                if (this.ExecuteThreeD != null)
                {
                    hashCode = (hashCode * 59) + this.ExecuteThreeD.GetHashCode();
                }
                if (this.MpiImplementationType != null)
                {
                    hashCode = (hashCode * 59) + this.MpiImplementationType.GetHashCode();
                }
                if (this.ScaExemption != null)
                {
                    hashCode = (hashCode * 59) + this.ScaExemption.GetHashCode();
                }
                if (this.ThreeDSVersion != null)
                {
                    hashCode = (hashCode * 59) + this.ThreeDSVersion.GetHashCode();
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
