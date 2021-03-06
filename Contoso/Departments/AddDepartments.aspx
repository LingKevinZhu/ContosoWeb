﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddDepartments.aspx.cs" Inherits="Contoso.Departments.AddDepartments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <label for="txtName">Department Name:</label>
        <asp:TextBox runat="server" ID="txtName" CssClass="form-control" />
        <asp:RequiredFieldValidator CssClass="text-danger" ID="reqDepartmentName" ErrorMessage="Department Name Should be Required!!" ControlToValidate="txtName" runat="server" />
    </div>

    <div class="form-group">
        <label for="txtBudget">Department Budget:</label>
        <asp:TextBox runat="server" ID="txtBudget" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="txtStartDate">Department Start Date:</label>
        <asp:TextBox runat="server" ID="txtStartDate" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="ddlInstructorID">Instructor ID:</label>
        <asp:DropDownList runat="server" ID="ddlInstructorID" CssClass="form-control">
        </asp:DropDownList>
    </div>

    <div class="form-group">
        <label for="txtRowVersion">Row Version:</label>
        <asp:TextBox runat="server" ID="txtRowVersion" CssClass="form-control" />
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

    <asp:Button Text="SaveDepartments" runat="server" ID="btnSave" OnClick="btnSave_Click" CssClass="btn btn-primary" />
    <asp:Button Text="CancelPeople" CssClass="btn btn-danger" runat="server" ID="btnCancel" CausesValidation="false" OnClick="btnCancel_Click" />
</asp:Content>
