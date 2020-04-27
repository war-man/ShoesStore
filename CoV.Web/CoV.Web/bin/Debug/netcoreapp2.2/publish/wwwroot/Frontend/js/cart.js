$(document).on('click', '.up-qty', function(){
	var inputQty = $(this).parent().find('input[type="number"]'),
			old_val = parseFloat(inputQty.val());
	new_val = old_val + 1;
	inputQty.val(new_val);
	inputQty.trigger("change");
});

$(document).on('click', '.down-qty', function(){
	var inputQty = $(this).parent().find('input[type="number"]'),
			min = inputQty.attr('min'),
			old_val = parseFloat(inputQty.val());
	if (old_val <= min) {
		new_val = old_val;
	} else {
		new_val = old_val - 1;
	}
	inputQty.val(new_val);
	inputQty.trigger("change");
});

function refeshcart(){
  $.get(window.location.href, function(data, status){
    $('.load_cart').html($(data).find('.list-cart'));
  });
}

$(document).on('submit', 'form.updateCart', function(e){
	e.preventDefault();
  $('.opacity').css('opacity', 0.5);
  $.ajax({
    type: "POST",  
    url: $(this).find('input[name="action"]').val(),  
    data: $(this).serialize(),
    dataType: 'json',
    success: function(res) {
    	refeshcart();
    },
    error: function(res) {
			$('.opacity').css('opacity', 1);
			$(this).trigger('reset');
    }
  });
});