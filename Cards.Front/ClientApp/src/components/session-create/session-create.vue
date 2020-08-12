<template>
  <v-main>
    <v-container fluid>
      <v-row>
        <v-col cols="8">
          <v-text-field label="Имя сеанса" v-model="sessionName"></v-text-field>
        </v-col>
        <v-col>
          <v-btn v-on:click="createSession">Создать</v-btn>
        </v-col>
      </v-row>
      <!-- <v-row>
        <v-data-table
          :headers="headers"
          :items="desserts"
          :options.sync="options"
          :server-items-length="totalDesserts"
          :loading="loading"
          class="elevation-1"
        ></v-data-table>
      </v-row>-->
    </v-container>
    <error-handler ref="errorHandler"/>
  </v-main>
</template>
<script lang="ts">
import Vue from "vue";
import { VContainer, VRow, VCol } from "vuetify/lib";
import { SessionsClient, IConfig, SessionModel } from "../../client/api-client";
import ErrorHandler from "../error-handler/error-handler.vue";

export default Vue.extend({
  name: "session-create",
  components: {
    VContainer,
    VRow,
    VCol,
    ErrorHandler,
  },
  data() {
    return {
      sessions: new Array<SessionModel>(),
      sessionsClient: new SessionsClient(new IConfig("dlkdfklsl44kmrf")),
      sessionName: "",
      pageSize: 10,
    };
  },
  methods: {
    async createSession() {
        try {
            console.log(`sessionName is [${this.sessionName}]`);
            await this.sessionsClient.create(this.sessionName);
        }
        catch(err) {
            (this.$refs.errorHandler as ErrorHandler).display(err)
        }
    },
    async listSessions() {
      this.sessions = await this.sessionsClient.list(this.pageSize, 0);
    },
  },
});
</script>