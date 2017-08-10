<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsPeople.aspx.cs" Inherits="Contoso.People.DetailsPeople" %>
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
        <dt>
            MiddleName
        </dt>
        <dd>
            <asp:Label Text="" ID="MiddleNameLabel" runat="server" />
        <dd>
        <dt>
            Age
        </dt>
        <dd>
            <asp:Label Text="" ID="AgeLabel" runat="server" />
        <dd>
        <dt>
            E-mail Address
        </dt>
        <dd>
            <asp:Label Text="" ID="EmailLabel" runat="server" />
        <dd>
        <dt>
            Phone Number
        </dt>
        <dd>
            <asp:Label Text="" ID="PhoneLabel" runat="server" />
        <dd>
        <dt>
            AddressLine 1
        </dt>
        <dd>
            <asp:Label Text="" ID="AddressLine1Label" runat="server" />
        <dd>
        <dt>
            AddressLine 2
        </dt>
        <dd>
            <asp:Label Text="" ID="AddressLine2Label" runat="server" />
        <dd>
        <dt>
            Unit Or Apartment Number
        </dt>
        <dd>
            <asp:Label Text="" ID="UnitOrApartmentNumberLabel" runat="server" />
        <dd>
        <dt>
            City
        </dt>
        <dd>
            <asp:Label Text="" ID="CityLabel" runat="server" />
        <dd>
        <dt>
            State
        </dt>
        <dd>
            <asp:Label Text="" ID="StateLabel" runat="server" />
        <dd>
        <dt>
            Zip Code
        </dt>
        <dd>
            <asp:Label Text="" ID="ZipCodeLabel" runat="server" />
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
        <dt>
            Password
        </dt>
        <dd>
            <asp:Label Text="" ID="PasswordLabel" runat="server" />
        <dd>
        <dt>
            Salt
        </dt>
        <dd>
            <asp:Label Text="" ID="SaltLabel" runat="server" />
        <dd>
        <dt>
            IsLocked
        </dt>
        <dd>
            <asp:Label Text="" ID="IsLockedLabel" runat="server" />
        <dd>
        <dt>
            Last Locked Date Time
        </dt>
        <dd>
            <asp:Label Text="" ID="LastLockedDateTimeLabel" runat="server" />
        <dd>
        <dt>
            Failed Attempts
        </dt>
        <dd>
            <asp:Label Text="" ID="FailedAttemptsLabel" runat="server" />
        <dd>
    </dl>
</asp:Content>
