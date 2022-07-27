const AllIngredients = [];
var counter = 0;
function IngredientAndColor(e, btn, color, objButton) {
    //if (counter == 0) {
    //    AllIngredients.push(objButton.value);
    //    counter++;
    //}
    //else {
    //for (let i = 0; i < AllIngredients.length; i++) {
    //    if (objButton.value == AllIngredients[i] ) {
    //        alert("not adding");
    //    }
    //    else {
    //        AllIngredients.push(objButton.value);
    //    }
    //    }
    //}
    AllIngredients.push(objButton.value);
    alert(AllIngredients);
    
    //if (AllIngredients.find(objButton.value)) {

    //}
    //else {
    
    //    //alert(AllIngredients);
    //}
    var target = e.target, count = +target.dataset.count;
    target.style.backgroundColor = count === 1 ? "#ff8c00" : '#ffffff';
    target.dataset.count = count === 1 ? 0 : 1;
    sessionStorage.setItem("IngredientArray", JSON.stringify(AllIngredients));

}