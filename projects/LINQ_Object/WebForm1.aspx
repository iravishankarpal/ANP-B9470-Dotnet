<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LINQ_Project2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <style type="text/css">  
        .auto-style1 {  
            width: 50%;  
            background-color: #FF9900;  
        }  
        .auto-style2 {  
            width: 310px;  
        }  
        .auto-style3 {  
            width: 310px;  
            height: 26px;  
        }  
        .auto-style4 {  
            height: 26px;  
        }  
        .auto-style5 {  
            width: 310px;  
            height: 97px;  
        }  
        .auto-style6 {  
            height: 97px;  
        }  
    </style>  
</head>  
<body>  
    <form id="form1" runat="server">  
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Text="LINQ TO SQL"></asp:Label>  
        <div>  
            <table border="1" class="auto-style1">  
                <tr>  
                    <td class="auto-style5">Student Roll No</td>  
                    <td class="auto-style6">  
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
                        <asp:Button ID="Button1" runat="server" ForeColor="#0066FF" OnClick="Button1_Click" Text="Search" />  
                        <br />  
                        <asp:Label ID="Label2" runat="server"></asp:Label>  
                    </td>  
                </tr>  
                <tr>  
                    <td class="auto-style2">Student Name</td>  
                    <td>  
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td class="auto-style3">Father's Name</td>  
                    <td class="auto-style4">  
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td class="auto-style2">Mother's Name</td>  
                    <td>  
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td class="auto-style2"> </td>  
                    <td> </td>  
                </tr>  
            </table>  
        </div>  
    </form>  
</body>  
</html>
