// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function uploadfile() {
    var myfile= document.getElementById("myfile");
    var formData = new FormData();

    if (myfile.files.length > 0) {
        for (var i = 0; i < myfile.files.length; i++) {
            formData.append('file-' + i, myfile.files[i]);
        }
    }

    $.ajax({
        url: "/Books/UploadFile/",
        type: "POST",
        dataType: "json",
        data: formData,
        contentType: false,
        processData: false,
        success: function(data){
            $document.getElementById("CoverImage").src = "/Data/Imgs" + data.files.src
        },
        error: function (data) {

        }
     })
 }