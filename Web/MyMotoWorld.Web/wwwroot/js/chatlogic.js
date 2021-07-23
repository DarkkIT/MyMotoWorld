var connection =
    new signalR.HubConnectionBuilder()
        .withUrl("/chathub")
        .build();

connection.on("ReceiveMessage",
    function (response) {
        console.log(response);

        var chatInfo = `<div>[${response.user}][${(response.date)}] ${escapeHtml(response.message)}</div>`;

        console.log('Response:')
        console.log(chatInfo)
        

        $("#divChatWindow").append(chatInfo);
    });

$("#sendButton").click(function () {

    var userid = $("#sendButton").attr("data-userid");

    console.log("insideInvokeMetod");

    var content = $("#messageInput").val();

    let data = { content: content, userid: userid };

    console.log(data);

    connection.invoke("Send", data);
    $("#messageInput").val("");
});

connection.start().catch(function (err) {
    return console.error(err.toString());
});
function escapeHtml(unsafe) {
    return unsafe
        .replace(/&/g, "&amp;")
        .replace(/</g, "&lt;")
        .replace(/>/g, "&gt;")
        .replace(/"/g, "&quot;")
        .replace(/'/g, "&#039;");
}