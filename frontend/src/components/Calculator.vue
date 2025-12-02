<script setup>
import { ref } from 'vue'

const display = ref('')
const isError = ref(false)

const appendToDisplay = (value) => {
  display.value += value
  clearError()
}

const clearDisplay = () => {
  display.value = ''
  clearError()
}

const clearError = () => {
  isError.value = false
}

const setError = (msg) => {
  display.value = msg
  isError.value = true
}

const calculate = async () => {
  const expr = display.value.trim()
  if (!expr) {
    setError("Input is empty")
    return
  }

  try {
    const response = await fetch('http://localhost:5238/api/calculator/calculate', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify({ expression: expr })
    })

    if (!response.ok) {
      const errorText = await response.text()
      throw new Error(errorText || 'Calculation failed')
    }

    const data = await response.json()
    display.value = data.result
  } catch (e) {
    setError(e.message)
  }
}
</script>

<template>
  <div class="calculator">
    <input type="text" v-model="display" :class="{ error: isError }" readonly />

    <div class="buttons">
      <button @click="appendToDisplay('1')">1</button>
      <button @click="appendToDisplay('2')">2</button>
      <button @click="appendToDisplay('3')">3</button>
      <button @click="appendToDisplay('+')">+</button>

      <button @click="appendToDisplay('4')">4</button>
      <button @click="appendToDisplay('5')">5</button>
      <button @click="appendToDisplay('6')">6</button>
      <button @click="appendToDisplay('-')">-</button>

      <button @click="appendToDisplay('7')">7</button>
      <button @click="appendToDisplay('8')">8</button>
      <button @click="appendToDisplay('9')">9</button>
      <button @click="appendToDisplay('*')">*</button>

      <button @click="appendToDisplay('0')">0</button>
      <button @click="appendToDisplay('.')">.</button>
      <button @click="clearDisplay()">C</button>
      <button @click="appendToDisplay('/')">/</button>

      <button @click="appendToDisplay('(')">(</button>
      <button @click="appendToDisplay(')')">)</button>
    </div>

    <button class="calc-btn" @click="calculate()">=</button>
  </div>
</template>

<style scoped>
.calculator {
  background-color: white;
  padding: 20px;
  border-radius: 10px;
  box-shadow: 0 5px 15px rgba(0, 0, 0, 0.1);
  width: 260px;
  margin: 0 auto;
}

input {
  width: 100%;
  padding: 10px;
  font-size: 18px;
  text-align: right;
  margin-bottom: 10px;
  border: 1px solid #ccc;
  box-sizing: border-box;
  max-width: 100%;
  overflow: hidden;
  color: black;
}

.buttons {
  display: grid;
  grid-template-columns: repeat(4, 1fr);
  gap: 8px;
}

button {
  font-size: 20px;
  padding: 12px;
  background-color: #f1f1f1;
  border: 1px solid #ccc;
  cursor: pointer;
}

button:hover {
  background-color: #ddd;
}

.calc-btn {
  margin-top: 10px;
  width: 100%;
  padding: 12px;
  font-size: 20px;
}

.error {
  border-color: red;
  color: red;
}
</style>
