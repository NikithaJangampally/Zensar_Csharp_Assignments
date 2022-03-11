<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="SubmitPage.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 22px;
        }
        .auto-style1 {
            text-align: justify;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Insert your details :<br />
            <br />
            Name:&nbsp;
            <asp:TextBox ID="Name" runat="server" OnTextChanged="TextBox4_TextChanged" style="margin-left: 101px" Width="180px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Name" ErrorMessage="Name" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Family Name:&nbsp
            <asp:TextBox ID="FamilyName" runat="server" style="margin-left: 0px" Width="180px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FamilyName" ErrorMessage="Name must be different from Family name" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="FamilyName" ErrorMessage="Must be different from Name" ForeColor="Red" ControlToCompare="Name" Operator="NotEqual"></asp:CompareValidator>
            <br />
            <br />
            Address:&nbsp; <asp:TextBox ID="Address" runat="server" style="margin-left: 80px" Width="180px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Address" ErrorMessage="Contain atleast 2 characters" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="Address" ErrorMessage="Must be atleast 2 characters" ForeColor="Red" ValidationExpression="^[a-zA-Z-\s\{2,}]+$"></asp:RegularExpressionValidator>
            <br />
            <br />
            City:&nbsp;
            <asp:TextBox ID="City" runat="server" OnTextChanged="TextBox9_TextChanged" style="margin-left: 113px" Width="180px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="City" ErrorMessage="Contain atleast 2 characters" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="City" ErrorMessage="Must be atleast 2 characters" ForeColor="Red" ValidationExpression="^[a-zA-Z-\s\{2,}]+$"></asp:RegularExpressionValidator>
            <br />
            <br />
            Zip Code:&nbsp;
            <asp:TextBox ID="ZipCode" runat="server" OnTextChanged="TextBox5_TextChanged" style="margin-left: 71px" Width="180px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ZipCode" ErrorMessage="Must be 6 digits" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="ZipCode" ErrorMessage="Must enter valid Zip code" ForeColor="Red" ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
            <br />
            <br />
            Phone:&nbsp; <asp:TextBox ID="PhoneNum" runat="server" Height="17px" style="margin-left: 97px" Width="180px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="PhoneNum" ErrorMessage="Must be 10 digits of the format XX-XXXXXXXXXX" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="PhoneNum" ErrorMessage="Must enter Valid phone number" ForeColor="Red" ValidationExpression="[0-9]{2}-[0-9]{10}"></asp:RegularExpressionValidator>
            <br />
            <br />
            E-Mail:&nbsp;
            <asp:TextBox ID="Email" runat="server" style="margin-left: 38px" Width="180px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="Email" ErrorMessage="Must be of format Eg: abc@xyz.com" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Email" ErrorMessage="Must enter Valid Email Id" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Check" />
    </form>
</body>
</html>
