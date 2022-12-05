<script setup>
import { RouterLink, RouterView } from 'vue-router'
import Sidebar from '@/components/Sidebar/Sidebar.vue'
import { sidebarWidth } from './components/Sidebar/state'
</script>


<template>
  <Sidebar />
  <div :style="{ 'margin-left': sidebarWidth}"></div>
  <header>
    <div id="navBar">
      <button id="navBarButton" onclick="window.location.href='login.html'">ITEMS</button>
      <button id="navBarButton" onclick="window.location.href='/'">HOME</button>
      <button id="navBarButton" onclick="window.location.href='menu.html'">MENU</button>
      <button id="navBarButton" onclick="window.location.href='Contact.html'">CONTACT</button>
      <button id="navBarButton" onclick="window.location.href='Cart.html'">CART</button>
      <button id="navBarButton" onclick="window.location.href='login.html'">LOG IN</button>
    </div>
  </header>

  <footer class="footer">
            <p> Email:  </p>
            <p> Phone Number: +35845321654 </p>
            <p> Address: Myllykatu 160, Oulu 90069 </p>
        </footer>

  <RouterView />
</template>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
#nav {
  padding: 30px;
}
#nav a {
  font-weight: bold;
  color: #2c3e50;
}
#nav a.router-link-exact-active {
  color: #42b983;
}
</style>
