function ShowToastr(type, message) {
    if (type === 'success')
        toastr.success(message, "مزارع يحيى", { timeOut: 2000, positionClass: "toast-top-left" });
    else if (type === 'error')
        toastr.error(message, "مزارع يحيى", { timeOut: 2000, positionClass: "toast-top-left" });
}
SwalConfirm = () => {
    return new Promise(resolve => {
        Swal.fire({
            title: 'هل أنت متأكد؟',
            text: "لن يمكنك التراجع عن هذه العملية!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'نعم أكمل الحذف',
            cancelButtonText: "إلغاء", 
        }).then((result) => {
            resolve(result.isConfirmed);
        })
    });
}