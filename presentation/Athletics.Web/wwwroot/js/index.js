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

/* Sticky Effect */
/**************************/
var navbar = document.getElementById("navbar");
var sticky = navbar.offsetTop;

function myFunction(imgs) {
	
	if (window.pageYOffset >= sticky) {
		navbar.classList.add("sticky")
	} else {
		navbar.classList.remove("sticky");
	}

	/* About-Gallery */
	/**************************/
	//	var expandImgAbout = document.getElementById("expandedImgAbout");
	//	var imgTextAbout = document.getElementById("imgtextAbout");
	//	expandImgAbout.src = imgsAbout.src;
	//	imgTextAbout.innerHTML = imgsAbout.alt;
	//	expandImgAbout.parentElement.style.display = "block";

	/* Picture-Gallery */
	/**************************/
	//var expandImg = document.getElementById("expandedImg");
	//var imgText = document.getElementById("imgtext");
	//expandImg.src = imgs.src;
	//imgText.innerHTML = imgs.alt;
	//expandImg.parentElement.style.display = "block";
}