<template>
  <div class="mb-4">
    <label class="block text-gray-700 font-medium mb-2">{{
      $props.content
    }}</label>
    <div class="flex flex-wrap -mx-2">
      <div class="px-2 w-1/3" v-for="option in keyedOptions" :key="option.id">
        <label class="block text-gray-700 font-medium mb-2" :for="`${type}-${id}-${option.id}`">
          <input
            :name="id"
            :id="`${type}-${id}-${option.id}`"
            type="radio"
            class="mr-2"
            :value="option.value"
          /> {{ option.value }}
        </label>
      </div>
    </div>
  </div>
</template>

<script lang="ts">

export default{
    props:[
        "id",
        "type",
        "options",
        "content"
    ],
    computed:{
      keyedOptions(){
        return this.options.map((v, i) => ({id : i, value : v}));
      }
    },
    setup(props) {
        console.log(props)
    },
    mounted() {
        console.log("blah2");
    }
}

</script>
