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
    public partial class InlineResponseDefault4 : IEquatable<InlineResponseDefault4>
    { 
        /// <summary>
        /// @odata.context
        /// </summary>
        /// <value>@odata.context</value>
        [DataMember(Name="@odata.context")]
        public string OdataContext { get; set; }

        /// <summary>
        /// AccessRights
        /// </summary>
        /// <value>AccessRights</value>
        [DataMember(Name="AccessRights")]
        public string AccessRights { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponseDefault4 {\n");
            sb.Append("  OdataContext: ").Append(OdataContext).Append("\n");
            sb.Append("  AccessRights: ").Append(AccessRights).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InlineResponseDefault4)obj);
        }

        /// <summary>
        /// Returns true if InlineResponseDefault4 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponseDefault4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponseDefault4 other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OdataContext == other.OdataContext ||
                    OdataContext != null &&
                    OdataContext.Equals(other.OdataContext)
                ) && 
                (
                    AccessRights == other.AccessRights ||
                    AccessRights != null &&
                    AccessRights.Equals(other.AccessRights)
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
                    if (OdataContext != null)
                    hashCode = hashCode * 59 + OdataContext.GetHashCode();
                    if (AccessRights != null)
                    hashCode = hashCode * 59 + AccessRights.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponseDefault4 left, InlineResponseDefault4 right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponseDefault4 left, InlineResponseDefault4 right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
