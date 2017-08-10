<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListCourses.aspx.cs" Inherits="Contoso.Courses.ListCourses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>
        List of Courses
    </h4>
    <hr/>
    <a href="AddCourses.aspx">Add Courses</a>
    <asp:Repeater runat="server" ID="repeaterCourses" OnItemCommand="repeaterCourses_ItemCommand">
        <HeaderTemplate>
            <table class="table table-bordered">
                <tr class="info alert-info">
                    <th>ID</th>
                    <th>Title</th>
                    <th>Credits</th>
                    <th>Department ID</th>
                    <th>Actions</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>  
                <tr>
                    <td>
                        <asp:Label Text='<%# Eval("ID") %>' runat="server" ID="IDLabel" />
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("Title") %>' runat="server" ID="TitleLabel" />                        
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("Credits") %>' runat="server" ID="CreditsLabel" />
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("DepartmentID") %>' runat="server" ID="DepartmentIDLabel" />
                    </td>
                    <td>
                        <asp:Button Text="Edit" ID="editCourses" CssClass="btn btn-primary" runat="server"  CommandName="edit" CommandArgument='<%# Eval("ID") %>'/>
                        <asp:Button Text="Delete" ID="deleteCourses" CssClass="btn btn-danger" runat="server"  CommandName="delete" CommandArgument='<%# Eval("ID") %>'/>
                        <asp:Button Text="Details" ID="detailsCourses" CssClass="btn btn-success" runat="server" CommandName="details" CommandArgument='<%# Eval("ID") %>' />
                    </td>
                </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
