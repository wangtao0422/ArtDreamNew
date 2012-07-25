/// <reference path="../jquery.js" />
/// <reference path="../jquery-1.5.1-vsdoc.js" />

$(document).ready(function () {
    var _manager = new TeacherManager();
    _manager.Init();
});
var TeacherManager = function () {
};

TeacherManager.prototype.GetInstance = function () {
    var manager = this;
    return manager;
};

TeacherManager.prototype.Init = function () {
    $('#teacherNav').addClass('active');
};