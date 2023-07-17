<script>

</script>

<template>
  <div class="wrapper">
    <h1>Weather</h1>
    <p>Find out the weather in your city</p>
    <input type="text" placeholder="Enter city">
    <button>Get the weather</button>
  </div>
</template>

<style scoped>
.wrapper{
  width: 900px;
  height: 500px;
  border-radius: 50px;
  padding: 20px;
  background: #1f0f24;
  text-align: center;
  color: #fff;
}

.wrapper h1 {
  margin-top: 20px;
}

.wrapper p {
  margin-top: 20px;
}

.wrapper input {
  margin-top: 30px;
  background: transparent;
  border: 0;
  border-bottom: 2px solid #110813;
  color: #fcfcfc;
  font-size: 14px;
  padding: 5px 8px;
  outline: none;
}

.wrapper input:focus{
  border-bottom-color: #6e2d7d;
}

.wrapper button{
  background: #e3bc4b;
  color: #fff;
  border-radius: 10px;
  border: 2px solid #b99935;
  padding: 10px 15px;
  margin-left: 20px;
  cursor: pointer;
  transition: transform 500ms ease;
}

.wrapper button:hover{
  transform: scale(1.1) translateY(-5px);
}
</style>
