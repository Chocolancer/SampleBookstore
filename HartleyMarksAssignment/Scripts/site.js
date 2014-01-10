var timeout;

$(document).ready(function () {
    $('#buy-status').hide();
});

$('.buy-item').click(function (event) {
    var form = $(event.target).parents('div[class=modal-content]'),
        url = "/Home/BuyItem?itemTitle=" + form.find('input[name=ItemTitle]').val() + "&creditCardNo=" + form.find('input[name=CreditCardNo]').val();

    $('input[type=text]').val("");
    $('.close').click();

    $.get(url, function (msg) {
        var statusBar = $('#buy-status');

        statusBar.html(msg);
        statusBar.attr({ class: 'alert alert-success' });
        statusBar.show(500);

        if (timeout !== null) {
            clearTimeout(timeout);
        }

        timeout = setTimeout(function () {
            statusBar.hide(500);
        }, 3000);
    });
});