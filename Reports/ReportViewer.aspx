<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportViewer.aspx.cs" Inherits="CustomMembershipEF.Reports.ReportViewer" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          
     <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Height="509px" Width="647px">
            <%--<LocalReport ReportEmbeddedResource="WebApplication1.Reports.Report1.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />

                </DataSources>
            </LocalReport>--%>
        </rsweb:ReportViewer>

        <%--<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="TeamboxDataSetTableAdapters.UsersTableAdapter"></asp:ObjectDataSource>--%>
    </div>
    </form>

</body>
</html>