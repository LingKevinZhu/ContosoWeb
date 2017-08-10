<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCourses.aspx.cs" Inherits="ContosoWeb.Courses.AddCourses" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <label for="txtTitle">Course Title:</label>
        <asp:TextBox runat="server" ID="txtTitle" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="txtCredits">Course Credits:</label>
        <asp:TextBox runat="server" ID="txtCredits" CssClass="form-control" />
    </div>

    <div class="form-group">
        <label for="ddlDepartmentID">Department ID:</label>
        <asp:DropDownList runat="server" ID="ddlDepartmentID" CssClass="form-control">
        </asp:DropDownList>
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

    <asp:Button Text="SaveCourses" runat="server" ID="btnSave" OnClick="btnSave_Click" />

</asp:Content>