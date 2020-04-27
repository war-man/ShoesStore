$('#ajax-contact').on('submit', function(e){
  $('.error-text').html('');
  e.preventDefault();
  var flag = true,
      $this = $(this);
  $this.find('.required').each(function(){
    if (!$(this).val()) {
      $(this).addClass('error-1');
      $('.error-text').html('Vui lòng không để trống');
      flag = false;
    }
  });

  if (flag == true) {
    $this.css({'opacity': '0.5'});
    $this.find('button[type="submit"]').prop('disabled', true);
    contact($this);
  } else {
    return flag;
  }
});

// Ajax form contact
var contact = function ($form){
  var data = $form.serialize(),
      url = $form.find('input[name="action"]').val();
  $.ajax({
    type: 'POST',
    url:  url,
    data: data,
    success: function(res) {
      $form.css({'opacity': '1'});
      $form.find('button[type="submit"]').prop('disabled', false);
      afterSubmit($form, res);
    },
    error: function(res) {
      console.log('Lỗi, vui lòng thử lại sau.');
    },
  })
}

var afterSubmit = function(form, res) {
  if (res.success == true) {
    form.slideUp();
    $('.alert-button').slideDown();
    form.trigger('reset');
  } else {
    if (res.errors.fullName) {
      form.find('.error-fullname').html(res.errors.fullName);
    } else if (res.errors.email) {
      form.find('.error-email').html(res.errors.email);
    } else if (res.errors.phone) {
      form.find('.error-phone').html(res.errors.phone);
    }
  }
}