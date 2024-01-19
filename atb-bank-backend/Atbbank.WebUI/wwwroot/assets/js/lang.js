// Change language
document.querySelectorAll('.lang a').forEach(function(lang) {
    lang.addEventListener('click', function() {
        document.querySelector('.lang .d-none').classList.remove('d-none')
        lang.classList.add('d-none')
    })
})


 var input1 = document.getElementById('input1')
 var range1 = document.getElementById('range1')

 input1.oninput = function() {
     var inputvalue1 = document.getElementById('input1').value
     document.getElementById('range1').value = inputvalue1
 }

 range1.oninput = function() {
     var rangevalue1 = document.getElementById('range1').value
     document.getElementById('input1').value = rangevalue1
 }

 var input2 = document.getElementById('input2')
 var range2 = document.getElementById('range2')

 input2.oninput = function() {
     var inputvalue2 = document.getElementById('input2').value
     document.getElementById('range2').value = inputvalue2
 }

 range2.oninput = function() {
     var rangevalue2 = document.getElementById('range2').value
     document.getElementById('input2').value = rangevalue2
 }

 var input3 = document.getElementById('input3')
 var range3 = document.getElementById('range3')

 input3.oninput = function() {
     var inputvalue3 = document.getElementById('input3').value
     document.getElementById('range3').value = inputvalue3
 }

 range3.oninput = function() {
     var rangevalue3 = document.getElementById('range3').value
     document.getElementById('input3').value = rangevalue3
 }

 var button = document.getElementById('button')

 button.onclick = function() {
     var amount = Number(document.getElementById('input1').value)
     var time = Number(document.getElementById('input2').value)
     var percentage = Number(document.getElementById('input3').value)

     var total = (amount * (100 + percentage) / 100)
     document.getElementById('total').innerHTML = `${total.toFixed(2)} ₼`
     var pertotal = (amount * (100 + percentage) / 100) / time
     document.getElementById('pertotal').innerHTML = `${pertotal.toFixed(2)} ₼`
 }