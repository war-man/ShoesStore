$(document).ready(function () {
	// slide home
	$('#main_slide').owlCarousel({
		loop:false,
		margin:0,
		autoplay:true,
		autoplayTimeout:7000,
		nav:true,
		responsive:{
			0:{
				items:1
			}
		}
	});
	$('#testimonial_slide').owlCarousel({
		loop:false,
		margin:30,
		autoplay:true,
		autoplayTimeout:7000,
		nav:true,
		responsive:{
			0:{
				items:3
			}
		}
	});
	$('#service_slide').owlCarousel({
		loop:false,
		margin:15,
		autoplay:true,
		autoplayTimeout:7000,
		nav:true,
		responsive:{
			0:{
				items:4
			}
		}
	});
	$('#product_slide_men').owlCarousel({
		loop:false,
		margin:0,
		autoplay:true,
		autoplayTimeout:7000,
		nav:true,
		responsive:{
			0:{
				items:5
			}
		}
	});

	$('#product_slide_girl').owlCarousel({
		loop:false,
		margin:0,
		autoplay:true,
		autoplayTimeout:7000,
		nav:true,
		responsive:{
			0:{
				items:5
			}
		}
	});

	$('#product_slide_child_girl').owlCarousel({
		loop:false,
		margin:0,
		autoplay:true,
		autoplayTimeout:7000,
		nav:true,
		responsive:{
			0:{
				items:5
			}
		}
	});

	$('#product_slide_child_men').owlCarousel({
		loop:false,
		margin:0,
		autoplay:true,
		autoplayTimeout:7000,
		nav:true,
		responsive:{
			0:{
				items:5
			}
		}
	});

	//Tab
	$('.to-tab').click(function () {
		var data_id = $(this).attr('data-id');
		$(this).closest('.my-tab').find('.item-txt-tab').removeClass('block');
		$(this).closest('.my-tab').find('.to-tab').removeClass('active');
		$(this).addClass('active');
		$(this).closest('.my-tab').find('#'+data_id).addClass('block');
	});



	$('.control_sub_menu').click(function () {
		$(this).parent().find('.ul_sub').toggle(150);
		$(this).children('.fas').toggleClass('fa-plus fa-minus');
	});

	$('.control_menu').click(function () {
		$(this).closest('.main_menu').find('.list_menu').toggleClass('show_menu');
		$(this).children('.fas').toggleClass('fa-bars fa-times');
	});


	$('.to-pp-tab').click(function () {
		var data_id = $(this).attr('data-id');
		$(this).closest('.box-filter').find('#'+data_id).addClass('block-pp');
		$('html,body').css(
		{
			'overflow-y':'hidden',
			'position':'fixed'
		}
		);
	});
	$('.close-pp').click(function () {
		$(this).parent().removeClass('block-pp');
		$('html,body').css(
		{
			'overflow-y':'auto',
			'position':'relative'
		}
		);
	});

	$('.control_search').click(function () {
		$(this).children().children('.fas').toggleClass('fa-search fa-times')
		$(this).closest('.main_menu').find('.search').slideToggle(150);
	});

	$("#to_form_book,#btn_to_form_book").click(function() {
		$('html, body').animate({
			scrollTop: $("#form_book").offset().top
		}, 1000);
	});
	// check-order
	// $('.check-order').click(function () {
	// 	$(this).closest('.checkout-first').find('.order-to').slideToggle(0);
	// });
	// show info payment
	$('.radio-guide-payment').click(function () {
		$(this).parent().parent().find('.info-payment').removeClass('onblock');
		$(this).parent().parent().find('.item-payment').removeClass('m-border-blue');
		$(this).parent().find('.info-payment').addClass('onblock');
		$(this).parent().addClass('m-border-blue');
	});
});


var lastScroll = 0;
jQuery(document).ready(function($) {
	$(window).scroll(function(){
		var scroll = $(window).scrollTop();
		if (scroll > lastScroll) {
			$('#fixed_menu').removeClass('fixed_menu');
		} else if (scroll < lastScroll - 5) {
			$('#fixed_menu').addClass('fixed_menu');
		}
		lastScroll = scroll;
		if(scroll < 10){
			$('#fixed_menu').removeClass('fixed_menu');
		}

		if(scroll>300){
			$('.back-to-top').fadeIn();
			$('#btn_to_form_book').fadeIn();
			$(".back-to-top").on('click',function () {
				$('html,body').animate({
					scrollTop: 0},0);
			});

		}else{
			$('.back-to-top').fadeOut();
			$('#btn_to_form_book').fadeOut();
		}
	});
});

$(window).scroll(function(){
	var scrollTop = $(window).scrollTop();
	var objectSelect = $(".top-footer");
	var objectPosition = objectSelect.offset().top;

	if(scrollTop > objectPosition){
		$('.box-filter').addClass('offdisplay');
	}else{
		$('.box-filter').removeClass('offdisplay');
	}
});






















