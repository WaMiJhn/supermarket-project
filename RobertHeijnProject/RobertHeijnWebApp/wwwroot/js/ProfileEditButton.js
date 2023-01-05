document.getElementById('editbtn').addEventListener('click', function () {
    document.getElementById('editbtn').style.display = 'none';
    document.getElementById('savebtn').style.display = 'inline-block';

    var elements = document.getElementsByClassName('userdata');
    for (var i = 0; i < elements.length; i++) {
        elements[i].style.display = 'none';
    }

    elements = document.getElementsByClassName('editdata');
    for (var i = 0; i < elements.length; i++) {
        elements[i].style.display = 'inline-block';
    }
});
