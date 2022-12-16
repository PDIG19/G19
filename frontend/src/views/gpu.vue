<template>
  <div class="data">{{ cooler }}</div>
</template>

<script>
import useSWRV from 'swrv'

const fetcher = function(url){
  return fetch(url).then(r => r.json())
}

export default {
  name: 'App',
  setup() {
    const { data: cooler, error: coolerError } = useSWRV('https://localhost:7233/GraphicsCards', fetcher)
 
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