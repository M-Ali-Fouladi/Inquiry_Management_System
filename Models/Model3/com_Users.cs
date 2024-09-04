namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Users
    {
        public int Id { get; set; }

        public int? PersonTitleId { get; set; }

        [Required]
        [StringLength(64)]
        public string Username { get; set; }

        public long? AccessCode { get; set; }

        public int? FileSpace { get; set; }

        public int? MessageAttachmentLimit { get; set; }

        public int LanguageId { get; set; }

        public int? CalendarType { get; set; }

        public Guid DefaultSoftwareGuid { get; set; }

        public int ThemeId { get; set; }

        public bool OutlookbarSlide { get; set; }

        public byte? WebMenuEffect { get; set; }

        public bool? HandleKeyboard { get; set; }

        public bool? AlertsAutoPopup { get; set; }

        public bool? PasswordShouldBeChanged { get; set; }

        public bool Deleted { get; set; }

        public Guid? Uid { get; set; }

        public int? FirstAutoPermittedIPsCount { get; set; }

        public int? FirstAutoPermittedMachineIdentifiersCount { get; set; }

        public Guid Guid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public Guid? OperationGuid { get; set; }

        public bool? DontPlayAlertsSound { get; set; }

        public int? AccessZoneID { get; set; }

        public bool? LightPen { get; set; }

        public int AuthenticationType { get; set; }

        public int? BodyFileLimit { get; set; }

        public int? AttachmentLimit { get; set; }

        public bool? OpenMenusByClick { get; set; }

        public int? MobileUserType { get; set; }

        public string DidgahMobileAlertExcludeSoftwareList { get; set; }

        [MaxLength(64)]
        public byte[] Password { get; set; }

        public DateTime? ChangePasswordDate { get; set; }

        public int? MessageReceiversLimit { get; set; }

        public Guid? PersonGuid { get; set; }

        public bool Banned { get; set; }

        public DateTime? ActivityLimitationDate { get; set; }

        public long? TelegramUserID { get; set; }

        public bool OTPRequired { get; set; }

        [StringLength(256)]
        public string OTPSecretKey { get; set; }

        [StringLength(64)]
        public string Integrity { get; set; }

        public int? IntegrityVersion { get; set; }

        [StringLength(64)]
        public string AuthenticationTokenProfileName { get; set; }

        public bool? ShowOtherAssignedStaffAlerts { get; set; }

        [StringLength(512)]
        public string TimeZoneOffset { get; set; }
    }
}
