import Vue from 'vue'
import App from './App.vue'
import router from './router'
import { CardsClient } from './cardsclient'

Vue.config.productionTip = false

new Vue({
  router,
  render: h => h(App),
  mounted(){
    const cc = new CardsClient();
    cc.picture(1, "ddd")
      .then(_ => alert('ура)))'))
      .catch(_ => alert('пиздец((('));
  }
}).$mount('#app')
