﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="bloodsaver.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
   
    <script src="~/Scripts/jquery-1.8.2.js"></script>
    <link rel="stylesheet" type="text/css" href="//cdn.datatables.net/1.10.7/css/jquery.dataTables.min.css" />
    <script src="//cdn.datatables.net/1.10.7/js/jquery.dataTables.min.js">
    </script>
</head>
    
<body>
    
    <form id="form1" runat="server">
    <div>
        <table id="x">
        <tr>
            <td>zubair</td>
        </tr>
        <tr>
            <td>ali</td>
        </tr>
    </table>
    
    </div>
    </form>

    <script type="text/javascript">
        $(document).ready(function () {
            $('#x').DataTable();

        });
</script>
</body>



</html>
