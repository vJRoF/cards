<template src="./session-create.html">
</template>
<style scoped src="./session-create.css">
</style>
<script lang="ts">

import Vue from 'vue'
import {VContainer, VRow, VCol} from 'vuetify/lib'
import {ApiClient, IConfig} from "../../client/api-client"

export default Vue.extend({
    name: 'session-create',
    components:{
        VContainer,
        VRow,
        VCol
    },
    data() {
        return {
            sessionName: ""
        }
    },
    methods: {
        async createSession() {
            const client = new ApiClient(new IConfig("dlkdfklsl44kmrf"));
            console.log(`sessionName is [${this.sessionName}]`);
            await client.create(this.sessionName);
        }
    }
})
</script>