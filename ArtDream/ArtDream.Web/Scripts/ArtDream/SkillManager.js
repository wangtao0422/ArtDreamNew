/// <reference path="../jquery.js" />
/// <reference path="../jquery-1.5.1-vsdoc.js" />

$(document).ready(function () {
    var _manager = new SkillManager();
    _manager.Init();
});

var SkillManager = function () {
};

SkillManager.prototype.GetInstance = function () {
    var manager = this;
    return manager;
};

SkillManager.prototype.Init = function () {
    $('#skillNav').addClass('active');
};