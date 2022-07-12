var app = angular.module('myApp', ['toastr']);
app.controller('classroomCtrl', ['$scope', '$http', 'toastr', function ($scope, $http, toastr) {

    $scope.grande = "";
    $scope.key = "";
    $scope.order = "";
    $scope.teacherId = "";
    $scope.year = "";

    $scope.AddClassroom = function () {
        if ($scope.grande != "" && $scope.key != "" && $scope.order != "" && $scope.teacherId != "" && $scope.year != "") {
                var body = {
                    "grande": $scope.grande,
                    "key": $scope.key,
                    "order": $scope.order,
                    "teacherId": $scope.teacherId,
                    "year": $scope.year                }
            $http.post('https://localhost:44300/api/Classroom/CreateOrUpdateClassroom', JSON.stringify(body)).then(function (response) {
                    if (response.data) {
                        toastr.success('Đã thêm một dữ liệu mới', 'Thành công');
                        $scope.grande = "";
                        $scope.key = "";
                        $scope.order = "";
                        $scope.teacherId = "";
                        $scope.year = "";
                    }
                    else
                        toastr.error('Vui lòng thử lại.', 'Thêm thất bại!');
                });
            }
        else {
            toastr.warning('Vui lòng điền đủ thông tin.', 'Cảnh báo!');
        }
    }
}]);

var app = angular.module('myApp2', []);
app.controller('classroomCtrl2', ['$scope', '$http', function ($scope, $http) {
    $http({
        method: "GET",
        url: "https://localhost:44300/api/Classroom/GetClassroom"
    }).then(function (response) {
        $scope.listClassrooms = response.data.data;
        $scope.totalClassroom = response.data.total;
    });
    //$scope.ID = "";
    //$scope.GetIdDel = function (id) {
    //    if (id != null) {
    //        $scope.ID = id;
    //    }
    //}
    //$scope.DelteteStudent = function () {
    //    if ($scope.ID != null) {
    //        $http.delete('https://localhost:44300/api/Students/DeleteStudentsEntity/' + $scope.ID).then(function (response) {
    //            $http({
    //                method: "GET",
    //                url: "https://localhost:44300/api/Students/GetAllStudents"
    //            }).then(function (response) {
    //                $scope.listStudents = response.data.data;
    //                $scope.totalStudent = response.data.total;
    //            });
    //        });
    //    }
    //};
}]);