var dropZone;
// Initializes the dropZone
$(document).ready(function () {
    dropZone = $('#dropZone');
    var eventId = $('input#eventId').val();

    dropZone.removeClass('error');
    // Check if window.FileReader exists to make
    // sure the browser supports file uploads
    if (typeof(window.FileReader) == 'undefined') {
        dropZone.text('Browser Not Supported!');
        dropZone.addClass('error');
        return;
    }
    // Add a nice drag effect
    dropZone[0].ondragover = function () {
        dropZone.addClass('hover');
        return false;
    };
    // Remove the drag effect when stopping our drag
    dropZone[0].ondragend = function () {
        dropZone.removeClass('hover');
        return false;
    };
    // The drop event handles the file sending
    dropZone[0].ondrop = function(event) {
        // Stop the browser from opening the file in the window
        event.preventDefault();
        dropZone.removeClass('hover');
        // Get the file and the file reader
        var file = event.dataTransfer.files[0];
        if (!file.type.match('image.*'))
        {
            alert("Можно загружать только изображения!");
            return;
        }
        // Send the file
        var xhr = new XMLHttpRequest();
        xhr.upload.addEventListener('progress', uploadProgress, false);
        xhr.onreadystatechange = stateChange;
        xhr.open('POST', '/Events/ImagesUpload/' + eventId, true);
        xhr.setRequestHeader('X-FILE-NAME', file.name);
        xhr.send(file);
        /*$.ajax(
        {
            type: 'POST',
            url: "/Events/ImagesUpload/@Model.EventId",
            data:
            {
                image: "hi"
            },
            success: function (responseData, textStatus, jqXHR) {
                location.reload();
            },
            error: function (responseData, textStatus, errorThrown) {
                alert(responseData);
            }
        })*/
        };
});
// Show the upload progress
function uploadProgress(event) {
    var percent = parseInt(event.loaded / event.total * 100);
    $('#dropZone').text('Uploading: ' + percent + '%');
}
// Show upload complete or upload failed depending on result
function stateChange(event) {
    if (event.target.readyState == 4) {
        if (event.target.status == 200) {
            $('#dropZone').text('Upload Complete!');
            location.reload();
        }
        else {
            dropZone.text('Upload Failed!');
            dropZone.addClass('error');
        }
    }
}