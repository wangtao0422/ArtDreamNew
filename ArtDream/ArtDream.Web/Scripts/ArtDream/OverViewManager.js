/// <reference path="../jquery.js" />
/// <reference path="../jquery-1.5.1-vsdoc.js" />

$(document).ready(function () {
    var overViewManager = new OverViewManager();
    overViewManager.Init();
});

var OverViewManager = function () {
}

OverViewManager.prototype.GetInstance = function () {
    return this;
}

OverViewManager.prototype.Init = function () {

    $('#homeNav').addClass("active");
    $('.carousel').carousel({
        interval: 2000
    });

    $('#events_slides').slides({
        play: 5000,
        pause: 2500,
        hoverPause: true
    });
}


