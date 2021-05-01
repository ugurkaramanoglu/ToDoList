$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "https://localhost:44303/home/getalltodolist",
        datatype: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {

            $("#tablo").DataTable({
                pageLength: 5,
                lengthMenu: [[5, 10, 20, -1], [5, 10, 20, 'Tümü']],
                "order": [[2, "desc"]],
                data: data,
                "columns": [

                    { data: "description", "autoWidth": true },
                    { data: "createdShortDate", "autoWidth": true },
                    { data: "updatedShortDate", "autowidth": true, },
                    {
                        "render": function (data, type, row) {
                            return "<a href='#' class='btn btn-danger' onclick=GetToDoId('" + row.id + "') data-toggle='modal' data-target='#UpdateToDoListModal' >UPDATE</a>";
                        }
                    },

                    {
                        "render": function (data, type, row) {
                            return "<a href='#' class='btn btn-danger' onclick=DeleteToDoList('" + row.id + "') >DELETE</a>";
                        }
                    }
                ]

            });
        }
    }); 

   

});

$("#AddToDoButton").click(function () {
    var ToDoDesc = $("#ToDoDesc").val();

    $.ajax({
        type: "POST",
        url: "https://localhost:44303/home/addtodolist",
        datatype: "json",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ 'Description': ToDoDesc }),
        success: function (data) {
            window.location.reload();

        }
    });
});

$("#AddToDoButton").click(function () {
    var ToDoDesc = $("#ToDoDesc").val();   

    $.ajax({
        type: "POST",
        url: "https://localhost:44303/home/addtodolist",
        datatype: "json",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ 'Description': ToDoDesc }),
        success: function (data) {
            window.location.reload();
            
        }
    });
});

$("#UpdateToDoButton").click(function () {
    var Id = Number($("#AddToDo").val());
    var desc = $("#descToDo").val();   

    $.ajax({
        type: "POST",
        url: "https://localhost:44303/home/updatetodolist",
        datatype: "json",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ 'Description': desc , 'Id': Id  }),
        success: function (data) {
            window.location.reload();
            
        }
    });
});

function GetToDoId(id) {
    $("#AddToDo").val(id);

}


function DeleteToDoList(id) {
    var Id = Number(id);
    $.ajax({
        type: "POST",
        url: "https://localhost:44303/home/deletetodolist",
        datatype: "json",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ 'Id': Id }),
        success: function (data) {
            window.location.reload();
            console.log("ready!");
        }
    });
    
}