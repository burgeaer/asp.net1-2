(function () {
    var app = angular.module("atTheMovies", ["ngRoute"]);
    var config = function ($routeProvider) {
        $routeProvider
            .when("/list",
                { templateUrl: "/client/views/List.html" })
            .when("/details/:id",
                { templateUrl: "/client/views/details.html" })
            .otherwise(
                { redirectTo: "/list" });
    };
    app.config(config);
    app.constant("movieApiUrl", "/api/movies/");
}());