<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsPerson.aspx.cs" Inherits="ContosoWeb.People.DetailsPerson" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>
        Details of One People
    </h4>
    <hr/>
    <dl class="dl-horizontal">
        <dt>
            FirstName
        </dt>
        <dd>
            <asp:Label Text="" ID="firstNameLabel" runat="server" />
        <dd>
        <dt>
            LastName
        </dt>
        <dd>
            <asp:Label Text="" ID="LastNameLabel" runat="server" />
        <dd>
    </dl>
</asp:Content>