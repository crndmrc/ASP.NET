<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="ASP.NET.Giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TxtKullaniciAdi" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="TxtSifre" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="BtnGiris" runat="server" Text="Giriş Yap" OnClick="BtnGiris_Click" />
            <br />
            <asp:Label ID="lblBilgi" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
