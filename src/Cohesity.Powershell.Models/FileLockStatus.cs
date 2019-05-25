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
    /// Specifies the information of lock status for a file.
    /// </summary>
    [DataContract]
    public partial class FileLockStatus :  IEquatable<FileLockStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileLockStatus" /> class.
        /// </summary>
        /// <param name="expiryTimestampMsecs">Specifies a expiry timestamp in milliseconds until the file is locked..</param>
        /// <param name="holdTimestampMsecs">Specifies a override timestamp in milliseconds when an expired file is kept on hold..</param>
        /// <param name="lockTimestampMsecs">Specifies the timestamp at which the file was locked..</param>
        /// <param name="state">Specifies the lock state of the file..</param>
        public FileLockStatus(long? expiryTimestampMsecs = default(long?), long? holdTimestampMsecs = default(long?), long? lockTimestampMsecs = default(long?), int? state = default(int?))
        {
            this.ExpiryTimestampMsecs = expiryTimestampMsecs;
            this.HoldTimestampMsecs = holdTimestampMsecs;
            this.LockTimestampMsecs = lockTimestampMsecs;
            this.State = state;
            this.ExpiryTimestampMsecs = expiryTimestampMsecs;
            this.HoldTimestampMsecs = holdTimestampMsecs;
            this.LockTimestampMsecs = lockTimestampMsecs;
            this.State = state;
        }
        
        /// <summary>
        /// Specifies a expiry timestamp in milliseconds until the file is locked.
        /// </summary>
        /// <value>Specifies a expiry timestamp in milliseconds until the file is locked.</value>
        [DataMember(Name="expiryTimestampMsecs", EmitDefaultValue=true)]
        public long? ExpiryTimestampMsecs { get; set; }

        /// <summary>
        /// Specifies a override timestamp in milliseconds when an expired file is kept on hold.
        /// </summary>
        /// <value>Specifies a override timestamp in milliseconds when an expired file is kept on hold.</value>
        [DataMember(Name="holdTimestampMsecs", EmitDefaultValue=true)]
        public long? HoldTimestampMsecs { get; set; }

        /// <summary>
        /// Specifies the timestamp at which the file was locked.
        /// </summary>
        /// <value>Specifies the timestamp at which the file was locked.</value>
        [DataMember(Name="lockTimestampMsecs", EmitDefaultValue=true)]
        public long? LockTimestampMsecs { get; set; }

        /// <summary>
        /// Specifies the lock state of the file.
        /// </summary>
        /// <value>Specifies the lock state of the file.</value>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public int? State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileLockStatus {\n");
            sb.Append("  ExpiryTimestampMsecs: ").Append(ExpiryTimestampMsecs).Append("\n");
            sb.Append("  HoldTimestampMsecs: ").Append(HoldTimestampMsecs).Append("\n");
            sb.Append("  LockTimestampMsecs: ").Append(LockTimestampMsecs).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as FileLockStatus);
        }

        /// <summary>
        /// Returns true if FileLockStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of FileLockStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileLockStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpiryTimestampMsecs == input.ExpiryTimestampMsecs ||
                    (this.ExpiryTimestampMsecs != null &&
                    this.ExpiryTimestampMsecs.Equals(input.ExpiryTimestampMsecs))
                ) && 
                (
                    this.HoldTimestampMsecs == input.HoldTimestampMsecs ||
                    (this.HoldTimestampMsecs != null &&
                    this.HoldTimestampMsecs.Equals(input.HoldTimestampMsecs))
                ) && 
                (
                    this.LockTimestampMsecs == input.LockTimestampMsecs ||
                    (this.LockTimestampMsecs != null &&
                    this.LockTimestampMsecs.Equals(input.LockTimestampMsecs))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.ExpiryTimestampMsecs != null)
                    hashCode = hashCode * 59 + this.ExpiryTimestampMsecs.GetHashCode();
                if (this.HoldTimestampMsecs != null)
                    hashCode = hashCode * 59 + this.HoldTimestampMsecs.GetHashCode();
                if (this.LockTimestampMsecs != null)
                    hashCode = hashCode * 59 + this.LockTimestampMsecs.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }

    }

}
