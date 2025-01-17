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
    /// Specifies the snapshot label for incremental and full backup of Secondary Netapp volumes (Data-Protect Volumes).
    /// </summary>
    [DataContract]
    public partial class SnapshotLabel :  IEquatable<SnapshotLabel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotLabel" /> class.
        /// </summary>
        /// <param name="fullLabel">Specifies the full snapshot label value.</param>
        /// <param name="incrementalLabel">Specifies the incremental snapshot label value.</param>
        public SnapshotLabel(string fullLabel = default(string), string incrementalLabel = default(string))
        {
            this.FullLabel = fullLabel;
            this.IncrementalLabel = incrementalLabel;
            this.FullLabel = fullLabel;
            this.IncrementalLabel = incrementalLabel;
        }
        
        /// <summary>
        /// Specifies the full snapshot label value
        /// </summary>
        /// <value>Specifies the full snapshot label value</value>
        [DataMember(Name="fullLabel", EmitDefaultValue=true)]
        public string FullLabel { get; set; }

        /// <summary>
        /// Specifies the incremental snapshot label value
        /// </summary>
        /// <value>Specifies the incremental snapshot label value</value>
        [DataMember(Name="incrementalLabel", EmitDefaultValue=true)]
        public string IncrementalLabel { get; set; }

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
            return this.Equals(input as SnapshotLabel);
        }

        /// <summary>
        /// Returns true if SnapshotLabel instances are equal
        /// </summary>
        /// <param name="input">Instance of SnapshotLabel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnapshotLabel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FullLabel == input.FullLabel ||
                    (this.FullLabel != null &&
                    this.FullLabel.Equals(input.FullLabel))
                ) && 
                (
                    this.IncrementalLabel == input.IncrementalLabel ||
                    (this.IncrementalLabel != null &&
                    this.IncrementalLabel.Equals(input.IncrementalLabel))
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
                if (this.FullLabel != null)
                    hashCode = hashCode * 59 + this.FullLabel.GetHashCode();
                if (this.IncrementalLabel != null)
                    hashCode = hashCode * 59 + this.IncrementalLabel.GetHashCode();
                return hashCode;
            }
        }

    }

}

