export default class ProductProfile {
  basketList: string[] = [""];
  query: string | null = null;
  price = 10000;
  category = "";
  brand: string | null = "";
  productsList: string[] = [];

  fromBasket(id: string, qty = 1) {
    return;
  }

  toBasket(id: string, qty = 1) {
    return;
  }

  rate(rate: number) {
    return;
  }

  async order() {
    return;
  }

  async loadDetail() {
    return;
  }

  async load() {
    return;
  }

  reset() {
    return;
  }
}
