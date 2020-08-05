<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MesajGoruntule.aspx.cs" Inherits="DinamikCV_ASP.Net_.MesajGoruntule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>Ad Soyad</th>
                <th>Konu</th>
                <th>Mesaj</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID") %></td>
                        <td><%# Eval("adsoyad") %></td>
                        <td><%# Eval("konu") %></td>
                        <td><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "MesajDetay.aspx?ID=" + Eval("ID") %>' CssClass="btn btn-success">Mesaj Gör</asp:HyperLink></td>
                    </tr>
                </ItemTemplate>

            </asp:Repeater>
        </table>
    </div>
</asp:Content>
