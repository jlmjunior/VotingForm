<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutOne.Master" AutoEventWireup="true" CodeBehind="RequestPoll.aspx.cs" Inherits="VotingForm.RequestPoll" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headLayoutOne" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderLayoutOne" runat="server">
    
    <div class="container mt-5">
        <div class="d-flex justify-content-center">
            <div class="p-2">
                <h1 class="display-4">
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </h1>
            </div>
        </div>
    </div>
    
</asp:Content>
