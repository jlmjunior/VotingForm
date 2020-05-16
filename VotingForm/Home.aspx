﻿<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutOne.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="VotingForm.Home" %>
<asp:Content id="ContentHeadHome" ContentPlaceHolderID="headLayoutOne" runat="server">

</asp:Content>

<asp:Content id="ContentBodyHome" ContentPlaceHolderID="ContentPlaceHolderLayoutOne" runat="server">

    <div class="container mt-5">
        <div class="d-flex justify-content-center">
            <div class="p-2">
                <h1 class="display-4">
                    Create your table! it's fast!
                </h1>
            </div>
        </div>
        <div class="d-flex justify-content-center mt-2">
            <div class="p-2">
                <asp:Button id="createNow" class="btn btn-primary btn-lg px-5 py-3" runat="server" Text="CREATE NOW" />
            </div>
        </div>
    </div>

</asp:Content>
