
/// <reference path="../jquery.js" />
/// <reference path="../jquery-1.5.1-vsdoc.js" />

$(document).ready(function () {
    var _manager = new NoticeManager();
    _manager.Init();
});

var NoticeManager = function () {
};

NoticeManager.prototype.GetInstance = function () {
    var manager = this;
    return manager;
};

NoticeManager.prototype.Init = function () {
    $('#noticeNav').addClass('active');
};