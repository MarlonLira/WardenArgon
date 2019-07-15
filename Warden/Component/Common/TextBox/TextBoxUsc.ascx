<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TextBoxUsc.ascx.cs" Inherits="Warden.Component.Common.TextBox.TextBoxUsc" %>

<div style="padding-top: 10px; padding-bottom:10px">
    
<% if (!IsHtml) {


        if (IsModified) {%>
<div class="col-<%=LoadMode() %>-<%=LoadSize() %>">
    <%} %>

    <%if (IsLabel == true) { %>
            <div style="text-align:left; padding-top:10px; padding-bottom: 1px">
                <usc:LabelUsc FontSize="14" runat="server" Text="label" Class="font-weight-bold mb-4" ID="lbl_control"/>
            </div>
    <%} %>
    <div class="input-group input-group-alternative">
    
        <div class="input-group-prepend">
            <span class="input-group-text"><i class="<%=LoadIcon()%>"></i></span>
        </div>
    
        <asp:TextBox ID="txt_control" runat="server" class="form-control" placeholder="Email"></asp:TextBox>
    </div>

<%if (IsModified) { %>
</div>
<%}
    } else {%>

    <div style="padding-left:10px; padding-top:10px">
        <label for="exampleInputEmail1"><b><%=Title %></b></label>
        <%if (!IsTextArea) { %>
            <input type="email" class="form-control" id="<%=ComponentId %>" aria-describedby="emailHelp" placeholder="Enter Text" title="<%=Text %>" style="color:slategray" >
        <%} else {%>
            <textarea rows="3" cols="30" class="form-control" id="<%=ComponentId %>" aria-describedby="emailHelp" placeholder="Enter text" title="<%=Text %>" style="color:slategray" ></textarea>
        <%} %>
    </div>

    <%} %>
</div>
