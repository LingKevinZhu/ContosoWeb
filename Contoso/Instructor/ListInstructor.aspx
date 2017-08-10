<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListInstructor.aspx.cs" Inherits="Contoso.Instructor.ListInstructor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>
        List of Instructor
    </h4>
    <hr/>
    <a href="AddInstructor.aspx">Add Instructor</a>
    <asp:Repeater runat="server" ID="repeaterInstructor" OnItemCommand="repeaterInstructor_ItemCommand">
        <HeaderTemplate>
            <table class="table table-bordered">
                <tr class="info alert-info">
                    <th>ID</th>
                    <th>Hire Date</th>
                    <th>Actions</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>  
                <tr>
                    <td>
                        <asp:Label Text='<%# Eval("ID") %>' runat="server" ID="IDLabel" />
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("HireDate") %>' runat="server" ID="HireDateLabel" />                        
                    </td>
                    <td>
                        <asp:Button Text="Edit" ID="editInstructor" CssClass="btn btn-primary" runat="server"  CommandName="edit" CommandArgument='<%# Eval("ID") %>'/>
                        <asp:Button Text="Delete" ID="deleteInstructor" CssClass="btn btn-danger" runat="server"  CommandName="delete" CommandArgument='<%# Eval("ID") %>'/>
                        <asp:Button Text="Details" ID="detailsInstructor" CssClass="btn btn-success" runat="server" CommandName="details" CommandArgument='<%# Eval("ID") %>' />
                    </td>
                </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
