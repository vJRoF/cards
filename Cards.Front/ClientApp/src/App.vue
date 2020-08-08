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

    <v-content>
      <v-btn v-on:click="addCard">
        PUSH ME
      </v-btn>
    </v-content>
  </v-app>
</template>

<script lang="ts">
import Vue from 'vue';
import * as signalR from "@microsoft/signalr";
import { ApiClient, IConfig } from "./client/api-client";

export default Vue.extend({
  name: 'App',

  components: {
  },

  data: () => ({
    //
  }),
  methods:{
    addCard: async () => {
      const client = new ApiClient(new IConfig("dfdfdf"));
      await client.card();
    }
  },
  mounted: () => {
    const connection = new signalR.HubConnectionBuilder()
    .withUrl('/hub')
    .build();
  },
});
</script>
