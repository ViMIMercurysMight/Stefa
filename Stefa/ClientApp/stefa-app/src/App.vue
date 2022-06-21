<template>
  <v-app style="background: #f9f9f9">
    <Header></Header>
    <v-main>
      <router-view />
    </v-main>
  </v-app>
</template>

<script lang="ts">
import Vue from "vue";
import Header from "../src/components/common/Header.vue";
export default Vue.extend({
  name: "App",

  components: {
    Header,
  },
  data: () => ({
    //      font-family: "Water Brush", cursive;
    //:style="{ background: $vuetify.theme.themes[theme].background }"
  }),
});
</script>
