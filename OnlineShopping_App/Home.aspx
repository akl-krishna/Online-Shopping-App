<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OnlineShopping_App.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   

       <div class="container">
       <div class="row">
         <h1 class="coffee_taital"> Category 
           </h1>
       </div>
         <br />
       <div class="row">
        <div class="col"></div>
        <div class="col">

        <asp:DataList ID="DataList1" runat="server" RepeatColumns="5" RepeatDirection="Horizontal">
            <ItemTemplate>
                <div class="text-center align-items-center">
                <table class="w-100">
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("cat_name") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:ImageButton ID="ImageButton1" runat="server" Height="218px" ImageUrl='<%# Eval("cat_img") %>' Width="217px" CommandArgument='<%# Eval("cat_id") %>' OnCommand="ImageButton1_Command" />
                        </td>
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
