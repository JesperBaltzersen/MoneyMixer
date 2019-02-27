// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

//document.getElementById("postinfomemberlabel").setAttribute("display:none");
//document.getElementById("postinfomemberdata").setAttribute("display:none");

// PostInfo
function makeEditable() {
    document.getElementById("postinfomemberdata").setAttribute("contenteditable", "true");
}

// Post Input
function hideShowExtraPostFields() {

}

// get post label width
// set span label to same width

function fixWidthOfValidationSpan() {
    var width = document.getElementById("postinput").offsetWidth;
    var widthStr = "width: " + width.toString() + "px"; //style "width:150px"
    document.getElementById("inputvalidation").setAttribute("style", widthStr);
}

function setNoTextLabelImageUpload() {
    document.getElementById("postinput").classList.remove("imageupload");
}

window.onload = fixWidthOfValidationSpan;
window.onload = setNoTextLabelImageUpload;


