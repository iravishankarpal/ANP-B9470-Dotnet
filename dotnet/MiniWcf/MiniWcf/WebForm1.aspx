<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MiniWcf.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div class="BgGrid" style="margin:100px;">  
                <table>  
                    <asp:Repeater ID="grduser" runat="server">  
                        <HeaderTemplate>  
                            <tr>  
                                <th style="margin:5px,auto;text-align:center">First Name</th>  
                                <th style="margin:5px,auto;text-align:center">Last Name</th>  
                                <th style="margin:5px,auto;text-align:center">Email</th>  
                            </tr>  
                        </HeaderTemplate>  
                        <ItemTemplate>  
                            <tr>  
                                <td>  
                                    <%#Eval("FirstName") %>  
                                </td>  
                                <td>  
                                    <%#Eval("LastName") %>  
                                </td>  
                                <td>  
                                    <%#Eval("Email") %>  
                                </td>  
                            </tr>  
                        </ItemTemplate>  
                    </asp:Repeater>  
                </table>  
            </div>  
            <div id="dvSI" style="margin:100px,20px;">  
                <asp:TextBox ID="txtP" runat="server" Placeholder="Enter Principle"></asp:TextBox>  
                <asp:TextBox ID="txtR" runat="server" Placeholder="Enter Rate"></asp:TextBox>  
                <asp:TextBox ID="txtT" runat="server" Placeholder="Enter Time"></asp:TextBox>  
                <asp:Button ID="btnSmt" Text="Calculate" OnClick="btnSmt_click" runat="server" /> </div>  
            <div style="margin:50px;">  
                <asp:Label ID="lblval" runat="server"></asp:Label>  
            </div>  
       
    </form>
</body>
</html>
