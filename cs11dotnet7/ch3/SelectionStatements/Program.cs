// See https://aka.ms/new-console-template for more information

WriteLine("Hello, its your animal creator!");

Animal?[] animals = new Animal?[]{
 new Cat {Name = "bobo", Born = new(2022, 8, 23), Legs = 4, isDomestic = true},
 new Spider {Name = "haggg", Born = new(2022, 10, 11), Legs = 4, IsPoisonous = false},
 new Cat {Name = "bobo", Born = new(1990, 8, 24), Legs = 3, isDomestic = false},
 new Animal {Name = "beepus", Born = new(1980, 7, 1), Legs = 3},
 new Cat { Name = "Karen", Born = new(year: 2022, month: 8, day: 23), 
    Legs = 4, isDomestic = true },
  null,
  new Cat { Name = "Mufasa", Born = new(year: 1994, month: 6, day: 12) },
  new Spider { Name = "Sid Vicious", Born = DateTime.Today, 
    IsPoisonous = true},
  new Spider { Name = "Captain Furry", Born = DateTime.Today }
};

foreach (Animal? animal in animals)
{
    string message;
    switch(animal){
        case Cat forLeggedCat when forLeggedCat.Legs == 4:
            message = $"The cat named {forLeggedCat.Name} has four legs.";
            break;
        case Cat wildCat when wildCat.isDomestic == false:
            message = $"The cat named {wildCat.Name} is feral.";
            break;
        case Cat cat:
            message = $"The cat named {cat.Name} has arrived.";
            break;
        default: // default is always evaluated last
            message = $"The animal named {animal.Name} is a {animal.GetType().Name}.";
            break;
        case Spider spider when spider.IsPoisonous:
            message = $"The spider named {spider.Name} is poisonous and will kill you.";
            break;
        case null:
            message = $"the animal is null";
            break;
    }
    WriteLine(message);
}