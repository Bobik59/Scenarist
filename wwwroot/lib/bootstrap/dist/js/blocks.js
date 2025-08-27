window.isClickInsideBlock = function (element, clientX, clientY) {
    let rect = element.getBoundingClientRect();
    let x = clientX - rect.left;
    let y = clientY - rect.top;

    for (let child of element.children) {
        let cRect = child.getBoundingClientRect();
        if (clientX >= cRect.left && clientX <= cRect.right &&
            clientY >= cRect.top && clientY <= cRect.bottom) {
            return true; // клик по блоку
        }
    }
    return false; // клик в пустую область
};
