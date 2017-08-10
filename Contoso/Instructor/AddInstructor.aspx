<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddInstructor.aspx.cs" Inherits="Contoso.Instructor.AddInstructor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>
        Add an Instructor
     </h4>
    <hr/>
    <div class="form-group">
        <label for="ddlID">Instructor ID:</label>
        <asp:DropDownList runat="server" ID="ddlID" CssClass="form-control">
        </asp:DropDownList>
    </div>
    <div class="form-group">
        <label for="txtHireDate">Hire Date:</label>
        <asp:TextBox runat="server" ID="txtHireDate" CssClass="form-control" />
        <asp:RequiredFieldValidator CssClass="text-danger" ID="reqHireDate" ErrorMessage="Hire Date Should be Required!!" ControlToValidate="txtHireDate" runat="server" />
    </div>
    <asp:Button Text="SaveInstructor" CssClass="btn btn-primary" runat="server" ID="btnSave" OnClick="btnSave_Click" />
    <asp:Button Text="CancelInstructor" CssClass="btn btn-danger" runat="server" ID="btnCancel" CausesValidation="false" OnClick="btnCancel_Click" />
</asp:Content>
