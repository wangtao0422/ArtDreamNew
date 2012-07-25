/// <reference path="../jquery.js" />
/// <reference path="../jquery-1.5.1-vsdoc.js" />

$(document).ready(function () {
    var _manager = new SchoolManager();
    _manager.Init();
});

var SchoolManager = function () {
};

SchoolManager.prototype.GetInstance = function () {
    var manager = this;
    return manager;
};

SchoolManager.prototype.Init = function () {
    $('#schoolNav').addClass('active');
};