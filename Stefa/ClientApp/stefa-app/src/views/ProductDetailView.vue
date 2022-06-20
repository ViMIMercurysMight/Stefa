<template>
  <div class="about">
    <h1>This is an log in Page page</h1>
    <v-btn text @click="buyItem"> Buy Item </v-btn>

    <v-btn text @click="toFavourite"> To Favourite </v-btn>

    <v-btn text @click="toBucket"> To Buccket </v-btn>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";

@Component
export default class ProductDetailView extends Vue {
  constructor() {
    super();
  }

  buyItem() {
    this.$router.push("order");
  }

  toBucket() {
    throw new Error("To Buacket process not implemented now");
  }

  toFavourite() {
    throw new Error("To Favorite process not implemented now");
  }
  fromFavourite() {
    throw new Error("from Favorite process not implemented now");
  }
}
</script>
