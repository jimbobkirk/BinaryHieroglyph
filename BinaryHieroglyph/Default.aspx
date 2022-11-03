<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BinaryHieroglyph.Default" %>

<!DOCTYPE html>
<link rel="stylesheet" href="Styles/style.css" media="screen" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:TextBox runat="server" ID="txtNumber"></asp:TextBox>
            <asp:Button runat="server" ID="btnCalculate" Text="Calculate" OnClick="btnCalculate_Click"  /><br /> <br />
            <div style="font-size:0px;">
                <div>
                    <asp:Label ID="lblLeft1" Width="10px" Text="&nbsp" runat="server" CssClass="StyleLeftOn"></asp:Label>
                    <asp:Label ID="lblRight1" Width="10px" Text="&nbsp" runat="server" CssClass="StyleRightOn"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblLeft2" Width="10px" Text="&nbsp" runat="server" CssClass="StyleLeftOn"></asp:Label>
                    <asp:Label ID="lblRight2" Width="10px" Text="&nbsp" runat="server" CssClass="StyleRightOn"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblLeft3" Width="10px" Text="&nbsp" runat="server"></asp:Label>
                    <asp:Label ID="lblRight3" Width="10px" Text="&nbsp" runat="server"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblLeft4" Width="10px" Text="&nbsp" runat="server"></asp:Label>
                    <asp:Label ID="lblRight4" Width="10px" Text="&nbsp" runat="server"></asp:Label>
                </div>
                
            </div>X

        </div>
    </form>
</body>
</html>
