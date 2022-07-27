const AllIngredients = [];
function bothcolorAndIngredient(objButton, e, btn, color) { }
function inputIngredient(objButton) {
    //AllIngredients.push("test");
    AllIngredients.push(objButton.value);
    alert(AllIngredients);
    
    //if (collect(AllIngredients).contains(objButton.value)) {
    //    AllIngredients.pop(objButton.value);
    //}
    //else {
    //    alert(objButton.value);
    //    AllIngredients.push(objButton.value);
    //}
    //return AllIngredients;
}
function setColor(e, btn, color) {
    var target = e.target, count = + target.dataset.count;
    target.style.backgroundColor = count === 1 ? "#ff8c00" : '#ffffff';
    target.dataset.count = count === 1 ? 0 : 1;
    } 

//function GotoRecipe() {
//    alert("test");
//    //Html.RenderAction("Menu", "Home", new { AllIngredients_posted = AllIngredients });
//}

//<script>

//        //function onLoadStuffs() {
//        //    const AllIngredients = [];
//        //}
//        $(document).ready(function setColor(e, btn, color) {
//            if (typeof browser === "undefined") {
//                var browser = chrome;
//            }
//            var target = e.target, count = +target.dataset.count;
//            target.style.backgroundColor = count === 1 ? "#ff8c00" : '#ffffff';
//            target.dataset.count = count === 1 ? 0 : 1;
//        });
//    const AllIngredients = [];
//    $(document).ready(function inputIngredient(objButton) {
//            if (typeof browser === "undefined") {
//                var browser = chrome;
//            }
//    //AllIngredients.push("test");
//    AllIngredients.push(objButton.value);
//    alert(AllIngredients);
//            //if (collect(AllIngredients).contains(objButton.value)) {
//        //    AllIngredients.pop(objButton.value);
//        //}
//        //else {
//        //    alert(objButton.value);
//        //    AllIngredients.push(objButton.value);
//        //}
//        //return AllIngredients;
//    });
//    $(document).ready(function GotoRecipe() {
//            if (typeof browser === "undefined") {
//                var browser = chrome;
//            }
//    //alert("test");
//    Html.RenderAction("Menu", "Home", new {AllIngredients_posted = AllIngredients});

//        });

//</script>