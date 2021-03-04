module MiniProject

type Size = 
    | Small
    | Medium
    | Large

type DrinkType =
    | Coffee
    | Tea
    | Juice
    | Soda
    | Milk

type Drink = {
    Size: Size
    Type: DrinkType
    Name: string
    BasePrice: decimal
} 

let calculatePrice (drink:Drink) =
    match drink.Size with
    | Small -> drink.BasePrice
    | Medium -> (drink.BasePrice * 1.25m)
    | Large -> (drink.BasePrice * 1.4m)

//Coffee Drinks
let espressoS = {Size=Small; Type=Coffee; Name="Espresso Small"; BasePrice=12m}
let espressoM = {Size=Medium; Type=Coffee; Name="Espresso Medium"; BasePrice=12m}
let espressoL = {Size=Large; Type=Coffee; Name="Espresso Large"; BasePrice=12m}

let caffeLatteS = {Size=Small; Type=Coffee; Name="Caffe Late Small"; BasePrice=23.5m}
let caffeLatteM = {Size=Medium; Type=Coffee; Name="Caffe Late Medium"; BasePrice=23.5m}
let caffeLatteL = {Size=Large; Type=Coffee; Name="Caffe Late Large"; BasePrice=23.5m}

let americanoS = {Size=Small; Type=Coffee; Name="Americano Small"; BasePrice=17.25m}
let americanoM = {Size=Medium; Type=Coffee; Name="Americano Medium"; BasePrice=17.25m}
let americanoL = {Size=Large; Type=Coffee; Name="Americano Large"; BasePrice=17.25m}

let latteMacchiatoS = {Size=Small; Type=Coffee; Name="Latte Macchiato Small"; BasePrice=27.75m}
let latteMacchiatoM = {Size=Medium; Type=Coffee; Name="Latte Macchiato Medium"; BasePrice=27.75m}
let latteMacchiatoL = {Size=Large; Type=Coffee; Name="Latte Macchiato Large"; BasePrice=27.75m}

//Tea Drinks
let greenTeaS = {Size=Small; Type=Tea; Name="Green Tea Small"; BasePrice=11.25m}
let greenTeaM = {Size=Medium; Type=Tea; Name="Green Tea Medium"; BasePrice=11.25m}
let greenTeaL = {Size=Large; Type=Tea; Name="Green Tea Large"; BasePrice=11.25m}

let fruitTeaS = {Size=Small; Type=Tea; Name="Fruit Tea Small"; BasePrice=15.5m}
let fruitTeaM = {Size=Medium; Type=Tea; Name="Fruit Tea Medium"; BasePrice=15.5m}
let fruitTeaL = {Size=Large; Type=Tea; Name="Fruit Tea Large"; BasePrice=15.5m}

let blackTeaS = {Size=Small; Type=Tea; Name="Black Tea Small"; BasePrice=10.75m}
let blackTeaM = {Size=Medium; Type=Tea; Name="Black Tea Medium"; BasePrice=10.75m}
let blackTeaL = {Size=Large; Type=Tea; Name="Black Tea Large"; BasePrice=10.75m}

//Juice Drinks
let appleJuiceS = {Size=Small; Type=Juice; Name="Apple Juice Small"; BasePrice=25.25m}
let appleJuiceM = {Size=Medium; Type=Juice; Name="Apple Juice Medium"; BasePrice=25.25m}
let appleJuiceL = {Size=Large; Type=Juice; Name="Apple Juice Large"; BasePrice=25.25m}

let orangeJuiceS = {Size=Small; Type=Juice; Name="Orange Juice Small"; BasePrice=23.5m}
let orangeJuiceM = {Size=Medium; Type=Juice; Name="Orange Juice Medium"; BasePrice=23.5m}
let orangeJuiceL = {Size=Large; Type=Juice; Name="Orange Juice Large"; BasePrice=23.5m}

let mangoJuiceS = {Size=Small; Type=Juice; Name="Mango Juice Small"; BasePrice=28.75m}
let mangoJuiceM = {Size=Medium; Type=Juice; Name="Mango Juice Medium"; BasePrice=28.75m}
let mangoJuiceL = {Size=Large; Type=Juice; Name="Mango Juice Large"; BasePrice=28.75m}

//Soda Drink
let cokeS = {Size=Small; Type=Soda; Name="Coke Small"; BasePrice=12m}
let cokeM = {Size=Medium; Type=Soda; Name="Coke Medium"; BasePrice=12m}
let cokeL = {Size=Large; Type=Soda; Name="Coke Large"; BasePrice=12m}

let pepsiS = {Size=Small; Type=Soda; Name="Pepsi Small"; BasePrice=15m}
let pepsiM = {Size=Medium; Type=Soda; Name="Pepsi Medium"; BasePrice=15m}
let pepsiL = {Size=Large; Type=Soda; Name="Pepsi Large"; BasePrice=15m}

let fantaS = {Size=Small; Type=Soda; Name="Fanta Small"; BasePrice=13m}
let fantaM = {Size=Medium; Type=Soda; Name="Fanta Medium"; BasePrice=13m}
let fantaL = {Size=Large; Type=Soda; Name="Fanta Large"; BasePrice=13m}

let spriteS = {Size=Small; Type=Soda; Name="Sprite Small"; BasePrice=14m}
let spriteM = {Size=Medium; Type=Soda; Name="Sprite Medium"; BasePrice=14m}
let spriteL = {Size=Large; Type=Soda; Name="Sprite Large"; BasePrice=14m}

//Milk
let milkS = {Size=Small; Type=Milk; Name="Milk Small"; BasePrice=6m}
let milkM = {Size=Medium; Type=Milk; Name="Milk Medium"; BasePrice=6m}
let milkL = {Size=Large; Type=Milk; Name="Milk Large"; BasePrice=6m}

let warmMilkS = {Size=Small; Type=Milk; Name="Warm Milk Small"; BasePrice=6.5m}
let warmMilkM = {Size=Medium; Type=Milk; Name="Warm Milk Medium"; BasePrice=6.5m}
let warmMilkL = {Size=Large; Type=Milk; Name="Warm Milk Large"; BasePrice=6.5m}