<script setup lang="ts">
import RadioQuestion from "../components/QuestionTypes/RadioQuestion.vue";
import CheckBoxQuestion from "../components/QuestionTypes/CheckBoxQuestion.vue";
import TextQuestion from "../components/QuestionTypes/TextQuestion.vue";
import MultiSelectQuestion from "../components/QuestionTypes/MultiSelectQuestion.vue";
</script>

<template>
  <form
    class="bg-white border rounded-lg px-8 py-6 mx-auto my-8 max-w-2xl"
    @submit.prevent="handleSubmit"
  >
    <RadioQuestion
      id="1"
      content="What's your favourite colour?"
      type="radio"
      :options="radioButtonOptions"
    />
    <TextQuestion
      id="2"
      content="Whats your favourite word?"
      type="text"
      :placeholder="textPlaceholder"
    />
    <MultiSelectQuestion
      id="3"
      content="Where did you here about our service?"
      type="multiselect"
      :options="multiSelectOptions"
      v-model:="selectedOptions"
    />
    <CheckBoxQuestion id="4" content="Accept some T&Cs?" type="checkbox" />
    <button
      class="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded w-full"
      type="submit"
    >
      Submit
    </button>
  </form>
</template>

<script lang="ts">
export default {
  props: ["id", "type", "options", "content"],
  setup(props) {
    console.log(props);
  },
  mounted() {
    console.log("blah2");
  },
  data() {
    return {
      title: "Survey Title",
      email: "",
      selectedOption: "",
      radioButtonOptions: ["Red", "Yellow", "Purple", "Orange", "Green"],
      multiSelectOptions: [
        "Search Engine",
        "GP",
        "Social Media",
        "friend or family",
      ],
      textPlaceholder: "enter text here",
      selectedOptions: [],
    };
  },
  methods: {
    handleSubmit(evt) {
      let form = this.getData(evt.target);
      console.log(form)
      console.log(this.selectedOption)
    },
    getData(form) {
      var formData = new FormData(form);

      for (var pair of formData.entries()) {
        console.log(pair[0] + ": " + pair[1]);
      }

      console.log(Object.fromEntries(formData));
    },
  },
};
</script>
