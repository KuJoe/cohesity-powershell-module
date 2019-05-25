// Copyright 2019 Cohesity Inc.

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cohesity.Model
{
    /// <summary>
    /// Specifies a group or user added to the Cohesity Cluster for an Active Directory principal.
    /// </summary>
    [DataContract]
    public partial class AddedActiveDirectoryPrincipal :  IEquatable<AddedActiveDirectoryPrincipal>
    {
        /// <summary>
        /// Specifies the type of the referenced Active Directory principal. If &#39;kGroup&#39;, the referenced Active Directory principal is a group. If &#39;kUser&#39;, the referenced Active Directory principal is a user. &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class. &#39;kComputer&#39; specifies a computer object class.
        /// </summary>
        /// <value>Specifies the type of the referenced Active Directory principal. If &#39;kGroup&#39;, the referenced Active Directory principal is a group. If &#39;kUser&#39;, the referenced Active Directory principal is a user. &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class. &#39;kComputer&#39; specifies a computer object class.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectClassEnum
        {
            /// <summary>
            /// Enum KUser for value: kUser
            /// </summary>
            [EnumMember(Value = "kUser")]
            KUser = 1,

            /// <summary>
            /// Enum KGroup for value: kGroup
            /// </summary>
            [EnumMember(Value = "kGroup")]
            KGroup = 2,

            /// <summary>
            /// Enum KComputer for value: kComputer
            /// </summary>
            [EnumMember(Value = "kComputer")]
            KComputer = 3

        }

        /// <summary>
        /// Specifies the type of the referenced Active Directory principal. If &#39;kGroup&#39;, the referenced Active Directory principal is a group. If &#39;kUser&#39;, the referenced Active Directory principal is a user. &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class. &#39;kComputer&#39; specifies a computer object class.
        /// </summary>
        /// <value>Specifies the type of the referenced Active Directory principal. If &#39;kGroup&#39;, the referenced Active Directory principal is a group. If &#39;kUser&#39;, the referenced Active Directory principal is a user. &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class. &#39;kComputer&#39; specifies a computer object class.</value>
        [DataMember(Name="objectClass", EmitDefaultValue=true)]
        public ObjectClassEnum? ObjectClass { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddedActiveDirectoryPrincipal" /> class.
        /// </summary>
        /// <param name="createdTimeMsecs">Specifies the epoch time in milliseconds when the group or user was added to the Cohesity Cluster..</param>
        /// <param name="description">Specifies a description about the user or group..</param>
        /// <param name="domain">Specifies the domain of the Active Directory where the referenced principal is stored..</param>
        /// <param name="lastUpdatedTimeMsecs">Specifies the epoch time in milliseconds when the group or user was last modified on the Cohesity Cluster..</param>
        /// <param name="objectClass">Specifies the type of the referenced Active Directory principal. If &#39;kGroup&#39;, the referenced Active Directory principal is a group. If &#39;kUser&#39;, the referenced Active Directory principal is a user. &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class. &#39;kComputer&#39; specifies a computer object class..</param>
        /// <param name="principalName">Specifies the name of the Active Directory principal, that will be referenced by the group or user. The name of the Active Directory principal is used for naming the new group or user on the Cohesity Cluster..</param>
        /// <param name="restricted">Whether the principal is a restricted principal. A restricted principal can only view the objects he has permissions to..</param>
        /// <param name="roles">Array of Roles.  Specifies the Cohesity roles to associate with this user or group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this group or user. For example if the &#39;joe&#39; user is added for the Active Directory &#39;joe&#39; user principal and is associated with the Cohesity &#39;View&#39; role, &#39;joe&#39; can log in to the Cohesity Dashboard and has a read-only view of the data on the Cohesity Cluster..</param>
        /// <param name="sid">Specifies the unique Security ID (SID) of the Active Directory principal associated with this group or user..</param>
        public AddedActiveDirectoryPrincipal(long? createdTimeMsecs = default(long?), string description = default(string), string domain = default(string), long? lastUpdatedTimeMsecs = default(long?), ObjectClassEnum? objectClass = default(ObjectClassEnum?), string principalName = default(string), bool? restricted = default(bool?), List<string> roles = default(List<string>), string sid = default(string))
        {
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.Description = description;
            this.Domain = domain;
            this.LastUpdatedTimeMsecs = lastUpdatedTimeMsecs;
            this.ObjectClass = objectClass;
            this.PrincipalName = principalName;
            this.Restricted = restricted;
            this.Roles = roles;
            this.Sid = sid;
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.Description = description;
            this.Domain = domain;
            this.LastUpdatedTimeMsecs = lastUpdatedTimeMsecs;
            this.ObjectClass = objectClass;
            this.PrincipalName = principalName;
            this.Restricted = restricted;
            this.Roles = roles;
            this.Sid = sid;
        }
        
        /// <summary>
        /// Specifies the epoch time in milliseconds when the group or user was added to the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the group or user was added to the Cohesity Cluster.</value>
        [DataMember(Name="createdTimeMsecs", EmitDefaultValue=true)]
        public long? CreatedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies a description about the user or group.
        /// </summary>
        /// <value>Specifies a description about the user or group.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the domain of the Active Directory where the referenced principal is stored.
        /// </summary>
        /// <value>Specifies the domain of the Active Directory where the referenced principal is stored.</value>
        [DataMember(Name="domain", EmitDefaultValue=true)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies the epoch time in milliseconds when the group or user was last modified on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the group or user was last modified on the Cohesity Cluster.</value>
        [DataMember(Name="lastUpdatedTimeMsecs", EmitDefaultValue=true)]
        public long? LastUpdatedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the name of the Active Directory principal, that will be referenced by the group or user. The name of the Active Directory principal is used for naming the new group or user on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the name of the Active Directory principal, that will be referenced by the group or user. The name of the Active Directory principal is used for naming the new group or user on the Cohesity Cluster.</value>
        [DataMember(Name="principalName", EmitDefaultValue=true)]
        public string PrincipalName { get; set; }

        /// <summary>
        /// Whether the principal is a restricted principal. A restricted principal can only view the objects he has permissions to.
        /// </summary>
        /// <value>Whether the principal is a restricted principal. A restricted principal can only view the objects he has permissions to.</value>
        [DataMember(Name="restricted", EmitDefaultValue=true)]
        public bool? Restricted { get; set; }

        /// <summary>
        /// Array of Roles.  Specifies the Cohesity roles to associate with this user or group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this group or user. For example if the &#39;joe&#39; user is added for the Active Directory &#39;joe&#39; user principal and is associated with the Cohesity &#39;View&#39; role, &#39;joe&#39; can log in to the Cohesity Dashboard and has a read-only view of the data on the Cohesity Cluster.
        /// </summary>
        /// <value>Array of Roles.  Specifies the Cohesity roles to associate with this user or group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this group or user. For example if the &#39;joe&#39; user is added for the Active Directory &#39;joe&#39; user principal and is associated with the Cohesity &#39;View&#39; role, &#39;joe&#39; can log in to the Cohesity Dashboard and has a read-only view of the data on the Cohesity Cluster.</value>
        [DataMember(Name="roles", EmitDefaultValue=true)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Specifies the unique Security ID (SID) of the Active Directory principal associated with this group or user.
        /// </summary>
        /// <value>Specifies the unique Security ID (SID) of the Active Directory principal associated with this group or user.</value>
        [DataMember(Name="sid", EmitDefaultValue=true)]
        public string Sid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddedActiveDirectoryPrincipal {\n");
            sb.Append("  CreatedTimeMsecs: ").Append(CreatedTimeMsecs).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  LastUpdatedTimeMsecs: ").Append(LastUpdatedTimeMsecs).Append("\n");
            sb.Append("  ObjectClass: ").Append(ObjectClass).Append("\n");
            sb.Append("  PrincipalName: ").Append(PrincipalName).Append("\n");
            sb.Append("  Restricted: ").Append(Restricted).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Sid: ").Append(Sid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddedActiveDirectoryPrincipal);
        }

        /// <summary>
        /// Returns true if AddedActiveDirectoryPrincipal instances are equal
        /// </summary>
        /// <param name="input">Instance of AddedActiveDirectoryPrincipal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddedActiveDirectoryPrincipal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedTimeMsecs == input.CreatedTimeMsecs ||
                    (this.CreatedTimeMsecs != null &&
                    this.CreatedTimeMsecs.Equals(input.CreatedTimeMsecs))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.LastUpdatedTimeMsecs == input.LastUpdatedTimeMsecs ||
                    (this.LastUpdatedTimeMsecs != null &&
                    this.LastUpdatedTimeMsecs.Equals(input.LastUpdatedTimeMsecs))
                ) && 
                (
                    this.ObjectClass == input.ObjectClass ||
                    this.ObjectClass.Equals(input.ObjectClass)
                ) && 
                (
                    this.PrincipalName == input.PrincipalName ||
                    (this.PrincipalName != null &&
                    this.PrincipalName.Equals(input.PrincipalName))
                ) && 
                (
                    this.Restricted == input.Restricted ||
                    (this.Restricted != null &&
                    this.Restricted.Equals(input.Restricted))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
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
                if (this.CreatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.CreatedTimeMsecs.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.LastUpdatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.LastUpdatedTimeMsecs.GetHashCode();
                hashCode = hashCode * 59 + this.ObjectClass.GetHashCode();
                if (this.PrincipalName != null)
                    hashCode = hashCode * 59 + this.PrincipalName.GetHashCode();
                if (this.Restricted != null)
                    hashCode = hashCode * 59 + this.Restricted.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                return hashCode;
            }
        }

    }

}
