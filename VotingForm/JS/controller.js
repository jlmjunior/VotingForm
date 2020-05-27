function CopyLink() {
    var copyText = document.getElementById("pollLink");

    copyText.select();

    document.execCommand("copy");
}