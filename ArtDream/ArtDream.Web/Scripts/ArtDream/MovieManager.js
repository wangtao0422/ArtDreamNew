/// <reference path="../jquery.js" />
/// <reference path="../jquery-1.5.1-vsdoc.js" />

$(document).ready(function () {
    var _manager = new MovieManager();
    _manager.Init();
});

var MovieManager = function () {
};

MovieManager.prototype.GetInstance = function () {
    var manager = this;
    return manager;
};

MovieManager.prototype.Init = function () {
    $('#movieNav').addClass('active');
};