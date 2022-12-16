<template>
  <div class="data">
    <p v-if="coolerError">Sorry, there's been an error</p>
    <ul>
      <li v-for="item in cooler" v-bind:key="item.id">
        <a v-bind:href="item.link" target="blank">{{ item.title }}</a>
        </li>
    </ul>
</div>
</template>

<script>
import useSWRV from 'swrv'

const fetcher = function(url){
  return fetch(url).then(r => r.json())
}

export default {
  name: 'App',
  setup() {
    const { data: cooler, error: coolerError } = useSWRV('https://localhost:7233/swagger/v1/swagger.json#/G19/Ccontrollers/CoolerController', fetcher)
 
    return {
      cooler,
      coolerError,
    }
  },
}
</script>

<style>
.data {
  padding-left: 300px;
}
</style>