<template>
  <v-container>
    <v-row class="text-center">
      <v-col cols="12">
        <v-img
          :src="require('../../assets/img/stefa2.jpg')"
          class="my-3"
          contain
          height="200"
        />
      </v-col>

      <v-col class="mb-4">
        <h1 class="display-2 font-weight-bold mb-3">Your etno wave</h1>

        <p class="subheading font-weight-regular">
          Stefa - is e-shop of moder etno-arts
          <br />Find your best look
        </p>
      </v-col>
    </v-row>
  </v-container>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";

@Component
export default class Main extends Vue {
  constructor() {
    super();
  }

  registration() {
    this.$router.push("registration");
  }

  toProducts() {
    this.$router.push("products");
  }
}
</script>
