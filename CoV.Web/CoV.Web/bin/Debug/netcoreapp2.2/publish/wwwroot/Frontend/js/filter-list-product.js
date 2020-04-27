// -------------------------------------------------------
// Get a parameter
function GetURLParameter(sParam) {
  var sPageURL = window.location.search.substring(1);
  var sURLVariables = sPageURL.split('&');
  for (var i = 0; i < sURLVariables.length; i++){
    var sParameterName = sURLVariables[i].split('=');
    if (sParameterName[0] == sParam){
      return sParameterName[1];
    }
  }
}
// Explicitly save/update a url parameter using HTML5's replaceState().
function updateQueryStringParam (key, value) {
  var baseUrl = [location.protocol, '//', location.host, location.pathname].join(''),
      urlQueryString = document.location.search,
      newParam = key + '=' + value,
      params = '?' + newParam;
  // If the "search" string exists, then build params from it
  if (urlQueryString) {
    var updateRegex = new RegExp('([\?&])' + key + '[^&]*');
    var removeRegex = new RegExp('([\?&])' + key + '=[^&;]+[&;]?');
    if( typeof value == 'undefined' || value == null || value == '' ) { // Remove param if value is empty
      params = urlQueryString.replace(removeRegex, "$1");
      params = params.replace( /[&;]$/, "" );
    } else if (urlQueryString.match(updateRegex) !== null) { // If param exists already, update it
      params = urlQueryString.replace(updateRegex, "$1" + newParam);
    } else {
      params = urlQueryString + '&' + newParam;
    }
  }
  // no parameter was set so we don't need the question mark
  params = params == '?' ? '' : params;
  params = params[params.length-1] == '?' ? params.substring(0,params.length-1) : params;
  window.history.replaceState({}, "", baseUrl + params);
};
// Remove a parameter
function removeParam(key, sourceURL) {
  var rtn = sourceURL.split("?")[0],
      param,
      params_arr = [],
      queryString = (sourceURL.indexOf("?") !== -1) ? sourceURL.split("?")[1] : "";
  if (queryString !== "") {
    params_arr = queryString.split("&");
    for (var i = params_arr.length - 1; i >= 0; i -= 1) {
      param = params_arr[i].split("=")[0];
      if (param === key) {
        params_arr.splice(i, 1);
      }
    }
    rtn = rtn + "?" + params_arr.join("&");
    rtn = rtn[rtn.length-1] == '?' ? rtn.substring(0,rtn.length-1) : rtn;
  }
  return rtn;
}
//----------------------------------------

heightPrice = (typeof(heightPrice) !== "undefined") ? heightPrice : 50000000;
var price = GetURLParameter('price');
var min = 0;
var max = heightPrice ? heightPrice : 50000000;
if (price) {
  var arr = price.split('-');
  min = arr[0];
  max = arr[1];
}

// price click
$(".list-trademark-product a").click(function(event) {
    event.preventDefault();
    var name = $(this).attr('name');
    var value = $(this).attr('value');
    var arr = GetURLParameter(name) ? GetURLParameter(name).split(',') : [];
    if(arr.includes(value)){
      arr.splice(arr.indexOf(value), 1);
    } else {
      if (name == 'price') {
        arr = [value];
      } else if (name == 'size' || name == 'color') {
        arr = value
      } else arr.push(value);
    }
    updateQueryStringParam(name,arr);
    window.location.href = window.location.href;
});