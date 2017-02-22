<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema de Inventario de Equipos - INEQ</title>
    <link rel='stylesheet prefetch' href='http://fonts.googleapis.com/css?family=Open+Sans:600' />
    <link rel="stylesheet" href="css/style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-wrap">
            <div class="login-html">
                <input id="tab-1" type="radio" name="tab" class="sign-in" checked><label for="tab-1" class="tab">Iniciar Sesion</label>
                <input id="tab-2" type="radio" name="tab" class="sign-up" visible="false"><label visible="false" for="tab-2" class="tab">Registrarse</label>
                <div class="login-form">
                    <div class="sign-in-htm">
                        <div class="group">
                            <label for="user" class="label">Usuario</label>
                            <asp:TextBox ID="txtUsuario" runat="server" class="input"></asp:TextBox>
                        </div>
                        <div class="group">
                            <label for="pass" class="label">Contraseña</label>
                            <asp:TextBox ID="txtContrasenia" class="input" runat="server" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="group">
                            <asp:Button ID="btnIniciarSesion" class="button" runat="server" Text="Iniciar Sesion" OnClick="btnIniciarSesion_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
