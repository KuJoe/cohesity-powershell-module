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
    /// OracleDBChannelInfoHostInfo
    /// </summary>
    [DataContract]
    public partial class OracleDBChannelInfoHostInfo :  IEquatable<OracleDBChannelInfoHostInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OracleDBChannelInfoHostInfo" /> class.
        /// </summary>
        /// <param name="host">Host string from which we are allowed to take the backup/restore..</param>
        /// <param name="numChannels">Number of channels we need to create for this host. Default value for num_channels will be calculated as minimum of number of nodes in cohesity cluster, 2 * number of cpu on Oracle host..</param>
        /// <param name="portnum">port number where database is listening..</param>
        public OracleDBChannelInfoHostInfo(string host = default(string), int? numChannels = default(int?), long? portnum = default(long?))
        {
            this.Host = host;
            this.NumChannels = numChannels;
            this.Portnum = portnum;
            this.Host = host;
            this.NumChannels = numChannels;
            this.Portnum = portnum;
        }
        
        /// <summary>
        /// Host string from which we are allowed to take the backup/restore.
        /// </summary>
        /// <value>Host string from which we are allowed to take the backup/restore.</value>
        [DataMember(Name="host", EmitDefaultValue=true)]
        public string Host { get; set; }

        /// <summary>
        /// Number of channels we need to create for this host. Default value for num_channels will be calculated as minimum of number of nodes in cohesity cluster, 2 * number of cpu on Oracle host.
        /// </summary>
        /// <value>Number of channels we need to create for this host. Default value for num_channels will be calculated as minimum of number of nodes in cohesity cluster, 2 * number of cpu on Oracle host.</value>
        [DataMember(Name="numChannels", EmitDefaultValue=true)]
        public int? NumChannels { get; set; }

        /// <summary>
        /// port number where database is listening.
        /// </summary>
        /// <value>port number where database is listening.</value>
        [DataMember(Name="portnum", EmitDefaultValue=true)]
        public long? Portnum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OracleDBChannelInfoHostInfo {\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  NumChannels: ").Append(NumChannels).Append("\n");
            sb.Append("  Portnum: ").Append(Portnum).Append("\n");
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
            return this.Equals(input as OracleDBChannelInfoHostInfo);
        }

        /// <summary>
        /// Returns true if OracleDBChannelInfoHostInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OracleDBChannelInfoHostInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OracleDBChannelInfoHostInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.NumChannels == input.NumChannels ||
                    (this.NumChannels != null &&
                    this.NumChannels.Equals(input.NumChannels))
                ) && 
                (
                    this.Portnum == input.Portnum ||
                    (this.Portnum != null &&
                    this.Portnum.Equals(input.Portnum))
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
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.NumChannels != null)
                    hashCode = hashCode * 59 + this.NumChannels.GetHashCode();
                if (this.Portnum != null)
                    hashCode = hashCode * 59 + this.Portnum.GetHashCode();
                return hashCode;
            }
        }

    }

}
