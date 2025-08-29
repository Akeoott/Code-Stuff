// Always-on glitter overlay
const gliterOverlay = document.getElementById('gliter-overlay');

if (gliterOverlay) {
    gliterOverlay.innerHTML = '<img src="./assets/gliter.gif" alt="Glitter effect" draggable="false">';
    gliterOverlay.classList.add('active');
    gliterOverlay.style.display = 'block';
}