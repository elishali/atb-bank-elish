 const currency_calculationEl_one = document.getElementById('currency_calculation-one');
 const amountEl_one = document.getElementById('amount-one');
 const currency_calculationEl_two = document.getElementById('currency_calculation-two');
 const amountEl_two = document.getElementById('amount-two');

 const rateEl = document.getElementById('rate');
 const swap = document.getElementById('swap');

 // Fetch exchange rates and update the DOM
 function calculate() {
   const currency_calculation_one = currency_calculationEl_one.value;
   const currency_calculation_two = currency_calculationEl_two.value;

   fetch(`https://api.exchangerate-api.com/v4/latest/${currency_calculation_one}`)
     .then(res => res.json())
     .then(data => {
       // console.log(data);
       const rate = data.rates[currency_calculation_two];
      
       rateEl.innerText = `1 ${currency_calculation_one} = ${rate} ${currency_calculation_two}`;

       amountEl_two.value = (amountEl_one.value * rate).toFixed(2)
     })

 }

 // Event listeners
 currency_calculationEl_one.addEventListener('change', calculate);
 amountEl_one.addEventListener('input', calculate);
 currency_calculationEl_two.addEventListener('change', calculate);
 amountEl_two.addEventListener('input', calculate);

 swap.addEventListener('click', ()=> {
   const temp = currency_calculationEl_one.value;
   currency_calculationEl_one.value = currency_calculationEl_two.value;
   currency_calculationEl_two.value = temp;
   calculate()
 })

 calculate()