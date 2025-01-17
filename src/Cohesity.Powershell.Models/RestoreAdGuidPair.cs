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
    /// RestoreAdGuidPair is the AD object guid string pair.
    /// </summary>
    [DataContract]
    public partial class RestoreAdGuidPair :  IEquatable<RestoreAdGuidPair>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreAdGuidPair" /> class.
        /// </summary>
        /// <param name="destination">Specifies the destination guid in production AD object corresponding to source. If empty, it assumed to be &#39;source&#39; guid..</param>
        /// <param name="source">Specifies the source guid string of an AD object in mounted AD snapshot. This cannot be empty..</param>
        public RestoreAdGuidPair(string destination = default(string), string source = default(string))
        {
            this.Destination = destination;
            this.Source = source;
            this.Destination = destination;
            this.Source = source;
        }
        
        /// <summary>
        /// Specifies the destination guid in production AD object corresponding to source. If empty, it assumed to be &#39;source&#39; guid.
        /// </summary>
        /// <value>Specifies the destination guid in production AD object corresponding to source. If empty, it assumed to be &#39;source&#39; guid.</value>
        [DataMember(Name="destination", EmitDefaultValue=true)]
        public string Destination { get; set; }

        /// <summary>
        /// Specifies the source guid string of an AD object in mounted AD snapshot. This cannot be empty.
        /// </summary>
        /// <value>Specifies the source guid string of an AD object in mounted AD snapshot. This cannot be empty.</value>
        [DataMember(Name="source", EmitDefaultValue=true)]
        public string Source { get; set; }

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
            return this.Equals(input as RestoreAdGuidPair);
        }

        /// <summary>
        /// Returns true if RestoreAdGuidPair instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreAdGuidPair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreAdGuidPair input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                return hashCode;
            }
        }

    }

}

