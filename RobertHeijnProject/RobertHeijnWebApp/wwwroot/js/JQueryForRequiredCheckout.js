$('#deliveryoption').change(function () {
    if ($(this).val() == 'pickup') {
        $('#pickupdelivery input').attr('required', true);
        $('#homedelivery input').attr('required', false);
    } else if ($(this).val() == 'home') {
        $('#homedelivery input').attr('required', true);
        $('#pickupdelivery input').attr('required', false);
    } else {
        $('#homedelivery input').attr('required', false);
        $('#pickupdelivery input').attr('required', false);
    }
});
