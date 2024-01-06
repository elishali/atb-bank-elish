// Change menu
document.querySelectorAll('.navigation-menu-bottom a').forEach(function(navigation-menu-bottom) {
    menu.addEventListener('click', function() {
        document.querySelector('.menu .active').classList.remove('active')
        menu.classList.add('active')
    })
})