<template>
  <div class="about">
    <h1>This is Comment Edit Form</h1>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";

@Component
export default class CommentEditForm extends Vue {
  constructor() {
    super();
  }

  publicComment() {
    throw new Error("Public comment process not implemented now");
  }

  attachFile() {
    throw new Error("File Attachement process not implemented now");
  }
}
</script>
