<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="ASP.NET.Anasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server" BackColor="#E3EAEB" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#666666" Height="58px" StaticSubMenuIndent="10px" Width="399px">
                <DynamicHoverStyle BackColor="#666666" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#E3EAEB" />
                <DynamicSelectedStyle BackColor="#1C5E55" />
                <Items>
                    <asp:MenuItem Text="Anasayfa" Value="10"></asp:MenuItem>
                    <asp:MenuItem Text="Kullanıcı İşlemleri" Value="20"></asp:MenuItem>
                    <asp:MenuItem Text="Öğrenci İşleri" Value="30"></asp:MenuItem>
                    <asp:MenuItem Text="Ders İşlemleri" Value="40">
                        <asp:MenuItem Text="Başvuru Formu" Value="40:10"></asp:MenuItem>
                    </asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#666666" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#1C5E55" />
            </asp:Menu>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Raf"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownListRaf" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListRaf_SelectedIndexChanged"></asp:DropDownList>
        </div>
        <asp:Label ID="Label2" runat="server" Text="Kategori"></asp:Label>
        <br />
            <asp:ListBox ID="ListBoxKategori" runat="server" OnSelectedIndexChanged="ListBoxKategori_SelectedIndexChanged"></asp:ListBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Kitap"></asp:Label>
        <asp:FormView ID="FormViewKitap" runat="server">
        </asp:FormView>
        <asp:FormView ID="FormView2" runat="server">
        </asp:FormView>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Çıkış Yap" />
    </form>
</body>
</html>
