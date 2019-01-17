
this.GetEmployees = function () {
    $.ajax({
        url: "/Home/LoadData",
        type: "POST",
        dataType: "JSON",
        data: { data: document.getElementById('txtid').value },
        success: function (data) {
            var elmtTable = document.getElementById('Resultados');
            elmtTable.innerHTML = "";
            var event_data = '';
            event_data += '<table class="table" id="Resultados">'
            event_data += '<tr>';
            event_data += '<th>Id</th>';
            event_data += '<th>Name</th>';
            event_data += '<th>Contract Type Name</th>';
            event_data += '<th>Role Id</th>';
            event_data += '<th>Role Name</th>';
            event_data += '<th>Role Description</th>';
            event_data += '<th>Annual Salary</th>';

            if (data != null) {
                $.each(data, function (index, value) {


                    event_data += '<tr>';
                    event_data += '<td>' + value.Id + '</td>';
                    event_data += '<td>' + value.Name + '</td>';
                    event_data += '<td>' + value.ContractTypeName + '</td>';
                    event_data += '<td>' + value.RoleId + '</td>';
                    event_data += '<td>' + value.RoleName + '</td>';
                    event_data += '<td>' + value.RoleDescription + '</td>';
                    event_data += '<td>' + value.AnnualSalary + '</td>';
                    event_data += '<tr>';
                });
                $("#Resultados").append(event_data);
            } 
        }
    })
}

