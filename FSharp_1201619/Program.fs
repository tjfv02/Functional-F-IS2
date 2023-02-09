printfn "Hello from F#"

module Funciones = 

    //Funciones simples
    let sample x = x*x + 3
    let suma x y = x+y

    let result = sample 3
    let resultadoSuma = suma 4 5

    printfn $"El resultado es %d{resultadoSuma}"

    let SumaTipoDefinido (x: int) (y: int) = x + y


    //Numero Par
    let numeroPar (x: int) =
        if x%2 = 0 then
            printf $"El número %d{x}, si es Par"
        else
            printf $"El número %d{x}, no es Par"
   
    let resultadoNumeroPar = numeroPar 5

    printf $"{resultadoNumeroPar}"
   

   // Factorial Recursivo
    let rec factorial x =
        if x = 0 then
            1
        else
            x * factorial (x-1)

    let resultadoFactorial = factorial 10

    printf $"El factorial de 10 es: {resultadoFactorial}"




            