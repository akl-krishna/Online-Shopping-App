<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="ViewProducts.aspx.cs" Inherits="OnlineShopping_App.ViewProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    <div class="container">
       <div class="row">
         <h1 class="coffee_taital"> PRODUCTS UNDER 
             <asp:Label ID="Label4" runat="server"></asp:Label>
           </h1>
       &nbsp;</div>
         <br />
       <div class="row">
        <div class="col"></div>
        <div class="col">
 
 
  
   
            <asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal">
                <ItemTemplate>
                    <div class="text-center align-items-center">
                    <table class="w-100">
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("prod_name") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:ImageButton ID="ImageButton1" runat="server" Height="162px" ImageUrl='<%# Eval("prod_img") %>' Width="160px" CommandArgument='<%# Eval("prod_id") %>' OnCommand="ImageButton1_Command1" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Price: "></asp:Label>
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("prod_price") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                        </div>
                </ItemTemplate>
            </asp:DataList>

            </div>
        <div class="col"></div>
        </div>
    </div>
 
</asp:Content>
