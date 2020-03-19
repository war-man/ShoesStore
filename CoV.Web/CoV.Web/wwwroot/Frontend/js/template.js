$(document).ready(function () {
	// dropdown
	$('.btn-drop').click(function () {
		var $this = $(this);
		$this.parent().find('.list-drop').toggle(150);
	});
	// $(document).on('click', function(e) {
	// 	e.preventDefault();
	// 	if (!$(e.target).closest('.dropdown').length) {
	// 		$(this).find('.dropdown').children('.list-drop').hide();
	// 	}
	// });

	//modal
	$('.to-modal').click(function () {
		var data_id = $(this).attr('data-id');
		$(this).closest('body').find('#'+data_id).show();
		$(this).closest('body').css('overflow-y','hidden');
	});
	$('.close-modal').click(function () {
		$(this).closest('.box-modal').hide();
		$(this).closest('body').css('overflow-y','auto');
	});

	//collapse
	$('.box-collapse').find('.txt-collapse').first().show();
	$('.title-collapse').click(function () {
		$(this).parent().find('.txt-collapse').toggle(100);
		$(this).children('.icon-collapse').toggleClass('route-icon');
	});

	//Tab
	$('.to-tab').click(function () {
		var data_id = $(this).attr('data-id');
		$(this).closest('.my-tab').find('.item-txt-tab').removeClass('block');
		$(this).closest('.my-tab').find('.to-tab').removeClass('active');
		$(this).addClass('active');
		$(this).closest('.my-tab').find('#'+data_id).addClass('block');
	});

})