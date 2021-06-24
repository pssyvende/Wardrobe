function send(e) {
    //console.log(e.value);
    document.querySelector('form#selectSize a').classList.remove('disabled');
    var num = "size=" + e.value;
    document.querySelector("#selectSize a").href = document.querySelector("#selectSize a").href.replace("size=0", num);
    var regex = /id=\d/;
    var odlId = document.querySelector("#selectSize a").href.match(regex)[0];
    var id = odlId + e.value;
    document.querySelector("#selectSize a").href = document.querySelector("#selectSize a").href.replace(regex, id);
}

