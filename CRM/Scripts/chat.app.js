var app = angular.module('chatApp', ['firebase']);

app.controller('chatController', ['$scope', 'Message', function ($scope, Message) {

	$scope.user = "Guest";

	$scope.messages = Message.all;

	$scope.inserisci = function (message) {
		if (message.text.trim() !== "") {
			Message.create(message);
			$scope.newmessage.text = "";
		}
    };

    var ref = firebase.database().ref();
    ref.child('messages').orderByChild('user').on('child_added', function (ref) {
        if (ref.val().user != $scope.newmessage.user) {
            var audio = new Audio('https://notificationsounds.com/soundfiles/a5bfc9e07964f8dddeb95fc584cd965d/file-sounds-741-thrown.mp3');
            audio.play();
        }
    });
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

app.directive('ngEnter', function () {
	return function (scope, element, attrs) {
		element.bind("keydown keypress", function (event) {
			if (event.which === 13) {
				scope.$apply(function () {
					scope.$eval(attrs.ngEnter);
				});

				event.preventDefault();
			}
		});
	};
});

app.directive('scrollBottom', function () {
    return {
        scope: {
            scrollBottom: "="
        },
        link: function (scope, element) {
            scope.$watchCollection('scrollBottom', function (newValue) {
                if (newValue) {
                    $(element).scrollTop($(element)[0].scrollHeight);
                }
            });
        }
    }
})