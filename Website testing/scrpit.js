var audioplay = document.getElementById('audio');

// This will print the date on the screen in 'demo' paragraph
function changeP() {
  document.getElementById('demo').innerHTML = Date();
}

function playAudio() {
  audioplay.play();
}

function pauseAudio() {
  audioplay.pause(); 
}
