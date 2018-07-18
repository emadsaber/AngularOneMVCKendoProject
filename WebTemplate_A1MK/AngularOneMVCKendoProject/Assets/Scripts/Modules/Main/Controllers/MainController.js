var mainController = mainApp.controller("mainController", function ($scope) {

    $scope.testVar = "10";
    $scope.showHello = function () {
        alert('Hello')
    }
});