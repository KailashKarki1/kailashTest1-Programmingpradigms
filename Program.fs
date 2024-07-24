printfn "Hello from Kailash Karki"
let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

let highIncomeSalaries = List.filter (fun x -> x > 100000) salaries

let calculateTax salary =
    match salary with
    | _ when salary <= 49020 -> float salary * 0.15
    | _ when salary <= 98040 -> float salary * 0.205
    | _ when salary <= 151978 -> float salary * 0.26
    | _ when salary <= 216511 -> float salary * 0.29
    | _ -> float salary * 0.33


let taxes = List.map calculateTax salaries

let updatedSalaries = List.map (fun x -> if x < 49020 then x + 20000 else x) salaries

let filteredSalaries = List.filter (fun x -> x >= 50000 && x <= 100000) salaries
let sumFilteredSalaries = List.fold (+) 0 filteredSalaries

printfn "High-Income Salaries: %A" highIncomeSalaries
printfn "Taxes: %A" taxes
printfn "Updated Salaries: %A" updatedSalaries
printfn "Sum of Filtered Salaries: %d" sumFilteredSalaries


let sumOfMultiplesOf3 limit =
    let rec loop acc current =
        if current > limit then acc
        else loop (acc + current) (current + 3)
    loop 0 3

let limit = 35 
let result = sumOfMultiplesOf3 limit
printfn "The sum of all multiples of 3 up to %d is %d" limit result

