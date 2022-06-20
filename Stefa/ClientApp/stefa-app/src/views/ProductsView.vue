<template>
  <div class="about">
    <h1>This is an Product View</h1>
    <Filters></Filters>
    <hr />
    <ProductsList></ProductsList>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";
import Filters from "../components/products/Filters.vue";
import ProductsList from "../components/products/ProductsList.vue";

@Component({
  components: {
    Filters,
    ProductsList,
  },
})
export default class ProductsView extends Vue {
  constructor() {
    super();
  }
}
</script>
