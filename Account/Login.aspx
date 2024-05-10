<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Account_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .Centrar{
            margin:10px;
            padding:10px;
            position:absolute;
            display:flex;
            flex-direction:column;
            width:300px;
            height:200px;
            background-color: burlywood;
            justify-content:space-around;
            left:35%;
            top:35%;
            
        }
    </style>
</head>
<body>
    <div class="Centrar">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RV1" ForeColor="OrangeRed" ControlToValidate="TextBox1" runat="server" ErrorMessage="Debe Completar Este Campo"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label> <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="OrangeRed" ControlToValidate="TextBox1"  runat="server" ErrorMessage="Debe Completar Este Campo"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" ForeColor="DarkRed" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Ingresar" OnClick="Button1_Click" />
        </div>
    </form>
    </div>
</body>
</html>
