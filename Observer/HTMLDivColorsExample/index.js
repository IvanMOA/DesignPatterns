"use strict";
var Button = /** @class */ (function () {
    function Button() {
        var _this = this;
        this.observers = [];
        this.buttonEl = document.createElement('button');
        this.buttonEl.innerText = 'Observable, people will watch me';
        this.hexColor = '';
        this.buttonEl.addEventListener('click', function () {
            var hexColorInput = document.querySelector('#hexColorInput');
            var newHexColor = hexColorInput.value;
            _this.hexColor = newHexColor;
            _this.notifyObservers();
        });
    }
    Button.prototype.registerObserver = function (obs) {
        this.observers.push(obs);
    };
    Button.prototype.removeObserver = function (obs) {
        this.observers = this.observers.filter(function (obsFromArray) { return obsFromArray != obs; });
    };
    Button.prototype.notifyObservers = function () {
        var _this = this;
        this.observers.forEach(function (obs) { return obs.update(_this.hexColor); });
    };
    return Button;
}());
var Div = /** @class */ (function () {
    function Div() {
        this.divEl = document.createElement('div');
        this.divEl.innerHTML = "I will observe";
    }
    Div.prototype.update = function (hexColor) {
        this.divEl.style.backgroundColor = hexColor;
    };
    return Div;
}());
var rootEl = document.querySelector('.root');
var observableButton = new Button();
var div1 = new Div();
var div2 = new Div();
observableButton.registerObserver(div1);
observableButton.registerObserver(div2);
rootEl.appendChild(observableButton.buttonEl);
rootEl.appendChild(div1.divEl);
rootEl.appendChild(div2.divEl);
