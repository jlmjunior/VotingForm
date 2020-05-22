<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JsonRequest.aspx.cs" Inherits="VotingForm.JsonRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5" runat="server" id="errorPanel">
            <div class="d-flex justify-content-center">
                <div class="p-2">
                    <h1 class="display-4">
                        <asp:Label ID="errorMessage" runat="server" Text="Label"></asp:Label>
                    </h1>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
