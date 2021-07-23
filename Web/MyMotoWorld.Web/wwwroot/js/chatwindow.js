document.querySelector(".openChatBtn").addEventListener("click", openForm);
document.querySelector(".close").addEventListener("click", closeForm);
function openForm() {
    document.querySelector(".openChat").style.display = "block";
    document.querySelector(".openChatBtn").style.display = "none";
}
function closeForm() {
    document.querySelector(".openChat").style.display = "none";
    document.querySelector(".openChatBtn").style.display = "block";
}