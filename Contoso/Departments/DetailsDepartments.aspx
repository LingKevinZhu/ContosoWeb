<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsDepartments.aspx.cs" Inherits="Contoso.Departments.DetailsDepartments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>
        Details of One Department
    </h4>
    <hr/>
    <dl class="dl-horizontal">
        <dt>
            Deparment Name
        </dt>
        <dd>
            <asp:Label Text="" ID="NameLabel" runat="server" />
        <dd>
        <dt>
            Deparment Budget
        </dt>
        <dd>
            <asp:Label Text="" ID="BudgetLabel" runat="server" />
        <dd>
        <dt>
            Start Date
        </dt>
        <dd>
            <asp:Label Text="" ID="StartDateLabel" runat="server" />
        <dd>
        <dt>
            Instructor ID
        </dt>
        <dd>
            <asp:Label Text="" ID="InstructorIDLabel" runat="server" />
        <dd>
        <dt>
            Row Version
        </dt>
        <dd>
            <asp:Label Text="" ID="RowVersionLabel" runat="server" />
        <dd>
        <dt>
            Created Date
        </dt>
        <dd>
            <asp:Label Text="" ID="CreatedDateLabel" runat="server" />
        <dd>
        <dt>
            Created By
        </dt>
        <dd>
            <asp:Label Text="" ID="CreatedByLabel" runat="server" />
        <dd>
        <dt>    
            Updated Date
        </dt>
        <dd>
            <asp:Label Text="" ID="UpdatedDateLabel" runat="server" />
        <dd>
        <dt>
            Updated By
        </dt>
        <dd>
            <asp:Label Text="" ID="UpdatedByLabel" runat="server" />
        <dd>
    </dl>
</asp:Content>
