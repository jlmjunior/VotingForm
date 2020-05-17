﻿<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutOne.Master" AutoEventWireup="true" CodeBehind="CreateVoting.aspx.cs" Inherits="VotingForm.CreateVoting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headLayoutOne" runat="server">
    <script src="JS/CreatingVoting.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderLayoutOne" runat="server">

    <div class="container mt-4">
        <div class="d-flex justify-content-center mb-3">
            <div class="p-2">
                <h5 class="display-4">CREATING POLL</h5>
            </div>
        </div>

        <hr class="mb-4"/>

        <div class="input-group mb-5">
            <input name="option1" type="text" class="form-control form-control-lg rounded-right" placeholder="Title" required >
        </div>

        <div id="listOptions">
            <input name="option2" type="text" class="form-control form-control-lg rounded-right mb-3" placeholder="Option" required >
            <input name="option3" type="text" class="form-control form-control-lg rounded-right mb-3" placeholder="Option" required >
        </div>

        <div class="d-flex bd-highlight mt-1 mb-5">
            <div class="bd-highlight"><button id="newRow" onclick="return CreateInput()" class="btn btn-primary btn-lg px-5 py-3">New row</button></div>
            <div class="ml-auto bd-highlight"><asp:Button id="deleteAll" class="btn btn-danger btn-lg px-5 py-3" runat="server" Text="Delete all" PostBackUrl="~/RequestPoll.aspx" /></div>
        </div>
    </div>

</asp:Content>
