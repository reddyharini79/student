﻿@model Project2.Student

@{
    ViewBag.Title = "Delete";
}

< h2 > Delete </ h2 >

< h3 > Are you sure you want to delete this?</h3>
<div>
    <h4>Student</h4>
    <hr />
    <dl class= "dl-horizontal" >
        < dt >
            @Html.DisplayNameFor(model => model.studentName)
        </ dt >

        < dd >
            @Html.DisplayFor(model => model.studentName)
 </ dd >

        < dt >
            @Html.DisplayNameFor(model => model.Class.ClassName)
        </ dt >

        < dd >
            @Html.DisplayFor(model => model.Class.ClassName)
        </ dd >

        < dt >
            @Html.DisplayNameFor(model => model.Subject.subjectName)
        </ dt >

        < dd >
            @Html.DisplayFor(model => model.Subject.subjectName)
        </ dd >

    </ dl >

    @using(Html.BeginForm()) {
    @Html.AntiForgeryToken()

    < div class= "form-actions no-color" >

        < input type = "submit" value = "Delete" class= "btn btn-default" /> |
        @Html.ActionLink("Back to List", "Index")
    </ div >
    }
</ div >

