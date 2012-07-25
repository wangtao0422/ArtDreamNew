/// <reference path="../jquery.js" />
/// <reference path="../jquery-1.5.1-vsdoc.js" />
var _articleManager
$(document).ready(function () {
    _articleManager = new ArticleManager();
    _articleManager.Init();
});

var ArticleManager = function () {
};

ArticleManager.prototype.Init = function () {
    $('#articleNav').addClass("active");
};

ArticleManager.prototype.ConfirmDelete = function (id) {
    this.deleteId = id;
    $('#confirmDeleteArticle').modal('show');
};

ArticleManager.prototype.ShowEditor = function (id) {
    $("#SaveStateInfo").html('');
    $.get("/Admin/ArticleEditor", "id=" + id, function (html) {
        $("#articleEditorPanel").html(html);
        if (id == 0) {
            $("#articleEditorPanel .modal-header h3").text("创建文章");
        }
        $('#articleEditorPanel').modal('show');
    });
};