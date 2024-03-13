import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import MissionView from '../views/MissionView.vue'

import Demo1View from '../views/Demo1View.vue'
import Demo2View from '../views/Demo2View.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView
    },
    {
      path: '/mission',
      name: 'mission',
      // route level code-splitting
      // this generates a separate chunk (About.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: MissionView
    },
    {
      path: '/demo1',
      name: 'Demo1',
      component: Demo1View
    },
    {
      path: '/demo2',
      name: 'Demo2',
      component: Demo2View
    },
  ]
})

export default router
