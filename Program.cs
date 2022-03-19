string frase;

Console.WriteLine("O que voce acha de mim? Voce é muito sem graça\n");
frase = Console.ReadLine()!;

frase = frase.Remove(10);

Console.WriteLine($"E sabe o que eu penso de voce?\n{frase}...\nNAO, PERA.\nTo nervoso");
