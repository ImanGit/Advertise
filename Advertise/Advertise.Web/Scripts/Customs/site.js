function start() {
    $.ajax({
        type: "POST",
        url: "",
        data: data,
        success: success,
        dataType: dataType
    });
}

function getTree() {
    // Some logic to retrieve, or generate tree structure
    return data;
}

$('#tree').treeview({ data: getTree() });