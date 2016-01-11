$(function () {

    var users = $.connection.usersHub;
    $.connection.hub.start().done(function () {
        $('#formU').ready(function () {
            $('#discussion').empty();
            users.server.send($('#name').val(), $('#Password').val());
        });
    });


    users.client.onConnected = function (id, userName, allUsers) {
        $("#userName").append('<p><b>' + userName + '</b></p>');
        for (i = 0; i < allUsers.length; i++) {
            AddUser(allUsers[i].ConectionId, allUsers[i].Name);
        }
    }

    users.client.onNewUserConnected = function (id, name) {
        AddUser(id, name);
    }

    users.client.onUserDisconnected = function (id, userName) {
        $('#discussion').empty();
        users.server.send($('#name').val(), $('#Password').val());
    }
});

function AddUser(id, name) {

    var userId = $('#hdId').val();

    if (userId != id) {

        $("#discussion").append('<p id="' + id + '"><b>' + name + '</b></p>');
    }
}