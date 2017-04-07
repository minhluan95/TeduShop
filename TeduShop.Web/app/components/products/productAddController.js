(function (app) {
    app.controller('productAddController', productAddController);

    productAddController.$inject = ['apiService', '$scope', 'notificationService', '$state', 'commonService'];
    function productAddController(apiService, $scope, notificationService, $state, commonService) {
        $scope.product =
        {
            CreatedDate: new Date(),
            Status: true
        }
        $scope.AddProduct = AddProduct;
        function AddProduct() {
            apiService.post('api/product/create', $scope.product,
                function (result) {
                    notificationService.displaySuccess(result.data.Name + ' đã được thêm mới');
                    $state.go('products');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công');
                });
        }

        $scope.GetSeoTitle = GetSeoTitle;
        function GetSeoTitle() {
            $scope.product.Alias = commonService.getSeoTitle($scope.product.Name);
        }

        $scope.parentCategories = [];

        function loadCategory() {
            apiService.get('api/productcategory/getallparents', null, function (result) {
                $scope.parentCategories = result.data;
            }, function () {
                console.log('Cannot get list parent');
            });
        }
        $scope.editorOptions = {
            language: 'vi',
            //uiColor: '#000000',
            height: '200px'
        };

        $scope.ChooseImage = function()
        {
            var finder = new CKFinder();
            finder.selectActionFunction =function(fileUrl)
            {
                $scope.product.Image = fileUrl;
            }
            finder.popup();
        }

    loadCategory();
}
})(angular.module('tedushop.products'));