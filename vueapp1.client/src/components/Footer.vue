<script setup lang="ts">
import { ref } from 'vue'

const email = ref('evorre23@student.aau.dk')
const phoneNumber = ref('+45 31 64 52 22')

const showMail = () => {
  alert(`Mail: ${email.value}`)
}

const showPhoneNumber = () => {
  alert(`Phone Number: ${phoneNumber.value}`)
}
</script>

<template>
  <footer class="footer">
    <div class="footer-images">
      <img src="./../assets/email.png" alt="email" @click="showMail" style="cursor: pointer;" />
      <a href="https://github.com/EmilVorre" target="_blank">
        <img src="./../assets/github.png" alt="github" />
      </a>
      <a href="https://www.linkedin.com/in/emil-vorre-112560273/" target="_blank">
        <img src="./../assets/linkedin.png" alt="linkedin" />
      </a>
      <img src="./../assets/phone.png" alt="phone" @click="showPhoneNumber" style="cursor: pointer;" />
    </div>
  </footer>
</template>

<style scoped>
.footer {
  display: flex;
  position: fixed;
  bottom: 0;
  width: 100%;
  left: 0;
  justify-content: center;
  align-items: center;
  padding: 0.5em;
  background-color: #333;
  color: white;
}

.footer-images {
  display: flex;
  gap: 1em;
}

.footer-images img {
  width: 30px;
  height: 30px;
}
</style>