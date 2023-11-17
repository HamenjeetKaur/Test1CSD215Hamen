// For more information see https://aka.ms/fsharp-console-apps

// 1
// a
let salary = [75000; 48000; 120000; 190000; 300113; 92000; 36000]
let filtersal = salary |> List.filter (fun x -> x > 100000)
printfn "%A" filtersal


// b
let salary = [75000; 48000; 120000; 190000; 300113; 92000; 36000]
let icltax=
 List.map (fun sal -> 
   if sal <= 49020 then sal - sal / 100 * 15
   elif sal > 49020 && sal <= 98040 then sal - sal / 100 * 20
   elif sal > 98040 && sal <= 151978 then sal - sal / 100 * 26
   elif sal > 151978 && sal <= 216511 then sal - sal / 100 * 29
   elif sal > 216511 then sal - sal / 100 * 33
   else 0
   ) salary
let taxamt = 
  List.map2 (fun x y -> x - y) salary  icltax
printfn "Basic Salary %A" salary
printfn "After Deduction: %A" icltax
printfn "Total tax: %A" taxamt


// c
let salary = [75000; 48000; 120000; 190000; 300113; 92000; 36000]
let filtersal= salary |> List.filter (fun x -> x <= 49020)
let inc = List.map (fun x -> x + 20000) filtersal
printfn "Basic Salary: %A" salary
printfn "Lower than 49020: %A" filtersal
printfn "After inc: %A" inc


// d
let salary = [75000; 48000; 120000; 190000; 300113; 92000; 36000]
let filtersal= salary |> List.filter (fun x -> x >= 50000 && x<= 100000)
let sum = List.fold (fun acc x -> acc + x) 0 filtersal
printfn "Basic Salary: %A" salary
printfn "Salary between 50000 to 100000: %A" filtersal
printfn "Summation using fold: %d" sum




// 2
let parameter n =
    let rec sum acc value =
        if value > n then
            acc
        else
            sum (acc + value) (value + 3)
    sum 0 3
let output = parameter 9
printfn "Result: %d" output
