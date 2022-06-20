<template>
  <div class="about">
    <h1>This is an log in Page page</h1>
    <v-btn text @click="registration"> Registrate now </v-btn>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";

@Component
export default class LogInView extends Vue {
  constructor() {
    super();
  }

  registration() {
    this.$router.push("registration");
  }
}
</script>
