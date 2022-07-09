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
 
    $scope.EditStudent = function () {
        
        if ($scope.password == $scope.comfirmPassword) {
            $http.post('https://localhost:44300/api/Students/CreateStudent', JSON.stringify(body)).then(function (response) {
                if (response.data)
                    toastr.success('Đã thêm một dữ liệu mới', 'Thành công');
            });
        }
        else {
            toastr.error('Vui lòng thử lại.', 'Mật khẩu không khớp!');
        }
    }
    $scope.AddStudent = function () {
        
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
            $http.post('https://localhost:44300/api/Students/CreateStudent', JSON.stringify(body)).then(function (response) {
                if (response.data)
                    toastr.success('Đã thêm một dữ liệu mới', 'Thành công');
            });
        }
        else {
            toastr.error('Vui lòng thử lại.', 'Mật khẩu không khớp!');
        }
    }
}]);

var app = angular.module('myApp2', []);
app.controller('studentCtrl2', ['$scope', '$http', function ($scope, $http) {
    $scope.listStudents = [];
    $scope.totalStudent = "";
    $http({
        method: "GET",
        url: "https://localhost:44300/api/Students/GetAllStudents"
    }).then(function (response) {
        $scope.listStudents = response.data.data;
        $scope.totalStudent = response.data.total;
    });
}]);