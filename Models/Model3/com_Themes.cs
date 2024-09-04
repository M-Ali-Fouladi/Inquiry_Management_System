namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Themes
    {
        public int Id { get; set; }

        [StringLength(2048)]
        public string Title { get; set; }

        [StringLength(8)]
        public string THColor { get; set; }

        [StringLength(8)]
        public string THBackgroundColor { get; set; }

        [StringLength(8)]
        public string ListRowNormalColor { get; set; }

        [StringLength(8)]
        public string ListRowNormalBackgroundColor { get; set; }

        [StringLength(8)]
        public string ListRowNormalSelectedColor { get; set; }

        [StringLength(8)]
        public string ListRowNormalSelectedBackgroundColor { get; set; }

        [StringLength(8)]
        public string ListRowUnreadColor { get; set; }

        [StringLength(8)]
        public string ListRowUnreadBackgroundColor { get; set; }

        [StringLength(8)]
        public string ListRowUnreadSelectedColor { get; set; }

        [StringLength(8)]
        public string ListRowUnreadSelectedBackgroundColor { get; set; }

        [StringLength(8)]
        public string TitleBarBackgroundColor { get; set; }

        [StringLength(8)]
        public string TitleBarColor { get; set; }

        [StringLength(8)]
        public string TreeNodeBackgroundColorHighlighted { get; set; }

        [StringLength(8)]
        public string TreeViewBackgroundColor { get; set; }

        [StringLength(8)]
        public string HeaderPanelBackgroundColor { get; set; }

        [StringLength(8)]
        public string ContainerBackgroundColor { get; set; }

        [StringLength(8)]
        public string TitleCellColor { get; set; }

        [StringLength(8)]
        public string SoftwareTitleColor { get; set; }

        [StringLength(8)]
        public string ButtonNormalColor { get; set; }

        [StringLength(8)]
        public string ButtonNormalBackgroundColor { get; set; }

        [StringLength(8)]
        public string ButtonHighlightedColor { get; set; }

        [StringLength(8)]
        public string ButtonHighlightedBackgroundColor { get; set; }

        [StringLength(8)]
        public string InputColor { get; set; }

        [StringLength(8)]
        public string InputBackgroundColor { get; set; }

        [StringLength(8)]
        public string OutlookbarBackgroundColor { get; set; }

        [StringLength(8)]
        public string OutlookbarButtonBackgroundColor { get; set; }

        [StringLength(8)]
        public string OutlookbarButtonColor { get; set; }

        [StringLength(8)]
        public string OutlookbarItemColor { get; set; }

        [StringLength(8)]
        public string MenuItemColor { get; set; }

        [StringLength(8)]
        public string MenuItemBackgroundColor { get; set; }

        [StringLength(8)]
        public string MenuItemSelectedColor { get; set; }

        [StringLength(8)]
        public string MenuItemSelectedBackgroundColor { get; set; }

        [StringLength(8)]
        public string MenuGroupBackgroundColor { get; set; }

        [StringLength(8)]
        public string MenuGroupColor { get; set; }

        [StringLength(8)]
        public string MenuGroupTopBorder { get; set; }

        [StringLength(8)]
        public string MenuGroupSelectedBackgroundColor { get; set; }

        [StringLength(8)]
        public string MenuGroupSelectedColor { get; set; }

        [StringLength(8)]
        public string MenuGroupSideBorder { get; set; }
    }
}
