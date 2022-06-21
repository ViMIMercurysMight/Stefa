<template>
  <v-app-bar elevation="0" app color="primary" dark>
    <v-app-bar-title class="d-flex align-right">
      <router-link to="/">
        <span class="accent--text stefa-header-text">Stefa</span>
      </router-link>
    </v-app-bar-title>
    <v-row class="nav-container mx-auto">
      <v-col v-for="(route, index) in navigation" :key="index">
        <router-link class="secondary--text nav-item" :to="route.path">{{
          route.text
        }}</router-link>
      </v-col>
    </v-row>
  </v-app-bar>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";

@Component
export default class Header extends Vue {
  navigation: any = [
    { path: "/products", text: "Products" },
    { path: "/", text: "Main" },
    { path: "/profile", text: "Profile" },
    { path: "/login", text: "Login" },
    { path: "/about", text: "About" },
  ];

  constructor() {
    super();
  }
}
</script>
<style>
.stefa-header-text {
  font-family: "Estonia", cursive;
  font-size: 4em;
}

.nav-item {
  font-family: "Estonia", cursive;
  font-size: 3em;
  text-decoration: none;
}

.nav-container {
  max-width: 75vh;
}
</style>
