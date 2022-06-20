<template>
  <div class="about">
    <h1>This is Order Page</h1>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";

@Component
export default class Order extends Vue {
  constructor() {
    super();
  }

  reset() {
    throw new Error("Order reset process not implemented now");
  }

  removePosition() {
    throw new Error("Order remove position process not implemented now");
  }

  proceedOrder() {
    throw new Error("Order proceeding process not implemented now");
  }
}
</script>
