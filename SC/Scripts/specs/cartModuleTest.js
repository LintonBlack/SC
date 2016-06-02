/// <reference path="../angular.js" />
/// <reference path="../angular-mocks.js" />
/// <reference path="../jasmine/jasmine.js" />
/// <reference path="../ShoppingCart/app.js" />
/// <reference path="../ShoppingCart/controllers/cart.js" />


describe('cartModule', function () {
    beforeEach(module('app'));

    describe('cartModuleCtrl', function () {

        var scope, controller;

        // Dependency Injection
        beforeEach(inject(function ($rootScope, $controller) {
            scope = $rootScope.$new();
            
            controller = $controller('cartCtrl', {
                 $scope : scope
            })
        }));



        //
        it('It should return the sum of two values', function() {

        //Act
        var result = scope.sum(10,20);

        //Expect
        expect(result).toEqual(30);
    })
    })
})