document.addEventListener("DOMContentLoaded", function () {
    const buttons = document.querySelectorAll(".toggle-btn");
    alert('test');
    buttons.forEach((btn) => {
        btn.addEventListener("click", () => {
            // Find the next .more-services section after the button
            const hiddenSection = btn.closest(".view-all-wrapper").nextElementSibling;

            if (hiddenSection && hiddenSection.classList.contains("more-services")) {
                const isVisible = hiddenSection.style.display !== "none" && hiddenSection.style.display !== "";

                if (!isVisible) {
                    hiddenSection.style.display = "flex";
                    hiddenSection.style.flexWrap = "wrap";
                    hiddenSection.style.justifyContent = "center";
                    btn.textContent = "Show Less";
                } else {
                    hiddenSection.style.display = "none";
                    btn.textContent = "View All Services";
                }
            }
        });
    });
});
