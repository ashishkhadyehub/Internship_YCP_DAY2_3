// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('#tableEmployees').DataTable({
        dom: 'lBfrtip',
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print', 'colvis'
        ],
        "scrollY": "450px",
        "scrollCollapse": true,
        "paging": true
    });
});

//$(document).ready(function () {
//    $('#tableJobs,#tableApplications,#tableEnquiryData').DataTable({
//        dom: 'lBfrtip',
//        buttons: [
//            'copy', 'csv', 'excel', 'pdf', 'print', 'colvis'
//        ],
//        "scrollY": "450px",
//        "scrollCollapse": true,
//        "paging": true
//    });

//    $('#tableProjects').DataTable({

//        "scrollY": "450px",
//        "scrollCollapse": true,
//        "paging": true
//    });
//});

/*https://datatables.net/*/