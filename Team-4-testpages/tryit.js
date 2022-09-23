var ctx = new (window.AudioContext || window.webkitAudioContext)();
console.log(ctx);
let audio = new Audio("ArcticM.mp3");
audio.crossOrigin = "anonymous";

const source = ctx.createMediaElementSource(audio);
source.connect(ctx.destination);
//audio.play();
/*
fetch("./Rickroll.mp3")
  .then(data => data.arrayBuffer())
  .then(arrayBuffer => ctx.decodeAudioData(arrayBuffer))
  .then(decodedAudio => {
    audio = decodedAudio;
  });
*/
  function playback() {
    const playSound = ctx.createBufferSource();
    playSound.buffer = audio;
    playSound.connect(ctx.destination);
    playSound.start(ctx.currentTime);

    console.log(ctx.currentTime);
  }

  var btn = document.getElementById('btn')
  btn.addEventListener('click', function(){
   audio.play();
   console.log(ctx.currentTime);
  });


  //window.addEventListener("mousedown",);
