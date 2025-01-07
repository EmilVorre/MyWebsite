import { createRouter, createWebHistory } from 'vue-router'
import type { RouteRecordRaw } from 'vue-router'
import ProjectList from '../components/ProjectsList.vue'
import ProjectDetail from '../components/ProjectDetail.vue'
import AboutMe from '../components/AboutMe.vue'

const routes: Array<RouteRecordRaw> = [
  { path: '/', component: AboutMe },
  { path: '/projects', component: ProjectList },
  { path: '/project/:id', name: 'ProjectDetail', component: ProjectDetail, props: true }
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router