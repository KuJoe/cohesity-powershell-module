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
    /// Specifies statistics about a Protection Job Run. This contains the Job Run level statistics.
    /// </summary>
    [DataContract]
    public partial class ProtectionJobRunStats :  IEquatable<ProtectionJobRunStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionJobRunStats" /> class.
        /// </summary>
        /// <param name="admittedTimeUsecs">Specifies the time the task was unqueued from the queue to start running. This field can be used to determine the following times: initial-wait-time &#x3D; admittedTimeUsecs - startTimeUsecs run-time &#x3D; endTimeUsecs - admittedTimeUsecs If the task ends up waiting in other queues, then actual run-time will be smaller than the run-time computed this way. This field is only populated for Backup tasks currently..</param>
        /// <param name="endTimeUsecs">Specifies the end time of the Protection Run. The end time is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="numAppInstances">Specifies the number of application instances backed up by this Run. For example if the environment type is kSQL, this field contains the number of SQL Server instances..</param>
        /// <param name="numCanceledTasks">Specifies the number of backup tasks that were canceled..</param>
        /// <param name="numFailedAppObjects">Specifies the number of application objects that were cancelled in this Run..</param>
        /// <param name="numFailedTasks">Specifies the number of backup tasks that failed..</param>
        /// <param name="numSuccessfulAppObjects">Specifies the number of application objects successfully backed up by this Run. For example, if the environment type is kSQL, this number is for all of the SQL server databases..</param>
        /// <param name="numSuccessfulTasks">Specifies the number of backup tasks that completed successfully..</param>
        /// <param name="startTimeUsecs">Specifies the start time of the Protection Run. The start time is specified as a Unix epoch Timestamp (in microseconds). This time is when the task is queued to an internal queue where tasks are waiting to run..</param>
        /// <param name="timeTakenUsecs">Specifies the actual execution time for the protection run to complete the backup task and the copy tasks. This time will not include the time waited in various internal queues. This field is only populated for Backup tasks currently..</param>
        /// <param name="totalBytesReadFromSource">Specifies the total amount of data read from the source (so far)..</param>
        /// <param name="totalBytesToReadFromSource">Specifies the total amount of data expected to be read from the source..</param>
        /// <param name="totalLogicalBackupSizeBytes">Specifies the size of the source object (such as a VM) protected by this task on the primary storage after the snapshot is taken. The logical size of the data on the source if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication..</param>
        /// <param name="totalPhysicalBackupSizeBytes">Specifies the total amount of physical space used on the Cohesity Cluster to store the protected object after being reduced by change-block tracking, compression and deduplication. For example, if the logical backup size is 1GB, but only 1MB was used on the Cohesity Cluster to store it, this field be equal to 1MB..</param>
        /// <param name="totalSourceSizeBytes">Specifies the size of the source object (such as a VM) protected by this task on the primary storage before the snapshot is taken. The logical size of the data on the source if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication..</param>
        public ProtectionJobRunStats(long? admittedTimeUsecs = default(long?), long? endTimeUsecs = default(long?), int? numAppInstances = default(int?), long? numCanceledTasks = default(long?), int? numFailedAppObjects = default(int?), long? numFailedTasks = default(long?), int? numSuccessfulAppObjects = default(int?), long? numSuccessfulTasks = default(long?), long? startTimeUsecs = default(long?), long? timeTakenUsecs = default(long?), long? totalBytesReadFromSource = default(long?), long? totalBytesToReadFromSource = default(long?), long? totalLogicalBackupSizeBytes = default(long?), long? totalPhysicalBackupSizeBytes = default(long?), long? totalSourceSizeBytes = default(long?))
        {
            this.AdmittedTimeUsecs = admittedTimeUsecs;
            this.EndTimeUsecs = endTimeUsecs;
            this.NumAppInstances = numAppInstances;
            this.NumCanceledTasks = numCanceledTasks;
            this.NumFailedAppObjects = numFailedAppObjects;
            this.NumFailedTasks = numFailedTasks;
            this.NumSuccessfulAppObjects = numSuccessfulAppObjects;
            this.NumSuccessfulTasks = numSuccessfulTasks;
            this.StartTimeUsecs = startTimeUsecs;
            this.TimeTakenUsecs = timeTakenUsecs;
            this.TotalBytesReadFromSource = totalBytesReadFromSource;
            this.TotalBytesToReadFromSource = totalBytesToReadFromSource;
            this.TotalLogicalBackupSizeBytes = totalLogicalBackupSizeBytes;
            this.TotalPhysicalBackupSizeBytes = totalPhysicalBackupSizeBytes;
            this.TotalSourceSizeBytes = totalSourceSizeBytes;
            this.AdmittedTimeUsecs = admittedTimeUsecs;
            this.EndTimeUsecs = endTimeUsecs;
            this.NumAppInstances = numAppInstances;
            this.NumCanceledTasks = numCanceledTasks;
            this.NumFailedAppObjects = numFailedAppObjects;
            this.NumFailedTasks = numFailedTasks;
            this.NumSuccessfulAppObjects = numSuccessfulAppObjects;
            this.NumSuccessfulTasks = numSuccessfulTasks;
            this.StartTimeUsecs = startTimeUsecs;
            this.TimeTakenUsecs = timeTakenUsecs;
            this.TotalBytesReadFromSource = totalBytesReadFromSource;
            this.TotalBytesToReadFromSource = totalBytesToReadFromSource;
            this.TotalLogicalBackupSizeBytes = totalLogicalBackupSizeBytes;
            this.TotalPhysicalBackupSizeBytes = totalPhysicalBackupSizeBytes;
            this.TotalSourceSizeBytes = totalSourceSizeBytes;
        }
        
        /// <summary>
        /// Specifies the time the task was unqueued from the queue to start running. This field can be used to determine the following times: initial-wait-time &#x3D; admittedTimeUsecs - startTimeUsecs run-time &#x3D; endTimeUsecs - admittedTimeUsecs If the task ends up waiting in other queues, then actual run-time will be smaller than the run-time computed this way. This field is only populated for Backup tasks currently.
        /// </summary>
        /// <value>Specifies the time the task was unqueued from the queue to start running. This field can be used to determine the following times: initial-wait-time &#x3D; admittedTimeUsecs - startTimeUsecs run-time &#x3D; endTimeUsecs - admittedTimeUsecs If the task ends up waiting in other queues, then actual run-time will be smaller than the run-time computed this way. This field is only populated for Backup tasks currently.</value>
        [DataMember(Name="admittedTimeUsecs", EmitDefaultValue=true)]
        public long? AdmittedTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the end time of the Protection Run. The end time is specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the end time of the Protection Run. The end time is specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=true)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the number of application instances backed up by this Run. For example if the environment type is kSQL, this field contains the number of SQL Server instances.
        /// </summary>
        /// <value>Specifies the number of application instances backed up by this Run. For example if the environment type is kSQL, this field contains the number of SQL Server instances.</value>
        [DataMember(Name="numAppInstances", EmitDefaultValue=true)]
        public int? NumAppInstances { get; set; }

        /// <summary>
        /// Specifies the number of backup tasks that were canceled.
        /// </summary>
        /// <value>Specifies the number of backup tasks that were canceled.</value>
        [DataMember(Name="numCanceledTasks", EmitDefaultValue=true)]
        public long? NumCanceledTasks { get; set; }

        /// <summary>
        /// Specifies the number of application objects that were cancelled in this Run.
        /// </summary>
        /// <value>Specifies the number of application objects that were cancelled in this Run.</value>
        [DataMember(Name="numFailedAppObjects", EmitDefaultValue=true)]
        public int? NumFailedAppObjects { get; set; }

        /// <summary>
        /// Specifies the number of backup tasks that failed.
        /// </summary>
        /// <value>Specifies the number of backup tasks that failed.</value>
        [DataMember(Name="numFailedTasks", EmitDefaultValue=true)]
        public long? NumFailedTasks { get; set; }

        /// <summary>
        /// Specifies the number of application objects successfully backed up by this Run. For example, if the environment type is kSQL, this number is for all of the SQL server databases.
        /// </summary>
        /// <value>Specifies the number of application objects successfully backed up by this Run. For example, if the environment type is kSQL, this number is for all of the SQL server databases.</value>
        [DataMember(Name="numSuccessfulAppObjects", EmitDefaultValue=true)]
        public int? NumSuccessfulAppObjects { get; set; }

        /// <summary>
        /// Specifies the number of backup tasks that completed successfully.
        /// </summary>
        /// <value>Specifies the number of backup tasks that completed successfully.</value>
        [DataMember(Name="numSuccessfulTasks", EmitDefaultValue=true)]
        public long? NumSuccessfulTasks { get; set; }

        /// <summary>
        /// Specifies the start time of the Protection Run. The start time is specified as a Unix epoch Timestamp (in microseconds). This time is when the task is queued to an internal queue where tasks are waiting to run.
        /// </summary>
        /// <value>Specifies the start time of the Protection Run. The start time is specified as a Unix epoch Timestamp (in microseconds). This time is when the task is queued to an internal queue where tasks are waiting to run.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=true)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the actual execution time for the protection run to complete the backup task and the copy tasks. This time will not include the time waited in various internal queues. This field is only populated for Backup tasks currently.
        /// </summary>
        /// <value>Specifies the actual execution time for the protection run to complete the backup task and the copy tasks. This time will not include the time waited in various internal queues. This field is only populated for Backup tasks currently.</value>
        [DataMember(Name="timeTakenUsecs", EmitDefaultValue=true)]
        public long? TimeTakenUsecs { get; set; }

        /// <summary>
        /// Specifies the total amount of data read from the source (so far).
        /// </summary>
        /// <value>Specifies the total amount of data read from the source (so far).</value>
        [DataMember(Name="totalBytesReadFromSource", EmitDefaultValue=true)]
        public long? TotalBytesReadFromSource { get; set; }

        /// <summary>
        /// Specifies the total amount of data expected to be read from the source.
        /// </summary>
        /// <value>Specifies the total amount of data expected to be read from the source.</value>
        [DataMember(Name="totalBytesToReadFromSource", EmitDefaultValue=true)]
        public long? TotalBytesToReadFromSource { get; set; }

        /// <summary>
        /// Specifies the size of the source object (such as a VM) protected by this task on the primary storage after the snapshot is taken. The logical size of the data on the source if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication.
        /// </summary>
        /// <value>Specifies the size of the source object (such as a VM) protected by this task on the primary storage after the snapshot is taken. The logical size of the data on the source if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication.</value>
        [DataMember(Name="totalLogicalBackupSizeBytes", EmitDefaultValue=true)]
        public long? TotalLogicalBackupSizeBytes { get; set; }

        /// <summary>
        /// Specifies the total amount of physical space used on the Cohesity Cluster to store the protected object after being reduced by change-block tracking, compression and deduplication. For example, if the logical backup size is 1GB, but only 1MB was used on the Cohesity Cluster to store it, this field be equal to 1MB.
        /// </summary>
        /// <value>Specifies the total amount of physical space used on the Cohesity Cluster to store the protected object after being reduced by change-block tracking, compression and deduplication. For example, if the logical backup size is 1GB, but only 1MB was used on the Cohesity Cluster to store it, this field be equal to 1MB.</value>
        [DataMember(Name="totalPhysicalBackupSizeBytes", EmitDefaultValue=true)]
        public long? TotalPhysicalBackupSizeBytes { get; set; }

        /// <summary>
        /// Specifies the size of the source object (such as a VM) protected by this task on the primary storage before the snapshot is taken. The logical size of the data on the source if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication.
        /// </summary>
        /// <value>Specifies the size of the source object (such as a VM) protected by this task on the primary storage before the snapshot is taken. The logical size of the data on the source if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication.</value>
        [DataMember(Name="totalSourceSizeBytes", EmitDefaultValue=true)]
        public long? TotalSourceSizeBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtectionJobRunStats {\n");
            sb.Append("  AdmittedTimeUsecs: ").Append(AdmittedTimeUsecs).Append("\n");
            sb.Append("  EndTimeUsecs: ").Append(EndTimeUsecs).Append("\n");
            sb.Append("  NumAppInstances: ").Append(NumAppInstances).Append("\n");
            sb.Append("  NumCanceledTasks: ").Append(NumCanceledTasks).Append("\n");
            sb.Append("  NumFailedAppObjects: ").Append(NumFailedAppObjects).Append("\n");
            sb.Append("  NumFailedTasks: ").Append(NumFailedTasks).Append("\n");
            sb.Append("  NumSuccessfulAppObjects: ").Append(NumSuccessfulAppObjects).Append("\n");
            sb.Append("  NumSuccessfulTasks: ").Append(NumSuccessfulTasks).Append("\n");
            sb.Append("  StartTimeUsecs: ").Append(StartTimeUsecs).Append("\n");
            sb.Append("  TimeTakenUsecs: ").Append(TimeTakenUsecs).Append("\n");
            sb.Append("  TotalBytesReadFromSource: ").Append(TotalBytesReadFromSource).Append("\n");
            sb.Append("  TotalBytesToReadFromSource: ").Append(TotalBytesToReadFromSource).Append("\n");
            sb.Append("  TotalLogicalBackupSizeBytes: ").Append(TotalLogicalBackupSizeBytes).Append("\n");
            sb.Append("  TotalPhysicalBackupSizeBytes: ").Append(TotalPhysicalBackupSizeBytes).Append("\n");
            sb.Append("  TotalSourceSizeBytes: ").Append(TotalSourceSizeBytes).Append("\n");
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
            return this.Equals(input as ProtectionJobRunStats);
        }

        /// <summary>
        /// Returns true if ProtectionJobRunStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionJobRunStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionJobRunStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdmittedTimeUsecs == input.AdmittedTimeUsecs ||
                    (this.AdmittedTimeUsecs != null &&
                    this.AdmittedTimeUsecs.Equals(input.AdmittedTimeUsecs))
                ) && 
                (
                    this.EndTimeUsecs == input.EndTimeUsecs ||
                    (this.EndTimeUsecs != null &&
                    this.EndTimeUsecs.Equals(input.EndTimeUsecs))
                ) && 
                (
                    this.NumAppInstances == input.NumAppInstances ||
                    (this.NumAppInstances != null &&
                    this.NumAppInstances.Equals(input.NumAppInstances))
                ) && 
                (
                    this.NumCanceledTasks == input.NumCanceledTasks ||
                    (this.NumCanceledTasks != null &&
                    this.NumCanceledTasks.Equals(input.NumCanceledTasks))
                ) && 
                (
                    this.NumFailedAppObjects == input.NumFailedAppObjects ||
                    (this.NumFailedAppObjects != null &&
                    this.NumFailedAppObjects.Equals(input.NumFailedAppObjects))
                ) && 
                (
                    this.NumFailedTasks == input.NumFailedTasks ||
                    (this.NumFailedTasks != null &&
                    this.NumFailedTasks.Equals(input.NumFailedTasks))
                ) && 
                (
                    this.NumSuccessfulAppObjects == input.NumSuccessfulAppObjects ||
                    (this.NumSuccessfulAppObjects != null &&
                    this.NumSuccessfulAppObjects.Equals(input.NumSuccessfulAppObjects))
                ) && 
                (
                    this.NumSuccessfulTasks == input.NumSuccessfulTasks ||
                    (this.NumSuccessfulTasks != null &&
                    this.NumSuccessfulTasks.Equals(input.NumSuccessfulTasks))
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
                ) && 
                (
                    this.TimeTakenUsecs == input.TimeTakenUsecs ||
                    (this.TimeTakenUsecs != null &&
                    this.TimeTakenUsecs.Equals(input.TimeTakenUsecs))
                ) && 
                (
                    this.TotalBytesReadFromSource == input.TotalBytesReadFromSource ||
                    (this.TotalBytesReadFromSource != null &&
                    this.TotalBytesReadFromSource.Equals(input.TotalBytesReadFromSource))
                ) && 
                (
                    this.TotalBytesToReadFromSource == input.TotalBytesToReadFromSource ||
                    (this.TotalBytesToReadFromSource != null &&
                    this.TotalBytesToReadFromSource.Equals(input.TotalBytesToReadFromSource))
                ) && 
                (
                    this.TotalLogicalBackupSizeBytes == input.TotalLogicalBackupSizeBytes ||
                    (this.TotalLogicalBackupSizeBytes != null &&
                    this.TotalLogicalBackupSizeBytes.Equals(input.TotalLogicalBackupSizeBytes))
                ) && 
                (
                    this.TotalPhysicalBackupSizeBytes == input.TotalPhysicalBackupSizeBytes ||
                    (this.TotalPhysicalBackupSizeBytes != null &&
                    this.TotalPhysicalBackupSizeBytes.Equals(input.TotalPhysicalBackupSizeBytes))
                ) && 
                (
                    this.TotalSourceSizeBytes == input.TotalSourceSizeBytes ||
                    (this.TotalSourceSizeBytes != null &&
                    this.TotalSourceSizeBytes.Equals(input.TotalSourceSizeBytes))
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
                if (this.AdmittedTimeUsecs != null)
                    hashCode = hashCode * 59 + this.AdmittedTimeUsecs.GetHashCode();
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                if (this.NumAppInstances != null)
                    hashCode = hashCode * 59 + this.NumAppInstances.GetHashCode();
                if (this.NumCanceledTasks != null)
                    hashCode = hashCode * 59 + this.NumCanceledTasks.GetHashCode();
                if (this.NumFailedAppObjects != null)
                    hashCode = hashCode * 59 + this.NumFailedAppObjects.GetHashCode();
                if (this.NumFailedTasks != null)
                    hashCode = hashCode * 59 + this.NumFailedTasks.GetHashCode();
                if (this.NumSuccessfulAppObjects != null)
                    hashCode = hashCode * 59 + this.NumSuccessfulAppObjects.GetHashCode();
                if (this.NumSuccessfulTasks != null)
                    hashCode = hashCode * 59 + this.NumSuccessfulTasks.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                if (this.TimeTakenUsecs != null)
                    hashCode = hashCode * 59 + this.TimeTakenUsecs.GetHashCode();
                if (this.TotalBytesReadFromSource != null)
                    hashCode = hashCode * 59 + this.TotalBytesReadFromSource.GetHashCode();
                if (this.TotalBytesToReadFromSource != null)
                    hashCode = hashCode * 59 + this.TotalBytesToReadFromSource.GetHashCode();
                if (this.TotalLogicalBackupSizeBytes != null)
                    hashCode = hashCode * 59 + this.TotalLogicalBackupSizeBytes.GetHashCode();
                if (this.TotalPhysicalBackupSizeBytes != null)
                    hashCode = hashCode * 59 + this.TotalPhysicalBackupSizeBytes.GetHashCode();
                if (this.TotalSourceSizeBytes != null)
                    hashCode = hashCode * 59 + this.TotalSourceSizeBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}
