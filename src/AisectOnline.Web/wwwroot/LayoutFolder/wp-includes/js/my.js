   /*Slider image Js*/
   
   const slides = document.querySelectorAll('.slide');
    let currentSlide = 0;

    function showSlide(index) {
      slides.forEach((slide, i) => {
        slide.classList.remove('active');
        slide.style.left = '100%';
      });
      slides[index].classList.add('active');
      slides[index].style.left = '0';
    }

    setInterval(() => {
      currentSlide = (currentSlide + 1) % slides.length;
      showSlide(currentSlide);
    }, 6000); // slower transition (6 seconds)

   /*Modal Js*/
  function openLogin() {
    const modal = document.getElementById("login-modal");
    modal.classList.add("show");
    document.getElementById("wrapper").classList.add("blurred");
    document.body.classList.add("modal-open");
    generateCaptcha();
  }

  function closeLogin() {
    const modal = document.getElementById("login-modal");
    modal.classList.remove("show");
    document.getElementById("wrapper").classList.remove("blurred");
    document.body.classList.remove("modal-open");
  }

  function generateCaptcha() {
    const chars = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnpqrstuvwxyz23456789";
    let captcha = "";
    for (let i = 0; i < 6; i++) {
      captcha += chars.charAt(Math.floor(Math.random() * chars.length));
    }
    document.getElementById("captcha-text").textContent = captcha;
    document.getElementById("captcha-text").dataset.value = captcha;
  }

  function validateCaptcha() {
    const userInput = document.getElementById("captcha-input").value;
    const actualCaptcha = document.getElementById("captcha-text").dataset.value;
    if (userInput === actualCaptcha) {
      alert("Captcha verified. Proceeding with login...");
    } else {
      alert("Incorrect captcha. Please try again.");
      generateCaptcha();
    }
  }



   var tpj = jQuery;

        var revapi11;

        if (window.RS_MODULES === undefined) window.RS_MODULES = {};
        if (RS_MODULES.modules === undefined) RS_MODULES.modules = {};
        RS_MODULES.modules["revslider111"] = {
            init: function () {
                window.revapi11 = window.revapi11 === undefined || window.revapi11 === null || window.revapi11.length === 0 ? document.getElementById("rev_slider_11_1") : window.revapi11;
                if (window.revapi11 === null || window.revapi11 === undefined || window.revapi11.length == 0) { window.revapi11initTry = window.revapi11initTry === undefined ? 0 : window.revapi11initTry + 1; if (window.revapi11initTry < 20) requestAnimationFrame(function () { RS_MODULES.modules["revslider111"].init() }); return; }
                window.revapi11 = jQuery(window.revapi11);
                if (window.revapi11.revolution == undefined) { revslider_showDoubleJqueryError("rev_slider_11_1"); return; }
                revapi11.revolutionInit({
                    revapi: "revapi11",
                    DPR: "dpr",
                    sliderLayout: "fullwidth",
                    visibilityLevels: "1240,1024,778,480",
                    gridwidth: "1240,1024,778,480",
                    gridheight: "1040,768,960,720",
                    lazyType: "smart",
                    perspective: 600,
                    perspectiveType: "global",
                    editorheight: "1040,768,960,720",
                    responsiveLevels: "1240,1024,778,480",
                    progressBar: { disableProgressBar: true },
                    navigation: {
                        onHoverStop: false
                    },
                    parallax: {
                        levels: [5, 10, 15, 20, 25, 30, 35, 40, 45, 46, 47, 48, 49, 50, 51, 30],
                        type: "scroll",
                        origo: "slidercenter",
                        speed: 0
                    },
                    viewPort: {
                        global: true,
                        globalDist: "-200px",
                        enable: false
                    },
                    fallbacks: {
                        allowHTML5AutoPlayOnAndroid: true
                    },
                });

            }
        } // End of RevInitScript

        if (window.RS_MODULES.checkMinimal !== undefined) { window.RS_MODULES.checkMinimal(); };


        //*header*//

         function toggleModal() {
            const modal = document.getElementById("userModal");
            modal.style.display = modal.style.display === "flex" ? "none" : "flex";
        }

        function toggleDropdown() {
            const dropdown = document.getElementById("userDropdown");
            dropdown.style.display = dropdown.style.display === "flex" ? "none" : "flex";
        }

        window.addEventListener("click", function (e) {
            if (!e.target.closest(".profile-ewallet")) {
                document.getElementById("userDropdown").style.display = "none";
            }
        });



