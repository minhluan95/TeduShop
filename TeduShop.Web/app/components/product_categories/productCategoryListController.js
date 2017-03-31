(function (app) {
    app.controller('productCategoryListController', productCategoryListController);

    productCategoryListController.$inject = ['$scope','apiService'];

    function productCategoryListController($scope, apiService) {
        $scope.productCategoryListController = [];

        $scope.getProductCategories = getProductCategories;

        function getProductCategories()
        {
            apiService.get('/api/productcategory/getall', null, function (result) {
                $scope.getProductCategories = result.data;
            }, function () {
                console.log('Load productcategory failed.');
            });
        }
        $scope.getProductCategories();

    }
})(angular.module('tedushop.product_categories'));