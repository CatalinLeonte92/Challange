<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Websites.aspx.cs" Inherits="Challange.Websites" %>
  
    <!DOCTYPE html>  
    <html xmlns="http://www.w3.org/1999/xhtml">  
  <body>
       <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse" title="more options">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" runat="server" href="~/">Challange</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a runat="server" href="~/Scan.aspx">TaskOne</a></li>
                        <li><a runat="server" href="~/">Websites.aspx</a></li>
                       
                    </ul>
                   </div>
                </div>
           </div>
     <asp:Literal runat="server" id="txtValueA" EnableViewState="false" />
      <asp:Literal runat="server" id="txtValueB" EnableViewState="false" />
        <form id="form1" runat="server">  
    <div>  
        <asp:Button ID="Button1" runat="server" Text="Insert Data" OnClick="Button1_Click" />  
    </div>  
    </form>  

    <asp:Literal runat="server" id="txtValueC" EnableViewState="false" />
    </body>  
  
    </html>  
