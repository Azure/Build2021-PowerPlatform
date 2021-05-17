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
    public partial class InlineResponseDefault7Options : IEquatable<InlineResponseDefault7Options>
    { 
        /// <summary>
        /// Value
        /// </summary>
        /// <value>Value</value>
        [DataMember(Name="Value")]
        public int? Value { get; set; }

        /// <summary>
        /// Color
        /// </summary>
        /// <value>Color</value>
        [DataMember(Name="Color")]
        public string Color { get; set; }

        /// <summary>
        /// IsManaged
        /// </summary>
        /// <value>IsManaged</value>
        [DataMember(Name="IsManaged")]
        public bool? IsManaged { get; set; }

        /// <summary>
        /// ExternalValue
        /// </summary>
        /// <value>ExternalValue</value>
        [DataMember(Name="ExternalValue")]
        public string ExternalValue { get; set; }

        /// <summary>
        /// ParentValues
        /// </summary>
        /// <value>ParentValues</value>
        [DataMember(Name="ParentValues")]
        public List<Object> ParentValues { get; set; }

        /// <summary>
        /// MetadataId
        /// </summary>
        /// <value>MetadataId</value>
        [DataMember(Name="MetadataId")]
        public string MetadataId { get; set; }

        /// <summary>
        /// HasChanged
        /// </summary>
        /// <value>HasChanged</value>
        [DataMember(Name="HasChanged")]
        public string HasChanged { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="Label")]
        public InlineResponseDefault6OptionSetLabel Label { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description")]
        public InlineResponseDefault7Description Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponseDefault7Options {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  IsManaged: ").Append(IsManaged).Append("\n");
            sb.Append("  ExternalValue: ").Append(ExternalValue).Append("\n");
            sb.Append("  ParentValues: ").Append(ParentValues).Append("\n");
            sb.Append("  MetadataId: ").Append(MetadataId).Append("\n");
            sb.Append("  HasChanged: ").Append(HasChanged).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InlineResponseDefault7Options)obj);
        }

        /// <summary>
        /// Returns true if InlineResponseDefault7Options instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponseDefault7Options to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponseDefault7Options other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
                ) && 
                (
                    Color == other.Color ||
                    Color != null &&
                    Color.Equals(other.Color)
                ) && 
                (
                    IsManaged == other.IsManaged ||
                    IsManaged != null &&
                    IsManaged.Equals(other.IsManaged)
                ) && 
                (
                    ExternalValue == other.ExternalValue ||
                    ExternalValue != null &&
                    ExternalValue.Equals(other.ExternalValue)
                ) && 
                (
                    ParentValues == other.ParentValues ||
                    ParentValues != null &&
                    ParentValues.SequenceEqual(other.ParentValues)
                ) && 
                (
                    MetadataId == other.MetadataId ||
                    MetadataId != null &&
                    MetadataId.Equals(other.MetadataId)
                ) && 
                (
                    HasChanged == other.HasChanged ||
                    HasChanged != null &&
                    HasChanged.Equals(other.HasChanged)
                ) && 
                (
                    Label == other.Label ||
                    Label != null &&
                    Label.Equals(other.Label)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
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
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                    if (Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();
                    if (IsManaged != null)
                    hashCode = hashCode * 59 + IsManaged.GetHashCode();
                    if (ExternalValue != null)
                    hashCode = hashCode * 59 + ExternalValue.GetHashCode();
                    if (ParentValues != null)
                    hashCode = hashCode * 59 + ParentValues.GetHashCode();
                    if (MetadataId != null)
                    hashCode = hashCode * 59 + MetadataId.GetHashCode();
                    if (HasChanged != null)
                    hashCode = hashCode * 59 + HasChanged.GetHashCode();
                    if (Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponseDefault7Options left, InlineResponseDefault7Options right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponseDefault7Options left, InlineResponseDefault7Options right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
