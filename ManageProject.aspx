<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ManageProject.aspx.cs" Inherits="HR_MANAGMENT_SYSTEM.ManageProject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <script type="text/javascript">
       $(document).ready(function () {

           //$(document).ready(function () {
           //$('.table').DataTable();
           // });

           $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
           //$('.table1').DataTable();
       });
       </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
 
                <div class="card">
                    <div class="card-body">
 
                        <div class="row">
                            <div class="col">
                                <center>
                                        <h4>Project Details</h4>
                                    </center>
                            </div>
                        </div>
 
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100px" src="image/Details.png" />
                                       
                                    </center>
                            </div>
                        </div>
 
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
 
                        <div class="row">
                            <div class="col-md-4">
                                <label>Project ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="ID"></asp:TextBox>
                                        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Go" 
                                            onclick="Button1_Click" />
                                    </div>
                                </div>
                            </div>
 
                            <div class="col-md-8">
                                <label>Project Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Project Name"></asp:TextBox>
 
                                </div>
                            </div>
                        </div>

                        <div>
                                <label>Client Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Client Name" ></asp:TextBox>
 
                                </div>
                            </div>
                        </div>
                        
                         <div class="col-md-11">
                                <label>Client Contact_no</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Client Contact_no"></asp:TextBox>
 
                                </div>
                            </div>
                             <div class="col-md-11">
                                <label>Budget</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Budget" TextMode="Number"></asp:TextBox>
 
                                </div>
                            </div>
                            <div class="col-md-11">
                                <label>Deadlines</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Deadlines" TextMode="Date" ></asp:TextBox>
 
                                </div>
                            </div>
                            
                        </div>
                        <div class="row">
                            <div class="col-4">
                                <asp:Button ID="Button2" class="btn btn-lg btn-block btn-success" 
                                    runat="server" Text="Add" onclick="Button2_Click"/>
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button3" class="btn btn-lg btn-block btn-warning" 
                                    runat="server" Text="Update" onclick="Button3_Click" />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button4" class="btn btn-lg btn-block btn-danger" runat="server" 
                                    Text="Delete" onclick="Button4_Click" />
                            </div>
                        </div>
 
 
                    </div>
                </div>
 
                <br>
                <br>
            </div>
 
            <div class="col-md-6 mx-auto">
 
                <div class="card">
                    <div class="card-body">
 
 
 
                        <div class="row">
                            <div class="col">
                                <center>
                                        <h4>Project List</h4>
                                    </center>
                            </div>
                        </div>
 
                       
 
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
 
                        <div class="row">
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                                SelectCommand="SELECT * FROM [tbl_Project]"></asp:SqlDataSource>
                            <div class="col">
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" 
                                    runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="Pid" HeaderText="Pid" SortExpression="Pid" />
                                        <asp:BoundField DataField="Pname" HeaderText="Pname" SortExpression="Pname" />
                                        <asp:BoundField DataField="Client_name" HeaderText="Client_name" 
                                            SortExpression="Client_name" />
                                        <asp:BoundField DataField="Client_Contact_no" HeaderText="Client_Contact_no" 
                                            SortExpression="Client_Contact_no" />
                                        <asp:BoundField DataField="Budget" HeaderText="Budget" 
                                            SortExpression="Budget" />
                                        <asp:BoundField DataField="Deadlines" HeaderText="Deadlines" 
                                            SortExpression="Deadlines" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
 
 
                    </div>
                </div>
 
 
            </div>
 
        </div>
    </div>
</asp:Content>
