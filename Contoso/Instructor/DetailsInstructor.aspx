<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsInstructor.aspx.cs" Inherits="Contoso.Instructor.DetailsInstructor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>
        Details of One Instructor
    </h4>
    <hr/>
    <dl class="dl-horizontal">
        <dt>
            InstructorID
        </dt>
        <dd>
            <asp:Label Text="" ID="InstructorIDLabel" runat="server" />
        <dd>
        <dt>
            Hire Date
        </dt>
        <dd>
            <asp:Label Text="" ID="HireDateLabel" runat="server" />
        <dd>
    </dl>
</asp:Content>
