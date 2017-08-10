<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListPeople.aspx.cs" Inherits="Contoso.People.ListPeople" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>
        List of People
    </h4>
    <hr/>
    <a href="AddPeople.aspx">Add Person</a>
    <asp:Repeater runat="server" ID="repeaterPeople" OnItemCommand="repeaterPeople_ItemCommand">
        <HeaderTemplate>
            <table class="table table-bordered">
                <tr class="info alert-info">
                    <th>ID</th>
                    <th>LastName</th>
                    <th>FirstName</th>
                    <th>MiddleName</th>
                    <th>Age</th>
                    <th>E-mail</th>
                    <th>Phone Number</th>
                    <th>Actions</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>  
                <tr>
                    <td>
                        <asp:Label Text='<%# Eval("ID") %>' runat="server" ID="IDLabel" />
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("LastName") %>' runat="server" ID="LastNameLabel" />                        
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("FirstName") %>' runat="server" ID="FirstNameLabel" />
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("MiddleName") %>' runat="server" ID="MiddleNameLabel" />
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("Age") %>' runat="server" ID="AgeLabel" />
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("Email") %>' runat="server" ID="EmailLabel" />
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("Phone") %>' runat="server" ID="PhoneLabel" />
                    </td>
                    <td>
                        <asp:Button Text="Edit" ID="editPerson" CssClass="btn btn-primary" runat="server"  CommandName="edit" CommandArgument='<%# Eval("ID") %>'/>
                        <asp:Button Text="Delete" ID="deletePerson" CssClass="btn btn-danger" runat="server"  CommandName="delete" CommandArgument='<%# Eval("ID") %>'/>
                        <asp:Button Text="Details" ID="detailsPeron" CssClass="btn btn-success" runat="server" CommandName="details" CommandArgument='<%# Eval("ID") %>' />
                    </td>
                </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
