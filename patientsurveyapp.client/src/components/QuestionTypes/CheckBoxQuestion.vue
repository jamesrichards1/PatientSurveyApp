<template>
  <div class="mb-4">
    <label class="block text-gray-700 font-medium mb-2">{{
      $props.content
    }}</label>
    <div class="flex flex-wrap -mx-2">
      <div class="px-2 w-1/3">
        <label
          :for="`${type}-${id}`"
          class="block text-gray-700 font-medium mb-2"
        >
          <input 
          :name="id"
          :id="`${type}-${id}`"
          type="checkbox" 
          class="mr-2"
          />
        </label>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  props: ["id", "content", "type"],
});
</script>
