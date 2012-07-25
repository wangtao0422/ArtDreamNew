/// <reference path="../jquery.js" />
/// <reference path="../jquery-1.5.1-vsdoc.js" />

$(document).ready(function () {
    var _manager = new EventManager();
    _manager.Init();
});

var EventManager = function () {
};

EventManager.prototype.GetInstance = function () {
    var manager = this;
    return manager;
};

EventManager.prototype.Init = function () {
    $('#eventNav').addClass("active");
};