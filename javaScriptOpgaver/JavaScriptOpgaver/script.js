/*
 * Koden herunder behøver du ikke gøre noget ved.
 * Men du er selvfølgelig velkommen til at kigge på det hvis du er nysgerrig :)
 */

const svgns = "http://www.w3.org/2000/svg";

function drawBox(x, y, width, height, color = "red") {
  const svgElement = document.getElementById("grafik");
  const rect = document.createElementNS(svgns, "rect");
  rect.setAttributeNS(null, "x", x);
  rect.setAttributeNS(null, "y", y);
  rect.setAttributeNS(null, "height", width);
  rect.setAttributeNS(null, "width", height);
  rect.setAttributeNS(null, "fill", color);
  svgElement.appendChild(rect);
}

function drawCircle(cx, cy, radius, color = "red") {
  const svgElement = document.getElementById("grafik");
  const circle = document.createElementNS(svgns, "circle");
  circle.setAttributeNS(null, "cx", cx);
  circle.setAttributeNS(null, "cy", cy);
  circle.setAttributeNS(null, "r", radius);
  circle.setAttributeNS(null, "fill", color);
  circle.setAttributeNS(null, "stroke", "black");
  svgElement.appendChild(circle);
}

function drawLine(x1, y1, x2, y2, stroke = "red") {
  const svgElement = document.getElementById("grafik");
  const line = document.createElementNS(svgns, "line");
  line.setAttributeNS(null, "x1", x1);
  line.setAttributeNS(null, "y1", y1);
  line.setAttributeNS(null, "x2", x2);
  line.setAttributeNS(null, "y2", y2);
  line.setAttributeNS(null, "stroke", stroke);
  line.setAttributeNS(null, "stroke-width", 3);
  svgElement.appendChild(line);
}

function drawText(x, y, inputText) {
  const svgElement = document.getElementById("grafik");
  const text = document.createElementNS(svgns, "text");
  text.setAttributeNS(null, "x", x);
  text.setAttributeNS(null, "y", y);
  text.textContent = inputText;
  svgElement.appendChild(text);
}