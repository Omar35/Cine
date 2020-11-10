<%@ Page Title="" Language="C#" MasterPageFile="~/Principlal.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Cinev2.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form action="">
        <div class="container-fluid">
            <div class="row">
                <div class="col-4"></div>
                <div class="col-4 text-left text-dark">
                    <br>
                    <label class="alert-dark">Nombre</label>
                    <div class="row">
                        <input type="text">  
                    </div>
                    <br>
                    <label>Primer apellido</label>
                    <div class="row"> <input type="text" ></div>
                    <br>
                    <label>Segundo apellido</label><br>
                    <div class="row"><input type="text"></div>
                    <br>
                    <label>Telefono</label>
                    <div class="row"><input type="text"></div>
                    <br>
                    <label>Correo</label>
                    <div class="row"><input type="text"></div>
                    <br>
                    <label>Contraseña</label>
                    <div class="row"><input type="text"></div>
                    <br>
                    <div class="row"></div>



                </div>
                <div class="col-4"></div>
            </div>
        </div>

    </form>
</asp:Content>
