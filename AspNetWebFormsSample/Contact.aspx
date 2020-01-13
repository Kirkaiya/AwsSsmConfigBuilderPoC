<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="AspNetWebFormsSample.Contact" %>
<%@ Import Namespace="System.Configuration" %>
<%@ Import Namespace="System.Web.Configuration" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <b>TestKey</b> = 
    <%=(ConfigurationManager.AppSettings["TestKey"]) %>
    <br /><br />
    <b>TwitterKey</b> = 
    <%=(WebConfigurationManager.AppSettings["TwitterKey"]) %>
    <br /><br />
    <b>ConnectionString</b> = 
    <%=(ConfigurationManager.ConnectionStrings["DefaultConnection"]) %>

    <hr  />
    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>

</asp:Content>
