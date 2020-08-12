<template src="./session-create.html">
</template>
<style scoped src="./session-create.css">
</style>
<script lang="ts">

import Vue from 'vue'
import {VContainer, VRow, VCol} from 'vuetify/lib'
import {SessionsClient, IConfig} from "../../client/api-client"

export default Vue.extend({
    name: 'session-create',
    components:{
        VContainer,
        VRow,
        VCol
    },
    data() {
        return {
            sessionsClient: new SessionsClient(new IConfig("dlkdfklsl44kmrf")),
            sessionName: "",
            pageSize: 10
        }
    },
    methods: {
        async createSession() {
            console.log(`sessionName is [${this.sessionName}]`);
            await this.sessionsClient.create(this.sessionName);
        },
        async listSessions(){

        }
    }
})
</script>