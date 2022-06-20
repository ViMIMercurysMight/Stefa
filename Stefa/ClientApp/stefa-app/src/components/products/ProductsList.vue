<template>
  <div>
    <div v-for="product in products" class="about" :key="product">
      <ProductItem :id="product"></ProductItem>
    </div>
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import ProductItem from "./ProductItem.vue";

@Component({
  components: {
    ProductItem,
  },
})
export default class ProductsList extends Vue {
  products: number[] = [10, 22, 27234, 33, 99, 23];
  constructor() {
    super();
  }
}
</script>
