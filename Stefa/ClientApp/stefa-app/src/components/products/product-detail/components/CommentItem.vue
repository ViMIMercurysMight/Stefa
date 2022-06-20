<template>
  <div class="about">
    <h1>This is commentItem</h1>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";

@Component
export default class CommentItem extends Vue {
  constructor() {
    super();
  }

  edit() {
    throw new Error("Comment edit process not implemented now");
  }
}
</script>
