/*
 * CDS - GtmEntries
 *
 * CDS - GtmEntries
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace APIMDemo.Models
{ 
    /// <summary>
    /// Description
    /// </summary>
    [DataContract]
    public partial class InlineResponseDefault7Description : IEquatable<InlineResponseDefault7Description>
    { 
        /// <summary>
        /// LocalizedLabels
        /// </summary>
        /// <value>LocalizedLabels</value>
        [DataMember(Name="LocalizedLabels")]
        public List<Object> LocalizedLabels { get; set; }

        /// <summary>
        /// UserLocalizedLabel
        /// </summary>
        /// <value>UserLocalizedLabel</value>
        [DataMember(Name="UserLocalizedLabel")]
        public string UserLocalizedLabel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponseDefault7Description {\n");
            sb.Append("  LocalizedLabels: ").Append(LocalizedLabels).Append("\n");
            sb.Append("  UserLocalizedLabel: ").Append(UserLocalizedLabel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((InlineResponseDefault7Description)obj);
        }

        /// <summary>
        /// Returns true if InlineResponseDefault7Description instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponseDefault7Description to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponseDefault7Description other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LocalizedLabels == other.LocalizedLabels ||
                    LocalizedLabels != null &&
                    LocalizedLabels.SequenceEqual(other.LocalizedLabels)
                ) && 
                (
                    UserLocalizedLabel == other.UserLocalizedLabel ||
                    UserLocalizedLabel != null &&
                    UserLocalizedLabel.Equals(other.UserLocalizedLabel)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (LocalizedLabels != null)
                    hashCode = hashCode * 59 + LocalizedLabels.GetHashCode();
                    if (UserLocalizedLabel != null)
                    hashCode = hashCode * 59 + UserLocalizedLabel.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponseDefault7Description left, InlineResponseDefault7Description right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponseDefault7Description left, InlineResponseDefault7Description right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
