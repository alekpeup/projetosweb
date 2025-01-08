
function calcular()
{
  var txtv = document.querySelector('input#txtvel');
  var res = document.querySelector('#res')
  var vel = Number(txtv.value);

  res.innerHTML = `<p>Sua velocidade atual e <strong>${vel}km/h</strong></p>`
  if(vel > 60)
  {
    res.innerHTML += `Voce ultrapassou o limite. Esta multado!`
  }
  else
  {
    res.innerHTML = `<p>Voce esta tranquilo, boa viagem.</p>`
  }
  

}