<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListDepartments.aspx.cs" Inherits="Contoso.Departments.ListDepartments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>
        List of Departments
    </h4>
    <hr/>
    <a href="AddDepartments.aspx">Add Departments</a>
    <asp:Repeater runat="server" ID="repeaterDepartments" OnItemCommand="repeaterDepartments_ItemCommand">
        <HeaderTemplate>
            <table class="table table-bordered">
                <tr class="info alert-info">
                    <th>ID</th>
                    <th>Name</th>
                    <th>Budget</th>
                    <th>Instructor ID</th>
                    <th>Row Version</th>
                    <th>Actions</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>  
                <tr>
                    <td>
                        <asp:Label Text='<%# Eval("ID") %>' runat="server" ID="IDLabel" />
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("Name") %>' runat="server" ID="NameLabel" />                        
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("Budget") %>' runat="server" ID="BudgetLabel" />
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("InstructorID") %>' runat="server" ID="InstructorIDLabel" />
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("RowVersion") %>' runat="server" ID="RowVersionLabel" />
                    </td>
                    <td>
                        <asp:Button Text="Edit" ID="editDepartments" CssClass="btn btn-primary" runat="server"  CommandName="edit" CommandArgument='<%# Eval("ID") %>'/>
                        <asp:Button Text="Delete" ID="deleteDepartments" CssClass="btn btn-danger" runat="server"  CommandName="delete" CommandArgument='<%# Eval("ID") %>'/>
                        <asp:Button Text="Details" ID="detailsDepartments" CssClass="btn btn-success" runat="server" CommandName="details" CommandArgument='<%# Eval("ID") %>' />
                    </td>
                </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
