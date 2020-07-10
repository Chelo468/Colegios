function verPaginas(idRol, nombreRol) {
    $.colorbox({
        title: "Paginas para " + nombreRol,
        href: RolIndexParams.paginasRolURL + '?idRol=' + idRol,
        width: "600px",
        height: "600px",
        overlayClose: false,
        scrolling: true,
        escKey: true,
    })
}