<template>
  <div class="about">
    <h1>This is user Products Item</h1>
    <v-btn text @click="toDetail">To Detail</v-btn>
    <v-btn text @click="addToBacket"> Add To Backet </v-btn>
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from "vue-property-decorator";

@Component
export default class ProductItem extends Vue {
  @Prop({ default: "" }) readonly id!: string;

  constructor() {
    super();
  }

  addToBacket() {
    throw new Error("Add To backet not implemmentd yet");
  }

  toDetail() {
    this.$router.push("products/" + this.id);
  }
}
</script>
