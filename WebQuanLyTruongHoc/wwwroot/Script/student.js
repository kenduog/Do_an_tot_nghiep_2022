var app = angular.module('myApp', ['toastr']);
app.controller('studentCtrl', ['$scope', '$http', 'toastr', function ($scope, $http, toastr) {

    $scope.firstName = "";
    $scope.lastName = "";
    $scope.birthDate = "";
    $scope.address = "";
    $scope.phone = "";
    $scope.process = "";
    $scope.userName = "";
    $scope.password = "";
    $scope.comfirmPassword = "";
    $scope.status = "";

    $scope.AddStudent = function () {
        debugger
        if ($scope.firstName != "" && $scope.lastName != "" && $scope.birthDate != "" && $scope.userName != "" && $scope.password != "") {
            if ($scope.password == $scope.comfirmPassword) {
                var body = {
                    "firstName": $scope.firstName,
                    "lastName": $scope.lastName,
                    "birthDate": $scope.birthDate,
                    "address": $scope.address,
                    "phone": $scope.phone,
                    "process": $scope.process,
                    "userName": $scope.userName,
                    "password": $scope.password
                }
                $http.post('https://localhost:44300/api/Students/CreateorUpdateStudent', JSON.stringify(body)).then(function (response) {
                    if (response.data) {
                        toastr.success('Đã thêm một dữ liệu mới', 'Thành công');
                        $scope.firstName = "";
                        $scope.lastName = "";
                        $scope.birthDate = "";
                        $scope.address = "";
                        $scope.phone = "";
                        $scope.process = "";
                        $scope.userName = "";
                        $scope.password = "";
                        $scope.comfirmPassword = "";
                        $scope.status = "";
                    }
                    else
                        toastr.error('Vui lòng thử lại.', 'Thêm thất bại!');
                });
            }
            else {
                toastr.error('Vui lòng thử lại.', 'Mật khẩu không khớp!');
            }
        }
        else {
            toastr.warning('Vui lòng điền đủ thông tin.', 'Cảnh báo!');
        }
    }
}]);

var app = angular.module('myApp2', []);
app.controller('studentCtrl2', ['$scope', '$http', function ($scope, $http) {
    $http({
        method: "GET",
        url: "https://localhost:44300/api/Students/GetAllStudents"
    }).then(function (response) {
        $scope.listStudents = response.data.data;
        $scope.totalStudent = response.data.total;
    });
    $scope.ID = "";
    $scope.GetIdStudent = function (id) {
        if (id != null) {
            $scope.ID = id;
        }
    }
    $scope.DelteteStudent = function () {
        if ($scope.ID != null) {
            $http.delete('https://localhost:44300/api/Students/DeleteStudentsEntity/' + $scope.ID).then(function (response) {
                $http({
                    method: "GET",
                    url: "https://localhost:44300/api/Students/GetAllStudents"
                }).then(function (response) {
                    $scope.listStudents = response.data.data;
                    $scope.totalStudent = response.data.total;
                });
            });
        }
    };
    $scope.listStudentDetail = [];
    if ($scope.ID != null || $scope.ID != "") {
        debugger
        var bodyGetByStudentID = {
            "StudentID": $scope.ID
        }
        $http.post('https://localhost:44300/api/Students/GetStudentByID', JSON.stringify(bodyGetByStudentID)).then(function (response) {
            $scope.listStudentDetail = response.data.data;
        });
    };
}]);