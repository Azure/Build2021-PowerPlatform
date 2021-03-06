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
    /// 
    /// </summary>
    [DataContract]
    public partial class InlineResponseDefault6Value : IEquatable<InlineResponseDefault6Value>
    { 
        /// <summary>
        /// LogicalName
        /// </summary>
        /// <value>LogicalName</value>
        [DataMember(Name="LogicalName")]
        public string LogicalName { get; set; }

        /// <summary>
        /// MetadataId
        /// </summary>
        /// <value>MetadataId</value>
        [DataMember(Name="MetadataId")]
        public string MetadataId { get; set; }

        /// <summary>
        /// Gets or Sets OptionSet
        /// </summary>
        [DataMember(Name="OptionSet")]
        public InlineResponseDefault6OptionSet OptionSet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponseDefault6Value {\n");
            sb.Append("  LogicalName: ").Append(LogicalName).Append("\n");
            sb.Append("  MetadataId: ").Append(MetadataId).Append("\n");
            sb.Append("  OptionSet: ").Append(OptionSet).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InlineResponseDefault6Value)obj);
        }

        /// <summary>
        /// Returns true if InlineResponseDefault6Value instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponseDefault6Value to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponseDefault6Value other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LogicalName == other.LogicalName ||
                    LogicalName != null &&
                    LogicalName.Equals(other.LogicalName)
                ) && 
                (
                    MetadataId == other.MetadataId ||
                    MetadataId != null &&
                    MetadataId.Equals(other.MetadataId)
                ) && 
                (
                    OptionSet == other.OptionSet ||
                    OptionSet != null &&
                    OptionSet.Equals(other.OptionSet)
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
                    if (LogicalName != null)
                    hashCode = hashCode * 59 + LogicalName.GetHashCode();
                    if (MetadataId != null)
                    hashCode = hashCode * 59 + MetadataId.GetHashCode();
                    if (OptionSet != null)
                    hashCode = hashCode * 59 + OptionSet.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponseDefault6Value left, InlineResponseDefault6Value right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponseDefault6Value left, InlineResponseDefault6Value right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
