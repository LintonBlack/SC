/// <reference path="../../angular.js" />

function cartCtrl($scope, $http) {
    var viewModel = this;
    viewModel.cartItems = [];
    viewModel.total = 0;
    viewModel.cartDiscount = 0;
    

    //
    $scope.sum = function (valA, valB) {
        return valA+ valB;
    }
    //Get product
    viewModel.allProduct = function () {
        // Perform the ajax post

        $http({
            method: 'GET',
            url: "/ShoppingCart/GetCard"
        }).then(function successCallback(response) {
            // this callback will be called asynchronously
            // when the response is available
            if (response.data) {
                var data = response.data;
                        viewModel.cartTotal = data.CartTotal;
                        viewModel.cartDiscount = data.CartDiscount;
                        viewModel.cartItems = data.CartItems;
            }
        }, function errorCallback(response) {
            // called asynchronously if an error occurs
            // or server returns response with an error status.
        });

    }
    //Remove product
    viewModel.addProduct = function (item) {
        var ProductId = item.Product.ProductId;
        item.Count = item.Count + 1;
        // Perform the ajax post
        $.post("/ShoppingCart/AddToCart", { "id": ProductId },
            function (data) {
                viewModel.allProduct();
            })
    }

    //Remove product
    viewModel.removeProduct = function (item) {
        var ProductId = item.Product.ProductId;
        if (item.Count > 0) {
            item.Count = item.Count - 1;
        };
        // Perform the ajax post
        $.post("/ShoppingCart/RemoveFromCart", { "id": ProductId },
            function (data) {
                viewModel.allProduct();
            })
    }

    viewModel.allProduct();
    console.log(viewModel.cartItems);

}

app.controller("cartCtrl", cartCtrl);

cartCtrl.$inject = ['$scope','$http'];