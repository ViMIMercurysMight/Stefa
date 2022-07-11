<template>
  <v-container>
    <v-row>
      <v-col>
        <v-parallax height="900" src="../../assets/img/stefa2.jpg">
          <v-row align="center" justify="center">
            <div class="text-center" :height="'100%'">
              <h1 class="display-2 font-weight-bold mb-3">Your etno wave</h1>
              <p class="subheading font-weight-regular">
                Stefa - is e-shop of moder etno-arts
                <br />Find your best look
              </p>
            </div>
          </v-row>
        </v-parallax>
      </v-col>
    </v-row>

    <div class="text-center accent--text">
      <h2>CREATE YOUR OWN ETNO STYLE</h2>
    </div>
    <v-row>
      <v-col v-for="item in data" :key="item.productName">
        <v-card class="mx-auto my-12">
          <template slot="progress">
            <v-progress-linear
              color="deep-purple"
              height="10"
              indeterminate
            ></v-progress-linear>
          </template>

          <v-img
            height="250"
            src="https://cdn.vuetifyjs.com/images/cards/cooking.png"
          ></v-img>

          <v-card-title>{{ item.productName }}</v-card-title>
          <v-card-subtitle>{{ item.collection }}</v-card-subtitle>
          <v-card-text>
            <v-row align="center" class="mx-0">
              {{ item.description }}
            </v-row>
          </v-card-text>

          <v-divider class="mx-4"></v-divider>
          <v-card-actions>
            <v-btn color="deep-purple lighten-2" text> Order now </v-btn>
          </v-card-actions>
        </v-card>
      </v-col>
    </v-row>

    <v-row>
      <v-col v-for="item in data" :key="item.productName">
        <v-card class="mx-auto my-12">
          <template slot="progress">
            <v-progress-linear
              color="deep-purple"
              height="10"
              indeterminate
            ></v-progress-linear>
          </template>

          <v-img
            height="250"
            src="https://cdn.vuetifyjs.com/images/cards/cooking.png"
          ></v-img>

          <v-card-title>{{ item.productName }}</v-card-title>
          <v-card-subtitle>{{ item.collection }}</v-card-subtitle>
          <v-card-text>
            <v-row align="center" class="mx-0">
              {{ item.description }}
            </v-row>
          </v-card-text>

          <v-divider class="mx-4"></v-divider>
          <v-card-actions>
            <v-btn color="deep-purple lighten-2" text> Order now </v-btn>
          </v-card-actions>
        </v-card>
      </v-col>
    </v-row>

    <v-row>
      <v-btn>To Shop</v-btn>
    </v-row>

    <v-divider></v-divider>

    <div class="text-center accent--text">
      <h2>CREATE YOUR OWN WITH OUR COLLECTION</h2>
    </div>
    <v-row>
      <v-col class="mx-auto">
        <v-carousel cycle :show-arrows="false" :height="'80vh'">
          <v-carousel-item src="../../assets/img/stefa1.jpg"></v-carousel-item>
          <v-carousel-item src="../../assets/img/stefa2.jpg"> </v-carousel-item>
          <v-carousel-item src="../../assets/img/stefa3.jpg"> </v-carousel-item>
        </v-carousel>
      </v-col>
    </v-row>

    <v-row>
      <v-btn>To Collection</v-btn>
    </v-row>

    <v-divider></v-divider>
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

  data: any = [
    {
      productName: "Etno Shirt Reborn",
      collection: "Ento Street",
      Price: "100$",
      Description: "You rebirn etno style for all",
    },
    {
      productName: "Etno Shoe Ukraine",
      collection: "Etno Country",
      Price: "100$",
      Description: "You rebirn etno style for all",
    },
    {
      productName: "Etno Shirt Lepro",
      collection: "Etno City",
      Price: "100$",
      Description: "You rebirn etno style for all",
    },
  ];

  registration() {
    this.$router.push("registration");
  }

  toProducts() {
    this.$router.push("products");
  }
}
</script>
