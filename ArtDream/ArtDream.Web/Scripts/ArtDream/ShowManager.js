
/// <reference path="../jquery.js" />
/// <reference path="../jquery-1.5.1-vsdoc.js" />

$(document).ready(function () {
    var _manager = new ShowManager();
    _manager.Init();
});

var ShowManager = function () {
};

ShowManager.prototype.GetInstance = function () {
    var manager = this;
    return manager;
};

ShowManager.prototype.Init = function () {
    $('#showNav').addClass('active');
};