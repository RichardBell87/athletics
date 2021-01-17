/* Navbar-Clouse-Open */
/**************************/
let mainNav = document.getElementById('js-menu');
let navBarToggle = document.getElementById('js-navbar-toggle');

navBarToggle.addEventListener('click', function () {

	mainNav.classList.toggle('active');
});

window.onscroll = function () {
	myFunction()
};

var navbar = document.getElementById("navbar");
var sticky = navbar.offsetTop;


/* Sticky Effect */
/* Gallery */
/**************************/
function myFunction(imgs) {
	/* Sticky Effect */
	/**************************/
	if (window.pageYOffset >= sticky) {
		navbar.classList.add("sticky")
	} else {
		navbar.classList.remove("sticky");
	}
	/* About */
	/**************************/
	//	var expandImgAbout = document.getElementById("expandedImgAbout");
	//	var imgTextAbout = document.getElementById("imgtextAbout");
	//	expandImgAbout.src = imgsAbout.src;
	//	imgTextAbout.innerHTML = imgsAbout.alt;
	//	expandImgAbout.parentElement.style.display = "block";

	/* Gallery */
	/**************************/
	var expandImg = document.getElementById("expandedImg");
	var imgText = document.getElementById("imgtext");
	expandImg.src = imgs.src;
	imgText.innerHTML = imgs.alt;
	expandImg.parentElement.style.display = "block";
}

