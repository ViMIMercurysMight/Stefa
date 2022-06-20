<template>
  <v-app>
    <Header></Header>
    <v-main>
      <router-view />
    </v-main>
    <Footer></Footer>
  </v-app>
</template>

<script lang="ts">
import Vue from "vue";
import Footer from "../src/components/common/Footer.vue";
import Header from "../src/components/common/Header.vue";
export default Vue.extend({
  name: "App",

  components: {
    Footer,
    Header,
  },
  data: () => ({
    //      font-family: "Water Brush", cursive;
  }),
});
</script>
<style>
.stefa-header-text {
  font-family: "Estonia", cursive;
  font-size: 64px;
}
</style>
