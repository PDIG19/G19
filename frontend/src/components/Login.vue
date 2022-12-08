<template>
    <div class="container">
      <form @submit.prevent="login">
        <h2 class="login">Login</h2>
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
        <div class="noAccount">
          You don't have an account? <span @click="moveToRegister">Register</span>
        </div>
        <button type="submit" class="submit" id="login_button">
          Login
        </button>
      </form>
    </div>
  </template>
  
  <script>
  export default {
    data() {
      return {
        email: "",
        password: "",
      };
    },
    methods: {
      moveToRegister() {
        this.$router.push("/register");
      },
    }
  }
  </script>
  