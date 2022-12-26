// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



$('nav a-profile').click(function (e) {
    e.preventDefault();
    $('nav a-profile').removeClass('active');
    $(this).addClass('active');
    if (this.id === !'payment') {
        $('.payment').addClass('noshow');
    }
    else if (this.id === 'payment') {
        $('.payment').removeClass('noshow');
        $('.rightbox').children().not('.payment').addClass('noshow');
    }
    else if (this.id === 'profile') {
        $('.profile').removeClass('noshow');
        $('.rightbox').children().not('.profile').addClass('noshow');
    }
    else if (this.id === 'subscription') {
        $('.subscription').removeClass('noshow');
        $('.rightbox').children().not('.subscription').addClass('noshow');
    }
    else if (this.id === 'privacy') {
        $('.privacy').removeClass('noshow');
        $('.rightbox').children().not('.privacy').addClass('noshow');
    }
    else if (this.id === 'settings') {
        $('.settings').removeClass('noshow');
        $('.rightbox').children().not('.settings').addClass('noshow');
    }
});