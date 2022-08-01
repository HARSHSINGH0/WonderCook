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

    if (!(AllIngredients.indexOf(String(objButton.value)) > -1)) {
        AllIngredients.push(objButton.value);
        alert(AllIngredients);
    }

    //if (AllIngredients.find(objButton.value)) {

    //}
    //else {

    //    //alert(AllIngredients);
    //}
    var target = e.target, count = +target.dataset.count;
    target.style.backgroundColor = count === 1 ? "#ff8c00" : '#ffffff';
    target.dataset.count = count === 1 ? 0 : 1;

    //if (target.dataset.count == 0) {
    //    const index = AllIngredients.indexOf(String(objButton.value));
    //    if (index > -1) { // only splice array when item is found
    //        AllIngredients.splice(index, 1); // 2nd parameter means remove one item only
    //    }
    //    // array = [2, 9]
    //    console.log(AllIngredients);
    //}

    if (target.dataset.count == 0) {
        


        const index = AllIngredients.indexOf(String(objButton.value));
        if (index > -1) { // only splice array when item is found
            array.splice(index, 1); // 2nd parameter means remove one item only
        }

        // array = [2, 9]
        console.log(AllIngredients);
    }
    sessionStorage.setItem("IngredientArray", JSON.stringify(AllIngredients));

}