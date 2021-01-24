interface Observer {
    update(hexColor : string) : void;
}

interface Observable {
    observers : Observer[]
    registerObserver(obs: Observer): void;
    removeObserver(obs: Observer): void;
    notifyObservers() : void;
}

class Button implements Observable {
    private hexColor: string;
    buttonEl : HTMLButtonElement
    observers: Observer[];

    constructor(){
        this.observers = [];
        this.buttonEl = document.createElement('button')
        this.buttonEl.innerText = 'Observable, people will watch me'
        this.hexColor = ''
        this.buttonEl.addEventListener('click', () => {
            const hexColorInput = document.querySelector('#hexColorInput') as HTMLButtonElement
            const newHexColor = hexColorInput.value as string
            this.hexColor = newHexColor;
            this.notifyObservers()
        }) 
    }

    registerObserver(obs: Observer): void {
        this.observers.push(obs);
    }
    removeObserver(obs: Observer): void {
        this.observers = this.observers.filter( obsFromArray => obsFromArray != obs)
    }
    notifyObservers(): void {
        this.observers.forEach(obs => obs.update(this.hexColor))
    }


}

class Div implements Observer {
    divEl : HTMLDivElement

    constructor(){
        this.divEl = document.createElement('div')
        this.divEl.innerHTML = "I will observe"
    }

    update(hexColor : string) {
        this.divEl.style.backgroundColor = hexColor
    }

}

const rootEl = document.querySelector('.root') as HTMLDivElement

const observableButton = new Button()
const div1 = new Div()
const div2 = new Div()
observableButton.registerObserver(div1)
observableButton.registerObserver(div2)

rootEl.appendChild(observableButton.buttonEl)
rootEl.appendChild(div1.divEl)
rootEl.appendChild(div2.divEl)