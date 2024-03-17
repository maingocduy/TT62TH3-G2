import './assets/main.css'

import { createApp } from 'vue'
import App from './App.vue'
import router from './router'

const app = createApp(App)

app.use(router)

app.mount('#app')

import axios from 'axios';

axios.get('https://api.example.com/data')
  .then(response => {
    // Xử lý phản hồi
    console.log(response.data);
  })
  .catch(error => {
    // Xử lý lỗi
    console.error('Lỗi khi truy vấn dữ liệu:', error);
  });
