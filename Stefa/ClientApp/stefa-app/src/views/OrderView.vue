<template>
  <div class="about">
    <h1>This is an Order View</h1>
    <br />
    <hr />
    <form>
      <input type="email" placeholder="Enter Your Email Address" />
      <input type="tel" placeholder="Enter Your Phone" />
      <input type="text" placeholder="Enter Your First Name" />
      <input type="text" placeholder="Enter Your Last Name" />
      <select>
        <option>Nove Poshta</option>

        <option>Samovivoz</option>
      </select>
    </form>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";

@Component
export default class OrderView extends Vue {
  constructor() {
    super();
  }
}
</script>
