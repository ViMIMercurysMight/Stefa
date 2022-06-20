<template>
  <v-app-bar app color="primary" dark>
    <div class="d-flex align-right">
      <router-link to="/">
        <span class="secondary--text stefa-header-text">Stefa</span>
      </router-link>
    </div>
    <v-spacer></v-spacer>
    <router-link to="/products" class="accent--text">Products</router-link>
    <router-link to="/" class="accent--text">Main</router-link>
    <router-link to="/profile" class="accent--text">Profile</router-link>
    <router-link to="/login" class="accent--text">LogIn</router-link>
    <router-link to="/about" class="accent--text">About</router-link>
  </v-app-bar>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";

@Component
export default class Header extends Vue {
  constructor() {
    super();
  }
}
</script>
<style>
.stefa-header-text {
  font-family: "Estonia", cursive;
  font-size: 64px;
}
</style>
