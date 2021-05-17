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
    /// OptionSet
    /// </summary>
    [DataContract]
    public partial class InlineResponseDefault6OptionSet : IEquatable<InlineResponseDefault6OptionSet>
    { 
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
        /// IsCustomOptionSet
        /// </summary>
        /// <value>IsCustomOptionSet</value>
        [DataMember(Name="IsCustomOptionSet")]
        public bool? IsCustomOptionSet { get; set; }

        /// <summary>
        /// IsGlobal
        /// </summary>
        /// <value>IsGlobal</value>
        [DataMember(Name="IsGlobal")]
        public bool? IsGlobal { get; set; }

        /// <summary>
        /// IsManaged
        /// </summary>
        /// <value>IsManaged</value>
        [DataMember(Name="IsManaged")]
        public bool? IsManaged { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// ExternalTypeName
        /// </summary>
        /// <value>ExternalTypeName</value>
        [DataMember(Name="ExternalTypeName")]
        public string ExternalTypeName { get; set; }

        /// <summary>
        /// OptionSetType
        /// </summary>
        /// <value>OptionSetType</value>
        [DataMember(Name="OptionSetType")]
        public string OptionSetType { get; set; }

        /// <summary>
        /// IntroducedVersion
        /// </summary>
        /// <value>IntroducedVersion</value>
        [DataMember(Name="IntroducedVersion")]
        public string IntroducedVersion { get; set; }

        /// <summary>
        /// ParentOptionSetName
        /// </summary>
        /// <value>ParentOptionSetName</value>
        [DataMember(Name="ParentOptionSetName")]
        public string ParentOptionSetName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description")]
        public InlineResponseDefault6OptionSetDescription Description { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="DisplayName")]
        public InlineResponseDefault6OptionSetDisplayName DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets IsCustomizable
        /// </summary>
        [DataMember(Name="IsCustomizable")]
        public InlineResponseDefault6OptionSetIsCustomizable IsCustomizable { get; set; }

        /// <summary>
        /// Options
        /// </summary>
        /// <value>Options</value>
        [DataMember(Name="Options")]
        public List<InlineResponseDefault6OptionSetOptions> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponseDefault6OptionSet {\n");
            sb.Append("  MetadataId: ").Append(MetadataId).Append("\n");
            sb.Append("  HasChanged: ").Append(HasChanged).Append("\n");
            sb.Append("  IsCustomOptionSet: ").Append(IsCustomOptionSet).Append("\n");
            sb.Append("  IsGlobal: ").Append(IsGlobal).Append("\n");
            sb.Append("  IsManaged: ").Append(IsManaged).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExternalTypeName: ").Append(ExternalTypeName).Append("\n");
            sb.Append("  OptionSetType: ").Append(OptionSetType).Append("\n");
            sb.Append("  IntroducedVersion: ").Append(IntroducedVersion).Append("\n");
            sb.Append("  ParentOptionSetName: ").Append(ParentOptionSetName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  IsCustomizable: ").Append(IsCustomizable).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InlineResponseDefault6OptionSet)obj);
        }

        /// <summary>
        /// Returns true if InlineResponseDefault6OptionSet instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponseDefault6OptionSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponseDefault6OptionSet other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
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
                    IsCustomOptionSet == other.IsCustomOptionSet ||
                    IsCustomOptionSet != null &&
                    IsCustomOptionSet.Equals(other.IsCustomOptionSet)
                ) && 
                (
                    IsGlobal == other.IsGlobal ||
                    IsGlobal != null &&
                    IsGlobal.Equals(other.IsGlobal)
                ) && 
                (
                    IsManaged == other.IsManaged ||
                    IsManaged != null &&
                    IsManaged.Equals(other.IsManaged)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    ExternalTypeName == other.ExternalTypeName ||
                    ExternalTypeName != null &&
                    ExternalTypeName.Equals(other.ExternalTypeName)
                ) && 
                (
                    OptionSetType == other.OptionSetType ||
                    OptionSetType != null &&
                    OptionSetType.Equals(other.OptionSetType)
                ) && 
                (
                    IntroducedVersion == other.IntroducedVersion ||
                    IntroducedVersion != null &&
                    IntroducedVersion.Equals(other.IntroducedVersion)
                ) && 
                (
                    ParentOptionSetName == other.ParentOptionSetName ||
                    ParentOptionSetName != null &&
                    ParentOptionSetName.Equals(other.ParentOptionSetName)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    DisplayName == other.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    IsCustomizable == other.IsCustomizable ||
                    IsCustomizable != null &&
                    IsCustomizable.Equals(other.IsCustomizable)
                ) && 
                (
                    Options == other.Options ||
                    Options != null &&
                    Options.SequenceEqual(other.Options)
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
                    if (MetadataId != null)
                    hashCode = hashCode * 59 + MetadataId.GetHashCode();
                    if (HasChanged != null)
                    hashCode = hashCode * 59 + HasChanged.GetHashCode();
                    if (IsCustomOptionSet != null)
                    hashCode = hashCode * 59 + IsCustomOptionSet.GetHashCode();
                    if (IsGlobal != null)
                    hashCode = hashCode * 59 + IsGlobal.GetHashCode();
                    if (IsManaged != null)
                    hashCode = hashCode * 59 + IsManaged.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (ExternalTypeName != null)
                    hashCode = hashCode * 59 + ExternalTypeName.GetHashCode();
                    if (OptionSetType != null)
                    hashCode = hashCode * 59 + OptionSetType.GetHashCode();
                    if (IntroducedVersion != null)
                    hashCode = hashCode * 59 + IntroducedVersion.GetHashCode();
                    if (ParentOptionSetName != null)
                    hashCode = hashCode * 59 + ParentOptionSetName.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                    if (IsCustomizable != null)
                    hashCode = hashCode * 59 + IsCustomizable.GetHashCode();
                    if (Options != null)
                    hashCode = hashCode * 59 + Options.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponseDefault6OptionSet left, InlineResponseDefault6OptionSet right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponseDefault6OptionSet left, InlineResponseDefault6OptionSet right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
