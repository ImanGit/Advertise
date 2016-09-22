function htmlEncode(value){
  //create a in-memory div, set it's inner text(which jQuery automatically encodes)
  //then grab the encoded contents back out.  The div never exists on the page.
  return $('<div/>').text(value).html().replace(/&/g,'%26');
}

function htmlDecode(value){
  return $('<div/>').html(value).text();
}



$(function () {
    // جهت استفاده از فایل: kendo.culture.fa-IR.js
    kendo.culture("fa-IR");
    
         var getCategoryList = new kendo.data.HierarchicalDataSource({
            transport: {
                read: {
                    url: "GetCategoryList",
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
                $("#Review").kendoEditor({
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
                            url: "",
                            dataType: "json",
                            contentType: 'application/json; charset=utf-8',
                            type: 'GET',
                            cache: false
                        },
                        destroy: {
                            url: "",
                            type: "POST"
                        },
                        create: {
                            url: "",
                            type: "POST"
                        },
                        thumbnailUrl: "",
                        uploadUrl: "",
                        imageUrl: ""
                    }
                },
                fileBrowser: {
                    messages: {
                        dropFilesHere: "فایل‌های خود را به اینجا کشیده و رها کنید"
                    },
                    transport: {
                        read: {
                            url: "",
                            dataType: "json",
                            contentType: 'application/json; charset=utf-8',
                            type: 'GET',
                            cache: false
                        },
                        destroy: {
                            url: "",
                            type: "POST"
                        },
                        create: {
                            url: "",
                            type: "POST"
                        },
                        uploadUrl: "",
                        fileUrl: ""
                    }
                },
                change: function(e) {
                    document.getElementById("Body").value = htmlEncode($("#Review").data("kendoEditor").value().text());
                }
            });
});