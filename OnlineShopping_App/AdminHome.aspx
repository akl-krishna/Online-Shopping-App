<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="OnlineShopping_App.css.AdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<style>
  .parent {
  height: 200px;
  display: flex;
  align-items: center;
  justify-content: center;
}

.child {
  background-color: orange;
  width: 300px;
  height: 200px;
}
    .imgsiz
    {
  width: 300px;
  height: 200px;
    }
</style>

     <div class="container">
            <div class="row">
               <h1 class="coffee_taital">
                   Welcome Admin !</h1>
            </div>
    </div>

    <div class="container">
    <div><h2><b>Add</b></h2></div>
    <div class="row">
        <div class="col parent">
        <div class="child">
            <asp:ImageButton ID="ImageButton1" class="imgsiz" runat="server" OnClick="ImageButton1_Click" ImageUrl="~/images/category.jpg" />
            <br /><h3>Category</h3>
        </div>
        </div>
        <div class="col parent">
           <div class="child">
            <asp:ImageButton ID="ImageButton2" class="imgsiz" runat="server" OnClick="ImageButton2_Click" ImageUrl="~/images/product.jpg" />
            <br /><h3>Product</h3>
        </div>
            </div>
        <div class="col parent">
        <div class="child">
            <asp:ImageButton ID="ImageButton3" class="imgsiz" runat="server" OnClick="ImageButton3_Click" ImageUrl="~/images/user.jpg" />
            <br /><h3>User</h3>
        </div>
        </div>
   </div>
   </div>
    <br /><hr style="height:2px;border-width:0;color:gray;background-color:gray; width:1050px;">
     <div class="container">
    <div><h2><b>View</b></h2></div>
    <div class="row">
        <div class="col parent">
        <div class="child">
            <asp:ImageButton ID="ImageButton4" class="imgsiz" runat="server" OnClick="ImageButton1_Click" ImageUrl="~/images/category.jpg" />
            <br /><h3>Category</h3>
        </div>
        </div>
        <div class="col parent">
           <div class="child">
            <asp:ImageButton ID="ImageButton5" class="imgsiz" runat="server" OnClick="ImageButton2_Click" ImageUrl="~/images/product.jpg" />
            <br /><h3>Product</h3>
        </div>
            </div>
        <div class="col parent">
        <div class="child">
            <asp:ImageButton ID="ImageButton6" class="imgsiz" runat="server" OnClick="ImageButton3_Click" ImageUrl="~/images/user.jpg" />
            <br /><h3>User</h3>
        </div>
        </div>
   </div>
   </div>
     
</asp:Content>


