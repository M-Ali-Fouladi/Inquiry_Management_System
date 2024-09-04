namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        private static Model1 Instance;
        public Model1()
            : base("name=Model12")
        {
        }
        public static Model1 GetInstance()
        {
            if (Instance == null)
                Instance = new Model1();
            return Instance;
        }
        public virtual DbSet<C____ChangesList> C____ChangesList { get; set; }
        public virtual DbSet<C____Configuration> C____Configuration { get; set; }
        public virtual DbSet<C____Servers> C____Servers { get; set; }
        public virtual DbSet<C____UpdateHistory> C____UpdateHistory { get; set; }
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<com_AccessZones> com_AccessZones { get; set; }
        public virtual DbSet<com_AdvancedReportColumns> com_AdvancedReportColumns { get; set; }
        public virtual DbSet<com_AdvancedReportGroups> com_AdvancedReportGroups { get; set; }
        public virtual DbSet<com_AdvancedReportHybridColumnElements> com_AdvancedReportHybridColumnElements { get; set; }
        public virtual DbSet<com_AdvancedReportHybridColumns> com_AdvancedReportHybridColumns { get; set; }
        public virtual DbSet<com_AdvancedReports> com_AdvancedReports { get; set; }
        public virtual DbSet<com_Alerts> com_Alerts { get; set; }
        public virtual DbSet<com_AssociationDetails> com_AssociationDetails { get; set; }
        public virtual DbSet<com_Associations> com_Associations { get; set; }
        public virtual DbSet<com_BackgroundTasks> com_BackgroundTasks { get; set; }
        public virtual DbSet<com_BackupPlanFiles> com_BackupPlanFiles { get; set; }
        public virtual DbSet<com_BackupPlans> com_BackupPlans { get; set; }
        public virtual DbSet<com_CascadeAccesses> com_CascadeAccesses { get; set; }
        public virtual DbSet<com_Categories> com_Categories { get; set; }
        public virtual DbSet<com_ContactLogs> com_ContactLogs { get; set; }
        public virtual DbSet<com_Contacts> com_Contacts { get; set; }
        public virtual DbSet<com_CostCenters> com_CostCenters { get; set; }
        public virtual DbSet<com_DashboardEntities> com_DashboardEntities { get; set; }
        public virtual DbSet<com_DashboardGroupItems> com_DashboardGroupItems { get; set; }
        public virtual DbSet<com_DashboardGroups> com_DashboardGroups { get; set; }
        public virtual DbSet<com_DataIntegrityFailureHistory> com_DataIntegrityFailureHistory { get; set; }
        public virtual DbSet<com_DataListUserSettings> com_DataListUserSettings { get; set; }
        public virtual DbSet<com_Deadlines> com_Deadlines { get; set; }
        public virtual DbSet<com_Delegates> com_Delegates { get; set; }
        public virtual DbSet<com_DelegateSoftwares> com_DelegateSoftwares { get; set; }
        public virtual DbSet<com_DelegateUsers> com_DelegateUsers { get; set; }
        public virtual DbSet<com_DepartmentCostCenters> com_DepartmentCostCenters { get; set; }
        public virtual DbSet<com_DepartmentRelevants> com_DepartmentRelevants { get; set; }
        public virtual DbSet<com_Departments> com_Departments { get; set; }
        public virtual DbSet<com_Dictionary> com_Dictionary { get; set; }
        public virtual DbSet<com_DigitalSignature> com_DigitalSignature { get; set; }
        public virtual DbSet<com_DigitalSignatureVersion> com_DigitalSignatureVersion { get; set; }
        public virtual DbSet<com_Discussion> com_Discussion { get; set; }
        public virtual DbSet<com_DiscussionEntry> com_DiscussionEntry { get; set; }
        public virtual DbSet<com_DiscussionLog> com_DiscussionLog { get; set; }
        public virtual DbSet<com_DiscussionMember> com_DiscussionMember { get; set; }
        public virtual DbSet<com_Drawings> com_Drawings { get; set; }
        public virtual DbSet<com_DynamicReports> com_DynamicReports { get; set; }
        public virtual DbSet<com_EmailAccountLogs> com_EmailAccountLogs { get; set; }
        public virtual DbSet<com_EmailAccounts> com_EmailAccounts { get; set; }
        public virtual DbSet<com_EmailGroupMembers> com_EmailGroupMembers { get; set; }
        public virtual DbSet<com_EmailGroups> com_EmailGroups { get; set; }
        public virtual DbSet<com_EntityAttributeValues> com_EntityAttributeValues { get; set; }
        public virtual DbSet<com_EventFlowcharts> com_EventFlowcharts { get; set; }
        public virtual DbSet<com_EventLog> com_EventLog { get; set; }
        public virtual DbSet<com_Events> com_Events { get; set; }
        public virtual DbSet<com_ExternalSystemReferences> com_ExternalSystemReferences { get; set; }
        public virtual DbSet<com_ExternalSystems> com_ExternalSystems { get; set; }
        public virtual DbSet<com_ExtraModelGuids> com_ExtraModelGuids { get; set; }
        public virtual DbSet<com_ExtraModelGuidSearchTemplateFields> com_ExtraModelGuidSearchTemplateFields { get; set; }
        public virtual DbSet<com_ExtraModelGuidSearchTemplates> com_ExtraModelGuidSearchTemplates { get; set; }
        public virtual DbSet<com_ExtraModels> com_ExtraModels { get; set; }
        public virtual DbSet<com_ExtraModelSearchTemplateFields> com_ExtraModelSearchTemplateFields { get; set; }
        public virtual DbSet<com_ExtraModelSearchTemplates> com_ExtraModelSearchTemplates { get; set; }
        public virtual DbSet<com_FailedExternalSystemNotifications> com_FailedExternalSystemNotifications { get; set; }
        public virtual DbSet<com_FaxGroupMembers> com_FaxGroupMembers { get; set; }
        public virtual DbSet<com_FaxGroups> com_FaxGroups { get; set; }
        public virtual DbSet<com_Feedbacks> com_Feedbacks { get; set; }
        public virtual DbSet<com_FileCleanupSchedules> com_FileCleanupSchedules { get; set; }
        public virtual DbSet<com_FileNatures> com_FileNatures { get; set; }
        public virtual DbSet<com_Files> com_Files { get; set; }
        public virtual DbSet<com_FinancialAccountBindings> com_FinancialAccountBindings { get; set; }
        public virtual DbSet<com_FinancialActivityTypes> com_FinancialActivityTypes { get; set; }
        public virtual DbSet<com_FiscalYearDetails> com_FiscalYearDetails { get; set; }
        public virtual DbSet<com_FiscalYears> com_FiscalYears { get; set; }
        public virtual DbSet<com_FrozenObjects> com_FrozenObjects { get; set; }
        public virtual DbSet<com_Inbox> com_Inbox { get; set; }
        public virtual DbSet<com_IndicatorRepositories> com_IndicatorRepositories { get; set; }
        public virtual DbSet<com_IndicatorRepositoryPartitions> com_IndicatorRepositoryPartitions { get; set; }
        public virtual DbSet<com_IndicatorRepositoryPartitionSequences> com_IndicatorRepositoryPartitionSequences { get; set; }
        public virtual DbSet<com_Indicators> com_Indicators { get; set; }
        public virtual DbSet<com_IndividualPersons> com_IndividualPersons { get; set; }
        public virtual DbSet<com_ItemCategories> com_ItemCategories { get; set; }
        public virtual DbSet<com_Languages> com_Languages { get; set; }
        public virtual DbSet<com_LegalPersons> com_LegalPersons { get; set; }
        public virtual DbSet<com_Log> com_Log { get; set; }
        public virtual DbSet<com_LogicalDatabases> com_LogicalDatabases { get; set; }
        public virtual DbSet<com_LogServiceDetails> com_LogServiceDetails { get; set; }
        public virtual DbSet<com_MergedPeople> com_MergedPeople { get; set; }
        public virtual DbSet<com_MergeRequests> com_MergeRequests { get; set; }
        public virtual DbSet<com_MigrateTemplates> com_MigrateTemplates { get; set; }
        public virtual DbSet<com_MobileDevices> com_MobileDevices { get; set; }
        public virtual DbSet<com_MobileFeedbacks> com_MobileFeedbacks { get; set; }
        public virtual DbSet<com_Nationalities> com_Nationalities { get; set; }
        public virtual DbSet<com_Notes> com_Notes { get; set; }
        public virtual DbSet<com_NumberingGroupEntities> com_NumberingGroupEntities { get; set; }
        public virtual DbSet<com_NumberingGroupEntities_Old> com_NumberingGroupEntities_Old { get; set; }
        public virtual DbSet<com_NumberingGroups> com_NumberingGroups { get; set; }
        public virtual DbSet<com_NumberingGroups_Old> com_NumberingGroups_Old { get; set; }
        public virtual DbSet<com_OAuthProviders> com_OAuthProviders { get; set; }
        public virtual DbSet<com_OAuthProviderServices> com_OAuthProviderServices { get; set; }
        public virtual DbSet<com_OrganizationRelatedDepartment> com_OrganizationRelatedDepartment { get; set; }
        public virtual DbSet<com_OrganizationRelatedPeople> com_OrganizationRelatedPeople { get; set; }
        public virtual DbSet<com_Organizations> com_Organizations { get; set; }
        public virtual DbSet<com_OrganizationSapaadConfig> com_OrganizationSapaadConfig { get; set; }
        public virtual DbSet<com_Outbox> com_Outbox { get; set; }
        public virtual DbSet<com_Permanents> com_Permanents { get; set; }
        public virtual DbSet<com_PermissionGroups> com_PermissionGroups { get; set; }
        public virtual DbSet<com_Permissions> com_Permissions { get; set; }
        public virtual DbSet<com_PermissionTemplates> com_PermissionTemplates { get; set; }
        public virtual DbSet<com_PersonAddresses> com_PersonAddresses { get; set; }
        public virtual DbSet<com_PersonAddressTypes> com_PersonAddressTypes { get; set; }
        public virtual DbSet<com_PersonConnections> com_PersonConnections { get; set; }
        public virtual DbSet<com_PersonContactInfo> com_PersonContactInfo { get; set; }
        public virtual DbSet<com_PersonContactTypes> com_PersonContactTypes { get; set; }
        public virtual DbSet<com_PersonLogs> com_PersonLogs { get; set; }
        public virtual DbSet<com_PersonOwnershipTypes> com_PersonOwnershipTypes { get; set; }
        public virtual DbSet<com_Persons> com_Persons { get; set; }
        public virtual DbSet<com_PersonStockStatus> com_PersonStockStatus { get; set; }
        public virtual DbSet<com_PersonSupplyStatus> com_PersonSupplyStatus { get; set; }
        public virtual DbSet<com_PersonTimelineSync> com_PersonTimelineSync { get; set; }
        public virtual DbSet<com_PersonTitles> com_PersonTitles { get; set; }
        public virtual DbSet<com_PhysicalDatabases> com_PhysicalDatabases { get; set; }
        public virtual DbSet<com_Priorities> com_Priorities { get; set; }
        public virtual DbSet<com_Projects> com_Projects { get; set; }
        public virtual DbSet<com_Recurrences> com_Recurrences { get; set; }
        public virtual DbSet<com_ReferenceMaps> com_ReferenceMaps { get; set; }
        public virtual DbSet<com_RelatedOrganization> com_RelatedOrganization { get; set; }
        public virtual DbSet<com_RelatedOrganizationTypes> com_RelatedOrganizationTypes { get; set; }
        public virtual DbSet<com_RelatedPermissionGroups> com_RelatedPermissionGroups { get; set; }
        public virtual DbSet<com_ReportGroups> com_ReportGroups { get; set; }
        public virtual DbSet<com_ReportRequests> com_ReportRequests { get; set; }
        public virtual DbSet<com_Reports> com_Reports { get; set; }
        public virtual DbSet<com_ReportTemplates> com_ReportTemplates { get; set; }
        public virtual DbSet<com_RepresentingStructure> com_RepresentingStructure { get; set; }
        public virtual DbSet<com_RepresentingStructureDepartmentDetails> com_RepresentingStructureDepartmentDetails { get; set; }
        public virtual DbSet<com_RepresentingStructureStaffDetails> com_RepresentingStructureStaffDetails { get; set; }
        public virtual DbSet<com_RetrievedEmails> com_RetrievedEmails { get; set; }
        public virtual DbSet<com_ShamimInsertionLogs> com_ShamimInsertionLogs { get; set; }
        public virtual DbSet<com_SmsInbox> com_SmsInbox { get; set; }
        public virtual DbSet<com_SmsOutbox> com_SmsOutbox { get; set; }
        public virtual DbSet<com_SmsProviderReceiverSoftwares> com_SmsProviderReceiverSoftwares { get; set; }
        public virtual DbSet<com_SmsProviders> com_SmsProviders { get; set; }
        public virtual DbSet<com_Softwares> com_Softwares { get; set; }
        public virtual DbSet<com_SoftwareSettings> com_SoftwareSettings { get; set; }
        public virtual DbSet<com_Staff> com_Staff { get; set; }
        public virtual DbSet<com_StaffAccessCodes> com_StaffAccessCodes { get; set; }
        public virtual DbSet<com_StaffGroupMembers> com_StaffGroupMembers { get; set; }
        public virtual DbSet<com_StaffGroups> com_StaffGroups { get; set; }
        public virtual DbSet<com_StaffPermissionGroupAccessCodes> com_StaffPermissionGroupAccessCodes { get; set; }
        public virtual DbSet<com_StaffPermissionGroups> com_StaffPermissionGroups { get; set; }
        public virtual DbSet<com_StaffRelationHistory> com_StaffRelationHistory { get; set; }
        public virtual DbSet<com_StaffRelevants> com_StaffRelevants { get; set; }
        public virtual DbSet<com_StaffUsers> com_StaffUsers { get; set; }
        public virtual DbSet<com_StimulsoftDidgahDesigner_ChartSeries> com_StimulsoftDidgahDesigner_ChartSeries { get; set; }
        public virtual DbSet<com_StimulsoftDidgahDesigner_CrossTabDisplayColumns> com_StimulsoftDidgahDesigner_CrossTabDisplayColumns { get; set; }
        public virtual DbSet<com_StimulsoftDidgahDesigner_DataSourceColumns> com_StimulsoftDidgahDesigner_DataSourceColumns { get; set; }
        public virtual DbSet<com_StimulsoftDidgahDesigner_DataSourceParameters> com_StimulsoftDidgahDesigner_DataSourceParameters { get; set; }
        public virtual DbSet<com_StimulsoftDidgahDesigner_DataSourceTables> com_StimulsoftDidgahDesigner_DataSourceTables { get; set; }
        public virtual DbSet<com_StimulsoftDidgahDesigner_OrderColumns> com_StimulsoftDidgahDesigner_OrderColumns { get; set; }
        public virtual DbSet<com_StimulsoftDidgahDesigner_Reports> com_StimulsoftDidgahDesigner_Reports { get; set; }
        public virtual DbSet<com_StimulsoftDidgahDesigner_StandardDisplayColumns> com_StimulsoftDidgahDesigner_StandardDisplayColumns { get; set; }
        public virtual DbSet<com_StimulsoftDidgahDesigner_StandardDisplayGroupColumn> com_StimulsoftDidgahDesigner_StandardDisplayGroupColumn { get; set; }
        public virtual DbSet<com_StimulsoftDidgahDesigner_TemplateStyles> com_StimulsoftDidgahDesigner_TemplateStyles { get; set; }
        public virtual DbSet<com_SyncServerRelatedMobileSoftwares> com_SyncServerRelatedMobileSoftwares { get; set; }
        public virtual DbSet<com_SyncServers> com_SyncServers { get; set; }
        public virtual DbSet<com_SyncServersInfo> com_SyncServersInfo { get; set; }
        public virtual DbSet<com_SyncSessionCandidates> com_SyncSessionCandidates { get; set; }
        public virtual DbSet<com_SyncSessionQueues> com_SyncSessionQueues { get; set; }
        public virtual DbSet<com_SyncSessions> com_SyncSessions { get; set; }
        public virtual DbSet<com_SyncWarnings> com_SyncWarnings { get; set; }
        public virtual DbSet<com_TagGroups> com_TagGroups { get; set; }
        public virtual DbSet<com_Tenants> com_Tenants { get; set; }
        public virtual DbSet<com_Themes> com_Themes { get; set; }
        public virtual DbSet<com_TimelineDiscussionMapping> com_TimelineDiscussionMapping { get; set; }
        public virtual DbSet<com_TimelineMessage> com_TimelineMessage { get; set; }
        public virtual DbSet<com_TimelineSubscriber> com_TimelineSubscriber { get; set; }
        public virtual DbSet<com_TipOfTheDay> com_TipOfTheDay { get; set; }
        public virtual DbSet<com_TrackerEnquiries> com_TrackerEnquiries { get; set; }
        public virtual DbSet<com_Trackers> com_Trackers { get; set; }
        public virtual DbSet<com_TrackerSmsConfigs> com_TrackerSmsConfigs { get; set; }
        public virtual DbSet<com_TrackerStatuses> com_TrackerStatuses { get; set; }
        public virtual DbSet<com_TrackerStatusResponses> com_TrackerStatusResponses { get; set; }
        public virtual DbSet<com_TrackingEntities> com_TrackingEntities { get; set; }
        public virtual DbSet<com_UpdateInformation> com_UpdateInformation { get; set; }
        public virtual DbSet<com_UserAccessCodes> com_UserAccessCodes { get; set; }
        public virtual DbSet<com_UserAccessDefinitionSoftwares> com_UserAccessDefinitionSoftwares { get; set; }
        public virtual DbSet<com_UserAuthenticationLog> com_UserAuthenticationLog { get; set; }
        public virtual DbSet<com_UserCertificates> com_UserCertificates { get; set; }
        public virtual DbSet<com_UserData> com_UserData { get; set; }
        public virtual DbSet<com_UserGroupAccessTypes> com_UserGroupAccessTypes { get; set; }
        public virtual DbSet<com_UserGroupMembers> com_UserGroupMembers { get; set; }
        public virtual DbSet<com_UserGroups> com_UserGroups { get; set; }
        public virtual DbSet<com_UserIPs> com_UserIPs { get; set; }
        public virtual DbSet<com_UserLoginLockInfos> com_UserLoginLockInfos { get; set; }
        public virtual DbSet<com_UserLogins> com_UserLogins { get; set; }
        public virtual DbSet<com_UserMachineIdentifiers> com_UserMachineIdentifiers { get; set; }
        public virtual DbSet<com_UserMobileToken> com_UserMobileToken { get; set; }
        public virtual DbSet<com_UserPermissionGroupAccessCodes> com_UserPermissionGroupAccessCodes { get; set; }
        public virtual DbSet<com_UserPermissionGroups> com_UserPermissionGroups { get; set; }
        public virtual DbSet<com_Users> com_Users { get; set; }
        public virtual DbSet<com_UserSessionPolicies> com_UserSessionPolicies { get; set; }
        public virtual DbSet<com_UserSettings> com_UserSettings { get; set; }
        public virtual DbSet<com_VoucherSignatures> com_VoucherSignatures { get; set; }
        public virtual DbSet<com_VoucherSignatureSets> com_VoucherSignatureSets { get; set; }
        public virtual DbSet<com_Weather> com_Weather { get; set; }
        public virtual DbSet<com_WebPublishingBuffer> com_WebPublishingBuffer { get; set; }
        public virtual DbSet<com_WebServiceAccessCodes> com_WebServiceAccessCodes { get; set; }
        public virtual DbSet<com_WebServiceAccesses> com_WebServiceAccesses { get; set; }
        public virtual DbSet<com_WebServiceLogs> com_WebServiceLogs { get; set; }
        public virtual DbSet<com_WebServiceMethods> com_WebServiceMethods { get; set; }
        public virtual DbSet<com_WebServiceParameters> com_WebServiceParameters { get; set; }
        public virtual DbSet<com_WebServices> com_WebServices { get; set; }
        public virtual DbSet<com_DepartmentDatabases> com_DepartmentDatabases { get; set; }
        public virtual DbSet<com_DynamicReportFields> com_DynamicReportFields { get; set; }
        public virtual DbSet<com_EventContextFields> com_EventContextFields { get; set; }
        public virtual DbSet<com_FinancialActivityTypeFiscalYearDetails> com_FinancialActivityTypeFiscalYearDetails { get; set; }
        public virtual DbSet<com_FlowNodes> com_FlowNodes { get; set; }
        public virtual DbSet<com_Flows> com_Flows { get; set; }
        public virtual DbSet<com_IndicatorUsageTypes> com_IndicatorUsageTypes { get; set; }
        public virtual DbSet<com_OrganizationRelatedPeopleGroupMembers> com_OrganizationRelatedPeopleGroupMembers { get; set; }
        public virtual DbSet<com_OrganizationRelatedPeopleGroups> com_OrganizationRelatedPeopleGroups { get; set; }
        public virtual DbSet<com_PersonTitles_Back> com_PersonTitles_Back { get; set; }
        public virtual DbSet<com_ReportParameters> com_ReportParameters { get; set; }
        public virtual DbSet<com_ReportQueryParameters> com_ReportQueryParameters { get; set; }
        public virtual DbSet<com_SelectOperations> com_SelectOperations { get; set; }
        public virtual DbSet<com_StaffRelationHistoryDetail> com_StaffRelationHistoryDetail { get; set; }
        public virtual DbSet<com_SyncFiles> com_SyncFiles { get; set; }
        public virtual DbSet<com_UserHotkeys> com_UserHotkeys { get; set; }
        public virtual DbSet<com_UserSmsAlertSettings> com_UserSmsAlertSettings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C____Configuration>()
                .Property(e => e.Key)
                .IsUnicode(false);

            modelBuilder.Entity<C____UpdateHistory>()
                .Property(e => e.DatabaseVersion)
                .IsUnicode(false);

            modelBuilder.Entity<com_AdvancedReportHybridColumnElements>()
                .Property(e => e.Operand)
                .IsUnicode(false);

            modelBuilder.Entity<com_AdvancedReportHybridColumns>()
                .HasMany(e => e.com_AdvancedReportHybridColumnElements)
                .WithRequired(e => e.com_AdvancedReportHybridColumns)
                .HasForeignKey(e => e.AdvancedReportHybridColumnId);

            modelBuilder.Entity<com_AdvancedReports>()
                .Property(e => e.SortDirection)
                .IsUnicode(false);

            modelBuilder.Entity<com_Alerts>()
                .Property(e => e.ImageFilename)
                .IsUnicode(false);

            modelBuilder.Entity<com_AssociationDetails>()
                .Property(e => e.Hierarchy)
                .IsUnicode(false);

            modelBuilder.Entity<com_BackgroundTasks>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<com_BackupPlans>()
                .Property(e => e.DayTime)
                .IsUnicode(false);

            modelBuilder.Entity<com_Categories>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.WebPageURL)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.Email1)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.Email2)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.Email3)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.HomePhone1)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.HomePhone2)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.HomePhone3)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.BusinessPhone1)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.BusinessPhone2)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.BusinessPhone3)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.CompanyPhone1)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.CompanyPhone2)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.CompanyPhone3)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.MobilePhone1)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.MobilePhone2)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.MobilePhone3)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.Fax1)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.Fax2)
                .IsUnicode(false);

            modelBuilder.Entity<com_Contacts>()
                .Property(e => e.Fax3)
                .IsUnicode(false);

            modelBuilder.Entity<com_CostCenters>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<com_DataIntegrityFailureHistory>()
                .Property(e => e.MasterHmac)
                .IsUnicode(false);

            modelBuilder.Entity<com_DataIntegrityFailureHistory>()
                .Property(e => e.CalculatedHmac)
                .IsUnicode(false);

            modelBuilder.Entity<com_Departments>()
                .Property(e => e.RemoteEmail)
                .IsUnicode(false);

            modelBuilder.Entity<com_Departments>()
                .Property(e => e.BureauCode)
                .IsUnicode(false);

            modelBuilder.Entity<com_Departments>()
                .Property(e => e.Hierarchy)
                .IsUnicode(false);

            modelBuilder.Entity<com_Dictionary>()
                .Property(e => e.Word)
                .IsUnicode(false);

            modelBuilder.Entity<com_Dictionary>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<com_DigitalSignatureVersion>()
                .Property(e => e.Fields)
                .IsUnicode(false);

            modelBuilder.Entity<com_Discussion>()
                .HasMany(e => e.com_DiscussionEntry)
                .WithRequired(e => e.com_Discussion)
                .HasForeignKey(e => e.DiscussionGuid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<com_Discussion>()
                .HasMany(e => e.com_DiscussionMember)
                .WithRequired(e => e.com_Discussion)
                .HasForeignKey(e => e.DiscussionGuid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<com_DiscussionMember>()
                .HasMany(e => e.com_DiscussionEntry)
                .WithOptional(e => e.com_DiscussionMember)
                .HasForeignKey(e => e.MemberGuid);

            modelBuilder.Entity<com_Drawings>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<com_DynamicReports>()
                .Property(e => e.GroupDirection)
                .IsUnicode(false);

            modelBuilder.Entity<com_DynamicReports>()
                .Property(e => e.SortDirection)
                .IsUnicode(false);

            modelBuilder.Entity<com_EmailAccounts>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<com_EmailAccounts>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<com_EmailAccounts>()
                .Property(e => e.ReplyAddress)
                .IsUnicode(false);

            modelBuilder.Entity<com_EmailAccounts>()
                .Property(e => e.Pop3Server)
                .IsUnicode(false);

            modelBuilder.Entity<com_EmailAccounts>()
                .Property(e => e.Pop3AccountName)
                .IsUnicode(false);

            modelBuilder.Entity<com_EmailAccounts>()
                .Property(e => e.SmtpServer)
                .IsUnicode(false);

            modelBuilder.Entity<com_EmailAccounts>()
                .Property(e => e.SmtpAccountName)
                .IsUnicode(false);

            modelBuilder.Entity<com_EmailAccounts>()
                .Property(e => e.SmtpPassword)
                .IsUnicode(false);

            modelBuilder.Entity<com_EventLog>()
                .Property(e => e.SessionID)
                .IsUnicode(false);

            modelBuilder.Entity<com_EventLog>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<com_EventLog>()
                .Property(e => e.Integrity)
                .IsUnicode(false);

            modelBuilder.Entity<com_ExternalSystems>()
                .Property(e => e.ValidIPs)
                .IsUnicode(false);

            modelBuilder.Entity<com_ExtraModelGuids>()
                .Property(e => e.ListWidth)
                .IsUnicode(false);

            modelBuilder.Entity<com_ExtraModelGuids>()
                .Property(e => e.EditWidth)
                .IsUnicode(false);

            modelBuilder.Entity<com_ExtraModelGuids>()
                .Property(e => e.ExtraInfo)
                .IsUnicode(false);

            modelBuilder.Entity<com_ExtraModels>()
                .Property(e => e.ListWidth)
                .IsUnicode(false);

            modelBuilder.Entity<com_ExtraModels>()
                .Property(e => e.EditWidth)
                .IsUnicode(false);

            modelBuilder.Entity<com_ExtraModels>()
                .Property(e => e.ExtraInfo)
                .IsUnicode(false);

            modelBuilder.Entity<com_Feedbacks>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<com_Feedbacks>()
                .Property(e => e.ResultTag)
                .IsUnicode(false);

            modelBuilder.Entity<com_FileCleanupSchedules>()
                .Property(e => e.ReferenceFlags)
                .IsUnicode(false);

            modelBuilder.Entity<com_Files>()
                .Property(e => e.Hash)
                .IsFixedLength();

            modelBuilder.Entity<com_Languages>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<com_Languages>()
                .Property(e => e.ContentType)
                .IsUnicode(false);

            modelBuilder.Entity<com_MobileFeedbacks>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<com_MobileFeedbacks>()
                .Property(e => e.ResultTag)
                .IsUnicode(false);

            modelBuilder.Entity<com_Nationalities>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<com_Nationalities>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<com_OrganizationRelatedDepartment>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<com_OrganizationRelatedDepartment>()
                .Property(e => e.Hierarchy)
                .IsUnicode(false);

            modelBuilder.Entity<com_OrganizationRelatedDepartment>()
                .Property(e => e.SapadPartyID)
                .IsUnicode(false);

            modelBuilder.Entity<com_OrganizationRelatedPeople>()
                .Property(e => e.AccountCode)
                .IsUnicode(false);

            modelBuilder.Entity<com_OrganizationRelatedPeople>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<com_OrganizationRelatedPeople>()
                .Property(e => e.Hierarchy)
                .IsUnicode(false);

            modelBuilder.Entity<com_OrganizationRelatedPeople>()
                .Property(e => e.FaxNumber)
                .IsUnicode(false);

            modelBuilder.Entity<com_OrganizationRelatedPeople>()
                .Property(e => e.CellPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<com_Organizations>()
                .Property(e => e.AccountCode)
                .IsUnicode(false);

            modelBuilder.Entity<com_Organizations>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<com_Organizations>()
                .Property(e => e.LinkServerEmail)
                .IsUnicode(false);

            modelBuilder.Entity<com_Organizations>()
                .Property(e => e.SapadPartyID)
                .IsUnicode(false);

            modelBuilder.Entity<com_Outbox>()
                .Property(e => e.ReferenceIdentifier)
                .IsUnicode(false);

            modelBuilder.Entity<com_Outbox>()
                .Property(e => e.MessageID)
                .IsUnicode(false);

            modelBuilder.Entity<com_Outbox>()
                .Property(e => e.ReceiverIdentifier)
                .IsUnicode(false);

            modelBuilder.Entity<com_Permanents>()
                .Property(e => e.Parameter)
                .IsUnicode(false);

            modelBuilder.Entity<com_PersonAddressTypes>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<com_PersonContactTypes>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<com_PersonOwnershipTypes>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<com_Persons>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<com_Persons>()
                .HasMany(e => e.com_DiscussionMember)
                .WithRequired(e => e.com_Persons)
                .HasForeignKey(e => e.PersonGuid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<com_Persons>()
                .HasOptional(e => e.com_PersonTimelineSync)
                .WithRequired(e => e.com_Persons);

            modelBuilder.Entity<com_Persons>()
                .HasMany(e => e.com_TimelineSubscriber)
                .WithRequired(e => e.com_Persons)
                .HasForeignKey(e => e.PersonGuid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<com_PersonStockStatus>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<com_PersonSupplyStatus>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<com_PersonTitles>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<com_PersonTitles>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<com_Priorities>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<com_Recurrences>()
                .Property(e => e.OccurrenceDates)
                .IsUnicode(false);

            modelBuilder.Entity<com_ReportRequests>()
                .Property(e => e.ReportTitle)
                .IsUnicode(false);

            modelBuilder.Entity<com_ReportRequests>()
                .Property(e => e.ReportFilename)
                .IsUnicode(false);

            modelBuilder.Entity<com_ReportRequests>()
                .Property(e => e.OutputType)
                .IsUnicode(false);

            modelBuilder.Entity<com_ReportRequests>()
                .Property(e => e.Destination)
                .IsUnicode(false);

            modelBuilder.Entity<com_ReportRequests>()
                .Property(e => e.SessionID)
                .IsUnicode(false);

            modelBuilder.Entity<com_ReportRequests>()
                .Property(e => e.DBDataSource)
                .IsUnicode(false);

            modelBuilder.Entity<com_ReportRequests>()
                .Property(e => e.DBInitialCatalog)
                .IsUnicode(false);

            modelBuilder.Entity<com_ReportRequests>()
                .Property(e => e.DBPrefix)
                .IsUnicode(false);

            modelBuilder.Entity<com_ReportRequests>()
                .Property(e => e.DBUserID)
                .IsUnicode(false);

            modelBuilder.Entity<com_ReportRequests>()
                .Property(e => e.DBPassword)
                .IsUnicode(false);

            modelBuilder.Entity<com_RepresentingStructure>()
                .Property(e => e.Hierarchy)
                .IsUnicode(false);

            modelBuilder.Entity<com_RepresentingStructureDepartmentDetails>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<com_RepresentingStructureDepartmentDetails>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<com_RepresentingStructureStaffDetails>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<com_RepresentingStructureStaffDetails>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<com_Staff>()
                .Property(e => e.Hierarchy)
                .IsUnicode(false);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_StandardDisplayColumns>()
                .Property(e => e.Width)
                .HasPrecision(18, 0);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.PaperKind)
                .IsUnicode(false);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.MarginTop)
                .HasPrecision(18, 0);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.MarginRight)
                .HasPrecision(18, 0);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.MarginBottom)
                .HasPrecision(18, 0);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.MarginLeft)
                .HasPrecision(18, 0);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.CellHeight)
                .HasPrecision(18, 0);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.CellDefaultWidth)
                .HasPrecision(18, 0);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.HeaderFontName)
                .IsUnicode(false);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.RowFontName)
                .IsUnicode(false);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.HeaderColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.EvenRowColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.OddRowColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.TotalSumColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.PageSumColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.SumFromFirstColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.PreviousPageSumColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.HeaderPrintOn)
                .IsUnicode(false);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.SignaturPrintOn)
                .IsUnicode(false);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.CrossTabDetailColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_StimulsoftDidgahDesigner_TemplateStyles>()
                .Property(e => e.CrossTabTotalColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_SyncSessionQueues>()
                .Property(e => e.PackageFileName)
                .IsUnicode(false);

            modelBuilder.Entity<com_SyncSessionQueues>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<com_Tenants>()
                .Property(e => e.ENKeyword)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.THColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.THBackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.ListRowNormalColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.ListRowNormalBackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.ListRowNormalSelectedColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.ListRowNormalSelectedBackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.ListRowUnreadColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.ListRowUnreadBackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.ListRowUnreadSelectedColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.ListRowUnreadSelectedBackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.TitleBarBackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.TitleBarColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.TreeNodeBackgroundColorHighlighted)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.TreeViewBackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.HeaderPanelBackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.ContainerBackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.TitleCellColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.SoftwareTitleColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.ButtonNormalColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.ButtonNormalBackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.ButtonHighlightedColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.ButtonHighlightedBackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.InputColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.InputBackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.OutlookbarBackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.OutlookbarButtonBackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.OutlookbarButtonColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.OutlookbarItemColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.MenuItemColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.MenuItemBackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.MenuItemSelectedColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.MenuItemSelectedBackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.MenuGroupBackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.MenuGroupColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.MenuGroupTopBorder)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.MenuGroupSelectedBackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.MenuGroupSelectedColor)
                .IsUnicode(false);

            modelBuilder.Entity<com_Themes>()
                .Property(e => e.MenuGroupSideBorder)
                .IsUnicode(false);

            modelBuilder.Entity<com_TrackerEnquiries>()
                .Property(e => e.TrackNo)
                .IsUnicode(false);

            modelBuilder.Entity<com_TrackerStatusResponses>()
                .Property(e => e.LanguageKey)
                .IsUnicode(false);

            modelBuilder.Entity<com_TrackerStatusResponses>()
                .Property(e => e.Tag)
                .IsUnicode(false);

            modelBuilder.Entity<com_TrackingEntities>()
                .Property(e => e.TrackingNo)
                .IsUnicode(false);

            modelBuilder.Entity<com_UserAuthenticationLog>()
                .Property(e => e.Integrity)
                .IsUnicode(false);

            modelBuilder.Entity<com_UserCertificates>()
                .Property(e => e.File_filename)
                .IsUnicode(false);

            modelBuilder.Entity<com_UserCertificates>()
                .Property(e => e.SerialNumber)
                .IsUnicode(false);

            modelBuilder.Entity<com_UserCertificates>()
                .Property(e => e.Integrity)
                .IsUnicode(false);

            modelBuilder.Entity<com_UserCertificates>()
                .Property(e => e.Thumbprint)
                .IsUnicode(false);

            modelBuilder.Entity<com_UserCertificates>()
                .Property(e => e.SubjectDN)
                .IsUnicode(false);

            modelBuilder.Entity<com_UserData>()
                .Property(e => e.CommandId)
                .IsUnicode(false);

            modelBuilder.Entity<com_UserData>()
                .Property(e => e.System)
                .IsUnicode(false);

            modelBuilder.Entity<com_UserGroups>()
                .Property(e => e.AccessType)
                .IsUnicode(false);

            modelBuilder.Entity<com_UserIPs>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<com_UserLoginLockInfos>()
                .Property(e => e.Integrity)
                .IsUnicode(false);

            modelBuilder.Entity<com_UserLogins>()
                .Property(e => e.SessionID)
                .IsUnicode(false);

            modelBuilder.Entity<com_UserLogins>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<com_UserLogins>()
                .Property(e => e.ComputerName)
                .IsUnicode(false);

            modelBuilder.Entity<com_UserLogins>()
                .Property(e => e.Integrity)
                .IsUnicode(false);

            modelBuilder.Entity<com_UserMachineIdentifiers>()
                .Property(e => e.MachineIdentifier)
                .IsUnicode(false);

            modelBuilder.Entity<com_Users>()
                .Property(e => e.DidgahMobileAlertExcludeSoftwareList)
                .IsUnicode(false);

            modelBuilder.Entity<com_Users>()
                .Property(e => e.Integrity)
                .IsUnicode(false);

            modelBuilder.Entity<com_VoucherSignatureSets>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<com_WebPublishingBuffer>()
                .Property(e => e.UserIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<com_DynamicReportFields>()
                .Property(e => e.SortDirection)
                .IsUnicode(false);

            modelBuilder.Entity<com_FlowNodes>()
                .Property(e => e.AlertIconFileName)
                .IsUnicode(false);

            modelBuilder.Entity<com_FlowNodes>()
                .Property(e => e.StatusCaption)
                .IsUnicode(false);

            modelBuilder.Entity<com_FlowNodes>()
                .Property(e => e.PhaseCaption)
                .IsUnicode(false);

            modelBuilder.Entity<com_FlowNodes>()
                .Property(e => e.Hierarchy)
                .IsUnicode(false);

            modelBuilder.Entity<com_PersonTitles_Back>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<com_PersonTitles_Back>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);
        }
    }
}
