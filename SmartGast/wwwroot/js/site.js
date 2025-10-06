// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const anima = document.querySelector("body > div > main");
if (anima) {
    anima.animate(
        [
            { opacity: 0, transform: "translateY(25px)" },
            { opacity: 1, transform: "translateY(0)" }
        ],
        {
            duration: 1000,   // 1 second
            iterations: 1,    // play once
            fill: "forwards", // keep final state
            easing: "ease-out"
        }
    );
}