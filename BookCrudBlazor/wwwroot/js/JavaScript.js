function FullCounter() {
    const mensaje = document.getElementById('mensaje');
    const contador = document.getElementById('contador');

    mensaje.addEventListener('input', function (e) {
        const target = e.target;
        const longitudMax = target.getAttribute('maxlength');
        const longitudAct = target.value.length;
        contador.innerHTML = `${longitudAct}/${longitudMax}`;
        if (target.value.length == 40) {
            alertify.alert('Advertencia', function () { alertify.error('Ha superado el limite de caracteres'); });
        }
    });
}

 function AlertBorrarLibro() {
    alertify.alert('Exito', function () { alertify.success('Libro eliminado'); });

}

function AlertGuardarLibro() {
    alertify.alert('Exito!', function () { alertify.success('Libro guardado con exito'); });

}