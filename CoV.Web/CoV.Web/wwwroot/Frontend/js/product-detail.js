$('.qty-product').ready(function(){
  $(this).find('.count').prop('disabled', false);
  $(this).find('.up-qty').click(function(){
    $(this).parent().find('.count').val(parseInt($(this).parent().find('.count').val()) + 1 );
  });
  $(this).find('.down-qty').click(function(){
    $(this).parent().find('.count').val(parseInt($(this).parent().find('.count').val()) - 1 );
    if ($(this).parent().find('.count').val() == 0) {
      $(this).parent().find('.count').val(1);
    }
  });
});

function updateVariantInfo(id, title, sku, price, salePrice, stock) {
  $('.detail-product').find('.name-product').html(title);
  $('.detail-product').find('.sku-product').html(sku);
  if (salePrice != '') {
    $('.detail-product').find('.price-product span.price').html(salePrice);
    $('.detail-product').find('.price-product del').html(price);
  } else {
    $('.detail-product').find('.price-product span.price').html(price);
  }
  if (stock == 'true') {
    $('.detail-product').find('.stock-product').html('<b>Tình trạng:</b> Còn hàng');
  } else {
    $('.detail-product').find('.stock-product').html('<b>Tình trạng:</b> Hết hàng');
  }
  $('.detail-product').find('form input[name="purchasableId"]').val(id);
}

function changeSize(color) {
  $('.proSize').css({'display': 'none'});
  $('.proSize[data-color="'+color+'"]').css({'display': 'block'});
}

$(document).on('click', '.proColor', function(){
	$('.proColor').removeClass('active');
	$(this).addClass('active');

	let id = $(this).attr('data-id'),
      title = $(this).attr('data-title'),
      sku = $(this).attr('data-sku'),
      price = $(this).attr('data-price'),
      salePrice = $(this).attr('data-sale'),
      color = $(this).attr('data-color'),
      stock = $(this).attr('data-stock');

  updateVariantInfo(id, title, sku, price, salePrice, stock);
  changeSize(color);
});
$(document).on('click', '.proSize', function(){
	$('.proSize').removeClass('active');
	$(this).addClass('active');

	let id = $(this).attr('data-id'),
      title = $(this).attr('data-title'),
      sku = $(this).attr('data-sku'),
      price = $(this).attr('data-price'),
      salePrice = $(this).attr('data-sale'),
      stock = $(this).attr('data-stock');

  updateVariantInfo(id, title, sku, price, salePrice, stock);
});