<template>
  <div class="container">
    <form @submit.prevent="register">
      <h2 class="register">Register</h2>
      <div class="input">
        <label for="email">Email address</label>
        <input
          class="form"
          type="text"
          name="email"
          placeholder="email@adress.com"
        />
      </div>
      <div class="input">
        <label for="password">Password</label>
        <input
          class="form"
          type="password"
          name="password"
          placeholder="password123"
        />
      </div>
      <div class="input">
        <label for="name">Your name</label>
        <input
          class="form"
          type="text"
          name="firstname"
          placeholder="First name"
        />
      </div>
      <div class="input">
        <label for="lastname">Last name</label>
        <input
          class="form"
          type="text"
          name="lastname"
          placeholder="Last name"
        />
      </div>
      <div class="input">
        <label for="mobilenumber">Mobile number</label>
        <input
          class="form"
          type="text" v-on:keypress="NumbersOnly"
          name="mNumber"
          placeholder="Mobile number"
        />
      </div>

      <div class="haveAccount">
        Already have an account? <span @click="moveToLogin">Login</span>
      </div>

      <button type="submit" id="register_button" class="register">
        Register
      </button>
    </form>
  </div>
</template>

<script>
export default {
  data() {
    return {
      email: "",
      password: "123456",
    };
  },
  methods: {
    moveToLogin() {
      this.$router.push("/login");
    },
    NumbersOnly(event) {
      event = (event) ? event : window.event;
      var charCode = (event.which) ? event.which : event.keyCode;
      if ((charCode > 31 && (charCode < 48 || charCode > 57)) && charCode !== 46) {
        event.preventDefault();;
      } else {
        return true;
      }
    }
  },
};
</script>