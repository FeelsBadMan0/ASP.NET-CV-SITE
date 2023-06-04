<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="HobiEkle.aspx.cs" Inherits="CVWebSite.HobiEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <form id="Form1" runat="server">
        <div class="form-group">

            <div>
                <asp:Label ID="Label1" runat="server" Text="Hobi"></asp:Label>
                <asp:TextBox ID="TxtHobi" runat="server" CssClass="form-control" TextMode="MultiLine" Height="100px"></asp:TextBox>
            </div>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="Button1_Click" />

        </div>
         </form>
</asp:Content>
