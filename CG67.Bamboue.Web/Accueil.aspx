<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Accueil.aspx.cs" Inherits="CG67.Bamboue.Web.Accueil" MasterPageFile="~/MasterPage.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph" runat="server">
    <asp:Label ID="lblInstallations" runat="server" Text="Selectionnez l'installation dont fait parti votre champ:"></asp:Label>
    <br />
    <asp:DropDownList ID="ddlInstallations" runat="server" OnSelectedIndexChanged="ddlInstallations_SelectedIndexChanged">
</asp:DropDownList>
</asp:Content>
