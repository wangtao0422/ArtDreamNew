/// <reference path="../jquery.js" />
/// <reference path="../jquery-1.5.1-vsdoc.js" />

$(document).ready(function () {
    var _manager = new HonoraryTeacherManager();
    _manager.Init();
});

var HonoraryTeacherManager = function () {
};

HonoraryTeacherManager.prototype.GetInstance = function () {
    var manager = this;
    return manager;
};

HonoraryTeacherManager.prototype.Init = function () {
    $('#honoraryTeacherNav').addClass('active');
};