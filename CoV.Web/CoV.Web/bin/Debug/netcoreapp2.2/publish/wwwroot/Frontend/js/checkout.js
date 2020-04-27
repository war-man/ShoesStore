$(document).on('click', '.check-order', function(){
	if ($('#check-order').is(":checked")) {
		$(this).closest('.checkout-first').find('.order-to').hide();
		$('form.form_checkout_address').prepend('<input type="hidden" name="shippingAddressSameAsBilling" value="1">');
		$('form.form_checkout_address').find('input[name="shippingAddressId"]').remove();
		$('form.form_checkout_address').find('.cl_ship').removeClass('required');
	} else {
		$(this).closest('.checkout-first').find('.order-to').show();
		$('form.form_checkout_address').prepend('<input type="hidden" name="shippingAddressId">');
		$('form.form_checkout_address').find('input[name="shippingAddressSameAsBilling"]').remove();
		$('form.form_checkout_address').find('.cl_ship').addClass('required');
	}
});

$(document).on('submit', 'form.form_checkout_address', function(){
	var flag = true;
	$(this).find('.required').each(function(){
		if (!$(this).val()) {
			$(this).addClass('error-1');
			flag = false;
		}
	});

	return flag;
});

$(document).on('click', '.shipping_method', function(){
	if ($(this).children('input[name="shippingMethodHandle"]').is(':checked')) {
		$('form#updateCart_shipping').submit();
	}
});

function refeshcart(){
  $.get(window.location.href, function(data, status){
  	$('form#updateCart_shipping').find('.list_ship').css({'opacity': '1'});
    $('.load_subcart').html($(data).find('.list-ordered.sub_cart'));
  });
}

$('form#updateCart_shipping').submit(function(e){
	e.preventDefault();
	$(this).find('.list_ship').css({'opacity': '0.5'});
	$.ajax({
    type: "POST",  
    url: $(this).find('input[name="action"]').val(),  
    data: $(this).serialize(),
    dataType: 'json',
    success: function(res) {
    	refeshcart();
    },
    error: function(res) {
			$(this).find('.list_ship').css({'opacity': '1'});
			$(this).trigger('reset');
    }
  });
});

$(document).on('submit', 'form#updateCart', function(e){
	e.preventDefault();
	$('#complete-order').css({'opacity': '0.5'}).text('Xin chờ...');
	$.ajax({
    type: "POST",  
    url: $(this).find('input[name="action"]').val(),  
    data: $(this).serialize(),
    dataType: 'json',
    success: function(res) {
    	$('form#paymentForm').submit();
    },
    error: function(res) {
			$('#complete-order').css({'opacity': '1'}).text('Hoàn tất đơn hàng');
			$(this).trigger('reset');
    }
  });
});