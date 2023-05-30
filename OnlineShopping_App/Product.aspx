<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="OnlineShopping_App.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        position: relative;
        width: 100%;
        min-height: 1px;
        -ms-flex-preferred-size: 0;
        flex-basis: 0;
        -ms-flex-positive: 1;
        flex-grow: 1;
        max-width: 100%;
        left: 0px;
        top: 0px;
        padding-left: 15px;
        padding-right: 15px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
       <div class="row">
         <h1 class="coffee_taital"> Product 
                 <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" ImageUrl="~/images/plus.png" Height="29px" Width="31px" />
           </h1>

       </div>
         <br />
       <div class="row">
         <div class="auto-style1"></div>
        <div class="col">
            <asp:GridView ID="GridView1" runat="server" DataKeyNames="prod_id" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="prod_id" HeaderText="Product Id" />
                    <asp:BoundField DataField="prod_name" HeaderText="Product Name" />
                    <asp:BoundField DataField="cat_id" HeaderText="Category Id" />
                    <asp:BoundField DataField="prod_price" HeaderText="Price" />
                    <asp:BoundField DataField="prod_desc" HeaderText="Description" />
                    <asp:ImageField DataImageUrlField="prod_img" HeaderText="Image">
                    </asp:ImageField>
                    <asp:BoundField DataField="stock" HeaderText="Stock" />
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
                </asp:GridView>
        </div>
        <div class="col"></div>
        </div>
    </div>

</asp:Content>
