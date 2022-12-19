function RedirectCart() {
    alert('@TempData.Peek("Message")');
    window.location.href = '/Cart';
}
