﻿int numberOfApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine(
    format: "{0} apples cost {1:C}"
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);
)