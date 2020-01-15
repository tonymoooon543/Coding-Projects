// This will print the date on the screen in 'demo' paragraph
function changeP() {
  document.getElementById('demo').innerHTML = Date();
}

function promptInput() {
  var person = prompt("Please enter your name")
  if (person != null) {
    document.getElementById('name').innerHTML = "Hello " + person + ", how are you doing"
  }
}
