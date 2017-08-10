<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsCourses.aspx.cs" Inherits="Contoso.Courses.DetailsCourses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>
        Details of One Course
    </h4>
    <hr/>
    <dl class="dl-horizontal">
        <dt>
            Course Title
        </dt>
        <dd>
            <asp:Label Text="" ID="TitleLabel" runat="server" />
        <dd>
        <dt>
            Course Credits
        </dt>
        <dd>
            <asp:Label Text="" ID="CreditsLabel" runat="server" />
        <dd>
        <dt>
            Department ID
        </dt>
        <dd>
            <asp:Label Text="" ID="DepartmentIDLabel" runat="server" />
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
