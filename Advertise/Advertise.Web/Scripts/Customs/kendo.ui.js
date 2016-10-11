

$(function () {
    // جهت استفاده از فایل: kendo.culture.fa-IR.js
    kendo.culture("fa-IR");
    
         var getCategoryList = new kendo.data.HierarchicalDataSource({
            transport: {
                read: {
                    url: "/Category/GetCategoryList",
                    dataType: "json",
                    contentType: "application/json; charset=utf-8",
                    type: "GET"
                }
            },
            schema: {
                model: {
                    id: "Id",
                    hasChildren: true
                }
            }
        });
       
   
    /////////////////////////////////////////////////////////////////////////////////////////////////////


    $("#getCategoryList").kendoTreeView({
        //استفاده از قالب در صورت نیاز
        //template: kendo.template($("#treeview-template").html()),
        //checkboxes: {
        //    checkChildren: false
        //},
        dataSource: getCategoryList,
        dataTextField: "Title",
        dataValueField: "Id",
        animation: {
            expand: {
                effects: "fadeIn expandVertical"
            },
            collapse: {
                effects: "fadeOut collapseVertical"
            }
        },
        messages: {
            retry: "سعی مجدد",
            requestFailed: "درخواست نامعتبر",
            loading: "بارگذاری..."
        },
        //رخدادها
        select:
            //function (e){document.getElementById("ParentId").value = this.text(e.node)  } 
            function(e) {
                console.log("Selecting: " + this.text(e.node));
                document.getElementById("ParentId").value = $("#getCategoryList").getKendoTreeView().dataItem(e.node).id;
                //console.log("Selecting: " + id);
            },
        check: function(e) { console.log("Checkbox changed :: " + this.text(e.node)); },
        change: function(e) { console.log("Selection changed"); },
        collapse: function(e) { console.log("Collapsing " + this.text(e.node)); },
        expand: function(e) { console.log("Expanding " + this.text(e.node)); }
    });

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////
    $("#Body").kendoEditor({
                tools: [
                    "bold", "italic", "underline", "strikethrough", "justifyLeft",
                    "justifyCenter", "justifyRight", "justifyFull", "insertUnorderedList",
                    "insertOrderedList", "indent", "outdent", "createLink", "unlink",
                    "insertImage", "insertFile",
                    "subscript", "superscript", "createTable", "addRowAbove", "addRowBelow",
                    "addColumnLeft", "addColumnRight", "deleteRow", "deleteColumn", "viewHtml",
                    "formatting", "cleanFormatting", "fontName", "fontSize", "foreColor",
                    "backColor", "print"
                ],
                encoded: false,
                imageBrowser: {
                    messages: {
                        dropFilesHere: "فایل‌های خود را به اینجا کشیده و رها کنید"
                    },
                    transport: {
                        read: {
                            url: "/KendoEditorImages/GetFilesList",
                            dataType: "json",
                            contentType: 'application/json; charset=utf-8',
                            type: 'GET',
                            cache: false
                        },
                        destroy: {
                            url: "/KendoEditorImages/DestroyFile",
                            type: "POST"
                        },
                        create: {
                            url: "/KendoEditorImages/CreateFolder",
                            type: "POST"
                        },
                        thumbnailUrl: "/KendoEditorImages/GetThumbnail",
                        uploadUrl: "/KendoEditorImages/UploadFile",
                        imageUrl: "/KendoEditorImages/GetFile?path={0}"
                    }
                },
                fileBrowser: {
                    messages: {
                        dropFilesHere: "فایل‌های خود را به اینجا کشیده و رها کنید"
                    },
                    transport: {
                        read: {
                            url: "/KendoEditorFiles/GetFilesList",
                            dataType: "json",
                            contentType: 'application/json; charset=utf-8',
                            type: 'GET',
                            cache: false
                        },
                        destroy: {
                            url: "/KendoEditorFiles/DestroyFile",
                            type: "POST"
                        },
                        create: {
                            url: "/KendoEditorFiles/CreateFolder",
                            type: "POST"
                        },
                        uploadUrl: "/KendoEditorFiles/UploadFile",
                        fileUrl: "/KendoEditorFiles/GetFile?path={0}"
                    }
                }
    });



    //////////////////////////////////////////////////////////////////////////////////////////////////////////

    $("#ImageFileName").kendoUpload({
        name: "files",
//        @*async: { // async configuration
//            saveUrl: "@Url.Action("Save", "KendoFileUpload")", // the url to save a file is '/save'
//        removeUrl: "@Url.Action("Remove", "KendoFileUpload")", // the url to remove a file is '/remove'
//        autoUpload: false, // automatically upload files once selected
//    removeVerb: 'POST'
//},*@
    multiple: false,
showFileList: true,
localization: {
    select: 'انتخاب فایل‌',
    remove: 'حذف فایل',
    retry: 'سعی مجدد',
    headerStatusUploading: 'در حال ارسال فایل‌ها',
    headerStatusUploaded: 'پایان ارسال',
    cancel: "لغو",
    uploadSelectedFiles: "ارسال فایل‌ها",
    dropFilesHere: "فایل‌ها را برای ارسال، کشیده و در اینجا رها کنید",
    statusUploading: "در حال ارسال",
    statusUploaded: "ارسال شد",
    statusWarning: "اخطار",
    statusFailed: "خطا در ارسال"
},
// template: kendo.template($('#fileListTemplate').html()),
select: function (e) {
    var fileReader = new FileReader();
    fileReader.onload = function (event) {
        console.log(event);
        var mapImage = event.target.result;
        $("#ImagePreview").attr('src', mapImage);

    }
    fileReader.readAsDataURL(e.files[0].rawFile);

},
remove: function () {
    $("#ImagePreview").attr('src', '/Files/Avatar/no-preview.png');
    console.log('File removed.');
}
});

/////////////////////////////////////////////////////////////////////////////////////////////////////

});





