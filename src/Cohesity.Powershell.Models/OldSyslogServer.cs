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
    /// Specifies the syslog servers configuration to upload Cluster audit logs and filer audit logs.
    /// </summary>
    [DataContract]
    public partial class OldSyslogServer :  IEquatable<OldSyslogServer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OldSyslogServer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OldSyslogServer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OldSyslogServer" /> class.
        /// </summary>
        /// <param name="address">Specifies the IP address or hostname of the syslog server. (required).</param>
        /// <param name="isAlertAuditingEnabled">Specifies if cohesity alert should be sent to syslog server If &#39;true&#39;, alert audting message are sent to the server. If &#39;false&#39;, alert auditng message are not sent to the server.(default).</param>
        /// <param name="isClusterAuditingEnabled">Specifies if Cluster audit logs should be sent to this syslog server. If &#39;true&#39;, Cluster audit logs are sent to the syslog server. (default) If &#39;false&#39;, Cluster audit logs are not sent to the syslog server. Either cluster audit logs or filer audit logs should be enabled..</param>
        /// <param name="isDataProtectionEnabled">Specifies if dataprotection  logs should be sent to syslog server If &#39;true&#39;, dataprotection  logs are sent to the server. If &#39;false&#39;, dataprotection  logs are not sent to the server.(default).</param>
        /// <param name="isFilerAuditingEnabled">Specifies if filer audit logs should be sent to this syslog server. If &#39;true&#39;, filer audit logs are sent to the syslog server. (default) If &#39;false&#39;, filer audit logs are not sent to the syslog server. Either cluster audit logs or filer audit logs should be enabled..</param>
        /// <param name="isSshLogEnabled">Specifies if ssh login logs should be sent to syslog server If &#39;true&#39;, ssh login logs are sent to the server. If &#39;false&#39;, ssh login logs are not sent to the server.(default).</param>
        /// <param name="name">Specifies a unique name for the syslog server on the Cluster..</param>
        /// <param name="port">Specifies the port where the syslog server listens. (required).</param>
        /// <param name="protocol">Specifies the protocol used to send the logs. (required).</param>
        public OldSyslogServer(string address = default(string), bool? isAlertAuditingEnabled = default(bool?), bool? isClusterAuditingEnabled = default(bool?), bool? isDataProtectionEnabled = default(bool?), bool? isFilerAuditingEnabled = default(bool?), bool? isSshLogEnabled = default(bool?), string name = default(string), int? port = default(int?), int? protocol = default(int?))
        {
            this.Address = address;
            this.IsAlertAuditingEnabled = isAlertAuditingEnabled;
            this.IsClusterAuditingEnabled = isClusterAuditingEnabled;
            this.IsDataProtectionEnabled = isDataProtectionEnabled;
            this.IsFilerAuditingEnabled = isFilerAuditingEnabled;
            this.IsSshLogEnabled = isSshLogEnabled;
            this.Name = name;
            this.Port = port;
            this.Protocol = protocol;
            this.IsAlertAuditingEnabled = isAlertAuditingEnabled;
            this.IsClusterAuditingEnabled = isClusterAuditingEnabled;
            this.IsDataProtectionEnabled = isDataProtectionEnabled;
            this.IsFilerAuditingEnabled = isFilerAuditingEnabled;
            this.IsSshLogEnabled = isSshLogEnabled;
            this.Name = name;
        }
        
        /// <summary>
        /// Specifies the IP address or hostname of the syslog server.
        /// </summary>
        /// <value>Specifies the IP address or hostname of the syslog server.</value>
        [DataMember(Name="address", EmitDefaultValue=true)]
        public string Address { get; set; }

        /// <summary>
        /// Specifies if cohesity alert should be sent to syslog server If &#39;true&#39;, alert audting message are sent to the server. If &#39;false&#39;, alert auditng message are not sent to the server.(default)
        /// </summary>
        /// <value>Specifies if cohesity alert should be sent to syslog server If &#39;true&#39;, alert audting message are sent to the server. If &#39;false&#39;, alert auditng message are not sent to the server.(default)</value>
        [DataMember(Name="isAlertAuditingEnabled", EmitDefaultValue=true)]
        public bool? IsAlertAuditingEnabled { get; set; }

        /// <summary>
        /// Specifies if Cluster audit logs should be sent to this syslog server. If &#39;true&#39;, Cluster audit logs are sent to the syslog server. (default) If &#39;false&#39;, Cluster audit logs are not sent to the syslog server. Either cluster audit logs or filer audit logs should be enabled.
        /// </summary>
        /// <value>Specifies if Cluster audit logs should be sent to this syslog server. If &#39;true&#39;, Cluster audit logs are sent to the syslog server. (default) If &#39;false&#39;, Cluster audit logs are not sent to the syslog server. Either cluster audit logs or filer audit logs should be enabled.</value>
        [DataMember(Name="isClusterAuditingEnabled", EmitDefaultValue=true)]
        public bool? IsClusterAuditingEnabled { get; set; }

        /// <summary>
        /// Specifies if dataprotection  logs should be sent to syslog server If &#39;true&#39;, dataprotection  logs are sent to the server. If &#39;false&#39;, dataprotection  logs are not sent to the server.(default)
        /// </summary>
        /// <value>Specifies if dataprotection  logs should be sent to syslog server If &#39;true&#39;, dataprotection  logs are sent to the server. If &#39;false&#39;, dataprotection  logs are not sent to the server.(default)</value>
        [DataMember(Name="isDataProtectionEnabled", EmitDefaultValue=true)]
        public bool? IsDataProtectionEnabled { get; set; }

        /// <summary>
        /// Specifies if filer audit logs should be sent to this syslog server. If &#39;true&#39;, filer audit logs are sent to the syslog server. (default) If &#39;false&#39;, filer audit logs are not sent to the syslog server. Either cluster audit logs or filer audit logs should be enabled.
        /// </summary>
        /// <value>Specifies if filer audit logs should be sent to this syslog server. If &#39;true&#39;, filer audit logs are sent to the syslog server. (default) If &#39;false&#39;, filer audit logs are not sent to the syslog server. Either cluster audit logs or filer audit logs should be enabled.</value>
        [DataMember(Name="isFilerAuditingEnabled", EmitDefaultValue=true)]
        public bool? IsFilerAuditingEnabled { get; set; }

        /// <summary>
        /// Specifies if ssh login logs should be sent to syslog server If &#39;true&#39;, ssh login logs are sent to the server. If &#39;false&#39;, ssh login logs are not sent to the server.(default)
        /// </summary>
        /// <value>Specifies if ssh login logs should be sent to syslog server If &#39;true&#39;, ssh login logs are sent to the server. If &#39;false&#39;, ssh login logs are not sent to the server.(default)</value>
        [DataMember(Name="isSshLogEnabled", EmitDefaultValue=true)]
        public bool? IsSshLogEnabled { get; set; }

        /// <summary>
        /// Specifies a unique name for the syslog server on the Cluster.
        /// </summary>
        /// <value>Specifies a unique name for the syslog server on the Cluster.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the port where the syslog server listens.
        /// </summary>
        /// <value>Specifies the port where the syslog server listens.</value>
        [DataMember(Name="port", EmitDefaultValue=true)]
        public int? Port { get; set; }

        /// <summary>
        /// Specifies the protocol used to send the logs.
        /// </summary>
        /// <value>Specifies the protocol used to send the logs.</value>
        [DataMember(Name="protocol", EmitDefaultValue=true)]
        public int? Protocol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() { return ToJson(); }
  
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
            return this.Equals(input as OldSyslogServer);
        }

        /// <summary>
        /// Returns true if OldSyslogServer instances are equal
        /// </summary>
        /// <param name="input">Instance of OldSyslogServer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OldSyslogServer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.IsAlertAuditingEnabled == input.IsAlertAuditingEnabled ||
                    (this.IsAlertAuditingEnabled != null &&
                    this.IsAlertAuditingEnabled.Equals(input.IsAlertAuditingEnabled))
                ) && 
                (
                    this.IsClusterAuditingEnabled == input.IsClusterAuditingEnabled ||
                    (this.IsClusterAuditingEnabled != null &&
                    this.IsClusterAuditingEnabled.Equals(input.IsClusterAuditingEnabled))
                ) && 
                (
                    this.IsDataProtectionEnabled == input.IsDataProtectionEnabled ||
                    (this.IsDataProtectionEnabled != null &&
                    this.IsDataProtectionEnabled.Equals(input.IsDataProtectionEnabled))
                ) && 
                (
                    this.IsFilerAuditingEnabled == input.IsFilerAuditingEnabled ||
                    (this.IsFilerAuditingEnabled != null &&
                    this.IsFilerAuditingEnabled.Equals(input.IsFilerAuditingEnabled))
                ) && 
                (
                    this.IsSshLogEnabled == input.IsSshLogEnabled ||
                    (this.IsSshLogEnabled != null &&
                    this.IsSshLogEnabled.Equals(input.IsSshLogEnabled))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.IsAlertAuditingEnabled != null)
                    hashCode = hashCode * 59 + this.IsAlertAuditingEnabled.GetHashCode();
                if (this.IsClusterAuditingEnabled != null)
                    hashCode = hashCode * 59 + this.IsClusterAuditingEnabled.GetHashCode();
                if (this.IsDataProtectionEnabled != null)
                    hashCode = hashCode * 59 + this.IsDataProtectionEnabled.GetHashCode();
                if (this.IsFilerAuditingEnabled != null)
                    hashCode = hashCode * 59 + this.IsFilerAuditingEnabled.GetHashCode();
                if (this.IsSshLogEnabled != null)
                    hashCode = hashCode * 59 + this.IsSshLogEnabled.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                return hashCode;
            }
        }

    }

}

