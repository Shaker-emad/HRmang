function toggleProfileMenu() {
    const profileMenu = document.getElementById('profileMenu');
    profileMenu.classList.toggle('show');
}

function toggleLanguageMenu() {
    const languageMenu = document.getElementById('languageMenu');
    languageMenu.classList.toggle('show');
}

// Close the dropdowns when clicking outside
window.onclick = function (event) {
    if (!event.target.matches('.dash-head-link')) {
        const dropdowns = document.querySelectorAll('.dropdown-menu');
        dropdowns.forEach(dropdown => {
            dropdown.classList.remove('show');
        });
    }
}
function toggleSubmenu() {
    var submenu = document.getElementById('staff-submenu');
    // Toggle display property
    if (submenu.style.display === "block") {
        submenu.style.display = "none"; // Hide the submenu
    } else {
        submenu.style.display = "block"; // Show the submenu
    }
}
