window.onscroll = function() {
    if (document.documentElement.scrollTop > 56) {
        document.getElementById("navi").setAttribute('style', 'background-color:rgba(0,0,0,0.9)!important');
    }
    else{
        document.getElementById("navi").setAttribute('style', 'background-color:transparent!important');
    }
}