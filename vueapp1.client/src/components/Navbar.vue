<script setup lang="ts">
import { ref } from 'vue'

const email = ref('evorre23@student.aau.dk')

const openMailClient = () => {
  window.location.href = `mailto:${email.value}`
}
</script>

<template>
  <nav class="navbar">
    <div class="navbar-left">
      <router-link to="/" class="navbar-link">Emil Vorre's Portfolio</router-link>
    </div>
    <div class="navbar-right">
      <button type="button" @click="openMailClient">Contact Me</button>
    </div>
  </nav>
</template>

<style scoped>
.navbar {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 1em;
  background-color: #333;
  color: white;
  z-index: 1000;
}

.navbar-left {
  font-size: 1.5em;
}

.navbar-link {
  color: white;
  text-decoration: none;
}

.navbar-right {
  margin-right: 2em;
}

.navbar-right button {
  background-color: #42b883;
  color: white;
  border: none;
  padding: 0.5em 1em;
  cursor: pointer;
}

.navbar-right button:hover {
  background-color: #333;
  color: #42b883;
}
</style>