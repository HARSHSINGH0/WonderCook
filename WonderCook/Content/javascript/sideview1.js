//const AllIngredients = [];
//function setColor(e, btn, color) {
//    var target = e.target, count = +target.dataset.count;
//    target.style.backgroundColor = count === 1 ? "#ff8c00" : '#ffffff';
//    target.dataset.count = count === 1 ? 0 : 1;
//}
//function inputIngredient(objButton) {
//    //AllIngredients.push("test");
//    AllIngredients.push(objButton.value);
//    sessionStorage.setItem("IngredientArray", JSON.stringify(AllIngredients));
//    alert(AllIngredients);
//const { post } = require("jquery");

//const { htmlimports } = require("modernizr");

//    //if (collect(AllIngredients).contains(objButton.value)) {
//    //    AllIngredients.pop(objButton.value);
//    //}
//    //else {
//    //    alert(objButton.value);
//    //    AllIngredients.push(objButton.value);
//    //}
//    //return AllIngredients;
//}

//function GotoRecipe(e, btn, color) {
//    //alert("test");
//    var teststring = sessionStorage.getItem("IngredientArray");
//    //teststring = teststring.replace(/'/g, '"');
    
//    teststring = JSON.parse(teststring);
//    alert(teststring);
//    /*Html.RenderAction("Menu", "Home", new { AllIngredients_posted = AllIngredients });*/
//    var target = e.target, count = +target.dataset.count;
//    target.style.backgroundColor = count === 1 ? "#ff8c00" : '#ffffff';
//    target.dataset.count = count === 1 ? 0 : 1;
    

//}
async function GotoRecipe(e, btn, color) {
    var teststring = sessionStorage.getItem("IngredientArray");
    //teststring = teststring.replace(/'/g, '"');

    teststring = JSON.parse(teststring);
    var target = e.target, count = +target.dataset.count;
    target.style.backgroundColor = count === 1 ? "#F59552" : '#ffffff';
    target.dataset.count = count === 1 ? 0 : 1;
    const res = await fetch("/Home/Index", {
        method: "POST",
        body: JSON.stringify(teststring),
        headers: {
            "Content-Type": "application/json",
            'Accept': 'application/json'
        }
    });

    const result = await res.json();
    alert(result);
};
