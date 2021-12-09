<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="HR_MANAGMENT_SYSTEM.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <section>
      <img src="image/HumanResource%20main%20image.png"  class="img-fluid" width="100%"  />
   </section>
    <section>
      <div class="container">
         <div class="row">
            <div class="col-12">
               <center>
                  <h2>Our Features</h2>
                  <p><b>Our 3 Primary Features -</b></p>
               </center>
            </div>
         </div>
         <div class="row">
            <div class="col-md-4">
               <center>
                    <img width="150px" src="image/manage%20Employee.png"/>
                  
                  <h4>Manage Employee</h4>
                  <p class="text-justify"></p>
               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <img width="150px" src="image/Manage%20Project.jpg"/>
                  <h4>Manage Project</h4>
                  <p class="text-justify"></p>
               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <img width="130px" src="image/paycheck-payroll-services-icon-32.png" />
                  <h4>Manage  Attendance information</h4>
                  <p class="text-justify"></p>
               </center>
            </div>
         </div>
      </div>
   </section>

</asp:Content>
