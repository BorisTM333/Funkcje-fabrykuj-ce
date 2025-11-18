function createProduct(name, price, stock) {

  if (price <= 0) {
    console.log("Cena była niepoprawna, ustawiono 1");
    price = 1;
  }

  if (stock < 0) {
    console.log("Ilość była niepoprawna, ustawiono 0");
    stock = 0;
  }

  return {
    name,
    price,
    stock,
    totalValue: price * stock,

    displayProduct() {
      console.log(
        "Produkt: " + this.name +
        " | Cena: " + this.price + " zł" +
        " | Dostępne: " + this.stock + " szt." +
        " | Wartość: " + this.totalValue + " zł"
      );
    },

    restock(quantity) {
      console.log("Dodano " + quantity + " sztuk do magazynu");
    },

    discount(percentage) {
      console.log("Zastosowano " + percentage + "% rabatu");
    }
  };
}

const product1 = createProduct("Monitor", 899, 12);

const product2 = createProduct("Klawiatura", -50, -10);

product1.displayProduct();
product1.restock(20);
product1.discount(15);

product2.displayProduct();
product2.restock(5);
product2.discount(10);
