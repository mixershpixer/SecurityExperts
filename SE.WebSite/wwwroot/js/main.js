/*-----------------------------------------------------------------------------------*/
/* 		Mian Js Start 
/*-----------------------------------------------------------------------------------*/
$(document).ready(function ($) {
    "use strict"
    /*-----------------------------------------------------------------------------------*/
    /*		STICKY NAVIGATION
    /*-----------------------------------------------------------------------------------*/
    $(".sticky").sticky({ topSpacing: 0 });
    /*-----------------------------------------------------------------------------------*/
    /* 	LOADER
    /*-----------------------------------------------------------------------------------*/
    /*$("#loader").delay(500).fadeOut("slow");*/
    /*-----------------------------------------------------------------------------------*/
    /*  FULL SCREEN
    /*-----------------------------------------------------------------------------------*/
    $('.full-screen').superslides({});
    /*-----------------------------------------------------------------------------------*/
    /*    Parallax
    /*-----------------------------------------------------------------------------------*/


    jQuery.stellar({
        horizontalScrolling: false,
        scrollProperty: 'scroll',
        positionProperty: 'position',
    });

    /*******************/
    $(window).on('load', function () {
        $('.preloader').fadeOut().end().delay(1000).fadeOut('slow');
    });
    /****************************/
    /*-----------------------------------------------------------------------------------*/
    /* 		Parallax
    /*-----------------------------------------------------------------------------------*/

    /*
    $('.images-slider').flexslider({
      animation: "fade",
      controlNav: "thumbnails"
    });
    */

    /*-----------------------------------------------------------------------------------*/
    /* 	GALLERY SLIDER
    /*-----------------------------------------------------------------------------------*/
    $('.block-slide').owlCarousel({
        loop: true,
        margin: 30,
        nav: true,
        navText: ["<i class='fa fa-angle-left'></i>", "<i class='fa fa-angle-right'></i>"],
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 2
            },
            800: {
                items: 3
            },
            1000: {
                items: 4
            },
            1400: {
                items: 5
            },
            1600: {
                items: 6
            }
        }
    });
    /*-----------------------------------------------------------------------------------*/
    /* 	GALLERY SLIDER
    /*-----------------------------------------------------------------------------------
    $('.block-slide-con').owlCarousel({
        loop:true,
        margin:30,
        nav:true,
        navText: ["<i class='fa fa-angle-left'></i>","<i class='fa fa-angle-right'></i>"],
        responsive:{
            0:{
                items:1
            },
            600:{
                items:2
            },
            1000:{
                items:4
            }
    }});
    */
    /*-----------------------------------------------------------------------------------*/
    /* 	GALLERY SLIDER
    /*-----------------------------------------------------------------------------------*/
    $('.two-col').owlCarousel({
        loop: true,
        margin: 30,
        nav: true,
        navText: ["<i class='fa fa-angle-left'></i>", "<i class='fa fa-angle-right'></i>"],
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 2
            }
        }
    });

    /*-----------------------------------------------------------------------------------*/
    /* 	GALLERY SLIDER
    /*-----------------------------------------------------------------------------------*/
    $('.clients-slide').owlCarousel({
        loop: true,
        margin: 30,
        nav: false,
        navText: ["<i class='fa fa-angle-left'></i>", "<i class='fa fa-angle-right'></i>"],
        responsive: {
            0: {
                items: 1
            },
            400: {
                items: 2
            },
            600: {
                items: 4
            },
            800: {
                items: 5
            },
            1200: {
                items: 8
            }
        }
    });
    /*-----------------------------------------------------------------------------------*/
    /* 	Single SLIDER
    /*-----------------------------------------------------------------------------------*/
    $(".single-slide").owlCarousel({
        items: 1,
        autoplay: true,
        loop: true,
        autoplayTimeout: 5000,
        autoplayHoverPause: true,
        singleItem: true,
        navigation: true,
        navText: ["<i class='fa fa-angle-left'></i>", "<i class='fa fa-angle-right'></i>"],
        pagination: true,
        animateOut: 'fadeOut'
    });
    /*-----------------------------------------------------------------------------------*/
    /* 	Item Slider
    /*-----------------------------------------------------------------------------------*/
    $('.item-slide').owlCarousel({
        loop: true,
        margin: 30,
        nav: false,
        navText: ["<i class='fa fa-angle-left'></i>", "<i class='fa fa-angle-right'></i>"],
        responsive: {
            0: {
                items: 1
            },
            400: {
                items: 2
            },
            900: {
                items: 3
            },
            1200: {
                items: 4
            }
        }
    });
    /* ------------------------------------------------------------------------ 
       Shop Slider
    ------------------------------------------------------------------------ */
    $('#shop-thumb').flexslider({
        animation: "slide",
        controlNav: false,
        animationLoop: false,
        slideshow: false,
        itemWidth: 210,
        itemMargin: 5,
        asNavFor: '#slider-shop'
    });
    $('#slider-shop').flexslider({
        animation: "slide",
        controlNav: false,
        animationLoop: false,
        slideshow: false,
        sync: "#shop-thumb"
    });
    /* ------------------------------------------------------------------------ 
       SEARCH OVERLAP
    ------------------------------------------------------------------------ */
    /*
    jQuery('.search-open').on('click', function(){
        jQuery('.search-inside').fadeIn();
    });
    jQuery('.search-close').on('click', function(){
        jQuery('.search-inside').fadeOut();
    });
    */
    /*-----------------------------------------------------------------------------------
        Animated progress bars
    /*-----------------------------------------------------------------------------------*/
    $('.progress-bars').waypoint(function () {
        $('.progress').each(function () {
            $(this).find('.progress-bar').animate({
                width: $(this).attr('data-percent')
            }, 100);
        });
    },
        {
            offset: '100%',
            triggerOnce: true
        });
    /*-----------------------------------------------------------------------------------*/
    /*    Magnifine Popups
    /*-----------------------------------------------------------------------------------*/
    $('.popup-with-zoom-anim').magnificPopup({
        type: 'inline',
        fixedContentPos: false,
        fixedBgPos: true,
        overflowY: 'auto',
        closeBtnInside: true,
        preloader: false,
        midClick: true,
        removalDelay: 300,
        mainClass: 'my-mfp-zoom-in'
    });
    $('.popup-with-move-anim').magnificPopup({
        type: 'inline',
        fixedContentPos: false,
        fixedBgPos: true,
        overflowY: 'auto',
        closeBtnInside: true,
        preloader: false,
        midClick: true,
        removalDelay: 300,
        mainClass: 'my-mfp-slide-bottom'
    });
    $('.popup-with-zoom-anim').magnificPopup({
        type: 'inline',
        fixedContentPos: false,
        fixedBgPos: true,
        overflowY: 'auto',
        closeBtnInside: true,
        preloader: false,
        midClick: true,
        removalDelay: 300,
        mainClass: 'my-mfp-zoom-in'
    });
    $('.popup-with-move-anim').magnificPopup({
        type: 'inline',
        fixedContentPos: false,
        fixedBgPos: true,
        overflowY: 'auto',
        closeBtnInside: true,
        preloader: false,
        midClick: true,
        removalDelay: 300,
        mainClass: 'my-mfp-slide-bottom'
    });
    $('.simple-ajax-popup-align-top').magnificPopup({
        type: 'ajax',
        alignTop: true,
        overflowY: 'scroll' // as we know that popup content is tall we set scroll overflow by default to avoid jump
    });
    $('.simple-ajax-popup').magnificPopup({
        type: 'ajax'
    });
});


/**     вкладки***/
function openInfo(evt, cityName) {
    var i, tabcontent, tablinks;
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }
    document.getElementById(cityName).style.display = "block";
    evt.currentTarget.className += " active";
   
}
document.getElementById("defaultOpen").click();

function DeleteAlert() {
    confirm("Вы уверены, что хотите удалить материал?");
}

function DeleteMaterial(materialId) {
    if (confirm("Вы уверены, что хотите удалить материал?")) {
        $.ajax({
            type: "GET",
            url: '/Material/DeleteMaterial?id=' + materialId,
            success: function (data) {
                pageNum = data.page;
                $('#totalCount').text(data.totalCount);
                if (data.totalCount == 0) {
                    $("#showMore").attr("hidden", true);
                    $('div[name="materials"]').attr("hidden", true);
                    $('h4[name="searchResult"]').removeAttr('hidden');
                    $('h4[name="noMaterials"]').removeAttr('hidden');
                }
                else {
                    $('h4[name="noMaterials"]').attr('hidden', true);
                    $('h4[name="searchResult"]').attr("hidden", true);
                    $('div[name="materials"]').removeAttr('hidden');
                    $('div[name="materials"]').empty();
                    $.each(data.materials, function () {
                        $('div[name="materials"]').append(
                            `<div class="info_item">
                                <div class="wrap_img_item">
                                    <a href="/Material/MaterialDetail?id=`+ this.id + `">`
                            + (this.base64Picture.length <= 10 ?
                                `<img src="/images/noimage.png" />` :
                                `<img src="data:image/jpeg;base64,` + this.base64Picture + `" />`) + `
                                    </a>
                                </div>
                                <h5 class="item_text"><a href="/Material/MaterialDetail?id=`+ this.id + `" class="item_text">` + this.name + `</a></h5>
                                <div class="dop_info_item" style="position:inherit; width:100%;">
                                    <p>Рейтинг: `+ this.rating + `<span style="font-size:20px; color: gold;" >★</span></p>
                                    <p class="dop_info_view"> Скачиваний: `+ this.downloadsCount + `</p>
                                </div>
                                <div class="row" style="text-align:center">
                                    <div style=" margin: 0 auto;">`
                            + (this.statusString == "На модерации" || this.statusString == "Опубликовано" ?
                                `<a onclick="DeleteMaterial('` + this.id + `');" class="btn btn-dark">Удалить</a>` : "")
                            //+ (this.statusString == "Удалено" ?
                            //    `<a href="/Material/RestoreMaterial?id=` + this.id + `" class="btn btn-success disabled">Восстановить</a>` : "") + `
                            //        </div>
                            //    </div>
                            + `</div>`
                        );
                    });
                }
            }
        })
    }
    else
        return;
}