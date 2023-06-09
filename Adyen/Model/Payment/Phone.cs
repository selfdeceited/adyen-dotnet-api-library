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
    /// Phone
    /// </summary>
    [DataContract(Name = "Phone")]
    public partial class Phone : IEquatable<Phone>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Phone" /> class.
        /// </summary>
        /// <param name="cc">Country code. Length: 1–3 characters..</param>
        /// <param name="subscriber">Subscriber number. Maximum length: 15 characters..</param>
        public Phone(string cc = default(string), string subscriber = default(string))
        {
            this.Cc = cc;
            this.Subscriber = subscriber;
        }

        /// <summary>
        /// Country code. Length: 1–3 characters.
        /// </summary>
        /// <value>Country code. Length: 1–3 characters.</value>
        [DataMember(Name = "cc", EmitDefaultValue = false)]
        public string Cc { get; set; }

        /// <summary>
        /// Subscriber number. Maximum length: 15 characters.
        /// </summary>
        /// <value>Subscriber number. Maximum length: 15 characters.</value>
        [DataMember(Name = "subscriber", EmitDefaultValue = false)]
        public string Subscriber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Phone {\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Subscriber: ").Append(Subscriber).Append("\n");
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
            return this.Equals(input as Phone);
        }

        /// <summary>
        /// Returns true if Phone instances are equal
        /// </summary>
        /// <param name="input">Instance of Phone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Phone input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cc == input.Cc ||
                    (this.Cc != null &&
                    this.Cc.Equals(input.Cc))
                ) && 
                (
                    this.Subscriber == input.Subscriber ||
                    (this.Subscriber != null &&
                    this.Subscriber.Equals(input.Subscriber))
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
                if (this.Cc != null)
                {
                    hashCode = (hashCode * 59) + this.Cc.GetHashCode();
                }
                if (this.Subscriber != null)
                {
                    hashCode = (hashCode * 59) + this.Subscriber.GetHashCode();
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
            // Cc (string) maxLength
            if (this.Cc != null && this.Cc.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cc, length must be less than 3.", new [] { "Cc" });
            }

            // Cc (string) minLength
            if (this.Cc != null && this.Cc.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cc, length must be greater than 1.", new [] { "Cc" });
            }

            // Subscriber (string) maxLength
            if (this.Subscriber != null && this.Subscriber.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Subscriber, length must be less than 15.", new [] { "Subscriber" });
            }

            yield break;
        }
    }

}
