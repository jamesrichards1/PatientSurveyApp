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
            type="text"
            :id="`${type}-${id}`"
            :name="id"
            :placeholder="placeholder"
            class="mr-2 italic"
          />
        </label>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  props: ["id", "content", "type", "placeholder"],
});
</script>
