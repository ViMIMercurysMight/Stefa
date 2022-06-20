<template>
  <v-footer absolute padless color="secondary">
    <v-card flat tile width="100%" color="primary" class="text-center">
      <v-card-text>
        <v-btn class="mx-4" icon>
          <v-icon size="24px"> mdi-home </v-icon>
        </v-btn>
      </v-card-text>

      <v-divider></v-divider>

      <v-card-text class="accent--text">
        {{ new Date().getFullYear() }} <strong>Stefa</strong>
      </v-card-text>
    </v-card>
  </v-footer>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";

@Component
export default class Footer extends Vue {
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
