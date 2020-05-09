// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

 $(document).ready(function () {
        $("#File").change(function () {
            var formdata = new FormData();
            var _image = $('#files')[0].files[0];
            formdata.append('file', _image);

            $.ajax({
                type: "POST",
                url: "/Books/UploadFile",
                data: formdata,
                async: true,
                cache: false,
                contentType: false,
                processData: false,
                success: function (result) {document.getElementById('ImgCv').src= result;},
                error: function (result) { console.log(result); }
            });

        });
    });
