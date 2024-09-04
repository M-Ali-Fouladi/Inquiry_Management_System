namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        private static Model1 Instance;
        public Model1()
            : base("name=Model11")
        {
        }
        public static Model1 GetInstance()
        {
            if (Instance == null)
                Instance = new Model1();
            return Instance;
        }
        public virtual DbSet<C____UpdateHistory> C____UpdateHistory { get; set; }
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<com_DataListUserSettings> com_DataListUserSettings { get; set; }
        public virtual DbSet<prs_AttachmentFileNatureFieldsMapping> prs_AttachmentFileNatureFieldsMapping { get; set; }
        public virtual DbSet<prs_AttainmentConditionItems> prs_AttainmentConditionItems { get; set; }
        public virtual DbSet<prs_AuditConfigurations> prs_AuditConfigurations { get; set; }
        public virtual DbSet<prs_AuditEntityLogs> prs_AuditEntityLogs { get; set; }
        public virtual DbSet<prs_BadWeatherGroups> prs_BadWeatherGroups { get; set; }
        public virtual DbSet<prs_BankFormatDetails> prs_BankFormatDetails { get; set; }
        public virtual DbSet<prs_BankFormats> prs_BankFormats { get; set; }
        public virtual DbSet<prs_BasePost> prs_BasePost { get; set; }
        public virtual DbSet<prs_BasePostHistory> prs_BasePostHistory { get; set; }
        public virtual DbSet<prs_BasePostPostRanks> prs_BasePostPostRanks { get; set; }
        public virtual DbSet<prs_BasijiTypes> prs_BasijiTypes { get; set; }
        public virtual DbSet<prs_Bookmarks> prs_Bookmarks { get; set; }
        public virtual DbSet<prs_CautionExtraFieldGroups> prs_CautionExtraFieldGroups { get; set; }
        public virtual DbSet<prs_CenterLevels> prs_CenterLevels { get; set; }
        public virtual DbSet<prs_ContractTypes> prs_ContractTypes { get; set; }
        public virtual DbSet<prs_Councils> prs_Councils { get; set; }
        public virtual DbSet<prs_CountryDivisions> prs_CountryDivisions { get; set; }
        public virtual DbSet<prs_CourseDegrees> prs_CourseDegrees { get; set; }
        public virtual DbSet<prs_CourseFields> prs_CourseFields { get; set; }
        public virtual DbSet<prs_Courses> prs_Courses { get; set; }
        public virtual DbSet<prs_CourseTypes> prs_CourseTypes { get; set; }
        public virtual DbSet<prs_DecreeChangesTrack> prs_DecreeChangesTrack { get; set; }
        public virtual DbSet<prs_DecreeCorrectionAffectedDecrees> prs_DecreeCorrectionAffectedDecrees { get; set; }
        public virtual DbSet<prs_DecreeItems> prs_DecreeItems { get; set; }
        public virtual DbSet<prs_DecreeLogs> prs_DecreeLogs { get; set; }
        public virtual DbSet<prs_DecreeLogSettings> prs_DecreeLogSettings { get; set; }
        public virtual DbSet<prs_Decrees> prs_Decrees { get; set; }
        public virtual DbSet<prs_Decrees_Audit> prs_Decrees_Audit { get; set; }
        public virtual DbSet<prs_DecreeSummaries> prs_DecreeSummaries { get; set; }
        public virtual DbSet<prs_DecreeTemplateCCReceivers> prs_DecreeTemplateCCReceivers { get; set; }
        public virtual DbSet<prs_DecreeTemplateChangeEventLogs> prs_DecreeTemplateChangeEventLogs { get; set; }
        public virtual DbSet<prs_DecreeTemplateChanges> prs_DecreeTemplateChanges { get; set; }
        public virtual DbSet<prs_DecreeTemplateFileByEmploymentTypes> prs_DecreeTemplateFileByEmploymentTypes { get; set; }
        public virtual DbSet<prs_DecreeTemplateHistories> prs_DecreeTemplateHistories { get; set; }
        public virtual DbSet<prs_DecreeTemplateItemDisplayCategories> prs_DecreeTemplateItemDisplayCategories { get; set; }
        public virtual DbSet<prs_DecreeTemplateItems> prs_DecreeTemplateItems { get; set; }
        public virtual DbSet<prs_DecreeTemplateItemTemplateItems> prs_DecreeTemplateItemTemplateItems { get; set; }
        public virtual DbSet<prs_DecreeTemplateItemTemplates> prs_DecreeTemplateItemTemplates { get; set; }
        public virtual DbSet<prs_DecreeTemplatePreconditions> prs_DecreeTemplatePreconditions { get; set; }
        public virtual DbSet<prs_DecreeTemplates> prs_DecreeTemplates { get; set; }
        public virtual DbSet<prs_DecreeTemplatesCategorizations> prs_DecreeTemplatesCategorizations { get; set; }
        public virtual DbSet<prs_DecreeTemplateSigners> prs_DecreeTemplateSigners { get; set; }
        public virtual DbSet<prs_DecreeTemplateVersions> prs_DecreeTemplateVersions { get; set; }
        public virtual DbSet<prs_DecreeTemplateVersionsAssignments> prs_DecreeTemplateVersionsAssignments { get; set; }
        public virtual DbSet<prs_DecreeWorkflowActions> prs_DecreeWorkflowActions { get; set; }
        public virtual DbSet<prs_DecreeWorkflowProcess> prs_DecreeWorkflowProcess { get; set; }
        public virtual DbSet<prs_DecreeWorkflowProcessHistory> prs_DecreeWorkflowProcessHistory { get; set; }
        public virtual DbSet<prs_DecreeWorkflowProcessSteps> prs_DecreeWorkflowProcessSteps { get; set; }
        public virtual DbSet<prs_DepartmentExtra> prs_DepartmentExtra { get; set; }
        public virtual DbSet<prs_DepartmentExtraHistory> prs_DepartmentExtraHistory { get; set; }
        public virtual DbSet<prs_DependencyDegrees> prs_DependencyDegrees { get; set; }
        public virtual DbSet<prs_DependencyReasons> prs_DependencyReasons { get; set; }
        public virtual DbSet<prs_DeprivationGroups> prs_DeprivationGroups { get; set; }
        public virtual DbSet<prs_DestinationRules> prs_DestinationRules { get; set; }
        public virtual DbSet<prs_DiplomaTypes> prs_DiplomaTypes { get; set; }
        public virtual DbSet<prs_Duties> prs_Duties { get; set; }
        public virtual DbSet<prs_DutyAssigments> prs_DutyAssigments { get; set; }
        public virtual DbSet<prs_DutyAssigmentSkills> prs_DutyAssigmentSkills { get; set; }
        public virtual DbSet<prs_DutyDescriptionGroups> prs_DutyDescriptionGroups { get; set; }
        public virtual DbSet<prs_DutyDescriptionNatures> prs_DutyDescriptionNatures { get; set; }
        public virtual DbSet<prs_DutyDescriptions> prs_DutyDescriptions { get; set; }
        public virtual DbSet<prs_DutyDescriptionSkills> prs_DutyDescriptionSkills { get; set; }
        public virtual DbSet<prs_DutyGroups> prs_DutyGroups { get; set; }
        public virtual DbSet<prs_EducationBranchs> prs_EducationBranchs { get; set; }
        public virtual DbSet<prs_EducationCenters> prs_EducationCenters { get; set; }
        public virtual DbSet<prs_EducationFieldGroupEducationFields> prs_EducationFieldGroupEducationFields { get; set; }
        public virtual DbSet<prs_EducationFieldGroups> prs_EducationFieldGroups { get; set; }
        public virtual DbSet<prs_EducationFieldGroupTemplates> prs_EducationFieldGroupTemplates { get; set; }
        public virtual DbSet<prs_EducationFields> prs_EducationFields { get; set; }
        public virtual DbSet<prs_EducationLevelFieldsMapping> prs_EducationLevelFieldsMapping { get; set; }
        public virtual DbSet<prs_EducationLevelGroupEducationLevels> prs_EducationLevelGroupEducationLevels { get; set; }
        public virtual DbSet<prs_EducationLevelGroups> prs_EducationLevelGroups { get; set; }
        public virtual DbSet<prs_EducationLevelGroupTemplates> prs_EducationLevelGroupTemplates { get; set; }
        public virtual DbSet<prs_EducationLevels_Back> prs_EducationLevels_Back { get; set; }
        public virtual DbSet<prs_EducationLicenseType> prs_EducationLicenseType { get; set; }
        public virtual DbSet<prs_Educations> prs_Educations { get; set; }
        public virtual DbSet<prs_EmploymentDemandedJobs> prs_EmploymentDemandedJobs { get; set; }
        public virtual DbSet<prs_EmploymentFormExtra> prs_EmploymentFormExtra { get; set; }
        public virtual DbSet<prs_EmploymentFormExtraFieldGroups> prs_EmploymentFormExtraFieldGroups { get; set; }
        public virtual DbSet<prs_EmploymentFormExtraFieldsMapping> prs_EmploymentFormExtraFieldsMapping { get; set; }
        public virtual DbSet<prs_EmploymentFormLogs> prs_EmploymentFormLogs { get; set; }
        public virtual DbSet<prs_EmploymentForms> prs_EmploymentForms { get; set; }
        public virtual DbSet<prs_EmploymentFormScores> prs_EmploymentFormScores { get; set; }
        public virtual DbSet<prs_EmploymentFormScoringItems> prs_EmploymentFormScoringItems { get; set; }
        public virtual DbSet<prs_EmploymentInterviews> prs_EmploymentInterviews { get; set; }
        public virtual DbSet<prs_EmploymentOfferJobs> prs_EmploymentOfferJobs { get; set; }
        public virtual DbSet<prs_EmploymentStatuses> prs_EmploymentStatuses { get; set; }
        public virtual DbSet<prs_EmploymentStatusGroupEmploymentStatuses> prs_EmploymentStatusGroupEmploymentStatuses { get; set; }
        public virtual DbSet<prs_EmploymentStatusGroups> prs_EmploymentStatusGroups { get; set; }
        public virtual DbSet<prs_EmploymentStatusGroupTemplates> prs_EmploymentStatusGroupTemplates { get; set; }
        public virtual DbSet<prs_EmploymentTypeGroupEmploymentTypes> prs_EmploymentTypeGroupEmploymentTypes { get; set; }
        public virtual DbSet<prs_EmploymentTypeGroups> prs_EmploymentTypeGroups { get; set; }
        public virtual DbSet<prs_EmploymentTypeGroupTemplates> prs_EmploymentTypeGroupTemplates { get; set; }
        public virtual DbSet<prs_EmploymentTypes> prs_EmploymentTypes { get; set; }
        public virtual DbSet<prs_EncourageExtraFieldGroups> prs_EncourageExtraFieldGroups { get; set; }
        public virtual DbSet<prs_EncourageGroups> prs_EncourageGroups { get; set; }
        public virtual DbSet<prs_EvaluationGrades> prs_EvaluationGrades { get; set; }
        public virtual DbSet<prs_EvaluationGroups> prs_EvaluationGroups { get; set; }
        public virtual DbSet<prs_EvaluationPeriods> prs_EvaluationPeriods { get; set; }
        public virtual DbSet<prs_EventLogs> prs_EventLogs { get; set; }
        public virtual DbSet<prs_ExpertGradeGroupExpertGrades> prs_ExpertGradeGroupExpertGrades { get; set; }
        public virtual DbSet<prs_ExpertGradeGroups> prs_ExpertGradeGroups { get; set; }
        public virtual DbSet<prs_ExpertGradeGroupTemplates> prs_ExpertGradeGroupTemplates { get; set; }
        public virtual DbSet<prs_ExpertGrades> prs_ExpertGrades { get; set; }
        public virtual DbSet<prs_ExtraModels> prs_ExtraModels { get; set; }
        public virtual DbSet<prs_ExtraWorkFlows> prs_ExtraWorkFlows { get; set; }
        public virtual DbSet<prs_ExtraWorkPlanItems> prs_ExtraWorkPlanItems { get; set; }
        public virtual DbSet<prs_ExtraWorkPlans> prs_ExtraWorkPlans { get; set; }
        public virtual DbSet<prs_ExtraWorks> prs_ExtraWorks { get; set; }
        public virtual DbSet<prs_FamilyRelations> prs_FamilyRelations { get; set; }
        public virtual DbSet<prs_ForeignLanguages> prs_ForeignLanguages { get; set; }
        public virtual DbSet<prs_FormulaEditorLogs> prs_FormulaEditorLogs { get; set; }
        public virtual DbSet<prs_GainConditionSettings> prs_GainConditionSettings { get; set; }
        public virtual DbSet<prs_GatewayItemsReferences> prs_GatewayItemsReferences { get; set; }
        public virtual DbSet<prs_GratitudeExtraFieldGroups> prs_GratitudeExtraFieldGroups { get; set; }
        public virtual DbSet<prs_IncrementFactors> prs_IncrementFactors { get; set; }
        public virtual DbSet<prs_Indicators> prs_Indicators { get; set; }
        public virtual DbSet<prs_InsuranceTypes> prs_InsuranceTypes { get; set; }
        public virtual DbSet<prs_InterviewType> prs_InterviewType { get; set; }
        public virtual DbSet<prs_ItemCalcs> prs_ItemCalcs { get; set; }
        public virtual DbSet<prs_ItemCategories> prs_ItemCategories { get; set; }
        public virtual DbSet<prs_ItemDefaults> prs_ItemDefaults { get; set; }
        public virtual DbSet<prs_ItemDisplayCategories> prs_ItemDisplayCategories { get; set; }
        public virtual DbSet<prs_ItemDisplayCategoryItems> prs_ItemDisplayCategoryItems { get; set; }
        public virtual DbSet<prs_ItemDisplayTitles> prs_ItemDisplayTitles { get; set; }
        public virtual DbSet<prs_ItemMatrixes> prs_ItemMatrixes { get; set; }
        public virtual DbSet<prs_ItemMatrixValues> prs_ItemMatrixValues { get; set; }
        public virtual DbSet<prs_Items> prs_Items { get; set; }
        public virtual DbSet<prs_ItemTables> prs_ItemTables { get; set; }
        public virtual DbSet<prs_ItemTableValues> prs_ItemTableValues { get; set; }
        public virtual DbSet<prs_JobCategories> prs_JobCategories { get; set; }
        public virtual DbSet<prs_JobCategoryGroupJobCategories> prs_JobCategoryGroupJobCategories { get; set; }
        public virtual DbSet<prs_JobCategoryGroups> prs_JobCategoryGroups { get; set; }
        public virtual DbSet<prs_JobCategoryGroupTemplates> prs_JobCategoryGroupTemplates { get; set; }
        public virtual DbSet<prs_JobDegrees> prs_JobDegrees { get; set; }
        public virtual DbSet<prs_JobDutyAssignments_old> prs_JobDutyAssignments_old { get; set; }
        public virtual DbSet<prs_JobDutyDescriptionDetails_old> prs_JobDutyDescriptionDetails_old { get; set; }
        public virtual DbSet<prs_JobDutyDescriptions_old> prs_JobDutyDescriptions_old { get; set; }
        public virtual DbSet<prs_JobDutyDescriptionTypes_old> prs_JobDutyDescriptionTypes_old { get; set; }
        public virtual DbSet<prs_JobEvaluationLevels> prs_JobEvaluationLevels { get; set; }
        public virtual DbSet<prs_JobExtraFieldGroups> prs_JobExtraFieldGroups { get; set; }
        public virtual DbSet<prs_JobFieldGroupJobFields> prs_JobFieldGroupJobFields { get; set; }
        public virtual DbSet<prs_JobFieldGroups> prs_JobFieldGroups { get; set; }
        public virtual DbSet<prs_JobFieldGroupTemplates> prs_JobFieldGroupTemplates { get; set; }
        public virtual DbSet<prs_JobFields> prs_JobFields { get; set; }
        public virtual DbSet<prs_JobGrades> prs_JobGrades { get; set; }
        public virtual DbSet<prs_JobHistory> prs_JobHistory { get; set; }
        public virtual DbSet<prs_Jobs> prs_Jobs { get; set; }
        public virtual DbSet<prs_JobStages> prs_JobStages { get; set; }
        public virtual DbSet<prs_LadderDecrees> prs_LadderDecrees { get; set; }
        public virtual DbSet<prs_LadderDecreeSettings> prs_LadderDecreeSettings { get; set; }
        public virtual DbSet<prs_LanguageKnowledges> prs_LanguageKnowledges { get; set; }
        public virtual DbSet<prs_LanguageKnowledgesProficiencyLevelTypes> prs_LanguageKnowledgesProficiencyLevelTypes { get; set; }
        public virtual DbSet<prs_LanguageKnowledgesRequirementLevelTypes> prs_LanguageKnowledgesRequirementLevelTypes { get; set; }
        public virtual DbSet<prs_LeaveBookmarks> prs_LeaveBookmarks { get; set; }
        public virtual DbSet<prs_LeaveConfirmationBookmarks> prs_LeaveConfirmationBookmarks { get; set; }
        public virtual DbSet<prs_LeaveDecreasingDays> prs_LeaveDecreasingDays { get; set; }
        public virtual DbSet<prs_LeaveFlows> prs_LeaveFlows { get; set; }
        public virtual DbSet<prs_LeaveGroups> prs_LeaveGroups { get; set; }
        public virtual DbSet<prs_LeaveGroupTypes> prs_LeaveGroupTypes { get; set; }
        public virtual DbSet<prs_LeavePlanItems> prs_LeavePlanItems { get; set; }
        public virtual DbSet<prs_LeavePlans> prs_LeavePlans { get; set; }
        public virtual DbSet<prs_Leaves> prs_Leaves { get; set; }
        public virtual DbSet<prs_LeaveSpecialDayCalendarDays> prs_LeaveSpecialDayCalendarDays { get; set; }
        public virtual DbSet<prs_LeaveSpecialDayCalendars> prs_LeaveSpecialDayCalendars { get; set; }
        public virtual DbSet<prs_LeaveTypePreusableMonths> prs_LeaveTypePreusableMonths { get; set; }
        public virtual DbSet<prs_LeaveTypeRangeRatios> prs_LeaveTypeRangeRatios { get; set; }
        public virtual DbSet<prs_LeaveTypes> prs_LeaveTypes { get; set; }
        public virtual DbSet<prs_LeaveTypeSpecialDays> prs_LeaveTypeSpecialDays { get; set; }
        public virtual DbSet<prs_ManagerLevels> prs_ManagerLevels { get; set; }
        public virtual DbSet<prs_MaritalStatuses> prs_MaritalStatuses { get; set; }
        public virtual DbSet<prs_MaritalStatusGroupMaritalStatuses> prs_MaritalStatusGroupMaritalStatuses { get; set; }
        public virtual DbSet<prs_MaritalStatusGroups> prs_MaritalStatusGroups { get; set; }
        public virtual DbSet<prs_MaritalStatusGroupTemplates> prs_MaritalStatusGroupTemplates { get; set; }
        public virtual DbSet<prs_MilitaryStatuses> prs_MilitaryStatuses { get; set; }
        public virtual DbSet<prs_MissionBookmarks> prs_MissionBookmarks { get; set; }
        public virtual DbSet<prs_MissionBudgetCenters> prs_MissionBudgetCenters { get; set; }
        public virtual DbSet<prs_MissionCancels_Old_ID_to_Guid_Changes> prs_MissionCancels_Old_ID_to_Guid_Changes { get; set; }
        public virtual DbSet<prs_MissionDecrees_Old_ID_to_Guid_Changes> prs_MissionDecrees_Old_ID_to_Guid_Changes { get; set; }
        public virtual DbSet<prs_MissionExtractionExtraFieldGroups> prs_MissionExtractionExtraFieldGroups { get; set; }
        public virtual DbSet<prs_MissionExtractionFlows_Old_ID_to_Guid_Changes> prs_MissionExtractionFlows_Old_ID_to_Guid_Changes { get; set; }
        public virtual DbSet<prs_MissionExtractions> prs_MissionExtractions { get; set; }
        public virtual DbSet<prs_MissionExtraFieldGroups> prs_MissionExtraFieldGroups { get; set; }
        public virtual DbSet<prs_MissionFlows_Old_ID_to_Guid_Changes> prs_MissionFlows_Old_ID_to_Guid_Changes { get; set; }
        public virtual DbSet<prs_MissionGroups> prs_MissionGroups { get; set; }
        public virtual DbSet<prs_MissionGroupTypes> prs_MissionGroupTypes { get; set; }
        public virtual DbSet<prs_MissionPaymentItemCalcs> prs_MissionPaymentItemCalcs { get; set; }
        public virtual DbSet<prs_MissionPaymentItemDefaults> prs_MissionPaymentItemDefaults { get; set; }
        public virtual DbSet<prs_MissionPaymentItems> prs_MissionPaymentItems { get; set; }
        public virtual DbSet<prs_MissionPlaceGroups> prs_MissionPlaceGroups { get; set; }
        public virtual DbSet<prs_MissionPlaces> prs_MissionPlaces { get; set; }
        public virtual DbSet<prs_MissionPlanItems_Old> prs_MissionPlanItems_Old { get; set; }
        public virtual DbSet<prs_MissionPlans_Old> prs_MissionPlans_Old { get; set; }
        public virtual DbSet<prs_MissionRequests_Old_ID_to_Guid_Changes> prs_MissionRequests_Old_ID_to_Guid_Changes { get; set; }
        public virtual DbSet<prs_Missions> prs_Missions { get; set; }
        public virtual DbSet<prs_MissionTargetOrganizations> prs_MissionTargetOrganizations { get; set; }
        public virtual DbSet<prs_MissionTypes> prs_MissionTypes { get; set; }
        public virtual DbSet<prs_MissionVehicleType> prs_MissionVehicleType { get; set; }
        public virtual DbSet<prs_Nationalities> prs_Nationalities { get; set; }
        public virtual DbSet<prs_NoticeCauseGroups> prs_NoticeCauseGroups { get; set; }
        public virtual DbSet<prs_NoticeCauses> prs_NoticeCauses { get; set; }
        public virtual DbSet<prs_Notices> prs_Notices { get; set; }
        public virtual DbSet<prs_NoticeTypeGroups> prs_NoticeTypeGroups { get; set; }
        public virtual DbSet<prs_NoticeTypes> prs_NoticeTypes { get; set; }
        public virtual DbSet<prs_NoticeTypes_Audit> prs_NoticeTypes_Audit { get; set; }
        public virtual DbSet<prs_OperationalUnitAccessZone> prs_OperationalUnitAccessZone { get; set; }
        public virtual DbSet<prs_OperationalUnitPersonnel> prs_OperationalUnitPersonnel { get; set; }
        public virtual DbSet<prs_OperationalUnits_Audit> prs_OperationalUnits_Audit { get; set; }
        public virtual DbSet<prs_OperationalUnitSoftwares> prs_OperationalUnitSoftwares { get; set; }
        public virtual DbSet<prs_OperationalUnitStaff> prs_OperationalUnitStaff { get; set; }
        public virtual DbSet<prs_Permanents> prs_Permanents { get; set; }
        public virtual DbSet<prs_Personnel> prs_Personnel { get; set; }
        public virtual DbSet<prs_PersonnelAbsences> prs_PersonnelAbsences { get; set; }
        public virtual DbSet<prs_PersonnelAssignment> prs_PersonnelAssignment { get; set; }
        public virtual DbSet<prs_PersonnelAssignmentLogs> prs_PersonnelAssignmentLogs { get; set; }
        public virtual DbSet<prs_PersonnelBasijies> prs_PersonnelBasijies { get; set; }
        public virtual DbSet<prs_PersonnelCaptivities> prs_PersonnelCaptivities { get; set; }
        public virtual DbSet<prs_PersonnelChangesTrack> prs_PersonnelChangesTrack { get; set; }
        public virtual DbSet<prs_PersonnelContracts> prs_PersonnelContracts { get; set; }
        public virtual DbSet<prs_PersonnelDependantExtra> prs_PersonnelDependantExtra { get; set; }
        public virtual DbSet<prs_PersonnelDependantExtraFieldGroups> prs_PersonnelDependantExtraFieldGroups { get; set; }
        public virtual DbSet<prs_PersonnelDependants> prs_PersonnelDependants { get; set; }
        public virtual DbSet<prs_PersonnelEncourageGroups> prs_PersonnelEncourageGroups { get; set; }
        public virtual DbSet<prs_PersonnelEvaluationGrades> prs_PersonnelEvaluationGrades { get; set; }
        public virtual DbSet<prs_PersonnelEvaluationGroups> prs_PersonnelEvaluationGroups { get; set; }
        public virtual DbSet<prs_PersonnelExtra> prs_PersonnelExtra { get; set; }
        public virtual DbSet<prs_PersonnelExtraFieldGroups> prs_PersonnelExtraFieldGroups { get; set; }
        public virtual DbSet<prs_PersonnelExtraGrid1> prs_PersonnelExtraGrid1 { get; set; }
        public virtual DbSet<prs_PersonnelExtraGrid2> prs_PersonnelExtraGrid2 { get; set; }
        public virtual DbSet<prs_PersonnelExtraGrid3> prs_PersonnelExtraGrid3 { get; set; }
        public virtual DbSet<prs_PersonnelExtraGrid4> prs_PersonnelExtraGrid4 { get; set; }
        public virtual DbSet<prs_PersonnelFormSettings> prs_PersonnelFormSettings { get; set; }
        public virtual DbSet<prs_PersonnelFrontServices> prs_PersonnelFrontServices { get; set; }
        public virtual DbSet<prs_PersonnelGroups> prs_PersonnelGroups { get; set; }
        public virtual DbSet<prs_PersonnelHistory> prs_PersonnelHistory { get; set; }
        public virtual DbSet<prs_PersonnelIncrementFactors> prs_PersonnelIncrementFactors { get; set; }
        public virtual DbSet<prs_PersonnelLeaveMilestones> prs_PersonnelLeaveMilestones { get; set; }
        public virtual DbSet<prs_PersonnelMissionGroups> prs_PersonnelMissionGroups { get; set; }
        public virtual DbSet<prs_PersonnelReferencedLetters> prs_PersonnelReferencedLetters { get; set; }
        public virtual DbSet<prs_PersonnelResultSetItems> prs_PersonnelResultSetItems { get; set; }
        public virtual DbSet<prs_PersonnelResultSets> prs_PersonnelResultSets { get; set; }
        public virtual DbSet<prs_PersonnelSaveConditionsSettings> prs_PersonnelSaveConditionsSettings { get; set; }
        public virtual DbSet<prs_PersonnelWorkHistory> prs_PersonnelWorkHistory { get; set; }
        public virtual DbSet<prs_PersonTitles> prs_PersonTitles { get; set; }
        public virtual DbSet<prs_PostDuties> prs_PostDuties { get; set; }
        public virtual DbSet<prs_PostExtra> prs_PostExtra { get; set; }
        public virtual DbSet<prs_PostExtraHistory> prs_PostExtraHistory { get; set; }
        public virtual DbSet<prs_PostGrades> prs_PostGrades { get; set; }
        public virtual DbSet<prs_PostLackOfSuctionLevels> prs_PostLackOfSuctionLevels { get; set; }
        public virtual DbSet<prs_PostNatures> prs_PostNatures { get; set; }
        public virtual DbSet<prs_PostOperationalNatures> prs_PostOperationalNatures { get; set; }
        public virtual DbSet<prs_PostPostRanks> prs_PostPostRanks { get; set; }
        public virtual DbSet<prs_PostRanks> prs_PostRanks { get; set; }
        public virtual DbSet<prs_PostTypes> prs_PostTypes { get; set; }
        public virtual DbSet<prs_PredecreeItems> prs_PredecreeItems { get; set; }
        public virtual DbSet<prs_Predecrees> prs_Predecrees { get; set; }
        public virtual DbSet<prs_PredecreeValues> prs_PredecreeValues { get; set; }
        public virtual DbSet<prs_ProbationExtraFieldGroups> prs_ProbationExtraFieldGroups { get; set; }
        public virtual DbSet<prs_ProclamationBookmarks> prs_ProclamationBookmarks { get; set; }
        public virtual DbSet<prs_ProclamationHistory> prs_ProclamationHistory { get; set; }
        public virtual DbSet<prs_Proclamations> prs_Proclamations { get; set; }
        public virtual DbSet<prs_ProclamationTemplates> prs_ProclamationTemplates { get; set; }
        public virtual DbSet<prs_ProclamationTemplatesCategorizations> prs_ProclamationTemplatesCategorizations { get; set; }
        public virtual DbSet<prs_ProclamationTemplateVersionsAssignmentsDetails> prs_ProclamationTemplateVersionsAssignmentsDetails { get; set; }
        public virtual DbSet<prs_ProficienciesAndSkills> prs_ProficienciesAndSkills { get; set; }
        public virtual DbSet<prs_PromotionAppointedApprovedReasons> prs_PromotionAppointedApprovedReasons { get; set; }
        public virtual DbSet<prs_PromotionAppointedRejectedReasons> prs_PromotionAppointedRejectedReasons { get; set; }
        public virtual DbSet<prs_PromotionBatchWorkflowSettings> prs_PromotionBatchWorkflowSettings { get; set; }
        public virtual DbSet<prs_PromotionHistory> prs_PromotionHistory { get; set; }
        public virtual DbSet<prs_PromotionRequestSettings> prs_PromotionRequestSettings { get; set; }
        public virtual DbSet<prs_Promotions> prs_Promotions { get; set; }
        public virtual DbSet<prs_PromotionWorkflowSettings> prs_PromotionWorkflowSettings { get; set; }
        public virtual DbSet<prs_RangeGroupRanges> prs_RangeGroupRanges { get; set; }
        public virtual DbSet<prs_RangeGroups> prs_RangeGroups { get; set; }
        public virtual DbSet<prs_RangeGroupTemplates> prs_RangeGroupTemplates { get; set; }
        public virtual DbSet<prs_ReferenceFields> prs_ReferenceFields { get; set; }
        public virtual DbSet<prs_ReferenceFieldValues> prs_ReferenceFieldValues { get; set; }
        public virtual DbSet<prs_Referrals> prs_Referrals { get; set; }
        public virtual DbSet<prs_Religions> prs_Religions { get; set; }
        public virtual DbSet<prs_ReportSettings> prs_ReportSettings { get; set; }
        public virtual DbSet<prs_RetiredTypes> prs_RetiredTypes { get; set; }
        public virtual DbSet<prs_RetirementTypes> prs_RetirementTypes { get; set; }
        public virtual DbSet<prs_SacrificerRelations> prs_SacrificerRelations { get; set; }
        public virtual DbSet<prs_SacrificialStatusGroups> prs_SacrificialStatusGroups { get; set; }
        public virtual DbSet<prs_SacrificialStatusGroupSacrificialStatuses> prs_SacrificialStatusGroupSacrificialStatuses { get; set; }
        public virtual DbSet<prs_SacrificialStatusGroupTemplates> prs_SacrificialStatusGroupTemplates { get; set; }
        public virtual DbSet<prs_SalaryPaymentBanks> prs_SalaryPaymentBanks { get; set; }
        public virtual DbSet<prs_SchoolGrades> prs_SchoolGrades { get; set; }
        public virtual DbSet<prs_SendAlertSettings> prs_SendAlertSettings { get; set; }
        public virtual DbSet<prs_ServiceCalls> prs_ServiceCalls { get; set; }
        public virtual DbSet<prs_SettlementStatuses> prs_SettlementStatuses { get; set; }
        public virtual DbSet<prs_SkillLevels> prs_SkillLevels { get; set; }
        public virtual DbSet<prs_Skills> prs_Skills { get; set; }
        public virtual DbSet<prs_SocialSecurityInsuranceBranches> prs_SocialSecurityInsuranceBranches { get; set; }
        public virtual DbSet<prs_StaffLeaveApprovers> prs_StaffLeaveApprovers { get; set; }
        public virtual DbSet<prs_StaffOperationalUnits_Backup> prs_StaffOperationalUnits_Backup { get; set; }
        public virtual DbSet<prs_StaffPlans> prs_StaffPlans { get; set; }
        public virtual DbSet<prs_StaffWorkflowPlans> prs_StaffWorkflowPlans { get; set; }
        public virtual DbSet<prs_StructureTree> prs_StructureTree { get; set; }
        public virtual DbSet<prs_StructureTreeChangesTrack> prs_StructureTreeChangesTrack { get; set; }
        public virtual DbSet<prs_StructureTreeChangesTrack10> prs_StructureTreeChangesTrack10 { get; set; }
        public virtual DbSet<prs_StructureTreeIDMap> prs_StructureTreeIDMap { get; set; }
        public virtual DbSet<prs_SummonCommands> prs_SummonCommands { get; set; }
        public virtual DbSet<prs_SummonTypeFields> prs_SummonTypeFields { get; set; }
        public virtual DbSet<prs_SummonTypes> prs_SummonTypes { get; set; }
        public virtual DbSet<prs_TaxExemptionTypes> prs_TaxExemptionTypes { get; set; }
        public virtual DbSet<prs_Teachings> prs_Teachings { get; set; }
        public virtual DbSet<prs_TemplateFiles> prs_TemplateFiles { get; set; }
        public virtual DbSet<prs_TermsOfGeographicLocations> prs_TermsOfGeographicLocations { get; set; }
        public virtual DbSet<prs_TermTypes> prs_TermTypes { get; set; }
        public virtual DbSet<prs_TransferRequests> prs_TransferRequests { get; set; }
        public virtual DbSet<prs_UndependencyReasons> prs_UndependencyReasons { get; set; }
        public virtual DbSet<prs_UnitCostCenters> prs_UnitCostCenters { get; set; }
        public virtual DbSet<prs_UnitDutyAssignments_old> prs_UnitDutyAssignments_old { get; set; }
        public virtual DbSet<prs_UnitDutyDescriptionDetails_old> prs_UnitDutyDescriptionDetails_old { get; set; }
        public virtual DbSet<prs_UnitDutyDescriptions_old> prs_UnitDutyDescriptions_old { get; set; }
        public virtual DbSet<prs_UnitDutyDescriptionTypes_old> prs_UnitDutyDescriptionTypes_old { get; set; }
        public virtual DbSet<prs_UnitLevels> prs_UnitLevels { get; set; }
        public virtual DbSet<prs_UnitNatures> prs_UnitNatures { get; set; }
        public virtual DbSet<prs_UnitOperationalNatures> prs_UnitOperationalNatures { get; set; }
        public virtual DbSet<prs_UnitStatus> prs_UnitStatus { get; set; }
        public virtual DbSet<prs_UnitStatus_Audit> prs_UnitStatus_Audit { get; set; }
        public virtual DbSet<prs_UnitTypes> prs_UnitTypes { get; set; }
        public virtual DbSet<prs_WorkExperiences> prs_WorkExperiences { get; set; }
        public virtual DbSet<prs_WorkflowExtraInfos> prs_WorkflowExtraInfos { get; set; }
        public virtual DbSet<prs_WorkflowPlanDetails> prs_WorkflowPlanDetails { get; set; }
        public virtual DbSet<prs_WorkflowPlans> prs_WorkflowPlans { get; set; }
        public virtual DbSet<prs_WorkflowUsecaseDefaultPlans> prs_WorkflowUsecaseDefaultPlans { get; set; }
        public virtual DbSet<prs_WorkHistoryEducationLevels> prs_WorkHistoryEducationLevels { get; set; }
        public virtual DbSet<prs_WorkHistorySettings> prs_WorkHistorySettings { get; set; }
        public virtual DbSet<prs_WorkingPeriodRanges> prs_WorkingPeriodRanges { get; set; }
        public virtual DbSet<prs_WorkingPeriodRangeStarts> prs_WorkingPeriodRangeStarts { get; set; }
        public virtual DbSet<prs_WorkingPeriods> prs_WorkingPeriods { get; set; }
        public virtual DbSet<prs_WorkPlaceGroups> prs_WorkPlaceGroups { get; set; }
        public virtual DbSet<prs_WorkPlaceGroupTemplates> prs_WorkPlaceGroupTemplates { get; set; }
        public virtual DbSet<prs_WorkPlaceGroupWorkPlaces> prs_WorkPlaceGroupWorkPlaces { get; set; }
        public virtual DbSet<prs_WorkPlaces> prs_WorkPlaces { get; set; }
        public virtual DbSet<prs_Workshops> prs_Workshops { get; set; }
        public virtual DbSet<prs_WorkTurns> prs_WorkTurns { get; set; }
        public virtual DbSet<costcenter2> costcenter2 { get; set; }
        public virtual DbSet<Notice> Notices { get; set; }
        public virtual DbSet<prs_AttainmentConditionItemCalcs> prs_AttainmentConditionItemCalcs { get; set; }
        public virtual DbSet<prs_courses_BeforeDelete> prs_courses_BeforeDelete { get; set; }
        public virtual DbSet<prs_Decrees_950805> prs_Decrees_950805 { get; set; }
        public virtual DbSet<prs_ExtraGrids> prs_ExtraGrids { get; set; }
        public virtual DbSet<prs_ItemDisplayTitleDetails> prs_ItemDisplayTitleDetails { get; set; }
        public virtual DbSet<prs_Items_bak921003> prs_Items_bak921003 { get; set; }
        public virtual DbSet<prs_JobGroups> prs_JobGroups { get; set; }
        public virtual DbSet<prs_LadderDecreeTemplateSigners> prs_LadderDecreeTemplateSigners { get; set; }
        public virtual DbSet<prs_LeaveRedemption> prs_LeaveRedemption { get; set; }
        public virtual DbSet<prs_LeaveRedemptionFlows> prs_LeaveRedemptionFlows { get; set; }
        public virtual DbSet<prs_Leaves_970118> prs_Leaves_970118 { get; set; }
        public virtual DbSet<prs_Leaves_970126> prs_Leaves_970126 { get; set; }
        public virtual DbSet<prs_MissionPlaceGroups_Back> prs_MissionPlaceGroups_Back { get; set; }
        public virtual DbSet<prs_OperationalUnitFeatures> prs_OperationalUnitFeatures { get; set; }
        public virtual DbSet<prs_OperationalUnitPersonnel_save> prs_OperationalUnitPersonnel_save { get; set; }
        public virtual DbSet<prs_OperationalUnitPersonnelCriteria> prs_OperationalUnitPersonnelCriteria { get; set; }
        public virtual DbSet<prs_OperationalUnits> prs_OperationalUnits { get; set; }
        public virtual DbSet<prs_OperationalUnits_BAK13940910> prs_OperationalUnits_BAK13940910 { get; set; }
        public virtual DbSet<prs_Personnel_bak920928> prs_Personnel_bak920928 { get; set; }
        public virtual DbSet<prs_Personnel_bak931001> prs_Personnel_bak931001 { get; set; }
        public virtual DbSet<prs_Personnel_bak940116> prs_Personnel_bak940116 { get; set; }
        public virtual DbSet<prs_Personnel_bak940622> prs_Personnel_bak940622 { get; set; }
        public virtual DbSet<prs_Personnel_bak940705> prs_Personnel_bak940705 { get; set; }
        public virtual DbSet<prs_PersonnelAbsenceItems> prs_PersonnelAbsenceItems { get; set; }
        public virtual DbSet<prs_PersonnelAssignmentBeforeUpdateOfficialPost> prs_PersonnelAssignmentBeforeUpdateOfficialPost { get; set; }
        public virtual DbSet<prs_PersonnelAssignmentBeforeUpdateWorksection> prs_PersonnelAssignmentBeforeUpdateWorksection { get; set; }
        public virtual DbSet<prs_personnelBack951217> prs_personnelBack951217 { get; set; }
        public virtual DbSet<prs_personnelback960219> prs_personnelback960219 { get; set; }
        public virtual DbSet<prs_PersonnelBeforeUpdateStaffByPerson> prs_PersonnelBeforeUpdateStaffByPerson { get; set; }
        public virtual DbSet<prs_PersonnelContracts_bak940930> prs_PersonnelContracts_bak940930 { get; set; }
        public virtual DbSet<prs_PersonnelDependants_bak920509> prs_PersonnelDependants_bak920509 { get; set; }
        public virtual DbSet<prs_PersonnelEvaluationGrades_bak921129> prs_PersonnelEvaluationGrades_bak921129 { get; set; }
        public virtual DbSet<prs_PersonnelExtraGrid2_910724> prs_PersonnelExtraGrid2_910724 { get; set; }
        public virtual DbSet<prs_PersonnelGroupMembers> prs_PersonnelGroupMembers { get; set; }
        public virtual DbSet<prs_PersonnelLeaveMilestones_bk> prs_PersonnelLeaveMilestones_bk { get; set; }
        public virtual DbSet<prs_PersonnelMissions> prs_PersonnelMissions { get; set; }
        public virtual DbSet<prs_PostCostCenters_old> prs_PostCostCenters_old { get; set; }
        public virtual DbSet<prs_PostExtra_95_07_26> prs_PostExtra_95_07_26 { get; set; }
        public virtual DbSet<prs_PostExtra_1394_06_28> prs_PostExtra_1394_06_28 { get; set; }
        public virtual DbSet<prs_PostExtra_1394_12_12> prs_PostExtra_1394_12_12 { get; set; }
        public virtual DbSet<prs_ProclamationTemplateFileByEmploymentTypes> prs_ProclamationTemplateFileByEmploymentTypes { get; set; }
        public virtual DbSet<prs_ProclamationTemplateSigners> prs_ProclamationTemplateSigners { get; set; }
        public virtual DbSet<prs_ProclamationTemplateVersions> prs_ProclamationTemplateVersions { get; set; }
        public virtual DbSet<prs_ProclamationTemplateVersionsAssignments> prs_ProclamationTemplateVersionsAssignments { get; set; }
        public virtual DbSet<prs_RetirementTypeFactors> prs_RetirementTypeFactors { get; set; }
        public virtual DbSet<prs_StructureTree_95_07_26> prs_StructureTree_95_07_26 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C____UpdateHistory>()
                .Property(e => e.DatabaseVersion)
                .IsUnicode(false);

            modelBuilder.Entity<prs_BankFormats>()
                .Property(e => e.Separator)
                .IsUnicode(false);

            modelBuilder.Entity<prs_BasePost>()
                .Property(e => e.MinimumWorkingDuration)
                .IsUnicode(false);

            modelBuilder.Entity<prs_BasePostHistory>()
                .Property(e => e.MinimumWorkingDuration)
                .IsUnicode(false);

            modelBuilder.Entity<prs_BasijiTypes>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_BasijiTypes>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_CautionExtraFieldGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_CautionExtraFieldGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_CenterLevels>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_CenterLevels>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ContractTypes>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ContractTypes>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_CountryDivisions>()
                .Property(e => e.Hierarchy)
                .IsUnicode(false);

            modelBuilder.Entity<prs_CourseDegrees>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_CourseDegrees>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_CourseFields>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_CourseFields>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_CourseTypes>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_CourseTypes>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_DecreeItems>()
                .Property(e => e.Amount)
                .HasPrecision(18, 8);

            modelBuilder.Entity<prs_Decrees>()
                .Property(e => e.LadderDrawCalculationType)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Decrees>()
                .Property(e => e.ItemsSum)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_Decrees_Audit>()
                .Property(e => e.LadderDrawCalculationType)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Decrees_Audit>()
                .Property(e => e.ItemsSum)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemE6C5A473_A951_47E5_A597_FF30846FE60A)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item83D0655E_F6CE_4BEB_9EED_CCB7321F3587)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item906FFD65_3573_461A_BAC2_DBDFE43A9D54)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemBCDC1C46_0421_42F7_92C8_A0C7E5CFB715)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemB00B6FD3_EDC0_4410_8E13_659FCFA53C01)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemC37F971F_4FA6_459B_876D_719AE4296A70)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemC7E9D058_047B_4602_8729_9C660D6141B2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemA249FD54_CA81_41F2_9E00_0F10F4CB25AE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item2BADA0BA_8B96_45F4_8DD4_7F44D1A36DF4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item955FE678_7148_4D84_8178_361219BA2962)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemFEC50836_9BD8_4B84_90A6_D2C3B40724CE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item75F65F8C_A613_4EDC_BB73_C18BFA882E95)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemD70DBBE3_33FA_4397_911F_C76700F01B4E)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemA9EEFBFA_9C26_4DD6_8551_BBFB24C5A693)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item5EE9C304_59FA_4E8D_8F53_5C3165F40A21)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item0A20023A_47EF_4B03_B3F2_D7A5D220F168)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item7C080995_E2DD_4444_83A2_89D268F53E1A)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemCC8737D3_4046_4D09_9BBC_4667E5E5CB3C)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemF6925698_AC6C_4B36_AF49_871AB4B56B2F)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item89A161CE_2D46_4E28_9BF7_BB5E03B9F5B8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item5F068ECE_5CCE_4039_A736_F3CBD78702ED)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemA3C8BAE1_9D6F_4985_B315_3A324E806F98)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item786D8879_2837_4F38_86DA_C8B3E293C9AC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemF57CE293_BD9B_47AC_9DE6_6A293340C6F6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemBDEE6AA2_FD2E_44C4_A847_42E3C18DBC7A)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item6AC5FBB6_7C40_4A78_85F1_0C46CA869D17)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item4C1823D6_9B2D_432D_BF6C_B7701474B25C)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item1F8C1874_4856_4C86_8AAE_62EA3D581393)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item087A54A6_60B8_450A_A495_A8E29D1E027F)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item27463E02_2C5B_4441_B6CF_9DDBBC2A16FF)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item2C022A2C_DF59_4341_8816_619BA6CA86D0)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemB1510639_6107_4AA4_819D_9EAF0782C347)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item35F6FDFA_CEA5_4FB0_8EFD_D91E2A8F083D)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemBF04B7F0_7857_4A27_8615_FBAC40103C7F)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemEFB6870F_90D8_44B8_A682_88FFEF2567E5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item9918CCC1_51EE_4CE5_AD3D_EE38254D6823)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item76FDDC20_2EA3_401A_A2B1_DE5073FE7BB8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemC1E0D909_DA54_44FB_AF86_9A1CF8EC5A7A)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemCF2DF407_984E_4A4A_A64D_BC22BBC3C31E)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item9BB1E7B0_6B96_481F_93A9_2EFC96556142)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item8E0A695E_62A7_4E6A_9AF3_61E5E82DE7A1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemD38FB9A8_DC70_448E_99AC_1D0B5E52D93A)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemBD8EC203_B931_41EA_84B7_0E70A3DEC81B)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemE7AC49EE_E60D_40B6_BE9A_C1BD52C46F6D)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item88BFDAFF_C724_4532_9142_8078C245EE74)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item4D8F4D74_A3F5_42A5_A219_494084BF247D)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.ItemE702F0F1_FD04_4083_A733_2C10D8EBD04C)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item8A9154A5_25AA_43DA_B7E5_4ABD80CA106A)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item4ED31F31_C786_405D_8F43_FAE1E89CDC31)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item0AD81753_2682_4CF0_9EB7_7A552623E909)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item9858F7DC_A427_4EE1_AE98_F754ECEB00F6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item55C6C42D_33BD_4166_8527_B7906B5EAC16)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item03B06487_9886_4763_832B_99BBE4685498)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item72ED9DFC_CF2F_4D32_AE0E_CEA03F98D348)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeSummaries>()
                .Property(e => e.Item5C6CF0A2_FDC1_427D_B111_E22B805562DC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_DecreeTemplatesCategorizations>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_DecreeTemplatesCategorizations>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_DepartmentExtra>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<prs_DepartmentExtra>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<prs_DepartmentExtraHistory>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<prs_DepartmentExtraHistory>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<prs_DependencyDegrees>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_DependencyDegrees>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_DependencyReasons>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_DependencyReasons>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_DiplomaTypes>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_DiplomaTypes>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EducationCenters>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EducationCenters>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EducationFieldGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EducationFieldGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EducationFieldGroupTemplates>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EducationFieldGroupTemplates>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EducationFields>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EducationFields>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EducationLevelGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EducationLevelGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EducationLevelGroupTemplates>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EducationLevelGroupTemplates>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EducationLevels_Back>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EducationLevels_Back>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EducationLicenseType>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EducationLicenseType>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Educations>()
                .Property(e => e.FinalGrade)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_EmploymentDemandedJobs>()
                .Property(e => e.DemandedSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_EmploymentFormExtraFieldGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EmploymentFormExtraFieldGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EmploymentForms>()
                .Property(e => e.SSN)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EmploymentForms>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EmploymentForms>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EmploymentForms>()
                .Property(e => e.FinalGrade)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_EmploymentFormScoringItems>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EmploymentFormScoringItems>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EmploymentStatuses>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EmploymentStatuses>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EmploymentStatusGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EmploymentStatusGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EmploymentStatusGroupTemplates>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EmploymentStatusGroupTemplates>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EmploymentTypeGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EmploymentTypeGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EmploymentTypeGroupTemplates>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EmploymentTypeGroupTemplates>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EmploymentTypes>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EmploymentTypes>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EncourageExtraFieldGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EncourageExtraFieldGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EncourageGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EncourageGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EvaluationGrades>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EvaluationGrades>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EvaluationGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EvaluationGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EvaluationPeriods>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EvaluationPeriods>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_EventLogs>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ExpertGradeGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ExpertGradeGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ExpertGradeGroupTemplates>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ExpertGradeGroupTemplates>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ExpertGrades>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ExpertGrades>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ExtraModels>()
                .Property(e => e.ListWidth)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ExtraModels>()
                .Property(e => e.EditWidth)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ExtraModels>()
                .Property(e => e.ExtraInfo)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ExtraWorks>()
                .Property(e => e.Hierarchy)
                .IsUnicode(false);

            modelBuilder.Entity<prs_FamilyRelations>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_FamilyRelations>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ForeignLanguages>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ForeignLanguages>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_GratitudeExtraFieldGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_GratitudeExtraFieldGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_IncrementFactors>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_IncrementFactors>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_InsuranceTypes>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_InsuranceTypes>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ItemCategories>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ItemCategories>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ItemDefaults>()
                .Property(e => e.DefaultValue)
                .HasPrecision(18, 8);

            modelBuilder.Entity<prs_ItemDisplayCategories>()
                .Property(e => e.BookmarkSuffix)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ItemDisplayCategories>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ItemDisplayCategories>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ItemMatrixValues>()
                .Property(e => e.RowValue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<prs_ItemMatrixValues>()
                .Property(e => e.ColumnValue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<prs_ItemMatrixValues>()
                .Property(e => e.ReturnValue)
                .HasPrecision(18, 8);

            modelBuilder.Entity<prs_ItemTableValues>()
                .Property(e => e.ColumnValue1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<prs_ItemTableValues>()
                .Property(e => e.ColumnValue2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<prs_ItemTableValues>()
                .Property(e => e.ColumnValue3)
                .HasPrecision(18, 0);

            modelBuilder.Entity<prs_ItemTableValues>()
                .Property(e => e.ColumnValue4)
                .HasPrecision(18, 0);

            modelBuilder.Entity<prs_ItemTableValues>()
                .Property(e => e.ColumnValue5)
                .HasPrecision(18, 0);

            modelBuilder.Entity<prs_ItemTableValues>()
                .Property(e => e.ColumnValue6)
                .HasPrecision(18, 0);

            modelBuilder.Entity<prs_ItemTableValues>()
                .Property(e => e.ColumnValue7)
                .HasPrecision(18, 0);

            modelBuilder.Entity<prs_ItemTableValues>()
                .Property(e => e.ColumnValue8)
                .HasPrecision(18, 0);

            modelBuilder.Entity<prs_ItemTableValues>()
                .Property(e => e.ColumnValue9)
                .HasPrecision(18, 0);

            modelBuilder.Entity<prs_ItemTableValues>()
                .Property(e => e.ColumnValue10)
                .HasPrecision(18, 0);

            modelBuilder.Entity<prs_ItemTableValues>()
                .Property(e => e.ReturnValue)
                .HasPrecision(18, 8);

            modelBuilder.Entity<prs_JobCategories>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobCategories>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobCategoryGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobCategoryGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobCategoryGroupTemplates>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobCategoryGroupTemplates>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobDegrees>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobDegrees>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobDutyDescriptionTypes_old>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobDutyDescriptionTypes_old>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobEvaluationLevels>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobEvaluationLevels>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobExtraFieldGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobExtraFieldGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobFieldGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobFieldGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobFieldGroupTemplates>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobFieldGroupTemplates>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobGrades>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobGrades>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobHistory>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Jobs>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobStages>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_JobStages>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_LanguageKnowledgesProficiencyLevelTypes>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_LanguageKnowledgesProficiencyLevelTypes>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_LanguageKnowledgesRequirementLevelTypes>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_LanguageKnowledgesRequirementLevelTypes>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Leaves>()
                .Property(e => e.Hierarchy)
                .IsUnicode(false);

            modelBuilder.Entity<prs_LeaveSpecialDayCalendarDays>()
                .Property(e => e.Days)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ManagerLevels>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ManagerLevels>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_MaritalStatuses>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_MaritalStatuses>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_MaritalStatusGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_MaritalStatusGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_MaritalStatusGroupTemplates>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_MaritalStatusGroupTemplates>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_MilitaryStatuses>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_MilitaryStatuses>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_MissionExtractionExtraFieldGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_MissionExtractionExtraFieldGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_MissionExtractions>()
                .Property(e => e.SalaryBase)
                .HasPrecision(12, 2);

            modelBuilder.Entity<prs_MissionExtractions>()
                .Property(e => e.DailyMissionPayment)
                .HasPrecision(12, 2);

            modelBuilder.Entity<prs_MissionExtractions>()
                .Property(e => e.MissionPayment)
                .HasPrecision(12, 2);

            modelBuilder.Entity<prs_MissionExtractions>()
                .Property(e => e.BadWeatherAmount)
                .HasPrecision(12, 2);

            modelBuilder.Entity<prs_MissionExtractions>()
                .Property(e => e.DenialOfFacilityAmount)
                .HasPrecision(12, 2);

            modelBuilder.Entity<prs_MissionExtractions>()
                .Property(e => e.DrivingAmount)
                .HasPrecision(12, 2);

            modelBuilder.Entity<prs_MissionExtractions>()
                .Property(e => e.TravelCost)
                .HasPrecision(12, 2);

            modelBuilder.Entity<prs_MissionExtractions>()
                .Property(e => e.FoodCostAmount)
                .HasPrecision(12, 2);

            modelBuilder.Entity<prs_MissionExtraFieldGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_MissionExtraFieldGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_MissionPaymentItemDefaults>()
                .Property(e => e.DefaultValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_Missions>()
                .Property(e => e.Hierarchy)
                .IsUnicode(false);

            modelBuilder.Entity<prs_MissionTypes>()
                .Property(e => e.ExternalCode)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Nationalities>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Nationalities>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Permanents>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Permanents>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel>()
                .Property(e => e.SSN)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel>()
                .Property(e => e.InjuryPercentage)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_Personnel>()
                .Property(e => e.FinalGrade)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_PersonnelDependantExtraFieldGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PersonnelDependantExtraFieldGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PersonnelDependants>()
                .Property(e => e.LastAverage)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_PersonnelEncourageGroups>()
                .Property(e => e.Score)
                .HasPrecision(18, 3);

            modelBuilder.Entity<prs_PersonnelEvaluationGrades>()
                .Property(e => e.Score)
                .HasPrecision(18, 3);

            modelBuilder.Entity<prs_PersonnelEvaluationGroups>()
                .Property(e => e.Score)
                .HasPrecision(18, 3);

            modelBuilder.Entity<prs_PersonnelExtra>()
                .Property(e => e.عدد_اعشاری)
                .HasPrecision(9, 2);

            modelBuilder.Entity<prs_PersonnelExtra>()
                .Property(e => e.هزینه_خودرو)
                .HasPrecision(9, 2);

            modelBuilder.Entity<prs_PersonnelExtra>()
                .Property(e => e.پایه_سنوات)
                .HasPrecision(9, 2);

            modelBuilder.Entity<prs_PersonnelExtra>()
                .Property(e => e.مزایای_مدیریتی)
                .HasPrecision(9, 2);

            modelBuilder.Entity<prs_PersonnelExtraFieldGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PersonnelExtraFieldGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PersonnelExtraGrid1>()
                .Property(e => e.مدت_به_ساعت)
                .HasPrecision(9, 2);

            modelBuilder.Entity<prs_PersonnelHistory>()
                .Property(e => e.SSN)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PersonnelHistory>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PersonnelHistory>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PersonnelHistory>()
                .Property(e => e.InjuryPercentage)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_PersonnelHistory>()
                .Property(e => e.FinalGrade)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_PersonnelIncrementFactors>()
                .Property(e => e.Factor)
                .HasPrecision(9, 2);

            modelBuilder.Entity<prs_PersonTitles>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PersonTitles>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostExtra>()
                .Property(e => e.MinimumWorkingDuration)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostExtra>()
                .Property(e => e.CommissionDuration)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostExtraHistory>()
                .Property(e => e.MinimumWorkingDuration)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostExtraHistory>()
                .Property(e => e.CommissionDuration)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostGrades>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostGrades>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostLackOfSuctionLevels>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostLackOfSuctionLevels>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostNatures>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostNatures>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostOperationalNatures>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostOperationalNatures>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostRanks>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostRanks>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostTypes>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostTypes>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PredecreeValues>()
                .Property(e => e.Amount)
                .HasPrecision(18, 8);

            modelBuilder.Entity<prs_ProbationExtraFieldGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ProbationExtraFieldGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ProclamationTemplatesCategorizations>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ProclamationTemplatesCategorizations>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ProficienciesAndSkills>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ProficienciesAndSkills>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PromotionAppointedApprovedReasons>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PromotionAppointedApprovedReasons>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PromotionAppointedRejectedReasons>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PromotionAppointedRejectedReasons>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_RangeGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_RangeGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_RangeGroupTemplates>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_RangeGroupTemplates>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ReferenceFields>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ReferenceFields>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Religions>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Religions>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_RetiredTypes>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_RetiredTypes>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_SacrificerRelations>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_SacrificerRelations>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_SacrificialStatusGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_SacrificialStatusGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_SacrificialStatusGroupTemplates>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_SacrificialStatusGroupTemplates>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_SalaryPaymentBanks>()
                .Property(e => e.BranchCode)
                .IsUnicode(false);

            modelBuilder.Entity<prs_SalaryPaymentBanks>()
                .Property(e => e.OrganizationCode)
                .IsUnicode(false);

            modelBuilder.Entity<prs_SchoolGrades>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_SchoolGrades>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_SettlementStatuses>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_SettlementStatuses>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_SkillLevels>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_SkillLevels>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_SocialSecurityInsuranceBranches>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_SocialSecurityInsuranceBranches>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_TaxExemptionTypes>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_TaxExemptionTypes>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_TermTypes>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_TermTypes>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_UndependencyReasons>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_UndependencyReasons>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_UnitDutyDescriptionTypes_old>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_UnitDutyDescriptionTypes_old>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_UnitLevels>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_UnitLevels>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_UnitNatures>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_UnitNatures>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_UnitOperationalNatures>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_UnitOperationalNatures>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_UnitStatus>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_UnitStatus>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_UnitStatus_Audit>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_UnitStatus_Audit>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_UnitTypes>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_UnitTypes>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_WorkHistoryEducationLevels>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_WorkHistoryEducationLevels>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_WorkHistorySettings>()
                .Property(e => e.Coefficient)
                .HasPrecision(9, 2);

            modelBuilder.Entity<prs_WorkPlaceGroups>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_WorkPlaceGroups>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_WorkPlaceGroupTemplates>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_WorkPlaceGroupTemplates>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_WorkTurns>()
                .Property(e => e.ExternalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<prs_WorkTurns>()
                .Property(e => e.ExternalCode2)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Decrees_950805>()
                .Property(e => e.LadderDrawCalculationType)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Decrees_950805>()
                .Property(e => e.ItemsSum)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prs_ExtraGrids>()
                .Property(e => e.SortDirection)
                .IsUnicode(false);

            modelBuilder.Entity<prs_ItemDisplayTitleDetails>()
                .Property(e => e.Value)
                .HasPrecision(18, 1);

            modelBuilder.Entity<prs_JobGroups>()
                .Property(e => e.BaseSalary)
                .HasPrecision(9, 2);

            modelBuilder.Entity<prs_Leaves_970118>()
                .Property(e => e.Hierarchy)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Leaves_970126>()
                .Property(e => e.Hierarchy)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel_bak920928>()
                .Property(e => e.SSN)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel_bak920928>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel_bak920928>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel_bak920928>()
                .Property(e => e.InjuryPercentage)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_Personnel_bak931001>()
                .Property(e => e.SSN)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel_bak931001>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel_bak931001>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel_bak931001>()
                .Property(e => e.InjuryPercentage)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_Personnel_bak940116>()
                .Property(e => e.SSN)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel_bak940116>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel_bak940116>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel_bak940116>()
                .Property(e => e.InjuryPercentage)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_Personnel_bak940622>()
                .Property(e => e.SSN)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel_bak940622>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel_bak940622>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel_bak940622>()
                .Property(e => e.InjuryPercentage)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_Personnel_bak940705>()
                .Property(e => e.SSN)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel_bak940705>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel_bak940705>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<prs_Personnel_bak940705>()
                .Property(e => e.InjuryPercentage)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_personnelBack951217>()
                .Property(e => e.SSN)
                .IsUnicode(false);

            modelBuilder.Entity<prs_personnelBack951217>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<prs_personnelBack951217>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<prs_personnelBack951217>()
                .Property(e => e.InjuryPercentage)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_personnelBack951217>()
                .Property(e => e.FinalGrade)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_personnelback960219>()
                .Property(e => e.SSN)
                .IsUnicode(false);

            modelBuilder.Entity<prs_personnelback960219>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<prs_personnelback960219>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<prs_personnelback960219>()
                .Property(e => e.InjuryPercentage)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_personnelback960219>()
                .Property(e => e.FinalGrade)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_PersonnelBeforeUpdateStaffByPerson>()
                .Property(e => e.SSN)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PersonnelBeforeUpdateStaffByPerson>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PersonnelBeforeUpdateStaffByPerson>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PersonnelBeforeUpdateStaffByPerson>()
                .Property(e => e.InjuryPercentage)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_PersonnelBeforeUpdateStaffByPerson>()
                .Property(e => e.FinalGrade)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_PersonnelDependants_bak920509>()
                .Property(e => e.LastAverage)
                .HasPrecision(10, 2);

            modelBuilder.Entity<prs_PersonnelEvaluationGrades_bak921129>()
                .Property(e => e.Score)
                .HasPrecision(18, 3);

            modelBuilder.Entity<prs_PostExtra_95_07_26>()
                .Property(e => e.MinimumWorkingDuration)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostExtra_95_07_26>()
                .Property(e => e.CommissionDuration)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostExtra_1394_06_28>()
                .Property(e => e.MinimumWorkingDuration)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostExtra_1394_06_28>()
                .Property(e => e.CommissionDuration)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostExtra_1394_12_12>()
                .Property(e => e.MinimumWorkingDuration)
                .IsUnicode(false);

            modelBuilder.Entity<prs_PostExtra_1394_12_12>()
                .Property(e => e.CommissionDuration)
                .IsUnicode(false);

            modelBuilder.Entity<prs_RetirementTypeFactors>()
                .Property(e => e.Percent)
                .HasPrecision(18, 0);
        }
    }
}
