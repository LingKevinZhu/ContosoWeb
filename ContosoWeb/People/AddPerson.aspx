<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPerson.aspx.cs" Inherits="ContosoWeb.People.AddPerson" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>
        Add a person
     </h4>
    <hr/>
    <div class="form-group">
        <label for="txtLastName">Last Name:</label>
        <asp:TextBox runat="server" MaxLength=50 ID="txtLastName" CssClass="form-control" />
        <asp:RequiredFieldValidator CssClass="text-danger" ID="reqLastName" ErrorMessage="Last Name Should be Required!!" ControlToValidate="txtLastName" runat="server" />
    </div>

    <div class="form-group">
        <label for="txtFirstName">First Name:</label>
        <asp:TextBox runat="server" MaxLength=50 ID="txtFirstName" CssClass="form-control" />
        <asp:RequiredFieldValidator CssClass="text-danger" ID="reqFirstName" ErrorMessage="First Name Should be Required!!" ControlToValidate="txtFirstName" runat="server" />
    </div>

    <div class="form-group">
        <label for="txtMiddleName">Middle Name:</label>
        <asp:TextBox runat="server" ID="txtMiddleName" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="txtAge">Age:</label>
        <asp:TextBox runat="server" ID="txtAge" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="txtEmail">E-mail Address:</label>
        <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" />
        <asp:RequiredFieldValidator CssClass="text-danger" ID="reqEmail" ErrorMessage="E-mail Should not be Empty!!" ControlToValidate="txtEmail" runat="server" />
        <asp:RegularExpressionValidator CssClass="text-danger" ID="regularExpressionEmail" ErrorMessage="E-mail Should be in Valid Format!!" ControlToValidate="txtEmail" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
    </div>

    <div class="form-group">
        <label for="txtPhone">Phone Number:</label>
        <asp:TextBox runat="server" ID="txtPhone" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="txtAddress1">Address 1:</label>
        <asp:TextBox runat="server" ID="txtAddress1" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="txtAddress2">Address 2:</label>
        <asp:TextBox runat="server" ID="txtAddress2" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="txtUnitOrApartmentNumber">Unit Or Apartment Number:</label>
        <asp:TextBox runat="server" ID="txtUnitOrApartmentNumber" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="txtCity">City:</label>
        <asp:TextBox runat="server" ID="txtCity" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="ddlStates">State:</label>
        <asp:DropDownList runat="server" ID="ddlStates" CssClass="form-control">
        </asp:DropDownList>
    </div>

    <div class="form-group">
        <label for="txtZipCode">Zip Code:</label>
        <asp:TextBox runat="server" ID="txtZipCode" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="txtCreatedDate">Created Date:</label>
        <asp:TextBox runat="server" ID="txtCreatedDate" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="txtCreatedBy">Created By:</label>
        <asp:TextBox runat="server" ID="txtCreatedBy" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="txtUpdatedDate">Updated Date:</label>
        <asp:TextBox runat="server" ID="txtUpdatedDate" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="txtUpdatedBy">Updated By:</label>
        <asp:TextBox runat="server" ID="txtUpdatedBy" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="txtPassword">Password:</label>
        <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="txtSalt">Salt:</label>
        <asp:TextBox runat="server" ID="txtSalt" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="ddlIsLocked">Is Locked Or Not:</label>
        <asp:DropDownList runat="server" ID="ddlIsLocked" CssClass="form-control">
            <asp:ListItem Text="Yes" />
            <asp:ListItem Text="No" />
        </asp:DropDownList>
    </div>

    <div class="form-group">
        <label for="txtLastLockedDateTime">Last Locked Date Time:</label>
        <asp:TextBox runat="server" ID="txtLastLockedDateTime" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="txtFailedAttempts">Failed Attempts:</label>
        <asp:TextBox runat="server" ID="txtFailedAttempts" CssClass="form-control" />
    </div>

    <asp:Button Text="SavePeople" CssClass="btn btn-primary" runat="server" ID="btnSave" OnClick="btnSave_Click" />
    <asp:Button Text="CancelPeople" CssClass="btn btn-danger" runat="server" ID="btnCancel" CausesValidation="false" OnClick="btnCancel_Click" />
</asp:Content>