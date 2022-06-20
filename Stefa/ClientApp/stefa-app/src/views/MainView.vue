<template>
  <Main />
</template>

<script lang="ts">
import Vue from "vue";
import Main from "../components/main/Main.vue";

export default Vue.extend({
  name: "main-view",

  components: {
    Main,
  },
});
</script>
