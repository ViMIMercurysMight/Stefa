<template>
  <v-app>
    <v-app-bar app color="primary" dark>
      <div class="d-flex align-right">
        <span class="secondary--text stefa-header-text">Stefa</span>
      </div>

      <v-spacer></v-spacer>
    </v-app-bar>

    <v-main>
      <router-view />
    </v-main>

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
  </v-app>
</template>

<script lang="ts">
import Vue from "vue";

export default Vue.extend({
  name: "App",

  data: () => ({
    //
  }),
});
</script>
<style>
.stefa-header-text {
  font-family: "Water Brush", cursive;
  font-size: 64px;
}
</style>
