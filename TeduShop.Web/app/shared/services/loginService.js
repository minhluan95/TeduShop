(function (app) {
    'use strict';
    app.service('loginService', ['$http', '$q', 'authenticationService', 'authData',
    function ($http, $q, authenticationService, authData) {
        var userInfo;
        var deferred;

        this.login = function (userName, password) {
            deferred = $q.defer();
            var data = "grant_type=password&username=" + userName + "&password=" + password;
            $http.post('/oauth/token', data, {
                headers:
                   { 'Content-Type': 'application/x-www-form-urlencoded' }
            }).then(function (response) { //từ angular 1.6 trở lên thì ko xài success nữa nha bạn
                userInfo = {
                    accessToken: response.data.access_token,
                    userName: userName
                };
                authenticationService.setTokenInfo(userInfo);
                authData.authenticationData.IsAuthenticated = true;
                authData.authenticationData.userName = userName;
                // deferred.resolve(null);
                deferred.resolve(userName);
                //đề mình giải thích đoạn này. response.data thì dù đăng nhập đúng hay sai thì nó vẫn trả về 1 dâta
                //nên phải return nnó về kiểu khác để bắt dữ liệu trả về trên loginController. ở đây mình return Username.
                //ban return gì cũn được. miễn sao trên controller bắt đúng giá trị của hàm then thì sẽ login được thôi
            })
            .catch(function (err, status) {
                authData.authenticationData.IsAuthenticated = false;
                authData.authenticationData.userName = "";
                deferred.resolve(err);
            });
            return deferred.promise;
        }

        this.logOut = function () {
            authenticationService.removeToken();
            authData.authenticationData.IsAuthenticated = false;
            authData.authenticationData.userName = "";
        }
    }]);
})(angular.module('tedushop.common'));