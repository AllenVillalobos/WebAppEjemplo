<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WebAppEjemplo.Paginas.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Hola</p>
            <div>
                <h2>Formulario para Validar Edad</h2>
                <br />
                <br />
                <label for="txtNombre">Nombre:</label>
                <asp:TextBox ID="txtNombre" runat="server" required="true"></asp:TextBox>
                <br />
                <br />
                <label for="txtEdad">Edad:</label>
                <asp:TextBox ID="txtEdad" runat="server" required="true"></asp:TextBox>
                <br />
                <asp:Button ID="btnEnviar" runat="server" Text="Enviar" required="true" OnClick="btnEnviar_Click" />
                <br />
                <br />
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
