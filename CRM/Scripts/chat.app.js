var app = angular.module('chatApp', ['firebase']);

app.controller('chatController', ['$scope', 'Message', function ($scope, Message) {

    $scope.user = "Guest";

    $scope.messages = Message.all;

    $scope.inserisci = function (message) {
        Message.create(message);
    };
}]);


app.factory('Message', ['$firebaseObject', '$firebaseArray',
	function ($firebaseObject, $firebaseArray) {
	    var ref = firebase.database().ref();
	    var messages = $firebaseArray(ref.child('messages'));
 
		var Message = {
			all: messages,
			create: function (message) {
				return messages.$add(message);
			},
			get: function (messageId) {
			    return $firebaseObject(ref.child('messages').child(messageId));
			},
			delete: function (message) {
				return messages.$remove(message);
			}
		};
 
		return Message;
 
	}
	]);