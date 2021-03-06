<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exervice4.aspx.cs" Inherits="WebApplication1exr4.exervice4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="alert-info">
            <asp:CheckBox ID="CheckBox1" runat="server" Text="C" />
            <br />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="C++" />
            <br />
             <asp:CheckBox ID="CheckBox3" runat="server" Text="C#" />

            <br />
             <asp:CheckBox ID="CheckBox4" runat="server" Text="VB.NET" />

            <br />
             <asp:CheckBox ID="CheckBox5" runat="server" Text="JAVA" />

            <br />
             <asp:CheckBox ID="CheckBox6" runat="server" Text="PASCAL" />

            <br />
            <asp:Button ID="Button1" runat="server" Text="ok" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        </div>
    </form>
</body>
</html>
