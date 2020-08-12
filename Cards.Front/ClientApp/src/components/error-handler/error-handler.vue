<template>
  <v-dialog v-model="dialog" max-width="290">
      <v-card>
          <v-card-title>
              Ошибка
          </v-card-title>
          <v-card-text>
              {{message}}
          </v-card-text>
          <v-card-actions>
              <v-btn
                @click="dismiss">
                Увы
              </v-btn>
          </v-card-actions>
      </v-card>
  </v-dialog>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";

@Component
export default class ErrorHandler extends Vue {
    dialog = false;
    message = '';
    
    display(message: string) {
        this.message = message;
        this.dialog = true;
    }

    dismiss() {
        this.dialog = false;
    }
}
</script>