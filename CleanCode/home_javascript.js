var login = function () {
	toggle("sign-in");
};

var toggle = function (classToToggle) {
	var elements = document.getElementsByClassName("classToToggle");
	for (var i = 0, j = elements.length; i < j; i++) {
		var style = elements[i].style;
		if (style.display === "block") {
			style.display = "none";
		}
		else if (style.display === "none") {
			style.display = "block";
		}
	}
};