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
    /// Specifies the settings for cloning an existing View.
    /// </summary>
    [DataContract]
    public partial class CloneViewRequest :  IEquatable<CloneViewRequest>
    {
        /// <summary>
        /// Specifies the supported Protocols for the View. &#39;kAll&#39; enables protocol access to all three views: NFS, SMB and S3. &#39;kNFSOnly&#39; enables protocol access to NFS only. &#39;kSMBOnly&#39; enables protocol access to SMB only. &#39;kS3Only&#39; enables protocol access to S3 only.
        /// </summary>
        /// <value>Specifies the supported Protocols for the View. &#39;kAll&#39; enables protocol access to all three views: NFS, SMB and S3. &#39;kNFSOnly&#39; enables protocol access to NFS only. &#39;kSMBOnly&#39; enables protocol access to SMB only. &#39;kS3Only&#39; enables protocol access to S3 only.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolAccessEnum
        {
            /// <summary>
            /// Enum KAll for value: kAll
            /// </summary>
            [EnumMember(Value = "kAll")]
            KAll = 1,

            /// <summary>
            /// Enum KNFSOnly for value: kNFSOnly
            /// </summary>
            [EnumMember(Value = "kNFSOnly")]
            KNFSOnly = 2,

            /// <summary>
            /// Enum KSMBOnly for value: kSMBOnly
            /// </summary>
            [EnumMember(Value = "kSMBOnly")]
            KSMBOnly = 3,

            /// <summary>
            /// Enum KS3Only for value: kS3Only
            /// </summary>
            [EnumMember(Value = "kS3Only")]
            KS3Only = 4

        }

        /// <summary>
        /// Specifies the supported Protocols for the View. &#39;kAll&#39; enables protocol access to all three views: NFS, SMB and S3. &#39;kNFSOnly&#39; enables protocol access to NFS only. &#39;kSMBOnly&#39; enables protocol access to SMB only. &#39;kS3Only&#39; enables protocol access to S3 only.
        /// </summary>
        /// <value>Specifies the supported Protocols for the View. &#39;kAll&#39; enables protocol access to all three views: NFS, SMB and S3. &#39;kNFSOnly&#39; enables protocol access to NFS only. &#39;kSMBOnly&#39; enables protocol access to SMB only. &#39;kS3Only&#39; enables protocol access to S3 only.</value>
        [DataMember(Name="protocolAccess", EmitDefaultValue=true)]
        public ProtocolAccessEnum? ProtocolAccess { get; set; }
        /// <summary>
        /// Specifies the security mode used for this view. Currently we support the following modes: Native, Unified and NTFS style. &#39;kNativeMode&#39; indicates a native security mode. &#39;kUnifiedMode&#39; indicates a unified security mode. &#39;kNtfsMode&#39; indicates a NTFS style security mode.
        /// </summary>
        /// <value>Specifies the security mode used for this view. Currently we support the following modes: Native, Unified and NTFS style. &#39;kNativeMode&#39; indicates a native security mode. &#39;kUnifiedMode&#39; indicates a unified security mode. &#39;kNtfsMode&#39; indicates a NTFS style security mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SecurityModeEnum
        {
            /// <summary>
            /// Enum KNativeMode for value: kNativeMode
            /// </summary>
            [EnumMember(Value = "kNativeMode")]
            KNativeMode = 1,

            /// <summary>
            /// Enum KUnifiedMode for value: kUnifiedMode
            /// </summary>
            [EnumMember(Value = "kUnifiedMode")]
            KUnifiedMode = 2,

            /// <summary>
            /// Enum KNtfsMode for value: kNtfsMode
            /// </summary>
            [EnumMember(Value = "kNtfsMode")]
            KNtfsMode = 3

        }

        /// <summary>
        /// Specifies the security mode used for this view. Currently we support the following modes: Native, Unified and NTFS style. &#39;kNativeMode&#39; indicates a native security mode. &#39;kUnifiedMode&#39; indicates a unified security mode. &#39;kNtfsMode&#39; indicates a NTFS style security mode.
        /// </summary>
        /// <value>Specifies the security mode used for this view. Currently we support the following modes: Native, Unified and NTFS style. &#39;kNativeMode&#39; indicates a native security mode. &#39;kUnifiedMode&#39; indicates a unified security mode. &#39;kNtfsMode&#39; indicates a NTFS style security mode.</value>
        [DataMember(Name="securityMode", EmitDefaultValue=true)]
        public SecurityModeEnum? SecurityMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneViewRequest" /> class.
        /// </summary>
        /// <param name="accessSids">Array of Security Identifiers (SIDs)  Specifies the list of security identifiers (SIDs) for the restricted Principals who have access to this View..</param>
        /// <param name="antivirusScanConfig">antivirusScanConfig.</param>
        /// <param name="cloneViewName">Specifies the name of the new View that is cloned from the source View..</param>
        /// <param name="dataLockExpiryUsecs">DataLock (Write Once Read Many) lock expiry epoch time in microseconds. If specified, a view will be marked as a DataLock view. If a view is marked as a DataLock view, only a Data Security Officer (a user having Data Security Privilege) can delete the view until the lock expiry time..</param>
        /// <param name="description">Specifies an optional text description about the View..</param>
        /// <param name="enableFilerAuditLogging">Specifies if Filer Audit Logging is enabled for this view..</param>
        /// <param name="enableMixedModePermissions">If set, mixed mode (NFS and SMB) access is enabled for this view. This field is deprecated. Use the field SecurityMode. deprecated: true.</param>
        /// <param name="enableNfsViewDiscovery">If set, it enables discovery of view for NFS..</param>
        /// <param name="enableSmbAccessBasedEnumeration">Specifies if access-based enumeration should be enabled. If &#39;true&#39;, only files and folders that the user has permissions to access are visible on the SMB share for that user..</param>
        /// <param name="enableSmbEncryption">Specifies the SMB encryption for the View. If set, it enables the SMB encryption for the View. Encryption is supported only by SMB 3.x dialects. Dialects that do not support would still access data in unencrypted format..</param>
        /// <param name="enableSmbViewDiscovery">If set, it enables discovery of view for SMB..</param>
        /// <param name="enforceSmbEncryption">Specifies the SMB encryption for all the sessions for the View. If set, encryption is enforced for all the sessions for the View. When enabled all future and existing unencrypted sessions are disallowed..</param>
        /// <param name="fileExtensionFilter">fileExtensionFilter.</param>
        /// <param name="fileLockConfig">fileLockConfig.</param>
        /// <param name="logicalQuota">Specifies an optional logical quota limit (in bytes) for the usage allowed on this View. (Logical data is when the data is fully hydrated and expanded.) This limit overrides the limit inherited from the Storage Domain (View Box) (if set). If logicalQuota is nil, the limit is inherited from the Storage Domain (View Box) (if set). A new write is not allowed if the Storage Domain (View Box) will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be a delay before the Cohesity Cluster allows more data to be written to the View, as the Cluster is calculating the usage across Nodes..</param>
        /// <param name="protocolAccess">Specifies the supported Protocols for the View. &#39;kAll&#39; enables protocol access to all three views: NFS, SMB and S3. &#39;kNFSOnly&#39; enables protocol access to NFS only. &#39;kSMBOnly&#39; enables protocol access to SMB only. &#39;kS3Only&#39; enables protocol access to S3 only..</param>
        /// <param name="qos">qos.</param>
        /// <param name="securityMode">Specifies the security mode used for this view. Currently we support the following modes: Native, Unified and NTFS style. &#39;kNativeMode&#39; indicates a native security mode. &#39;kUnifiedMode&#39; indicates a unified security mode. &#39;kNtfsMode&#39; indicates a NTFS style security mode..</param>
        /// <param name="smbPermissionsInfo">smbPermissionsInfo.</param>
        /// <param name="sourceViewName">Specifies the name of the source View that will be cloned..</param>
        /// <param name="storagePolicyOverride">storagePolicyOverride.</param>
        /// <param name="subnetWhitelist">Array of Subnets.  Specifies a list of Subnets with IP addresses that have permissions to access the View. (Overrides the Subnets specified at the global Cohesity Cluster level.).</param>
        /// <param name="tenantId">Optional tenant id who has access to this View..</param>
        public CloneViewRequest(List<string> accessSids = default(List<string>), AntivirusScanConfig antivirusScanConfig = default(AntivirusScanConfig), string cloneViewName = default(string), long? dataLockExpiryUsecs = default(long?), string description = default(string), bool? enableFilerAuditLogging = default(bool?), bool? enableMixedModePermissions = default(bool?), bool? enableNfsViewDiscovery = default(bool?), bool? enableSmbAccessBasedEnumeration = default(bool?), bool? enableSmbEncryption = default(bool?), bool? enableSmbViewDiscovery = default(bool?), bool? enforceSmbEncryption = default(bool?), FileExtensionFilter fileExtensionFilter = default(FileExtensionFilter), FileLevelDataLockConfig fileLockConfig = default(FileLevelDataLockConfig), QuotaPolicy logicalQuota = default(QuotaPolicy), ProtocolAccessEnum? protocolAccess = default(ProtocolAccessEnum?), QoS qos = default(QoS), SecurityModeEnum? securityMode = default(SecurityModeEnum?), SmbPermissionsInfo smbPermissionsInfo = default(SmbPermissionsInfo), string sourceViewName = default(string), StoragePolicyOverride storagePolicyOverride = default(StoragePolicyOverride), List<Subnet> subnetWhitelist = default(List<Subnet>), string tenantId = default(string))
        {
            this.AccessSids = accessSids;
            this.CloneViewName = cloneViewName;
            this.DataLockExpiryUsecs = dataLockExpiryUsecs;
            this.Description = description;
            this.EnableFilerAuditLogging = enableFilerAuditLogging;
            this.EnableMixedModePermissions = enableMixedModePermissions;
            this.EnableNfsViewDiscovery = enableNfsViewDiscovery;
            this.EnableSmbAccessBasedEnumeration = enableSmbAccessBasedEnumeration;
            this.EnableSmbEncryption = enableSmbEncryption;
            this.EnableSmbViewDiscovery = enableSmbViewDiscovery;
            this.EnforceSmbEncryption = enforceSmbEncryption;
            this.LogicalQuota = logicalQuota;
            this.ProtocolAccess = protocolAccess;
            this.SecurityMode = securityMode;
            this.SourceViewName = sourceViewName;
            this.SubnetWhitelist = subnetWhitelist;
            this.TenantId = tenantId;
            this.AccessSids = accessSids;
            this.AntivirusScanConfig = antivirusScanConfig;
            this.CloneViewName = cloneViewName;
            this.DataLockExpiryUsecs = dataLockExpiryUsecs;
            this.Description = description;
            this.EnableFilerAuditLogging = enableFilerAuditLogging;
            this.EnableMixedModePermissions = enableMixedModePermissions;
            this.EnableNfsViewDiscovery = enableNfsViewDiscovery;
            this.EnableSmbAccessBasedEnumeration = enableSmbAccessBasedEnumeration;
            this.EnableSmbEncryption = enableSmbEncryption;
            this.EnableSmbViewDiscovery = enableSmbViewDiscovery;
            this.EnforceSmbEncryption = enforceSmbEncryption;
            this.FileExtensionFilter = fileExtensionFilter;
            this.FileLockConfig = fileLockConfig;
            this.LogicalQuota = logicalQuota;
            this.ProtocolAccess = protocolAccess;
            this.Qos = qos;
            this.SecurityMode = securityMode;
            this.SmbPermissionsInfo = smbPermissionsInfo;
            this.SourceViewName = sourceViewName;
            this.StoragePolicyOverride = storagePolicyOverride;
            this.SubnetWhitelist = subnetWhitelist;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// Array of Security Identifiers (SIDs)  Specifies the list of security identifiers (SIDs) for the restricted Principals who have access to this View.
        /// </summary>
        /// <value>Array of Security Identifiers (SIDs)  Specifies the list of security identifiers (SIDs) for the restricted Principals who have access to this View.</value>
        [DataMember(Name="accessSids", EmitDefaultValue=true)]
        public List<string> AccessSids { get; set; }

        /// <summary>
        /// Gets or Sets AntivirusScanConfig
        /// </summary>
        [DataMember(Name="antivirusScanConfig", EmitDefaultValue=false)]
        public AntivirusScanConfig AntivirusScanConfig { get; set; }

        /// <summary>
        /// Specifies the name of the new View that is cloned from the source View.
        /// </summary>
        /// <value>Specifies the name of the new View that is cloned from the source View.</value>
        [DataMember(Name="cloneViewName", EmitDefaultValue=true)]
        public string CloneViewName { get; set; }

        /// <summary>
        /// DataLock (Write Once Read Many) lock expiry epoch time in microseconds. If specified, a view will be marked as a DataLock view. If a view is marked as a DataLock view, only a Data Security Officer (a user having Data Security Privilege) can delete the view until the lock expiry time.
        /// </summary>
        /// <value>DataLock (Write Once Read Many) lock expiry epoch time in microseconds. If specified, a view will be marked as a DataLock view. If a view is marked as a DataLock view, only a Data Security Officer (a user having Data Security Privilege) can delete the view until the lock expiry time.</value>
        [DataMember(Name="dataLockExpiryUsecs", EmitDefaultValue=true)]
        public long? DataLockExpiryUsecs { get; set; }

        /// <summary>
        /// Specifies an optional text description about the View.
        /// </summary>
        /// <value>Specifies an optional text description about the View.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies if Filer Audit Logging is enabled for this view.
        /// </summary>
        /// <value>Specifies if Filer Audit Logging is enabled for this view.</value>
        [DataMember(Name="enableFilerAuditLogging", EmitDefaultValue=true)]
        public bool? EnableFilerAuditLogging { get; set; }

        /// <summary>
        /// If set, mixed mode (NFS and SMB) access is enabled for this view. This field is deprecated. Use the field SecurityMode. deprecated: true
        /// </summary>
        /// <value>If set, mixed mode (NFS and SMB) access is enabled for this view. This field is deprecated. Use the field SecurityMode. deprecated: true</value>
        [DataMember(Name="enableMixedModePermissions", EmitDefaultValue=true)]
        public bool? EnableMixedModePermissions { get; set; }

        /// <summary>
        /// If set, it enables discovery of view for NFS.
        /// </summary>
        /// <value>If set, it enables discovery of view for NFS.</value>
        [DataMember(Name="enableNfsViewDiscovery", EmitDefaultValue=true)]
        public bool? EnableNfsViewDiscovery { get; set; }

        /// <summary>
        /// Specifies if access-based enumeration should be enabled. If &#39;true&#39;, only files and folders that the user has permissions to access are visible on the SMB share for that user.
        /// </summary>
        /// <value>Specifies if access-based enumeration should be enabled. If &#39;true&#39;, only files and folders that the user has permissions to access are visible on the SMB share for that user.</value>
        [DataMember(Name="enableSmbAccessBasedEnumeration", EmitDefaultValue=true)]
        public bool? EnableSmbAccessBasedEnumeration { get; set; }

        /// <summary>
        /// Specifies the SMB encryption for the View. If set, it enables the SMB encryption for the View. Encryption is supported only by SMB 3.x dialects. Dialects that do not support would still access data in unencrypted format.
        /// </summary>
        /// <value>Specifies the SMB encryption for the View. If set, it enables the SMB encryption for the View. Encryption is supported only by SMB 3.x dialects. Dialects that do not support would still access data in unencrypted format.</value>
        [DataMember(Name="enableSmbEncryption", EmitDefaultValue=true)]
        public bool? EnableSmbEncryption { get; set; }

        /// <summary>
        /// If set, it enables discovery of view for SMB.
        /// </summary>
        /// <value>If set, it enables discovery of view for SMB.</value>
        [DataMember(Name="enableSmbViewDiscovery", EmitDefaultValue=true)]
        public bool? EnableSmbViewDiscovery { get; set; }

        /// <summary>
        /// Specifies the SMB encryption for all the sessions for the View. If set, encryption is enforced for all the sessions for the View. When enabled all future and existing unencrypted sessions are disallowed.
        /// </summary>
        /// <value>Specifies the SMB encryption for all the sessions for the View. If set, encryption is enforced for all the sessions for the View. When enabled all future and existing unencrypted sessions are disallowed.</value>
        [DataMember(Name="enforceSmbEncryption", EmitDefaultValue=true)]
        public bool? EnforceSmbEncryption { get; set; }

        /// <summary>
        /// Gets or Sets FileExtensionFilter
        /// </summary>
        [DataMember(Name="fileExtensionFilter", EmitDefaultValue=false)]
        public FileExtensionFilter FileExtensionFilter { get; set; }

        /// <summary>
        /// Gets or Sets FileLockConfig
        /// </summary>
        [DataMember(Name="fileLockConfig", EmitDefaultValue=false)]
        public FileLevelDataLockConfig FileLockConfig { get; set; }

        /// <summary>
        /// Specifies an optional logical quota limit (in bytes) for the usage allowed on this View. (Logical data is when the data is fully hydrated and expanded.) This limit overrides the limit inherited from the Storage Domain (View Box) (if set). If logicalQuota is nil, the limit is inherited from the Storage Domain (View Box) (if set). A new write is not allowed if the Storage Domain (View Box) will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be a delay before the Cohesity Cluster allows more data to be written to the View, as the Cluster is calculating the usage across Nodes.
        /// </summary>
        /// <value>Specifies an optional logical quota limit (in bytes) for the usage allowed on this View. (Logical data is when the data is fully hydrated and expanded.) This limit overrides the limit inherited from the Storage Domain (View Box) (if set). If logicalQuota is nil, the limit is inherited from the Storage Domain (View Box) (if set). A new write is not allowed if the Storage Domain (View Box) will exceed the specified quota. However, it takes time for the Cohesity Cluster to calculate the usage across Nodes, so the limit may be exceeded by a small amount. In addition, if the limit is increased or data is removed, there may be a delay before the Cohesity Cluster allows more data to be written to the View, as the Cluster is calculating the usage across Nodes.</value>
        [DataMember(Name="logicalQuota", EmitDefaultValue=true)]
        public QuotaPolicy LogicalQuota { get; set; }

        /// <summary>
        /// Gets or Sets Qos
        /// </summary>
        [DataMember(Name="qos", EmitDefaultValue=false)]
        public QoS Qos { get; set; }

        /// <summary>
        /// Gets or Sets SmbPermissionsInfo
        /// </summary>
        [DataMember(Name="smbPermissionsInfo", EmitDefaultValue=false)]
        public SmbPermissionsInfo SmbPermissionsInfo { get; set; }

        /// <summary>
        /// Specifies the name of the source View that will be cloned.
        /// </summary>
        /// <value>Specifies the name of the source View that will be cloned.</value>
        [DataMember(Name="sourceViewName", EmitDefaultValue=true)]
        public string SourceViewName { get; set; }

        /// <summary>
        /// Gets or Sets StoragePolicyOverride
        /// </summary>
        [DataMember(Name="storagePolicyOverride", EmitDefaultValue=false)]
        public StoragePolicyOverride StoragePolicyOverride { get; set; }

        /// <summary>
        /// Array of Subnets.  Specifies a list of Subnets with IP addresses that have permissions to access the View. (Overrides the Subnets specified at the global Cohesity Cluster level.)
        /// </summary>
        /// <value>Array of Subnets.  Specifies a list of Subnets with IP addresses that have permissions to access the View. (Overrides the Subnets specified at the global Cohesity Cluster level.)</value>
        [DataMember(Name="subnetWhitelist", EmitDefaultValue=true)]
        public List<Subnet> SubnetWhitelist { get; set; }

        /// <summary>
        /// Optional tenant id who has access to this View.
        /// </summary>
        /// <value>Optional tenant id who has access to this View.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloneViewRequest {\n");
            sb.Append("  AccessSids: ").Append(AccessSids).Append("\n");
            sb.Append("  AntivirusScanConfig: ").Append(AntivirusScanConfig).Append("\n");
            sb.Append("  CloneViewName: ").Append(CloneViewName).Append("\n");
            sb.Append("  DataLockExpiryUsecs: ").Append(DataLockExpiryUsecs).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EnableFilerAuditLogging: ").Append(EnableFilerAuditLogging).Append("\n");
            sb.Append("  EnableMixedModePermissions: ").Append(EnableMixedModePermissions).Append("\n");
            sb.Append("  EnableNfsViewDiscovery: ").Append(EnableNfsViewDiscovery).Append("\n");
            sb.Append("  EnableSmbAccessBasedEnumeration: ").Append(EnableSmbAccessBasedEnumeration).Append("\n");
            sb.Append("  EnableSmbEncryption: ").Append(EnableSmbEncryption).Append("\n");
            sb.Append("  EnableSmbViewDiscovery: ").Append(EnableSmbViewDiscovery).Append("\n");
            sb.Append("  EnforceSmbEncryption: ").Append(EnforceSmbEncryption).Append("\n");
            sb.Append("  FileExtensionFilter: ").Append(FileExtensionFilter).Append("\n");
            sb.Append("  FileLockConfig: ").Append(FileLockConfig).Append("\n");
            sb.Append("  LogicalQuota: ").Append(LogicalQuota).Append("\n");
            sb.Append("  ProtocolAccess: ").Append(ProtocolAccess).Append("\n");
            sb.Append("  Qos: ").Append(Qos).Append("\n");
            sb.Append("  SecurityMode: ").Append(SecurityMode).Append("\n");
            sb.Append("  SmbPermissionsInfo: ").Append(SmbPermissionsInfo).Append("\n");
            sb.Append("  SourceViewName: ").Append(SourceViewName).Append("\n");
            sb.Append("  StoragePolicyOverride: ").Append(StoragePolicyOverride).Append("\n");
            sb.Append("  SubnetWhitelist: ").Append(SubnetWhitelist).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
            return this.Equals(input as CloneViewRequest);
        }

        /// <summary>
        /// Returns true if CloneViewRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CloneViewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloneViewRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessSids == input.AccessSids ||
                    this.AccessSids != null &&
                    input.AccessSids != null &&
                    this.AccessSids.SequenceEqual(input.AccessSids)
                ) && 
                (
                    this.AntivirusScanConfig == input.AntivirusScanConfig ||
                    (this.AntivirusScanConfig != null &&
                    this.AntivirusScanConfig.Equals(input.AntivirusScanConfig))
                ) && 
                (
                    this.CloneViewName == input.CloneViewName ||
                    (this.CloneViewName != null &&
                    this.CloneViewName.Equals(input.CloneViewName))
                ) && 
                (
                    this.DataLockExpiryUsecs == input.DataLockExpiryUsecs ||
                    (this.DataLockExpiryUsecs != null &&
                    this.DataLockExpiryUsecs.Equals(input.DataLockExpiryUsecs))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EnableFilerAuditLogging == input.EnableFilerAuditLogging ||
                    (this.EnableFilerAuditLogging != null &&
                    this.EnableFilerAuditLogging.Equals(input.EnableFilerAuditLogging))
                ) && 
                (
                    this.EnableMixedModePermissions == input.EnableMixedModePermissions ||
                    (this.EnableMixedModePermissions != null &&
                    this.EnableMixedModePermissions.Equals(input.EnableMixedModePermissions))
                ) && 
                (
                    this.EnableNfsViewDiscovery == input.EnableNfsViewDiscovery ||
                    (this.EnableNfsViewDiscovery != null &&
                    this.EnableNfsViewDiscovery.Equals(input.EnableNfsViewDiscovery))
                ) && 
                (
                    this.EnableSmbAccessBasedEnumeration == input.EnableSmbAccessBasedEnumeration ||
                    (this.EnableSmbAccessBasedEnumeration != null &&
                    this.EnableSmbAccessBasedEnumeration.Equals(input.EnableSmbAccessBasedEnumeration))
                ) && 
                (
                    this.EnableSmbEncryption == input.EnableSmbEncryption ||
                    (this.EnableSmbEncryption != null &&
                    this.EnableSmbEncryption.Equals(input.EnableSmbEncryption))
                ) && 
                (
                    this.EnableSmbViewDiscovery == input.EnableSmbViewDiscovery ||
                    (this.EnableSmbViewDiscovery != null &&
                    this.EnableSmbViewDiscovery.Equals(input.EnableSmbViewDiscovery))
                ) && 
                (
                    this.EnforceSmbEncryption == input.EnforceSmbEncryption ||
                    (this.EnforceSmbEncryption != null &&
                    this.EnforceSmbEncryption.Equals(input.EnforceSmbEncryption))
                ) && 
                (
                    this.FileExtensionFilter == input.FileExtensionFilter ||
                    (this.FileExtensionFilter != null &&
                    this.FileExtensionFilter.Equals(input.FileExtensionFilter))
                ) && 
                (
                    this.FileLockConfig == input.FileLockConfig ||
                    (this.FileLockConfig != null &&
                    this.FileLockConfig.Equals(input.FileLockConfig))
                ) && 
                (
                    this.LogicalQuota == input.LogicalQuota ||
                    (this.LogicalQuota != null &&
                    this.LogicalQuota.Equals(input.LogicalQuota))
                ) && 
                (
                    this.ProtocolAccess == input.ProtocolAccess ||
                    this.ProtocolAccess.Equals(input.ProtocolAccess)
                ) && 
                (
                    this.Qos == input.Qos ||
                    (this.Qos != null &&
                    this.Qos.Equals(input.Qos))
                ) && 
                (
                    this.SecurityMode == input.SecurityMode ||
                    this.SecurityMode.Equals(input.SecurityMode)
                ) && 
                (
                    this.SmbPermissionsInfo == input.SmbPermissionsInfo ||
                    (this.SmbPermissionsInfo != null &&
                    this.SmbPermissionsInfo.Equals(input.SmbPermissionsInfo))
                ) && 
                (
                    this.SourceViewName == input.SourceViewName ||
                    (this.SourceViewName != null &&
                    this.SourceViewName.Equals(input.SourceViewName))
                ) && 
                (
                    this.StoragePolicyOverride == input.StoragePolicyOverride ||
                    (this.StoragePolicyOverride != null &&
                    this.StoragePolicyOverride.Equals(input.StoragePolicyOverride))
                ) && 
                (
                    this.SubnetWhitelist == input.SubnetWhitelist ||
                    this.SubnetWhitelist != null &&
                    input.SubnetWhitelist != null &&
                    this.SubnetWhitelist.SequenceEqual(input.SubnetWhitelist)
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.AccessSids != null)
                    hashCode = hashCode * 59 + this.AccessSids.GetHashCode();
                if (this.AntivirusScanConfig != null)
                    hashCode = hashCode * 59 + this.AntivirusScanConfig.GetHashCode();
                if (this.CloneViewName != null)
                    hashCode = hashCode * 59 + this.CloneViewName.GetHashCode();
                if (this.DataLockExpiryUsecs != null)
                    hashCode = hashCode * 59 + this.DataLockExpiryUsecs.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnableFilerAuditLogging != null)
                    hashCode = hashCode * 59 + this.EnableFilerAuditLogging.GetHashCode();
                if (this.EnableMixedModePermissions != null)
                    hashCode = hashCode * 59 + this.EnableMixedModePermissions.GetHashCode();
                if (this.EnableNfsViewDiscovery != null)
                    hashCode = hashCode * 59 + this.EnableNfsViewDiscovery.GetHashCode();
                if (this.EnableSmbAccessBasedEnumeration != null)
                    hashCode = hashCode * 59 + this.EnableSmbAccessBasedEnumeration.GetHashCode();
                if (this.EnableSmbEncryption != null)
                    hashCode = hashCode * 59 + this.EnableSmbEncryption.GetHashCode();
                if (this.EnableSmbViewDiscovery != null)
                    hashCode = hashCode * 59 + this.EnableSmbViewDiscovery.GetHashCode();
                if (this.EnforceSmbEncryption != null)
                    hashCode = hashCode * 59 + this.EnforceSmbEncryption.GetHashCode();
                if (this.FileExtensionFilter != null)
                    hashCode = hashCode * 59 + this.FileExtensionFilter.GetHashCode();
                if (this.FileLockConfig != null)
                    hashCode = hashCode * 59 + this.FileLockConfig.GetHashCode();
                if (this.LogicalQuota != null)
                    hashCode = hashCode * 59 + this.LogicalQuota.GetHashCode();
                hashCode = hashCode * 59 + this.ProtocolAccess.GetHashCode();
                if (this.Qos != null)
                    hashCode = hashCode * 59 + this.Qos.GetHashCode();
                hashCode = hashCode * 59 + this.SecurityMode.GetHashCode();
                if (this.SmbPermissionsInfo != null)
                    hashCode = hashCode * 59 + this.SmbPermissionsInfo.GetHashCode();
                if (this.SourceViewName != null)
                    hashCode = hashCode * 59 + this.SourceViewName.GetHashCode();
                if (this.StoragePolicyOverride != null)
                    hashCode = hashCode * 59 + this.StoragePolicyOverride.GetHashCode();
                if (this.SubnetWhitelist != null)
                    hashCode = hashCode * 59 + this.SubnetWhitelist.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }

    }

}
