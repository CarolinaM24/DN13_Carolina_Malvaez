document.addEventListener("DOMContentLoaded", function () {

    document.querySelectorAll('.form-control').forEach(input => {
        input.addEventListener('keypress', function (e) {
            if (e.key === 'Enter' || e.key === ' ') { 
                e.preventDefault();
                showModal(input.closest('form').getAttribute('data-action'));
            }
        });
    });

    document.querySelectorAll('.btn-primary').forEach(button => {
        button.addEventListener('click', function (e) {
            e.preventDefault();
            showModal(button.closest('form').getAttribute('data-action'));
        });
    });
});

function showModal(action) {

    let memberId = document.querySelector('.form-control').value;

    let actionText;
    if (action === 'member-in-form') {
        actionText = 'Entrada';
    } else if (action === 'member-out-form') {
        actionText = 'Salida';
    } else {

        actionText = 'Acción Desconocida';
    }

    let title = 'Registro Exitoso';
    let text = `[${actionText}] registrada para el miembro ${memberId} ${getCurrentTime()}`;

    document.getElementById('exampleModalLabel').innerText = title;
    document.getElementById('modalText').innerText = text;

    let modal = new bootstrap.Modal(document.getElementById('exampleModal'), {});
    modal.show();

    setTimeout(function () {
        modal.hide();
    }, 3000);
}

function getCurrentTime() {
    let now = new Date();
    return now.toLocaleTimeString();
}
