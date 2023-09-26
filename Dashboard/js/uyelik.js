function uyeGirisi() {

    if (Mail.value != '' && Sifre.value != '') {
        $.ajax({
            url: '/Login/girisYap',
            type: 'POST',
            data: {
                Mail: Mail.value,
                Sifre: Sifre.value
            },
            success: function (cevap) {

                if (cevap == '') {
                    uyari.innerText = 'Email veya şifre hatalı.';
                }
                else {
                    window.location='/PersonelBilgileris/Index'
                }
            }
        })
    }
    else {
        uyari.innerText = 'Email veya şifre alanlarını doldurunuz.';
    }
}




