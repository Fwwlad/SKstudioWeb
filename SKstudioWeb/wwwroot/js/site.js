document.addEventListener('DOMContentLoaded', () => {
    const menuToggle = document.getElementById('mobile-menu-toggle');
    const mobileNav = document.getElementById('mobile-nav');

    menuToggle.addEventListener('click', () => {
        mobileNav.classList.toggle('open');
    });

    document.addEventListener('click', (event) => {
        if (!mobileNav.contains(event.target) && !menuToggle.contains(event.target)) {
            mobileNav.classList.remove('open');
        }
    });
});
