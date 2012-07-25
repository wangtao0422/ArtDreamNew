
/// <reference path="../jquery.js" />
/// <reference path="../jquery-1.5.1-vsdoc.js" />

$(document).ready(function () {
    var _manager = new AmbassadorManager();
    _manager.Init();
});

var AmbassadorManager = function () {
};

AmbassadorManager.prototype.GetInstance = function () {
    var manager = this;
    return manager;
};

AmbassadorManager.prototype.Init = function () {
    $('#ambassadorNav').addClass('active');
};