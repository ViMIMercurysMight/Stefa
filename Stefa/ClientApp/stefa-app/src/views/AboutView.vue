<template>
  <div class="about">
    <h1>This is an about page</h1>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";

@Component
export default class AboutView extends Vue {
  constructor() {
    super();
  }

  registration() {
    this.$router.push("registration");
  }
}
</script>
