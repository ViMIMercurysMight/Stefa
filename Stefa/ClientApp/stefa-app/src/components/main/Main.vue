<template>
  <v-container>
    <v-row>
      <v-col cols="8" class="mx-auto">
        <v-carousel cycle :show-arrows="false" :height="'80vh'">
          <v-carousel-item src="../../assets/img/stefa1.jpg"></v-carousel-item>
          <v-carousel-item src="../../assets/img/stefa2.jpg"></v-carousel-item>
          <v-carousel-item src="../../assets/img/stefa3.jpg"></v-carousel-item>
        </v-carousel>
      </v-col>

      <v-col class="text-center">
        <v-card :height="'100%'">
          <v-card-text>
            <h1 class="display-2 font-weight-bold mb-3">Your etno wave</h1>
            <p class="subheading font-weight-regular">
              Stefa - is e-shop of moder etno-arts
              <br />Find your best look
            </p>
          </v-card-text>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";
import Carousel from "../common/Carousel.vue";

@Component({
  components: {
    Carousel,
  },
})
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
