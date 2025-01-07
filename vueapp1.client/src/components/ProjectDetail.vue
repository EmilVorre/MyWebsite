<script setup lang="ts">
import { defineProps, ref, onMounted } from 'vue'
import axios from 'axios'

const props = defineProps<{ id: number }>()

const project = ref({
  id: props.id,
  image: '',
  title: '',
  description: '',
  details: ''
})

// Fetch project details based on the id
onMounted(async () => {
  try {
    const response = await axios.get(`http://emilvorre.dk/projects/${props.id}`)
    project.value = response.data
  } catch (error) {
    console.error('Error fetching project details:', error)
  }
})
</script>

<template>
  <div class="project-detail">
    <img :src="project.image" :alt="project.title" class="project-image" />
    <h1>{{ project.title }}</h1>
    <p>{{ project.description }}</p>
    <p>{{ project.details }}</p>
  </div>
</template>

<style scoped>
.project-detail {
  padding: 1em;
}

.project-image {
  width: 100%;
  height: auto;
  border-radius: 4px;
}
</style>
