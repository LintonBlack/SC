function cartCtrl($scope) {
    var viewModel = this;


    //Remove product
    viewModel.removeProduct = function ($event) {
        var ProductId = $event.target.attributes.data.value;

        // Perform the ajax post
        $.post("/ShoppingCart/RemoveFromCart", { "id": ProductId },
            function (data) {
                location.reload();
            })
    }


}

app.controller("cartCtrl", cartCtrl);

cartCtrl.$inject = ['$scope'];