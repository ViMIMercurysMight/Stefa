import Vue from "vue";
import Vuetify from "vuetify/lib/framework";

Vue.use(Vuetify);

export default new Vuetify({
  theme: {
    themes: {
      light: {
        primary: "#E3F4FD",
        secondary: "#F5000F",
        accent: "#5C00DE",
        error: "#FAFAE1",
      },
    },
  },
});
