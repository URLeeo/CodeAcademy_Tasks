document.addEventListener("DOMContentLoaded", function () {
  const num1El = document.getElementById("num1");
  const num2El = document.getElementById("num2");
  const resultEl = document.getElementById("result");

  const btnAdd = document.getElementById("add");
  const btnSub = document.getElementById("sub");
  const btnMul = document.getElementById("mul");
  const btnDiv = document.getElementById("div");

  function readNumbers() {
    const aRaw = num1El.value;
    const bRaw = num2El.value;
    const a = aRaw === "" ? NaN : parseFloat(aRaw);
    const b = bRaw === "" ? NaN : parseFloat(bRaw);
    return { a, b };
  }

  function showMessage(msg) {
    resultEl.value = msg;
  }

  function compute(op) {
    const { a, b } = readNumbers();
    if (isNaN(a) || isNaN(b)) {
      showMessage("Her iki reqemi daxil edin");
      return;
    }

    let res;
    switch (op) {
      case "+":
        res = a + b;
        break;
      case "-":
        res = a - b;
        break;
      case "*":
        res = a * b;
        break;
      case "/":
        if (b === 0) {
          showMessage("0 a bolmek olmaz");
          return;
        }
        res = a / b;
        break;
      default:
        return;
    }

    if (Number.isFinite(res) && Math.abs(res - Math.round(res)) < 1e-12) {
      res = Math.round(res);
    } else if (Number.isFinite(res)) {
      res = parseFloat(res.toFixed(8));
    }

    showMessage(res);
  }

  btnAdd.addEventListener("click", () => compute("+"));
  btnSub.addEventListener("click", () => compute("-"));
  btnMul.addEventListener("click", () => compute("*"));
  btnDiv.addEventListener("click", () => compute("/"));
});
