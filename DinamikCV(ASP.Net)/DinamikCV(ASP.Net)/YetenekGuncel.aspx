<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekGuncel.aspx.cs" Inherits="DinamikCV_ASP.Net_.YetenekGuncel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="cal-md-12">
        <div class="col-md-8">
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>  <br />
        </div>
         <div class="col-md-8">
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Belirtilmemiş"></asp:TextBox><br />
        </div>
        <div class="col-md-5">
            <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-info" OnClick="Button1_Click" />
        </div>
    </div>
    
    
</asp:Content>
