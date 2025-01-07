<script setup lang="ts">

</script>

<template>
  <div class="about-me">
    <div class="box image-box">
      <img src="./../assets/Me.png" alt="About Me Image" />
    </div>
    <div class="box text-box">
      <h2>About Me</h2>
      <p>Hi, I’m a 23-year-old computer science student in my third semester at Aalborg University, based in Aalborg, Denmark. Passionate about technology and innovation, I enjoy gaming and coding personal projects in my free time to deepen my skills and explore new ideas in the field.</p>
    </div>
  </div>
</template>

<style scoped>
.about-me {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 1em;
}

.box {
  flex: 1;
  margin: 0.5em;
}

.image-box img {
  max-width: 60%;
  height: auto;
}

.text-box {
  padding: 1em;
  border-radius: 8px;
}
</style>