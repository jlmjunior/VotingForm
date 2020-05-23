<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutOne.Master" AutoEventWireup="true" CodeBehind="BuildPoll.aspx.cs" Inherits="VotingForm.BuildPoll" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headLayoutOne" runat="server">
    <script src="/JS/Timer.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderLayoutOne" runat="server">

    <div class="container mt-5" runat="server" id="errorPanel">
        <div class="d-flex justify-content-center">
            <div class="p-2">
                <h1 class="display-4">
                    <asp:Label ID="errorMessage" runat="server" Text="Label"></asp:Label>
                </h1>
            </div>
        </div>
    </div>

    <div class="container mt-5" runat="server" id="successPanel">
        <div class="card-body">
            <h4 class="display-4">
                <asp:Label ID="pollTitle" runat="server" Text="Title"></asp:Label>
            </h4>
        </div>

        <div class="mt-2">
            <asp:Literal ID="litOptions" runat="server"></asp:Literal>
        </div>
    </div>

</asp:Content>
