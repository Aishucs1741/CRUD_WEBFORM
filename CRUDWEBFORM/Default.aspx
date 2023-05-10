<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRUDWEBFORM._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div style="font-size:x-large" align="center">..CRUD IN WEBFORM..</div>
   <br />
        <table style="width: 100%; border-style: solid; border-width: 1px">
            <tr>
                <td style="width: 164px">&nbsp;</td>
                <td style="width: 213px">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 164px">&nbsp;</td>
                <td style="width: 213px">Student Name</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Font-Size="Medium" Width="320px"></asp:TextBox>
                &nbsp;
                    <%--<asp:Button ID="Button6" runat="server" OnClick="Button_5Click" Text="GET" Width="63px" />--%>
                </td>
            </tr>
            <tr>
                <td style="width: 164px">&nbsp;</td>
                <td style="width: 213px">Address</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Font-Size="Medium" Width="321px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 164px">&nbsp;</td>
                <td style="width: 213px">Age</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Font-Size="Medium" Width="36px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 164px">&nbsp;</td>
                <td style="width: 213px">Contact</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" Font-Size="Medium" Width="320px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 164px; height: 13px;"></td>
                <td style="width: 213px; height: 13px;"></td>
                <td style="height: 13px"></td>
            </tr>
            <tr>
                <td style="width: 164px">&nbsp;</td>
                <td style="width: 213px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 164px">&nbsp;</td>
                <td style="width: 213px">&nbsp;</td>
                <td>
                    <asp:Button ID="Button2" runat="server" BackColor="#33CC33" BorderColor="Black" OnClick="Button1_Click" Text="INSERT" Width="118px" />
                &nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" BackColor="#66CCFF" BorderColor="Black" Text="UPDATE" Width="118px" BorderStyle="Solid" OnClick="Button2_Click" />
                &nbsp;
                    <asp:Button ID="Button4" runat="server" BackColor="Red" BorderColor="Black" Text="DELETE" Width="118px" BorderStyle="Solid" OnClick="Button3_Click" />
                &nbsp;
                    <asp:Button ID="Button5" runat="server" BackColor="Yellow" BorderColor="Black" Text="SEARCH" Width="118px" BorderStyle="Solid" OnClick="Button4_Click" />
                </td>
            </tr>
            <tr>
                <td style="width: 164px">&nbsp;</td>
                <td style="width: 213px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 164px">&nbsp;</td>
                <td style="width: 213px">&nbsp;</td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" Width="524px">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>

</asp:Content>
