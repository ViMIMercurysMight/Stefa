<template>
  <div class="about">
    <h1>This is user Bucket Modal Window</h1>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";

@Component
export default class Bucket extends Vue {
  constructor() {
    super();
  }

  toOrder() {
    this.$router.push("order");
  }
}
</script>
