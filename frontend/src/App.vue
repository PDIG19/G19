<script setup>
import { RouterLink, RouterView } from 'vue-router'
</script>


<template>
  <header>
    <div id="navBar">
      <button id="navBarButton" onclick="window.location.href='index.html'">HOME</button>
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

