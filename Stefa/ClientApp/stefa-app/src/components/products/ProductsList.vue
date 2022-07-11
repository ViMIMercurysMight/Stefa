<template>
  <div>
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
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import ProductItem from "./ProductItem.vue";

@Component({
  components: {
    ProductItem,
  },
})
export default class ProductsList extends Vue {
  products: number[] = [10, 22, 27234, 33, 99, 23];

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

  constructor() {
    super();
  }
}
</script>
