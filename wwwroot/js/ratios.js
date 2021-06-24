// change default view
var view = document.querySelectorAll('.items-details');

var radio = document.querySelectorAll('aside .form-check-input');
radio.forEach(r => {
    r.addEventListener('click', e => {
        let val = 12 / e.target.value;
        let style;

        let regex = SizeRegex();
        let pageAbbr = regex[0];
        let re = regex[1];
        style = "col-" + pageAbbr + "-" + val;

        view.forEach(v => {
            v.classList.remove(v.classList.toString().match(re));
            v.classList.add(style);
        });

    })
});

//change ratios on pageLoad
window.onload = CheckRatio();

//change rations on windowResize
window.addEventListener("resize", () => {
    let re = SizeRegex()[1];
    let size = Array.from(document.querySelector('.items-details').classList).filter(c => c.match(re)).toString().split("-");
    let value = 12 / parseInt(size[2]);

    let columns = parseInt(document.querySelector('aside .form-check-input:checked').value);
    if (columns != value) {
        document.querySelectorAll('aside .form-check-input[checked="checked"]').forEach(f => f.checked = false);
        document.querySelector(`aside .form-check-input[value="${value}"]`).checked = true;
    }

});

function CheckRatio() {
    let windowWidth = window.innerWidth;
    if (document.querySelector('aside .form-check-input')) {
        if (windowWidth >= 1400)
            document.querySelector('aside .form-check-input[value="4"]').checked = true;
        else if (windowWidth >= 992)
            document.querySelector('aside .form-check-input[value="3"]').checked = true;
        else
            document.querySelector('aside .form-check-input[value="2"]').checked = true;
    }
}

function SizeRegex() {
    let pageSize = window.innerWidth;
    let pageAbbr;
    if (pageSize >= 1400)
        pageAbbr = 'xxl';
    else if (pageSize >= 992)
        pageAbbr = 'lg';
    else
        pageAbbr = 'sm';
    let re = new RegExp("col-" + pageAbbr + "-\\d\\d?", "g");
    return [pageAbbr, re];
}
