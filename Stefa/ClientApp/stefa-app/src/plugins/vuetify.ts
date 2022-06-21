import Vue from "vue";
import Vuetify from "vuetify/lib/framework";

Vue.use(Vuetify);

export default new Vuetify({
  theme: {
    themes: {
      light: {
        primary: "#F9F9F9",
        background: "#F9F9F9",
        secondary: "#666666",
        accent: "#F5000F",
        error: "#FAFAE1",
      },
    },
  },
});
