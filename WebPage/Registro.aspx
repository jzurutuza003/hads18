<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Registro.aspx.vb" Inherits="Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 33px;
        }
        .auto-style3 {
            height: 60px;
        }
        .auto-style4 {
            height: 51px;
        }
        .auto-style5 {
            height: 52px;
        }
        .auto-style6 {
            height: 59px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="height: 612px; width: 1491px">
        <asp:label id="Label1" runat="server"></asp:label>
        <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" BackColor="lightblue" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" Height="519px" Width="718px">
            <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
            <CreateUserButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <WizardSteps>
                <asp:CreateUserWizardStep runat="server">
                    <ContentTemplate>
                        <table style="font-family:Verdana;font-size:100%;height:519px;width:718px;">
                            <tr>
                                <td align="center" colspan="2" style="color:black;background-color:lightblue;" class="auto-style2">Registration</td>
                            </tr>
                            <tr>
                                <td align="right" class="auto-style3">
                                    DNI:</td>
                                <td class="auto-style3">
                                    <asp:TextBox id="UserDNI" name="UserDNI" runat="server" OnTextChanged="UserDNI_TextChanged" TextMode="SingleLine"></asp:TextBox>
                                    <asp:RequiredFieldValidator id="DNIRequired" runat="server" ControlToValidate="UserDNI" ErrorMessage="User DNI is required." ToolTip="User DNI is required." ValidationGroup="CreateUserWizard1">* Insert DNI</asp:RequiredFieldValidator>
                                    </td>
                            </tr>
                            <tr>
                                <td align="right" class="auto-style4">
                                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
                                </td>
                                <td class="auto-style4">
                                    <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="CreateUserWizard1">* Insert name</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="auto-style5">1º Surname:</td>
                                <td class="auto-style5">
                                    <asp:TextBox ID="UserFirstSurname" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="FirstSurnameRequired" runat="server" ControlToValidate="UserFirstSurname" ErrorMessage="User First Surname is required." ToolTip="User First Surname is required." ValidationGroup="CreateUserWizard1">* Insert 1º surname</asp:RequiredFieldValidator>
                                    </td>
                            </tr>
                            <tr>
                                <td align="right" class="auto-style6">2º Surname:</td>
                                <td class="auto-style6">
                                    <asp:TextBox ID="UserSecondSurname" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="SecondSurnameRequired" runat="server" ControlToValidate="UserSecondSurname" ErrorMessage="User Second Surname is required." ToolTip="User Second Surname is required." ValidationGroup="CreateUserWizard1">* Insert 2º surname</asp:RequiredFieldValidator>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="CreateUserWizard1">* Insert password</asp:RequiredFieldValidator>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Confirm Password:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword" ErrorMessage="Confirm Password is required." ToolTip="Confirm Password is required." ValidationGroup="CreateUserWizard1">* Insert password</asp:RequiredFieldValidator>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">E-mail:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ControlToValidate="Email" ErrorMessage="* Insert E-mail" ValidationGroup="CreateUserWizard1"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator" runat="server" ControlToValidate="Email" ErrorMessage="* Incorrect E-mail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="CreateUserWizard1"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="QuestionLabel" runat="server" AssociatedControlID="Question">Security Question:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="Question" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="QuestionRequired" runat="server" ControlToValidate="Question" ErrorMessage="Security question is required." ToolTip="Security question is required." ValidationGroup="CreateUserWizard1">* Insert question</asp:RequiredFieldValidator>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="AnswerLabel" runat="server" AssociatedControlID="Answer">Security Answer:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="Answer" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="AnswerRequired" runat="server" ControlToValidate="Answer" ErrorMessage="Security answer is required." ToolTip="Security answer is required." ValidationGroup="CreateUserWizard1">* Insert Answer</asp:RequiredFieldValidator>
                                    </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                    <CustomNavigationTemplate>
                        <table border="0" cellspacing="5" style="width:100%;height:100%;">
                            <tr align="right">
                                <td align="center" colspan="0">
                                    <asp:Button ID="StepNextButton" runat="server" BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" CommandName="MoveNext" Font-Names="Verdana" ForeColor="#284775" Text="Create User" ValidationGroup="CreateUserWizard1" />
                                </td>
                            </tr>
                        </table>
                    </CustomNavigationTemplate>
                </asp:CreateUserWizardStep>
                <asp:CompleteWizardStep runat="server" />
            </WizardSteps>
            <HeaderStyle BackColor="#5D7B9D" BorderStyle="Solid" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
            <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
            <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="White" />
            <SideBarStyle BackColor="#5D7B9D" BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top" />
            <StepStyle BorderWidth="0px" />
        </asp:CreateUserWizard>
        </div>
    </form>
</body>
</html>
