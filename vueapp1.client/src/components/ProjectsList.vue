<script>
import axios from 'axios';

export default {
  name: "ProjectList",
  data() {
    return {
      projects: [],
    };
  },
  async created() {
    try {
      const response = await axios.get('http://emilvorre.dk/projects');
      console.log('Fetched projects:', response.data); // Log the fetched data
      this.projects = response.data;
    } catch (error) {
      console.error('Error fetching projects:', error);
    }
  },
};
</script>

<template>
  <div class="project-list">
    <h2>Projects</h2>
    <p>Here are some of the projects I have worked on:</p>
    <div class="project-grid">
      <div class="project-card" v-for="project in projects" :key="project.id">
        <div class="image-container">
          <img :src="`/images/${project.image}`" :alt="project.title" class="project-image" />
        </div>
        <div class="text-container">
          <h2 class="project-title">{{ project.title }}</h2>
          <p class="project-description">{{ project.description }}</p>
          <a :href="project.link" class="read-more-button" target="_blank" rel="noopener noreferrer">Github</a>
        </div>
      </div>
    </div>
  </div>
</template>

<style scoped>
.project-list {
  text-align: left; 
  padding: 1em;
}

.project-grid {
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(200px, 1fr));
  gap: 1em;
}

.project-card {
  background-color: #fff;
  border: 1px solid #ddd;
  border-radius: 8px;
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
  display: flex;
  flex-direction: column;
  align-items: center;
  text-align: center;
}

.image-container {
  width: 100%;
  height: 125px;
  display: flex;
  justify-content: center;
  align-items: center;
  overflow: hidden;
}

.project-image {
  width: 100%;
  object-fit: cover;
}

.text-container {
  padding: 1em;
  width: 100%;
  display: flex;
  flex-direction: column;
  flex-grow: 1;
}

.project-title {
  font-size: 1.2em;
  margin-bottom: 0.5em;
}

.project-description {
  font-size: 1em;
  color: #666;
  margin-bottom: 1em;
}

.read-more-button {
  display: inline-block;
  padding: 0.5em 1em;
  background-color: #42b883;
  color: white;
  text-decoration: none;
  border-radius: 4px;
  text-align: center;
  margin-left: 3em;
  margin-right: 3em;
  margin-top: auto; /* Push button to the bottom */
}

.read-more-button:hover {
  background-color: #333;
  color: #42b883;
}
</style>
