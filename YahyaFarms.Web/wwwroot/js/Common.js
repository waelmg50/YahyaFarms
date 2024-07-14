function ShowToastr(type, message) {
    if (type === 'success')
        toastr.success(message, "Yahya Farms", { timeOut: 2000, positionClass: "toast-top-left" });
    else if (type === 'error')
        toastr.error(message, "Yahya Farms", { timeOut: 2000, positionClass: "toast-top-left" });
}
SwalConfirm = () => {
    return new Promise(resolve => {
        Swal.fire({
            title: 'Are you sure?',
            text: "You won't be able to revert this!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, delete it!'
        }).then((result) => {
            resolve(result.isConfirmed);
        })
    });
}