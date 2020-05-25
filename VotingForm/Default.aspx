<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutOne.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VotingForm.Home" %>
<asp:Content id="ContentHeadHome" ContentPlaceHolderID="headLayoutOne" runat="server">

</asp:Content>

<asp:Content id="ContentBodyHome" ContentPlaceHolderID="ContentPlaceHolderLayoutOne" runat="server">

    <div class="container mt-5">
        <div class="d-flex justify-content-center">
            <div class="p-2">
                <h1 class="display-4">
                    Create your poll! it's fast!
                </h1>
            </div>
        </div>
        <div class="d-flex justify-content-center mt-2">
            <div class="p-2">
                <a class="btn btn-primary btn-lg px-5 py-3" href="CreateVoting.aspx">CREATE NOW</a>
            </div>
        </div>
    </div>

</asp:Content>
