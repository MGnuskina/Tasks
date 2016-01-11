$(function () {

    var game = $.connection.gameHub;
    $.connection.hub.start().done(function () {
        $('#gameForm').ready(function () {
            game.server.send($('#name').val(), $('#Password').val(), $('#gameM'));
        });

        $('#drawCanvas').click(function () {
            game.server.play($("#clickedX").val(), $("#clickedY").val());
        })
    });

    game.client.onMove = function (objectToDraw, drawBrush, points, allUsers) {
        for (i = 0; i < allUsers.length; i++) {
            DrawForUser(objectToDraw,allUsers[i].ConectionId, points);
        }
    }
});

function DrawForUser(objectTODraw, id, points) {
    var userId = $('#hdId').val();

    if (userId != id) {
        var c = document.getElementById("drawCanvas");
        var ctx = c.getContext("2d");
        ctx.beginPath();
        for (var i = 0; i < points.Count; i++) {
            ctx.moveTo(points[i][0], points[i][1]);
            ctx.fillText(objectTODraw, points[i][0], points[i][1]);
            ctx.stroke();
        }
    }
}
