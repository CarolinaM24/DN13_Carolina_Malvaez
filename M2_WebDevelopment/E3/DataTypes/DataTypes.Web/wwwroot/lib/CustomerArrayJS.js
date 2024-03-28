
class Customer {
    constructor(name, registrationDate) {
        this.name = name;
        this.registrationDate = registrationDate;
    }
}

var customerArray = [
    new Customer("Cliente 1", new Date()),
    new Customer("Cliente 2", new Date()),
    new Customer("Cliente 3", new Date()),
    new Customer("Cliente 4", new Date()),
    new Customer("Cliente 5", new Date()),
    new Customer("Cliente 6", new Date()),
    new Customer("Cliente 7", new Date()),
    new Customer("Cliente 8", new Date()),
    new Customer("Cliente 9", new Date()),
    new Customer("Cliente 10", new Date())
];

var ul = document.createElement("ul");
for (var i = 0; i < customerArray.length; i++) {
    var li = document.createElement("li");
    li.textContent = `Nombre del cliente: ${customerArray[i].name}, Fecha de registro: ${customerArray[i].registrationDate}`;
    ul.appendChild(li);
}
document.body.appendChild(ul);
