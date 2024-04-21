<template>
  <div class="mb-4">
    <label class="block text-gray-700 font-medium mb-2">{{
      $props.content
    }}</label>
    <div class="flex flex-wrap -mx-2">
      <div class="px-2 w-1/3" v-for="option in keyedOptions" :key="option.id">
        <label
          class="block text-gray-700 font-medium mb-2"
          :for="`${type}-${id}-${option.id}`"
        >
          <input
            :id="`${type}-${id}-${option.id}`"
            type="checkbox"
            class="mr-2"
            :value="modelValue"
            @input="$emit('update:modelValue', $event.target.value)"
          />
          {{ option.value }}
        </label>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  props: ["id", "content", "type", "options", "modelValue"],
  emits: ["update:modelValue"],
  data() {
    return {
      selected: [],
    };
  },
  computed: {
    keyedOptions() {
      return this.options.map((v, i) => ({ id: i, value: v }));
    },
  },
});
</script>
