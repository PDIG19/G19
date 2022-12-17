<template>
  <div class="data">{{ cooler1 }}
    <div>
      <button class="buybtn">Buy</button>
    </div>
  </div>
  <div class="data">{{ cooler2 }}
    <div>
      <button class="buybtn">Buy</button>
    </div>
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
    const { data: cooler1 } = useSWRV('https://localhost:7233/Case/1', fetcher)
    const { data: cooler2 } = useSWRV('https://localhost:7233/Case/2', fetcher)
 
    return {
      cooler1, cooler2,
    }
  },
}
</script>

<style>
.data {
  font-size: 16px;
  padding: 30px 30px;
  border-radius: 20px;
  margin: 100px auto;
  width: 50vw;
  background-color: #fff;
  box-shadow: 0 4px 6px 0 rgba(0, 0, 0, 0.3);
}
.buybtn {
  padding: 0.7rem 2rem;
  margin-top: -42px;
  margin-left: -750px;
  border: none;
  cursor: pointer;
  background: #2f855a;
  border-radius: 20px;
  text-align: center;
  color: #fff;
  font-size: 17px;
  font-weight: bold;
  letter-spacing: 2px;
  text-transform: uppercase;
  box-shadow: 24px 24px 84px #2d8d5b, inset -12px -12px 14px #3abe7c,inset 10px 10px 20px #17d177;
  position: absolute;
}
.buy:hover {
  color: #2fbe72;
}
</style>