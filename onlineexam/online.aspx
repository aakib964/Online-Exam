<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="online.aspx.cs" Inherits="onlineexam.online" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
                <h1>
                    Online exam
                </h1>           
            <asp:Repeater ID="Repeater1" runat="server" >
                <ItemTemplate>
                    <asp:Table ID="Table1" runat="server">
                    
                        <asp:TableRow>
                            <asp:TableCell>
                                <%#Eval("qid")%> :    <%#Eval("question")%> 
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:RadioButton ID="RadBtn1" runat="server"  Text='<%#Eval("option1")%>' GroupName="exam" ></asp:RadioButton>
                                <asp:RadioButton ID="RadBtn2" runat="server"  Text='<%#Eval("option2")%>' GroupName="exam"></asp:RadioButton>
                                <asp:RadioButton ID="RadBtn3" runat="server"  Text='<%#Eval("option3")%>' GroupName="exam"></asp:RadioButton>
                                <asp:RadioButton ID="RadBtn4" runat="server"  Text='<%#Eval("option4")%>' GroupName="exam"></asp:RadioButton>
                                <br />
                                <asp:Label ID="LabCorrectAns" runat="server" Text='<%#Eval("correctans")%>' Visible="false"></asp:Label>
                            </asp:TableCell>
                      </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="User" runat="server" Text=""></asp:Label>
                                
                           </asp:TableCell>
                         </asp:TableRow>
                    </asp:Table>
                   
                </ItemTemplate>
            </asp:Repeater>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
             
        </div>
        
    </form>
</body>
</html>
