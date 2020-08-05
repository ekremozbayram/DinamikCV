<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yeteneklerim.aspx.cs" Inherits="DinamikCV_ASP.Net_.Hakkimda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
        <h3>Yeni Yetenek Girişi:</h3>
        <div class="col-md-8">
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Yetenek Adı.."></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Derece.."></asp:TextBox>
        </div>
        <div class="col-md-1">
            <asp:Button ID="Button2" runat="server" Text="Kaydet" CssClass="btn btn-info" OnClick="Button2_Click" />
        </div>

    </div>

    <div class="col-md-12">
        <br />
        <br />
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>YETENEK</th>
                <th>DERECE</th>
                <th>SiL</th>
                <th>GÜNCELLE</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Id") %></td>

                        <td><%# Eval("yetenek") %></td>

                        <td><%# Eval("derece")  %></td>

                        <td>
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "YetenekSil.aspx?ID=" +Eval("ID") %>' CssClass="btn btn-danger">Sil</asp:HyperLink>
                        </td>

                        <td>
                            <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-success" NavigateUrl='<%# "YetenekGuncel.aspx?ID=" +Eval("ID") %>'>Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>


</asp:Content>
