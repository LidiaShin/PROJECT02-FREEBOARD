<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PART19.aspx.cs" Inherits="PRACTICES.TEST" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<link href="CSS/StyleForClassLab.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
			IsPostback + !IsPostBack <hr />
			<table>

			<tr>
				<td>Name:</td> <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
			</tr>
			<tr>
				<td>Age: </td><td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
			</tr>
				
			</table>
			<asp:Button ID="Btn_Send" runat="server" Text="SEND" OnClick="Btn_Send_Click"  />
        </div>
    </form>
</body>
</html>
