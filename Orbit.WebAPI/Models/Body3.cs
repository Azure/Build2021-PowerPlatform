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
    public partial class Body3 : IEquatable<Body3>
    { 
        /// <summary>
        /// cat_name
        /// </summary>
        /// <value>cat_name</value>
        [DataMember(Name="cat_name")]
        public string CatName { get; set; }

        /// <summary>
        /// cat_roletype
        /// </summary>
        /// <value>cat_roletype</value>
        [DataMember(Name="cat_roletype")]
        public int? CatRoletype { get; set; }

        /// <summary>
        /// cat_gtmEntry@odata.bind
        /// </summary>
        /// <value>cat_gtmEntry@odata.bind</value>
        [DataMember(Name="cat_gtmEntry@odata.bind")]
        public string CatGtmEntryodataBind { get; set; }

        /// <summary>
        /// cat_TeamMember@odata.bind
        /// </summary>
        /// <value>cat_TeamMember@odata.bind</value>
        [DataMember(Name="cat_TeamMember@odata.bind")]
        public string CatTeamMemberodataBind { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body3 {\n");
            sb.Append("  CatName: ").Append(CatName).Append("\n");
            sb.Append("  CatRoletype: ").Append(CatRoletype).Append("\n");
            sb.Append("  CatGtmEntryodataBind: ").Append(CatGtmEntryodataBind).Append("\n");
            sb.Append("  CatTeamMemberodataBind: ").Append(CatTeamMemberodataBind).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Body3)obj);
        }

        /// <summary>
        /// Returns true if Body3 instances are equal
        /// </summary>
        /// <param name="other">Instance of Body3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body3 other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CatName == other.CatName ||
                    CatName != null &&
                    CatName.Equals(other.CatName)
                ) && 
                (
                    CatRoletype == other.CatRoletype ||
                    CatRoletype != null &&
                    CatRoletype.Equals(other.CatRoletype)
                ) && 
                (
                    CatGtmEntryodataBind == other.CatGtmEntryodataBind ||
                    CatGtmEntryodataBind != null &&
                    CatGtmEntryodataBind.Equals(other.CatGtmEntryodataBind)
                ) && 
                (
                    CatTeamMemberodataBind == other.CatTeamMemberodataBind ||
                    CatTeamMemberodataBind != null &&
                    CatTeamMemberodataBind.Equals(other.CatTeamMemberodataBind)
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
                    if (CatName != null)
                    hashCode = hashCode * 59 + CatName.GetHashCode();
                    if (CatRoletype != null)
                    hashCode = hashCode * 59 + CatRoletype.GetHashCode();
                    if (CatGtmEntryodataBind != null)
                    hashCode = hashCode * 59 + CatGtmEntryodataBind.GetHashCode();
                    if (CatTeamMemberodataBind != null)
                    hashCode = hashCode * 59 + CatTeamMemberodataBind.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Body3 left, Body3 right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Body3 left, Body3 right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
