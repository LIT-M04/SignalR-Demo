$(function () {
    var simpleHub = $.connection.simpleHub;
    $.connection.hub.start();

    simpleHub.client.newMessageReceived = function(result) {
        $("ul").append("<li>" + result.message + " at: " + result.time + "</li>");
    }

    $('.btn').on('click', function() {
        $.post("/home/message", { message: $("#message").val() });
        $("#message").val('');
    });

});