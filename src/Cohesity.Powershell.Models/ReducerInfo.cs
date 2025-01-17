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
    /// ReducerInfo
    /// </summary>
    [DataContract]
    public partial class ReducerInfo :  IEquatable<ReducerInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReducerInfo" /> class.
        /// </summary>
        /// <param name="code">The code of the reducer in the specified language..</param>
        /// <param name="id">Reduced ID generated by system. Absent when user is creating a new reducer. Mandatory for all other use cases..</param>
        /// <param name="isSystemDefined">Whether the mapper is system defined..</param>
        /// <param name="jarName">User can write their own mapper/reducer or upload jar files containing mappers and reducers. If this reducer was part of a jar file, then this field will have the JAR name..</param>
        /// <param name="jarPath">path of JAR in which this reducer was found. This is applicable only when this reducer was uploaded via JAR..</param>
        /// <param name="language">Programming language used by the reducer..</param>
        /// <param name="name">Name of the reducer..</param>
        public ReducerInfo(string code = default(string), long? id = default(long?), bool? isSystemDefined = default(bool?), string jarName = default(string), string jarPath = default(string), int? language = default(int?), string name = default(string))
        {
            this.Code = code;
            this.Id = id;
            this.IsSystemDefined = isSystemDefined;
            this.JarName = jarName;
            this.JarPath = jarPath;
            this.Language = language;
            this.Name = name;
            this.Code = code;
            this.Id = id;
            this.IsSystemDefined = isSystemDefined;
            this.JarName = jarName;
            this.JarPath = jarPath;
            this.Language = language;
            this.Name = name;
        }
        
        /// <summary>
        /// The code of the reducer in the specified language.
        /// </summary>
        /// <value>The code of the reducer in the specified language.</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// Reduced ID generated by system. Absent when user is creating a new reducer. Mandatory for all other use cases.
        /// </summary>
        /// <value>Reduced ID generated by system. Absent when user is creating a new reducer. Mandatory for all other use cases.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Whether the mapper is system defined.
        /// </summary>
        /// <value>Whether the mapper is system defined.</value>
        [DataMember(Name="isSystemDefined", EmitDefaultValue=true)]
        public bool? IsSystemDefined { get; set; }

        /// <summary>
        /// User can write their own mapper/reducer or upload jar files containing mappers and reducers. If this reducer was part of a jar file, then this field will have the JAR name.
        /// </summary>
        /// <value>User can write their own mapper/reducer or upload jar files containing mappers and reducers. If this reducer was part of a jar file, then this field will have the JAR name.</value>
        [DataMember(Name="jarName", EmitDefaultValue=true)]
        public string JarName { get; set; }

        /// <summary>
        /// path of JAR in which this reducer was found. This is applicable only when this reducer was uploaded via JAR.
        /// </summary>
        /// <value>path of JAR in which this reducer was found. This is applicable only when this reducer was uploaded via JAR.</value>
        [DataMember(Name="jarPath", EmitDefaultValue=true)]
        public string JarPath { get; set; }

        /// <summary>
        /// Programming language used by the reducer.
        /// </summary>
        /// <value>Programming language used by the reducer.</value>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public int? Language { get; set; }

        /// <summary>
        /// Name of the reducer.
        /// </summary>
        /// <value>Name of the reducer.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

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
            return this.Equals(input as ReducerInfo);
        }

        /// <summary>
        /// Returns true if ReducerInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ReducerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReducerInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsSystemDefined == input.IsSystemDefined ||
                    (this.IsSystemDefined != null &&
                    this.IsSystemDefined.Equals(input.IsSystemDefined))
                ) && 
                (
                    this.JarName == input.JarName ||
                    (this.JarName != null &&
                    this.JarName.Equals(input.JarName))
                ) && 
                (
                    this.JarPath == input.JarPath ||
                    (this.JarPath != null &&
                    this.JarPath.Equals(input.JarPath))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsSystemDefined != null)
                    hashCode = hashCode * 59 + this.IsSystemDefined.GetHashCode();
                if (this.JarName != null)
                    hashCode = hashCode * 59 + this.JarName.GetHashCode();
                if (this.JarPath != null)
                    hashCode = hashCode * 59 + this.JarPath.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}

