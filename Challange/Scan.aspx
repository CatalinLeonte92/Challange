<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Scan.aspx.cs" Inherits="Challange.Scan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
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
                        <li><a runat="server" href="~/Scan.aspx">TaskTwo</a></li>
                        <li><a runat="server" href="~/Websites.aspx">TaskOne</a></li>
                       
                    </ul>
                   </div>
                </div>
           </div>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            Result of the Task:<br />
            <br />
        </div>
        
         <asp:Literal runat="server" id="txtValueB" EnableViewState="false" />
         
         
    </form>
    

       
    
   
</body>

</html>
