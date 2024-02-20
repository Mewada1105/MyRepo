// Using var
console.log("Using var:");
var itemsVar = [1, 2, 3];

for (var i = 0; i < itemsVar.length; i++) {
  setTimeout(function() {
    console.log("Item at index", i, "is", itemsVar[i]);
  }, 1000);
}

// Using let
console.log("\nUsing let:");
let itemsLet = [1, 2, 3];

for (let j = 0; j < itemsLet.length; j++) {
  setTimeout(function() {
    console.log("Item at index", j, "is", itemsLet[j]);
  }, 1000);
}
