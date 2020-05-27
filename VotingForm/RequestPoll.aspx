<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutOne.Master" AutoEventWireup="true" CodeBehind="RequestPoll.aspx.cs" Inherits="VotingForm.RequestPoll" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headLayoutOne" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderLayoutOne" runat="server">
    
    <div class="container mt-5">
        <div class="d-flex justify-content-center">
            <div class="p-2">
                <h1 class="display-4">
                    <asp:Label ID="statusMessage" runat="server" Text=""></asp:Label>
                </h1>
            </div>
        </div>
        <div id="inpLinkPoll" class="mt-5" runat="server">
            <div class="d-flex justify-content-center">
                <asp:TextBox id="pollLink" class="form-control box" runat="server" style="width:50%" ReadOnly="true" ClientIDMode="Static"></asp:TextBox>
                <i onClick="CopyLink()" class="far fa-copy fa-2x copyIcon ml-2"></i>
            </div>
        </div>
    </div>
    
</asp:Content>
