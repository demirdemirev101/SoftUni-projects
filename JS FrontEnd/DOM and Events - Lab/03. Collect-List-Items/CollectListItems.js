function extractText() {
    const array=Array.from(document.querySelectorAll("ul#items li"));
    let textArea=document.querySelector("#result");

    for (const element of array) {
        textArea.value+=element.textContent+'\n';
    }
}