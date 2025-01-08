var agora = new Date()

var diaSem = agora.getDay()

/* 
  get day funciona assim:
  domingo = 0 
  segunda = 1
  terça   = 2
  quarta  = 3
  quinta  = 4
  sexta   = 5
  sabado  = 6

*/


console.log(diaSem)

switch (diaSem)
{

  case 0:
    console.log("domingo")
    break;
  case 1:
    console.log("Hoje é segunda")
    break;
  case 2:
    console.log("terça")
    break;
  case 3:
    console.log("Hoje é quarta")
    break;
  case 4:
    console.log("quinta")
    break;
  case 5:
    console.log("Hoje é sexta")
    break;
  case 6:
    console.log("Hoje é sabado")
    break;
}




