<template>
  <v-app>
    <v-app-bar
      app
      color="primary"
      dark
    >
      <div class="d-flex align-center">
        <v-img
          alt="Vuetify Logo"
          class="shrink mr-2"
          contain
          src="https://cdn.vuetifyjs.com/images/logos/vuetify-logo-dark.png"
          transition="scale-transition"
          width="40"
        />

        <v-img
          alt="Vuetify Name"
          class="shrink mt-1 hidden-sm-and-down"
          contain
          min-width="100"
          src="https://cdn.vuetifyjs.com/images/logos/vuetify-name-dark.png"
          width="100"
        />
      </div>

      <v-spacer></v-spacer>

      <v-btn
        href="https://github.com/vuetifyjs/vuetify/releases/latest"
        target="_blank"
        text
      >
        <span class="mr-2">Latest Release</span>
        <v-icon>mdi-open-in-new</v-icon>
      </v-btn>
    </v-app-bar>

    <v-main>
      <v-btn v-on:click="addCard">
        PUSH ME
      </v-btn>
      <div v-for="message in messages" :key="message[0]">
        {{message[1]}}
      </div>
      <session-create/>
    </v-main>
  </v-app>
</template>

<script lang="ts">
import Vue from 'vue';
import * as signalR from "@microsoft/signalr";
import { ApiClient, IConfig } from "./client/api-client";
import sessionCreate from "./components/session-create/session-create.vue";

export default Vue.extend({
  name: 'App',

  components: {
    sessionCreate
  },

  data: () => ({
      messages: new Array<[number, string]>()
  }),
  methods:{
    addCard: async () => {
      const client = new ApiClient(new IConfig("dfdfdf"));
      await client.card();
    },
    addMessage: function (username: number, message: string) {
      this.messages.push([this.messages.length, message]);
    }
  },
  mounted: function () {
    const connection = new signalR.HubConnectionBuilder()
      .withUrl('/hub')
      .build();
      
    connection.on('messageRecieved', this.addMessage);
    connection.start().catch(err => console.log(err));
  },
});
</script>
