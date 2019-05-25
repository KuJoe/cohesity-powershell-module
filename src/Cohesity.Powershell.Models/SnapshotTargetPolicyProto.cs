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
    /// Message that specifies the policy for copying backup snapshots to a target. This message also specifies the retention policy that should be applied to the snapshots after they have been copied to the specified target.
    /// </summary>
    [DataContract]
    public partial class SnapshotTargetPolicyProto :  IEquatable<SnapshotTargetPolicyProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotTargetPolicyProto" /> class.
        /// </summary>
        /// <param name="copyPartiallySuccessfulRun">If this is false, then only snapshots from the first completely successful run in the given time granularity will be considered for being copied. If this is true, then snapshots from the first partially successful run will also be eligible to be copied..</param>
        /// <param name="granularityBucket">granularityBucket.</param>
        /// <param name="numDaysToKeep">Specifies how to determine the expiration time for snapshots copied due to this policy. The snapshots will be marked as expiring (i.e., eligible to be garbage collected) in &#39;num_days_to_keep&#39; days from when the snapshots were created..</param>
        /// <param name="retentionPolicy">retentionPolicy.</param>
        /// <param name="snapshotTarget">snapshotTarget.</param>
        public SnapshotTargetPolicyProto(bool? copyPartiallySuccessfulRun = default(bool?), GranularityBucket granularityBucket = default(GranularityBucket), long? numDaysToKeep = default(long?), RetentionPolicyProto retentionPolicy = default(RetentionPolicyProto), SnapshotTarget snapshotTarget = default(SnapshotTarget))
        {
            this.CopyPartiallySuccessfulRun = copyPartiallySuccessfulRun;
            this.NumDaysToKeep = numDaysToKeep;
            this.CopyPartiallySuccessfulRun = copyPartiallySuccessfulRun;
            this.GranularityBucket = granularityBucket;
            this.NumDaysToKeep = numDaysToKeep;
            this.RetentionPolicy = retentionPolicy;
            this.SnapshotTarget = snapshotTarget;
        }
        
        /// <summary>
        /// If this is false, then only snapshots from the first completely successful run in the given time granularity will be considered for being copied. If this is true, then snapshots from the first partially successful run will also be eligible to be copied.
        /// </summary>
        /// <value>If this is false, then only snapshots from the first completely successful run in the given time granularity will be considered for being copied. If this is true, then snapshots from the first partially successful run will also be eligible to be copied.</value>
        [DataMember(Name="copyPartiallySuccessfulRun", EmitDefaultValue=true)]
        public bool? CopyPartiallySuccessfulRun { get; set; }

        /// <summary>
        /// Gets or Sets GranularityBucket
        /// </summary>
        [DataMember(Name="granularityBucket", EmitDefaultValue=false)]
        public GranularityBucket GranularityBucket { get; set; }

        /// <summary>
        /// Specifies how to determine the expiration time for snapshots copied due to this policy. The snapshots will be marked as expiring (i.e., eligible to be garbage collected) in &#39;num_days_to_keep&#39; days from when the snapshots were created.
        /// </summary>
        /// <value>Specifies how to determine the expiration time for snapshots copied due to this policy. The snapshots will be marked as expiring (i.e., eligible to be garbage collected) in &#39;num_days_to_keep&#39; days from when the snapshots were created.</value>
        [DataMember(Name="numDaysToKeep", EmitDefaultValue=true)]
        public long? NumDaysToKeep { get; set; }

        /// <summary>
        /// Gets or Sets RetentionPolicy
        /// </summary>
        [DataMember(Name="retentionPolicy", EmitDefaultValue=false)]
        public RetentionPolicyProto RetentionPolicy { get; set; }

        /// <summary>
        /// Gets or Sets SnapshotTarget
        /// </summary>
        [DataMember(Name="snapshotTarget", EmitDefaultValue=false)]
        public SnapshotTarget SnapshotTarget { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SnapshotTargetPolicyProto {\n");
            sb.Append("  CopyPartiallySuccessfulRun: ").Append(CopyPartiallySuccessfulRun).Append("\n");
            sb.Append("  GranularityBucket: ").Append(GranularityBucket).Append("\n");
            sb.Append("  NumDaysToKeep: ").Append(NumDaysToKeep).Append("\n");
            sb.Append("  RetentionPolicy: ").Append(RetentionPolicy).Append("\n");
            sb.Append("  SnapshotTarget: ").Append(SnapshotTarget).Append("\n");
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
            return this.Equals(input as SnapshotTargetPolicyProto);
        }

        /// <summary>
        /// Returns true if SnapshotTargetPolicyProto instances are equal
        /// </summary>
        /// <param name="input">Instance of SnapshotTargetPolicyProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnapshotTargetPolicyProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CopyPartiallySuccessfulRun == input.CopyPartiallySuccessfulRun ||
                    (this.CopyPartiallySuccessfulRun != null &&
                    this.CopyPartiallySuccessfulRun.Equals(input.CopyPartiallySuccessfulRun))
                ) && 
                (
                    this.GranularityBucket == input.GranularityBucket ||
                    (this.GranularityBucket != null &&
                    this.GranularityBucket.Equals(input.GranularityBucket))
                ) && 
                (
                    this.NumDaysToKeep == input.NumDaysToKeep ||
                    (this.NumDaysToKeep != null &&
                    this.NumDaysToKeep.Equals(input.NumDaysToKeep))
                ) && 
                (
                    this.RetentionPolicy == input.RetentionPolicy ||
                    (this.RetentionPolicy != null &&
                    this.RetentionPolicy.Equals(input.RetentionPolicy))
                ) && 
                (
                    this.SnapshotTarget == input.SnapshotTarget ||
                    (this.SnapshotTarget != null &&
                    this.SnapshotTarget.Equals(input.SnapshotTarget))
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
                if (this.CopyPartiallySuccessfulRun != null)
                    hashCode = hashCode * 59 + this.CopyPartiallySuccessfulRun.GetHashCode();
                if (this.GranularityBucket != null)
                    hashCode = hashCode * 59 + this.GranularityBucket.GetHashCode();
                if (this.NumDaysToKeep != null)
                    hashCode = hashCode * 59 + this.NumDaysToKeep.GetHashCode();
                if (this.RetentionPolicy != null)
                    hashCode = hashCode * 59 + this.RetentionPolicy.GetHashCode();
                if (this.SnapshotTarget != null)
                    hashCode = hashCode * 59 + this.SnapshotTarget.GetHashCode();
                return hashCode;
            }
        }

    }

}
