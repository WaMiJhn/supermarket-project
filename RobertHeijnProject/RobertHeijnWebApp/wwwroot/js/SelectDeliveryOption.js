const selectbox = document.getElementById('deliveryoption');
const home = document.getElementById('homedelivery');
const btn = document.getElementById('orderbtn');
const pickup = document.getElementById('pickupdelivery');
pickup.setAttribute('disabled', 'disabled');
home.setAttribute('disabled', 'disabled');

selectbox.addEventListener('change', function handleChange(event) {
    if (event.target.value === 'home') {
        home.classList.add('selected');
        pickup.classList.remove('selected');
        btn.classList.add('selected');
        //pickup.setAttribute('disabled', true);
        //home.setAttribute('disabled', false);
    } else if (event.target.value === 'pickup') {
        pickup.classList.add('selected');
        home.classList.remove('selected');
        btn.classList.add('selected');
        //pickup.setAttribute('disabled', false);
        //home.setAttribute('disabled', true);
    }
});