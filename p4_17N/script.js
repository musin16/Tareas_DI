
var r=[];
var rCom=[];
var elemento=[];
jugar.onclick = function () {
    comprobar();
    setInterval(comprobar, 2000);
}

function comprobar() {
    cajaPadre.innerHTML="";
    for (let i = 0; i < 5; i++) {
        r[i]= Math.floor(Math.random()*19);
        elemento[i] = document.createElement("img");
        elemento[i].setAttribute("src", "img\\"+ r[i]+".JPG");
        cajaPadre.appendChild(elemento[i]);
    }
    validarRepe();
}
function validarRepe(){
    for (let i = 0; i < r.length; i++) {
        if(rCom.includes(r[i])){
            sppuntos2.innerText="Hay repetidas";
            break;
        }else{
            rCom[i]=r[i];
        }
    }
    if(r.length==rCom.length){
        sppuntos2.innerText="No Hay repetidas";
    }
    rCom=[];
}
