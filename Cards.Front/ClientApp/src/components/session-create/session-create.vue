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
      <v-row>
        <v-data-table
          :headers="headers"
          :items="sessions"
          :options.sync="options"
          :server-items-length="totalSessions"
          :loading="loading"
          class="elevation-1"
        >
          <template v-slot:[`item.created`]="{ item }">{{ item.created.toLocaleString() }}</template>
          <template v-slot:[`item.modified`]="{ item }">{{ item.created.toLocaleString() }}</template>
        </v-data-table>
      </v-row>
    </v-container>
    <error-handler ref="errorHandler" />
  </v-main>
</template>
<script lang="ts">
import Vue from "vue";
import { VContainer, VRow, VCol, VDataTable } from "vuetify/lib";
import { DataOptions } from "vuetify/types";
import { SessionsClient, IConfig, SessionModel } from "../../client/api-client";
import ErrorHandler from "../error-handler/error-handler.vue";
import Component from "vue-class-component";

@Component({
  components: {
    VDataTable,
  },
})
export default class Sessions extends Vue {
  sessions = new Array<SessionModel>();
  totalSessions = 0;
  sessionsClient = new SessionsClient(new IConfig("dlkdfklsl44kmrf"));
  sessionName = "";
  options!: DataOptions;
  headers = [
    { text: "Название", value: "name" },
    { text: "Дата создания", value: "created" },
    { text: "Дата изменения", value: "modified" },
  ];
  async createSession() {
    try {
      console.log(`sessionName is [${this.sessionName}]`);
      await this.sessionsClient.create(this.sessionName);
      await this;
    } catch (err) {
      (this.$refs.errorHandler as ErrorHandler).display(err);
    }
  }
  async listSessions() {
    const pagingResponse = await this.sessionsClient.list(
      this.options.itemsPerPage,
      this.options.itemsPerPage * (this.options.page - 1)
    );
    this.sessions = pagingResponse.items;
    this.totalSessions = pagingResponse.totalCount;
  }
  async mounted() {
    await this.listSessions();
  }
}
</script>